using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
namespace AuntRosieEntities
{
    public class Customer : Person
    {
        private long id;
       
        
        private string email;
        private string phone;
        private static SqlCommand createPrepCmd = null;
         

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
        
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
 
                createPrepCmd.CommandText = "insert into [tblCustomer]( [CustomerFirstName]" +
                      ",[CustomerLastName],[CustomerPhone] ,[CustomerEmail]) " +
                      "values ( @fname, @lname,@phone, @email)";
                     
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
                 
                 
                createPrepCmd.Prepare();
            }
            else
            {

                createPrepCmd.Parameters["@fname"].Value = FirstName;
                createPrepCmd.Parameters["@lname"].Value = LastName;
                createPrepCmd.Parameters["@phone"].Value = Phone;
                createPrepCmd.Parameters["@email"].Value = Email;
                 
            }

            id = Convert.ToInt16(Connector.Insert(createPrepCmd, true, transaction));
        }



        public override void Delete(SqlTransaction transaction = null)
        {
            base.Delete(transaction);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            base.Update(transaction);
        }

        ///
        /// <summary>
        /// Get All Customer
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable GetAllCustomer(String conStr)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblCustomer] where CustomerId > 0",dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable CustomerTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(CustomerTable);
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
            return CustomerTable;
        }

        ///
        /// <summary>
        /// Get Customers by lastName
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable GetAllCustomerByLastName(String conStr , String custName)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblCustomer] where  ((CustomerLastName LIKE '%" + custName + "%') " +
                "or  (CustomerFirstName LIKE '%" + custName + "%')) and CustomerId > 0", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable CustomerTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(CustomerTable);
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
            return CustomerTable;
        }
    }
}