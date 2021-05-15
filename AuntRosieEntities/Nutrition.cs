using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace AuntRosieEntities
{
    public class Nutrition : RosieEntity
    {
        private short id;
        private string name;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;


        /// <summary>
        /// Prepared statement to retrieve nutrition by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        /// <summary>
        /// Prepared statement to retrieve nutrition by name
        /// </summary>
        private static SqlCommand retrieveNamePrepCmd = null;

        public short Id { get => id;}
        public string Name { get => name; set => name = value; }

        private void SetID(short id)
        {
            this.id = id;
        }

        /// <summary>
        /// Create a new nutrition record
        /// </summary>
        /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblNutrition]([NutritionName]) values (@name)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                createPrepCmd.Parameters.Add(nameParam);



                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@name"].Value = Name;
            }

            id = Convert.ToInt16(Connector.Insert(createPrepCmd, true, transaction));
        }

        /// <summary>
        /// Delete nutrition record
        /// </summary>
        /// <param name="transaction"></param>
        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblNutrition] where [NutritionID] = @ID";


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
        /// Update nutrition record
        /// </summary>
        /// <param name="transaction"></param>
        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblNutrition] set [TypeName] = @name where [NutritionID] = @ID";


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
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@name"].Value = Name;
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        /// <summary>
        /// Retrieve nutrition record
        /// </summary>
        /// <param name="name">Name of the nutrition record</param>
        /// <returns></returns>
        public static Nutrition Retrieve(string name)
        {
            Nutrition nutrition = null;

            //Prepare statement
            if (retrieveNamePrepCmd is null)
            {
                retrieveNamePrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveNamePrepCmd.CommandText = "select [NutritionID] from [tblNutrition]  where [NutritionName] = @name";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = name;



                retrieveNamePrepCmd.Prepare();
            }
            else
            {
                retrieveNamePrepCmd.Parameters["@name"].Value = name;
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveNamePrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
                nutrition = new Nutrition();
                nutrition.SetID(reader.GetInt16(0));
                nutrition.Name = name;
            }

            reader.Close();

            return nutrition;
        }

        /// <summary>
        /// Retrieve a nutrition record
        /// </summary>
        /// <param name="id">ID of the record to retrieve</param>
        /// <returns></returns>
        public static Nutrition Retrieve(short id)
        {
            Nutrition nutrition = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [NutritionName] from [tblNutrition]  where [NutritionID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = id;

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
                nutrition = new Nutrition();
                nutrition.SetID(id);
                nutrition.Name = reader.GetString(0);
            }

            reader.Close();

            return nutrition;
        }

        public static List<Nutrition> GetNutritions()
        {
            List<Nutrition> nutritions = new List<Nutrition>();

            SqlDataReader reader = Connector.Retrieve("select [NutritionID], [NutritionName] from [tblNutrition]");

            while(reader.Read())
            {
                Nutrition nutrition = new Nutrition();
                nutrition.SetID(reader.GetInt16(0));
                nutrition.Name = reader.GetString(1);
                nutritions.Add(nutrition);
            }
            reader.Close();

            return nutritions;
        }
    }
}