using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;

namespace AuntRosieEntities
{
    public class DBConnector: IDisposable
    {
        private SqlConnection connection;

        public SqlConnection Connection { get => connection; set => connection = value; }

        public DBConnector(string connectionString)
        {
            this.Connect(connectionString);
        }

        /// <summary>
        /// Connect to a database
        /// </summary>
        /// <param name="connectionString">DB connection string</param>
        public void Connect(string connectionString)
        {
            if(!(Connection is null))
            {
                Connection.Close();
            }
            Connection = new SqlConnection(connectionString);
            Connection.Open();
        }

        /// <summary>
        /// Disconnect from a database
        /// </summary>
        public void Disconnect()
        {
            if(!(Connection is null))
            {
                Connection.Close();
            }
        }

        /// <summary>
        /// Insert a record into the database
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="getInsertedID">If true return the primary key of the newly inserted record else; return if insertion was successful</param>
        /// <param name="transaction">Transaction that the operation is a part of</param>
        /// <returns>The last inserted id</returns>
        public long Insert(string query, bool getInsertedID = true, SqlTransaction transaction = null)
        {
            return Insert(new SqlCommand(query, Connection), getInsertedID, transaction);
        }

        /// <summary>
        /// Insert a record into the database
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <param name="getInsertedID">If true return the primary key of the newly inserted record else; return if insertion was successful</param>
        /// <param name="transaction">Transaction that the operation is a part of</param>
        /// <returns>The last inserted id</returns>
        public long Insert(SqlCommand command, bool getInsertedID  = true, SqlTransaction transaction = null)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            long result = -1;

            if (!(transaction is null))
            {
                command.Transaction = transaction;
            }

            adapter.InsertCommand = command;
            object resObj = adapter.InsertCommand.ExecuteScalar();

            // result = getInsertedID ? Convert.ToInt64(resObj) : adapter.InsertCommand.ExecuteNonQuery();

            adapter.InsertCommand.Dispose();
            adapter.Dispose();

            return result;
        }

        /// <summary>
        /// Insert a record into the database
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="transaction">Transaction that the operation is a part of</param>
        /// <returns>Number of affected records</returns>
        public long Update(string query, SqlTransaction transaction = null)
        {
            return Update(new SqlCommand(query, Connection), transaction);
        }

        /// <summary>
        /// Insert a record into the database
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <param name="transaction">Transaction that the operation is a part of</param>
        /// <returns>Number of affected records</returns>
        public long Update(SqlCommand command, SqlTransaction transaction = null)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            long result = -1;

            if (!(transaction is null))
            {
                command.Transaction = transaction;
            }

            adapter.UpdateCommand = command;

            result = adapter.UpdateCommand.ExecuteNonQuery();

            adapter.UpdateCommand.Dispose();
            adapter.Dispose();

            return result;
        }

        /// <summary>
        /// Delete a record from the database
        /// </summary>
        /// <param name="query">Query to execute</param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public long Delete(string query, SqlTransaction transaction = null)
        {
            return Delete(new SqlCommand(query, Connection), transaction);
        }

        /// <summary>
        /// Delete a record from the database
        /// </summary>
        /// <param name="command">Sqlcommand to execute</param>
        /// <param name="transaction">Transaction to execute the operation in</param>
        /// <returns></returns>
        public long Delete(SqlCommand command, SqlTransaction transaction = null)
        {
            long result = -1;

            SqlDataAdapter adapter = new SqlDataAdapter();

            if(!(transaction is null))
            {
                command.Transaction = transaction;
            }

            adapter.DeleteCommand = command;

            result = adapter.DeleteCommand.ExecuteNonQuery();

            adapter.DeleteCommand.Dispose();
            adapter.Dispose();

            return result;
        }

        /// <summary>
        /// Retrieve records from the database
        /// </summary>
        /// <param name="query">Query to be executed</param>
        /// <returns>SQL data reader containing results</returns>
        public SqlDataReader Retrieve(string query)
        {
            return Retrieve(new SqlCommand(query, Connection));
        }

        /// <summary>
        /// Retrieve records from the database
        /// </summary>
        /// <param name="command">Command to be executed</param>
        /// <returns>SQL data reader containing records</returns>
        public SqlDataReader Retrieve(SqlCommand command)
        {
            return command.ExecuteReader();
        }

        public void Dispose()
        {
            while(Connection.State == ConnectionState.Executing)
            {

            }
            if(Connection.State != ConnectionState.Closed && Connection.State != ConnectionState.Broken)
            {
                Connection.Close();
            }
        }
    }
}