using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace AuntRosieEntities
{
    public class Ingredient : RosieEntity
    {
        private long id;
        private string name;
        private short ingredientTypeId;
        private string storingNote;
        private string unit;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        /// <summary>
        /// Prepared statement to retrieve ingredient by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        public IngredientType IngredientType
        {
            get
            {
                return IngredientType.Retrieve(IngredientTypeId);
            }
            set
            {
                IngredientTypeId = IngredientType.Id;
            }
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public short IngredientTypeId { get => ingredientTypeId; set => ingredientTypeId = value; }
        public string StoringNote { get => storingNote; set => storingNote = value; }
        public string Unit { get => unit; set => unit = value; }

        private void SetID(long id)
        {
            this.id = id;
        }

        /// <summary>
        /// Create a new ingredient
        /// </summary>
        /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblIngredient]([IngredientName], [StoringNote], [IngredientTypeID],[Unit])" +
                    " values (@name, @note, @type,@unit)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;
                SqlParameter unitParam = new SqlParameter("@unit", SqlDbType.VarChar, 20);
                unitParam.Value = Unit;
                createPrepCmd.Parameters.Add(unitParam);

                SqlParameter noteParam = new SqlParameter("@note", SqlDbType.Text, (int)Math.Pow(2, 31) - 1);
                noteParam.Value = StoringNote;

                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.SmallInt, 0);
                typeParam.Value = IngredientTypeId;

                createPrepCmd.Parameters.Add(nameParam);
                createPrepCmd.Parameters.Add(noteParam);
                createPrepCmd.Parameters.Add(typeParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@name"].Value = Name;
                createPrepCmd.Parameters["@note"].Value = StoringNote;
                createPrepCmd.Parameters["@type"].Value = IngredientTypeId;
                createPrepCmd.Parameters["@unit"].Value = Unit;
            }

            id = Convert.ToInt64(Connector.Insert(createPrepCmd, true, transaction));
        }

        /// <summary>
        /// Delete ingredient
        /// </summary>
        /// <param name="transaction"></param>
        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblIngredient] where [IngredientID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = Id;
                deletePrepCmd.Parameters.Add(idParam);

                
                deletePrepCmd.Prepare();   
            }
            else
            {
                deletePrepCmd.Parameters["@ID"].Value = Id;
            }

            Connector.Delete(deletePrepCmd, transaction);
        }

        /// <summary>
        /// Update ingredient
        /// </summary>
        /// <param name="transaction"></param>
        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblIngredient] set [IngredientName] = @name, [StoringNote] = @note , [Unit]=@unit " +
                    "where [IngredientID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = Id;

                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter noteParam = new SqlParameter("@note", SqlDbType.Text, (int)Math.Pow(2, 31) - 1);
                noteParam.Value = Name;

                SqlParameter unitParam = new SqlParameter("@unit", SqlDbType.VarChar, 20);
                unitParam.Value = Unit;
                updatePrepCmd.Parameters.Add(unitParam);

                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(nameParam);
                updatePrepCmd.Parameters.Add(noteParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@name"].Value = Name;
                updatePrepCmd.Parameters["@note"].Value = IngredientTypeId;
                updatePrepCmd.Parameters["@unit"].Value = Unit;
            }
            

            Connector.Update(updatePrepCmd, transaction);
        }

        ///// <summary>
        ///// Retrieve an ingredient from the database by name
        ///// </summary>
        ///// <param name="name">Name of the ingredient to retrieve</param>
        ///// <returns></returns>
        //public static Ingredient Retrieve(string name)
        //{
        //    Ingredient ingredient = null;

        //    //Prepare statement
        //    if (retrieveNamePrepCmd is null)
        //    {
        //        retrieveNamePrepCmd = new SqlCommand(null, Connector.Connection);
        //        retrieveNamePrepCmd.CommandText = "select [IngredientID], [StoringNote], [IngredientTypeID], [Unit] from [tblIngredient] where [IngredientName] = @name";


        //        SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
        //        nameParam.Value = name;

        //        retrieveNamePrepCmd.Prepare();
        //    }
        //    else
        //    {
        //        retrieveNamePrepCmd.Parameters["name"].Value = name;
        //    }

        //    //Process result
        //    SqlDataReader reader = Connector.Retrieve(retrieveNamePrepCmd);
        //    if (reader.HasRows)
        //    {
        //        reader.Read();
        //        ingredient = new Ingredient();
        //        ingredient.SetID(reader.GetInt64(0));
        //        ingredient.Name = name;
        //        ingredient.IngredientTypeId = reader.GetInt16(2);
        //        ingredient.StoringNote = reader.GetString(1);
        //    }

        //    reader.Close();

        //    return ingredient;
        //}

        /// <summary>
        /// Retrieve an ingredient from the database by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Ingredient Retrieve(long id)
        {
            Ingredient ingredient = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [IngredientName], [StoringNote], [IngredientTypeID], [Unit] " +
                    "from [tblIngredient] where [IngredientID] = @ID";
                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = id;
                retrieveIdPrepCmd.Parameters.Add(idParam);

                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                retrieveIdPrepCmd.Parameters["@ID"].Value = id;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                ingredient = new Ingredient();
                ingredient.SetID(id);
                ingredient.Name = reader.GetString(0);
                ingredient.IngredientTypeId = reader.GetInt16(2);
                ingredient.StoringNote = reader.GetString(1);
                ingredient.Unit = reader.GetString(3);
            }

            reader.Close();

            return ingredient;
        }



        /// <summary>
        /// Get Ingredints
        /// //Mervat November ,19
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable GetAllIngredints(String conStr)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblIngredient]", dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable IngredintTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(IngredintTable);
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
            return IngredintTable;
        }

        /// <summary>
        /// Get Ingredints by thier types
        /// //Mervat November ,19
        /// </summary>
        /// <param name="conStr"></param>
        /// <returns></returns>
        public static DataTable GetAllIngredintsByType(String conStr,String typeId)
        {
            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(conStr);

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT * FROM [tblIngredient] Where [IngredientTypeID]=" + typeId, dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable IngredintTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(IngredintTable);
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
            return IngredintTable;
        }
    }
}