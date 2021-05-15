using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class Product : RosieEntity, IDisposable
    {
        private short id = -1;
        private string name;
        private string type;
        private string servingSize;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public short Id { get => id; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string ServingSize { get => servingSize; set => servingSize = value; }

        private void SetID(short id)
        {
            this.id = id;
        }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblProduct]([ProductName], [ProductType], [ServingSize]) values " +
                    "(@name, @type, @size)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.VarChar, 50);
                typeParam.Value = Type;

                SqlParameter sizeParam = new SqlParameter("@size", SqlDbType.VarChar, 50);
                sizeParam.Value = ServingSize;

                createPrepCmd.Parameters.Add(nameParam);
                createPrepCmd.Parameters.Add(typeParam);
                createPrepCmd.Parameters.Add(sizeParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@name"].Value = Name;
                createPrepCmd.Parameters["@type"].Value = Type;
                createPrepCmd.Parameters["@size"].Value = ServingSize;
            }

            id = Convert.ToInt16(Connector.Insert(createPrepCmd, true, transaction));
        }



        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblProduct] where [ProductID]=@ID";


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

        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblProduct] set [ProductName]=@name, [ProductType]=@type, [ServingSize]=@size " +
                    "where [ProductID]=@ID";

                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = Id;

                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter typeParam = new SqlParameter("@type", SqlDbType.VarChar, 50);
                typeParam.Value = Type;

                SqlParameter sizeParam = new SqlParameter("@size", SqlDbType.VarChar, 50);
                sizeParam.Value = ServingSize;

                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(nameParam);
                updatePrepCmd.Parameters.Add(typeParam);
                updatePrepCmd.Parameters.Add(sizeParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@name"].Value = Name;
                updatePrepCmd.Parameters["@type"].Value = Type;
                updatePrepCmd.Parameters["@size"].Value = ServingSize;
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        public static Product Retrieve(short id)
        {
            Product product = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [ProductName], [ProductType], [ServingSize] from [tblProduct] where [ProductID] = @ID";


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
                product = new Product();
                product.SetID(id);
                product.Name = reader.GetString(0);
                product.Type = reader.GetString(1);
                product.ServingSize = reader.GetString(2);
            }

            reader.Close();

            return product;
        }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select [ProductID], [ProductName], [ProductType], [ServingSize]" +
                "from [tblProduct]");
            while (reader.HasRows && reader.Read())
            {
                Product product = new Product();
                product.SetID(reader.GetInt16(0));
                product.Name = reader.GetString(1);
                product.Type = reader.GetString(2);
                product.ServingSize = reader.GetString(3);

                products.Add(product);
            }

            reader.Close();

            return products;
        }

        public void Dispose()
        {
            //Dispose of prepared statements
            retrieveIdPrepCmd.Dispose();
            retrieveNamePrepCmd.Dispose();
        }

        public override string ToString()
        {
            return $"{Name} {ServingSize}";
        }
    }
}