using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
namespace AuntRosieEntities
{
    public class Employee : Person
    {
        private long id;
        private string type;
        private string role;
        private Address address = new Address();
        private string email;
        private string phone;
        private static SqlCommand createPrepCmd = null;
        private double salary;
        private DateTime  employmentDate;

        /// <summary>
        /// Prepared statement to retrieve ingredient type by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;
        private static SqlCommand updatePrepCmd = null;
        private static SqlCommand deletePrepCmd = null;

        public Address Address
        {
            get => default;
            set
            {
            }
        }

        public long Id { get => id; set => id = value; }
         public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Province { get => address.Province; set => address.Province = value; }
        public string City { get => address.City; set => address.City = value; }
        public string Street { get => address.Street; set => address.Street = value; }
        public string PostalCode { get => address.PostalCode; set => address.PostalCode = value; }
        public string Role { get => role; set => role = value; }
        public string Type { get => type ; set => type = value; }
        public double Salary { get => salary; set => salary = value; }
        public DateTime EmploymentDate{ get => employmentDate; set => employmentDate = value; }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                if (Type == "F")
                {
                    createPrepCmd.CommandText = "insert into [tblEmployee]([EmployeeFirstName],[EmployeeLastName],[EmployeePhone]" +
                      ",[EmployeeProvince],[EmployeeCity],[EmployeeStreet],[EmployeePostalCode]," +
                      " [EmployeeEmail] ,[EmployeeRole],[EmployeeType],[EmploymentDate],[EmployeeSalary]) " +
                      "values ( @fname, @lname,@phone, @province, @city,@street,@postal,@email,@role, @type,@date,@sal)";
                    SqlParameter salParam = new SqlParameter("@sal", SqlDbType.Money, 20);
                    salParam.Value = Salary;
                    createPrepCmd.Parameters.Add(salParam);
                    SqlParameter dateParam = new SqlParameter("@date", SqlDbType.Date);
                    dateParam.Value = EmploymentDate;
                    createPrepCmd.Parameters.Add(dateParam);
                }
                else
                {
                    createPrepCmd.CommandText = "insert into [tblEmployee]([EmployeeFirstName],[EmployeeLastName],[EmployeePhone]" +
                                          ",[EmployeeProvince],[EmployeeCity],[EmployeeStreet],[EmployeePostalCode], [EmployeeEmail] ,[EmployeeRole],[EmployeeType]) " +
                                          "values ( @fname, @lname,@phone," +
                                          "@province, @city,@street,@postal,@email,@role, @type)";
                }

                SqlParameter fNameParam = new SqlParameter("@fname", SqlDbType.VarChar, 50);
                fNameParam.Value = FirstName;
                createPrepCmd.Parameters.Add(fNameParam);

                SqlParameter lNameParam = new SqlParameter("@lname", SqlDbType.VarChar, 50);
                lNameParam.Value = LastName;
                createPrepCmd.Parameters.Add(lNameParam);

                SqlParameter phoneParam = new SqlParameter("@phone", SqlDbType.VarChar, 14);
                phoneParam.Value = Phone;
                createPrepCmd.Parameters.Add(phoneParam);

                SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 320);
                emailParam.Value = Email;
                createPrepCmd.Parameters.Add(emailParam);

                SqlParameter provinceParam = new SqlParameter("@province", SqlDbType.VarChar, 2);
                provinceParam.Value = Province;
                createPrepCmd.Parameters.Add(provinceParam);

                SqlParameter cityParam = new SqlParameter("@city", SqlDbType.VarChar, 50);
                cityParam.Value = City;
                createPrepCmd.Parameters.Add(cityParam);

                SqlParameter streetParam = new SqlParameter("@street", SqlDbType.VarChar, 50);
                streetParam.Value = Street;
                createPrepCmd.Parameters.Add(streetParam);

                SqlParameter postalParam = new SqlParameter("@postal", SqlDbType.VarChar, 6);
                postalParam.Value = PostalCode;
                createPrepCmd.Parameters.Add(postalParam);

