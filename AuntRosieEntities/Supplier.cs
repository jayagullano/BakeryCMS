using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
 

namespace AuntRosieEntities
{
    public class Supplier : RosieEntity
    {
        private long id;
        private string name;
        private string contactPersonFirstName;
        private string contactPersonLastName;
        private string phone;
        private string province;
        private  string street;
        private string city;
        private string postalCode;
        private string email;
        private static SqlCommand createPrepCmd = null;

        /// <summary>
        /// Prepared statement to retrieve ingredient type by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;
        private static SqlCommand updatePrepCmd = null;
        private static SqlCommand deletePrepCmd = null;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string ContactFirstName{ get => contactPersonFirstName; set => contactPersonFirstName = value; }
        public string ContactLasttName { get => contactPersonLastName; set => contactPersonLastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email;set  =>  email= value; }
        public string Province { get => province; set => province = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string PostalCode { get =>postalCode; set => postalCode = value; }

        private void SetID(short id)
        {
            this.id = id;
        }
        /// <summary>
        /// Function to add a new supplier to the database
        /// </summary>
        /// <param name="insertSupplier">a worker object to be inserted</param>
        /// <returns>true if successful</returns>
        public static bool InsertNewRecord(Supplier insertSupplier , String conStr)
        {
            // Create return value
            bool returnValue = false;

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command and assign it paramaters
            SqlCommand command = new SqlCommand("insert into [tblSupplier]([SupplierName], [ContactPersonFirstName],[ContactPersonLastName]," +
                    "[SupplierPhone],[SupplierProvince],[SupplierCity],[SupplierStreet]," +
                    "[SupplierPostalCode],[SupplierEmail]) values (@name, @fname, @lname,@phone," +
                    "@province, @city,@street,@postal,@email)", dbConnection);
            command.Parameters.AddWithValue("@name", insertSupplier.Name);
            command.Parameters.AddWithValue("@fname", insertSupplier.contactPersonFirstName);
            command.Parameters.AddWithValue("@lname", insertSupplier.contactPersonLastName);
            command.Parameters.AddWithValue("@phone", insertSupplier.Phone);
            command.Parameters.AddWithValue("@email", insertSupplier.Email);
            command.Parameters.AddWithValue("@street", insertSupplier.Street);
            command.Parameters.AddWithValue("@city", insertSupplier.City);
            command.Parameters.AddWithValue("@province", insertSupplier.Province);
            command.Parameters.AddWithValue("@postal", insertSupplier.postalCode);

            // Try to insert the new record, return result
            try
            {
                dbConnection.Open();
                returnValue = (command.ExecuteNonQuery() == 1);
            }
            catch (Exception ex)
            {
                returnValue= false;
            }
            finally
            {
                dbConnection.Close();
            }
            return returnValue;
           }


        ///
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblSupplier]([SupplierName], [ContactPersonFirstName],[ContactPersonLastName]," +
                    "[SupplierPhone],[SupplierProvince],[SupplierCity],[SupplierStreet]," +
                    "[SupplierPostalCode],[SupplierEmail]) values (@name, @fname, @lname,@phone," +
                    "@province, @city,@street,@postal,@email)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;
                createPrepCmd.Parameters.Add(nameParam);

                SqlParameter fNameParam = new SqlParameter("@fname", SqlDbType.VarChar, 50);
                fNameParam.Value = contactPersonFirstName;
                createPrepCmd.Parameters.Add(fNameParam);

                SqlParameter lNameParam = new SqlParameter("@lname", SqlDbType.VarChar, 50);
                lNameParam.Value = contactPersonLastName;
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



                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@name"].Value = Name;
                createPrepCmd.Parameters["@fname"].Value = ContactFirstName;
                createPrepCmd.Parameters["@lname"].Value = ContactLasttName;
                createPrepCmd.Parameters["@phone"].Value = Phone;
                createPrepCmd.Parameters["@email"].Value = Email;
                createPrepCmd.Parameters["@city"].Value = City;
                createPrepCmd.Parameters["@street"].Value = Street;
                createPrepCmd.Parameters["@province"].Value = Province;
                createPrepCmd.Parameters["@postal"].Value = postalCode;
            }

            id = Convert.ToInt16(Connector.Insert(createPrepCmd, true, transaction));
        }
 
        /// <summary>
        /// Update ingredient type
        /// </summary>
        /// <param name="transaction"></param>
        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblSupplier] set" +
                    "[SupplierName]=@name, [ContactPersonFirstName]=@fname,[ContactPersonLastName]= @lname," +
                    "[SupplierPhone]=@phone,[SupplierProvince]=@province,[SupplierCity]=@city,[SupplierStreet]=@street ," +
                    "[SupplierPostalCode]=@postal,[SupplierEmail]=@email where [SupplierID] = @id";

                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;
                updatePrepCmd.Parameters.Add(nameParam);

                SqlParameter fNameParam = new SqlParameter("@fname", SqlDbType.VarChar, 50);
                fNameParam.Value = contactPersonFirstName;
                updatePrepCmd.Parameters.Add(fNameParam);

                SqlParameter lNameParam = new SqlParameter("@lname", SqlDbType.VarChar, 50);
                lNameParam.Value = contactPersonLastName;
                updatePrepCmd.Parameters.Add(lNameParam);

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


                SqlParameter idParam = new SqlParameter("@id", SqlDbType.BigInt, 0);
                idParam.Value = Id;
                updatePrepCmd.Parameters.Add(idParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@name"].Value = Name;
                updatePrepCmd.Parameters["@fname"].Value = ContactFirstName;
                updatePrepCmd.Parameters["@lname"].Value = ContactLasttName;
                updatePrepCmd.Parameters["@phone"].Value = Phone;
                updatePrepCmd.Parameters["@email"].Value = Email;
                updatePrepCmd.Parameters["@city"].Value = City;
                updatePrepCmd.Parameters["@street"].Value = Street;
                updatePrepCmd.Parameters["@province"].Value = Province;
                updatePrepCmd.Parameters["@posal"].Value = postalCode;
                updatePrepCmd.Parameters["@id"].Value = Id;
            }

            Connector.Update(updatePrepCmd, transaction);
        }


        /// <summary>
        /// Retrieve a type of ingredient from the database by name
        /// </summary>
        /// <param name="name">Name of the ingredient to retrieve</param>
        /// <returns></returns>
        public static Supplier Retrieve(string idString)
        {
           Supplier supplier = null;
            long id = (long)Convert.ToDouble(idString);
            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [SupplierName], [ContactPersonFirstName],[ContactPersonLastName]," +
                    "[SupplierPhone],[SupplierProvince],[SupplierCity],[SupplierStreet]," +
                    "[SupplierPostalCode],[SupplierEmail] from [tblSupplier]  where [SupplierID] = @id";



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
                supplier = new Supplier(); ;
                supplier.Id = id ;
                supplier.Name = reader.GetString(0);
                supplier.contactPersonFirstName= reader.GetString(1);
                supplier.contactPersonLastName = reader.GetString(2);
                supplier.Phone = reader.GetString(3);
                supplier.Province = reader.GetString(4);
                supplier.City = reader.GetString(5);
                supplier.Street= reader.GetString(6);
                supplier.PostalCode = reader.GetString(7);
                supplier.Email = reader.GetString(8);

            }

            reader.Close();

            return supplier;
        }



        ///
        /// <summary>
        /// Get suppliers
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable GetAllSuppliers(String conStr)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblSupplier]", dbConnection);
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


        // <summary>
        /// Delete ingredient type
        /// </summary>
        /// <param name="transaction"></param>
        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblSupplier] where [SupplierID] = @ID";


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
    }
}