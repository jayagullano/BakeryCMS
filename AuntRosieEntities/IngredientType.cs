using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class IngredientType : RosieEntity
    { 
        private short id = -1;
        private string name = null;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        /// <summary>
        /// Prepared statement to retrieve ingredient type by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        /// <summary>
        /// Prepared statement to retrieve ingredient type by name
        /// </summary>
        private static SqlCommand retrieveNamePrepCmd = null;

        public short Id { get => id;}
        public string Name { get => name; set => name = value; }

        private void SetID(short id)
        {
            this.id = id;
        }

        /// <summary>
        /// Create a new type of ingredient
        /// </summary>
        /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblIngredientType]([TypeName]) values (@name)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                createPrepCmd.Parameters.Add(nameParam);



                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["name"].Value = Name;
            }

            id = Convert.ToInt16(Connector.Insert(createPrepCmd, true, transaction));
        }

        /// <summary>
        /// Delete ingredient type
        /// </summary>
        /// <param name="transaction"></param>
        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblIngredientType] where [IngredientTypeID] = @ID";


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

        /// <summary>
        /// Update ingredient type
        /// </summary>
        /// <param name="transaction"></param>
        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblIngredientType] set [TypeName] = @name where [IngredientTypeID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = Id;

                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;


                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(nameParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["ID"].Value = Id;
                updatePrepCmd.Parameters["name"].Value = Name;
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        /// <summary>
        /// Retrieve a type of ingredient from the database by name
        /// </summary>
        /// <param name="name">Name of the ingredient to retrieve</param>
        /// <returns></returns>
        public static IngredientType Retrieve(string name)
        {
            IngredientType type = null;

            //Prepare statement
            if (retrieveNamePrepCmd is null)
            {
                retrieveNamePrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveNamePrepCmd.CommandText = "select [IngredientTypeID] from [tblIngredientType]  where [TypeName] = @name";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = name;



                retrieveNamePrepCmd.Prepare();
            }
            else
            {
                retrieveNamePrepCmd.Parameters["name"].Value = name;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveNamePrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                type = new IngredientType();
                type.SetID(reader.GetInt16(0));
                type.Name = name;
            }

            reader.Close();

            return type;
        }

        /// <summary>
        /// Retrieve a type of ingredient from the database by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static IngredientType Retrieve(short id)
        {
            IngredientType type = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [TypeName] from [tblIngredientType]  where [IngredientTypeID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = id;

                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                retrieveIdPrepCmd.Parameters["ID"].Value = id;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if(reader.HasRows)
            {
                reader.Read();
                type = new IngredientType();
                type.SetID(id);
                type.Name = reader.GetString(0);
            }

            reader.Close();

            return type;
        }

        


/// <summary>
/// Get Ingredint type
/// //Mervat November ,19
/// </summary>
/// <param name="conStr"></param>
/// <returns></returns>
        public static DataTable GetAllIngredintType(String conStr)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblIngredientType]", dbConnection);
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

    }
}