                SqlParameter roleParam = new SqlParameter("@role", SqlDbType.VarChar, 50);
                roleParam.Value = Role;
                createPrepCmd.Parameters.Add(roleParam);

                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.VarChar, 1);
                typeParam.Value = Type;
                createPrepCmd.Parameters.Add(typeParam);

                createPrepCmd.Parameters.Add(fNameParam);
                createPrepCmd.Parameters.Add(lNameParam);
                createPrepCmd.Parameters.Add(phoneParam);
                createPrepCmd.Parameters.Add(emailParam);
                createPrepCmd.Parameters.Add(provinceParam);
                createPrepCmd.Parameters.Add(cityParam);
                createPrepCmd.Parameters.Add(streetParam);
                createPrepCmd.Parameters.Add(postalParam);
                createPrepCmd.Parameters.Add(roleParam);
                createPrepCmd.Parameters.Add(typeParam);

                createPrepCmd.Prepare();
            }
            else
            {
                
                createPrepCmd.Parameters["@fname"].Value = FirstName;
                createPrepCmd.Parameters["@lname"].Value = LastName;
                createPrepCmd.Parameters["@phone"].Value = Phone;
                createPrepCmd.Parameters["@email"].Value = Email;
                createPrepCmd.Parameters["@city"].Value = City;
                createPrepCmd.Parameters["@street"].Value = Street;
                createPrepCmd.Parameters["@province"].Value = Province;
                createPrepCmd.Parameters["@postal"].Value = PostalCode;
                createPrepCmd.Parameters["@role"].Value = Role;
                createPrepCmd.Parameters["@type"].Value = Type;

                if(Type=="F")
                {
                    createPrepCmd.Parameters["@date"].Value = EmploymentDate;
                    createPrepCmd.Parameters["@sal"].Value = Salary;

                }
            }

            id = Convert.ToInt16(Connector.Insert(createPrepCmd, true, transaction));
        }

    

    public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblEmployee] where [EmployeeID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = Id;

                deletePrepCmd.Parameters.Add(idParam);

                deletePrepCmd.Prepare();
            }
            else
            {
                deletePrepCmd.Parameters["ID"].Value = Id;
            }

            Connector.Delete(deletePrepCmd, transaction);
        }
        ///
        /// <summary>
        /// Get Employee
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable GetAllEmployees(String conStr)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblEmployee]", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable EmployeeTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(EmployeeTable);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated DataTable
            return EmployeeTable;
        }

        ///
        /// <summary>
        /// Get Employee
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable GetAllEmployeesByType(String conStr, string emptype)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblEmployee] where (EmployeeType= '" +  emptype.Trim()+ "')", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable IngredintTypeTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(IngredintTypeTable);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated DataTable
            return IngredintTypeTable;
        }

        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {

            updatePrepCmd = new SqlCommand(null, Connector.Connection);
                if (Type == "F")
                {
                    
                    updatePrepCmd.CommandText = "update [tblEmployee] set" +
                        "[EmployeeFirstName]=@fname,[EmployeeLastName]= @lname," +
                        "[EmployeePhone]=@phone,[EmployeeProvince]=@province,[EmployeeCity]=@city,[EmployeeStreet]=@street ," +
                        "[EmployeePostalCode]=@postal,[EmployeeEmail] =@email ," +
                        " EmployeeRole]=@role,[EmployeeType]=@type ,[EmploymentDate]=@date, [EmployeeSalary]=@sal   where [EmployeerID] = @id";
                    SqlParameter salParam = new SqlParameter("@sal", SqlDbType.Money, 20);
                    salParam.Value = Salary;
                    createPrepCmd.Parameters.Add(salParam);
                    SqlParameter dateParam = new SqlParameter("@date", SqlDbType.Date);
                    dateParam.Value = EmploymentDate;
                    createPrepCmd.Parameters.Add(dateParam);

                }
                else
                {
                    updatePrepCmd.CommandText = "update [tblEmployee] set" +
                        "[EmployeeFirstName]=@fname,[EmployeeLastName]= @lname," +
                        "[EmployeePhone]=@phone,[EmployeeProvince]=@province,[EmployeeCity]=@city,[EmployeeStreet]=@street ," +
                        "[EmployeePostalCode]=@postal,[EmployeeEmail] =@email ," +
                        " EmployeeRole]=@role,[EmployeeType]=@type  where [EmployeerID] = @id";

                }


                SqlParameter fNameParam = new SqlParameter("@fname", SqlDbType.VarChar, 50);
                fNameParam.Value = FirstName;
                createPrepCmd.Parameters.Add(fNameParam);

                SqlParameter lNameParam = new SqlParameter("@lname", SqlDbType.VarChar, 50);
                lNameParam.Value = LastName;
                createPrepCmd.Parameters.Add(lNameParam);

                SqlParameter phoneParam = new SqlParameter("@phone", SqlDbType.VarChar, 14);
                phoneParam.Value = Phone;
                updatePrepCmd.Parameters.Add(phoneParam);

                SqlParameter emailParam = new SqlParameter("@email", SqlDbType.VarChar, 320);
                emailParam.Value = Email;
                updatePrepCmd.Parameters.Add(emailParam);

                SqlParameter provinceParam = new SqlParameter("@province", SqlDbType.VarChar, 2);
                provinceParam.Value = Province;
                updatePrepCmd.Parameters.Add(provinceParam);

                SqlParameter cityParam = new SqlParameter("@city", SqlDbType.VarChar, 50);
                cityParam.Value = City;
                updatePrepCmd.Parameters.Add(cityParam);

                SqlParameter streetParam = new SqlParameter("@street", SqlDbType.VarChar, 50);
                streetParam.Value = Street;
                updatePrepCmd.Parameters.Add(streetParam);

                SqlParameter postalParam = new SqlParameter("@postal", SqlDbType.VarChar, 6);
                postalParam.Value = PostalCode;
                updatePrepCmd.Parameters.Add(postalParam);

                SqlParameter roleParam = new SqlParameter("@role", SqlDbType.VarChar, 50);
                roleParam.Value = Role;
                createPrepCmd.Parameters.Add(roleParam);

                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.VarChar, 1);
                typeParam.Value = Type;
                createPrepCmd.Parameters.Add(typeParam);

                SqlParameter idParam = new SqlParameter("@id", SqlDbType.BigInt, 0);
                idParam.Value = Id;
                updatePrepCmd.Parameters.Add(idParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@fname"].Value = FirstName;
                createPrepCmd.Parameters["@lname"].Value = LastName;
                createPrepCmd.Parameters["@phone"].Value = Phone;
                createPrepCmd.Parameters["@email"].Value = Email;
                createPrepCmd.Parameters["@city"].Value = City;
                createPrepCmd.Parameters["@street"].Value = Street;
                createPrepCmd.Parameters["@province"].Value = Province;
                createPrepCmd.Parameters["@posal"].Value = PostalCode;
                createPrepCmd.Parameters["@role"].Value = Role;
                createPrepCmd.Parameters["@type"].Value = Type;
                updatePrepCmd.Parameters["@id"].Value = Id;
                if (Type == "F")
                {
                    createPrepCmd.Parameters["@date"].Value = EmploymentDate;
                    createPrepCmd.Parameters["@sal"].Value = Salary;

                }
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        /// <summary>
        /// Retrieve a type of ingredient from the database by name
        /// </summary>
        /// <param name="name">Name of the ingredient to retrieve</param>
        /// <returns></returns>
        public static Employee Retrieve(string idString)
        {
            Employee emp = null;
            long id = (long)Convert.ToDouble(idString);
            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [EmployeeFirstName],[EmployeeLastName],[EmployeePhone]" +
                    ",[EmployeeProvince],[EmployeeCity],[EmployeeStreet],[EmployeePostalCode]," +
                    " [EmployeeEmail] ,[EmployeeRole],[EmployeeType],[EmploymentDate],[EmployeeSalary] from [tblEmployee]  where [EmployeeID] = @id";



                SqlParameter idParam = new SqlParameter("@id", SqlDbType.BigInt, 0);
                idParam.Value = id;
                retrieveIdPrepCmd.Parameters.Add(idParam);

                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                retrieveIdPrepCmd.Parameters["@id"].Value = id;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                emp = new Employee(); ;
                emp.Id = id;
                emp.FirstName = reader.GetString(0);
                emp.LastName = reader.GetString(1);
                emp.Phone = reader.GetString(2);
                emp.Province = reader.GetString(3);
                emp.City = reader.GetString(4);
                emp.Street = reader.GetString(5);
                emp.PostalCode = reader.GetString(6);
                emp.Email = reader.GetString(7);
                emp.Role = reader.GetString(8);
                emp.Type = reader.GetString(9);
                if (emp.type == "F")
                {
                    emp.EmploymentDate = reader.GetDateTime(10).Date;
                    //string retriveSal = reader.GetString(11);
                    //emp.Salary =Convert.ToDouble(retriveSal)  ;
                    emp.Salary = Convert.ToDouble(reader.GetDecimal(11));
                }

            }

            reader.Close();

            return emp;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

    }
}