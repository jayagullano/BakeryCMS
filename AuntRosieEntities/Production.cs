using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

using System.ComponentModel;

namespace AuntRosieEntities
{
    public class Production : RosieEntity
    {
        private long id;
        private int productItemID;
        private DateTime productionDate;
        private short quantity;
        private DateTime? expiryDate;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public ProductItem ProductItem
        {
            get
            {
                return ProductItem.Retrieve(ProductItemID);
            }
            set
            {
                ProductItemID = value.Id;
                Update();
            }
        }

        [Browsable(false)]
        public long Id { get => id; }
        [Browsable(false)]
        public int ProductItemID { get => productItemID; set => productItemID = value; }
        public DateTime ProductionDate { get => productionDate; set => productionDate = value; }
        public short Quantity { get => quantity; set => quantity = value; }
        public DateTime? ExpiryDate { get => expiryDate; set => expiryDate = value; }

        private void SetID(long id)
        {
            this.id = id;
        }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblProduction]([ProductItemID], [ProductionQuantity], [ExpiryDate], [ProductionDate]) " +
                    "values (@product, @qty, @expDate, @prodDate)";


                SqlParameter productItemParam = new SqlParameter("@product", SqlDbType.Int, 0);
                productItemParam.Value = ProductItemID;

                SqlParameter qtyParam = new SqlParameter("@qty", SqlDbType.SmallInt, 0);
                qtyParam.Value = Quantity;

                SqlParameter expParam = new SqlParameter("@expDate", SqlDbType.Date, 0);
                expParam.Value = ExpiryDate??ExpiryDate.Value.Date;

                SqlParameter productionDateParam = new SqlParameter("@prodDate", SqlDbType.DateTime, 0);
                productionDateParam.Value = ProductionDate;

                createPrepCmd.Parameters.Add(productItemParam);
                createPrepCmd.Parameters.Add(qtyParam);
                createPrepCmd.Parameters.Add(expParam);
                createPrepCmd.Parameters.Add(productionDateParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@product"].Value = ProductItemID;
                createPrepCmd.Parameters["@qty"].Value = Quantity;
                createPrepCmd.Parameters["@expDate"].Value = ExpiryDate;
                createPrepCmd.Parameters["@prodDate"].Value = ProductionDate;
            }

            id = Connector.Insert(createPrepCmd, true, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            DeleteProduction(Id, transaction);
        }

        public static void DeleteProduction(long id, SqlTransaction transaction=null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblProduction] where [ProductionID]=@ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = id;

                deletePrepCmd.Parameters.Add(idParam);

                deletePrepCmd.Prepare();
            }
            else
            {
                deletePrepCmd.Parameters["@ID"].Value = id;
            }

            Connector.Delete(deletePrepCmd, transaction);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            if (updatePrepCmd is null)
            {
                updatePrepCmd = new SqlCommand(null, Connector.Connection);
                updatePrepCmd.CommandText = "update [tblProduction] set [ProductItemID]=@product, " +
                    "[ProductionQuantity]=@qty, [ExpiryDate]=@expDate, [ProductionDate]=@prodDate where [ProductionID]=@ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
                idParam.Value = Id;

                SqlParameter productItemParam = new SqlParameter("@product", SqlDbType.Int, 0);
                productItemParam.Value = ProductItemID;

                SqlParameter qtyParam = new SqlParameter("@qty", SqlDbType.SmallInt, 0);
                qtyParam.Value = Quantity;

                SqlParameter expParam = new SqlParameter("@expDate", SqlDbType.Date, 0);
                expParam.Value = ExpiryDate ?? ExpiryDate.Value.Date;

                SqlParameter productionDateParam = new SqlParameter("@prodDate", SqlDbType.DateTime, 0);
                productionDateParam.Value = ProductionDate;

                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(productItemParam);
                updatePrepCmd.Parameters.Add(qtyParam);
                updatePrepCmd.Parameters.Add(expParam);
                updatePrepCmd.Parameters.Add(productionDateParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@product"].Value = ProductItemID;
                updatePrepCmd.Parameters["@qty"].Value = Quantity;
                updatePrepCmd.Parameters["@expDate"].Value = ExpiryDate;
                updatePrepCmd.Parameters["@prodDate"].Value = ProductionDate;
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        public static Production Retrieve(long id)
        {
            Production production = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [ProductItemID], [ProductionDate], [ProductionQuantity], [ExpiryDate]" +
                    " from [tblProduction] where [ProductionID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.BigInt, 0);
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
                production = new Production();
                production.SetID(id);
                production.ProductItemID = reader.GetInt32(0);
                production.ProductionDate = reader.GetDateTime(1);
                production.Quantity = reader.GetInt16(2);
                production.ExpiryDate = reader.GetDateTime(3);
            }

            reader.Close();

            return production;
        }

        /// <summary>
        /// Get a list of all production records
        /// </summary>
        /// <param name="productionId"></param>
        /// <returns></returns>
        public static List<Production> GetProductions()
        {
            List<Production> items = new List<Production>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select [ProductionID], [ProductItemID], [ProductionDate], " +
                "[ProductionQuantity], [ExpiryDate] from [tblProduction]");

            while (reader.HasRows && reader.Read())
            {
                Production productionItem = new Production();
                productionItem.SetID(reader.GetInt64(0));
                productionItem.ProductItemID = reader.GetInt32(1);
                productionItem.ProductionDate = reader.GetDateTime(2);
                productionItem.Quantity = reader.GetInt16(3);
                productionItem.ExpiryDate = reader.GetDateTime(4);

                items.Add(productionItem);
            }

            reader.Close();

            return items;
        }

        /// <summary>
        /// Get productions earlier than supplied date
        /// </summary>
        /// <param name="earliest">Earliest production date to return</param>
        /// <returns></returns>
        public static List<Production> GetProductions(DateTime earliest)
        {
            List<Production> items = new List<Production>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select prdtn.[ProductionID], prdtn.[ProductItemID], prdtn.[ProductionDate], " +
                "prdtn.[ProductionQuantity], prdtn.[ExpiryDate] from [tblProduction] prdtn " +
                "inner join [tblProductItem] prdi on prdi.[ProductItemID] = prdtn.[ProductItemID] " +
                "inner join [tblProduct] prd on prd.[ProductID] = prdi.[ProductID] " +
                $"where prdtn.[ProductionDate] >= '{earliest.Date}'");

            while (reader.HasRows && reader.Read())
            {
                Production productionItem = new Production();
                productionItem.SetID(reader.GetInt64(0));
                productionItem.ProductItemID = reader.GetInt32(1);
                productionItem.ProductionDate = reader.GetDateTime(2);
                productionItem.Quantity = reader.GetInt16(3);
                productionItem.ExpiryDate = reader.GetDateTime(4);

                items.Add(productionItem);
            }

            reader.Close();

            return items;
        }

        /// <summary>
        /// Get a list of all production records
        /// </summary>
        /// <param name="productionId"></param>
        /// <returns></returns>
        public static List<Production> GetProductions(string productType)
        {
            List<Production> items = new List<Production>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select prdtn.[ProductionID], prdtn.[ProductItemID], prdtn.[ProductionDate], " +
                "prdtn.[ProductionQuantity], prdtn.[ExpiryDate] from [tblProduction] prdtn " +
                "inner join [tblProductItem] prdi on prdi.[ProductItemID] = prdtn.[ProductItemID] " +
                "inner join [tblProduct] prd on prd.[ProductID] = prdi.[ProductID] " +
                $"where prd.[ProductType] = '{productType}'");

            while (reader.HasRows && reader.Read())
            {
                Production productionItem = new Production();
                productionItem.SetID(reader.GetInt64(0));
                productionItem.ProductItemID = reader.GetInt32(1);
                productionItem.ProductionDate = reader.GetDateTime(2);
                productionItem.Quantity = reader.GetInt16(3);
                productionItem.ExpiryDate = reader.GetDateTime(4);

                items.Add(productionItem);
            }

            reader.Close();

            return items;
        }

        /// <summary>
        /// Search by production date
        /// </summary>
        /// <param name="earliest"></param>
        /// <param name="latest"></param>
        /// <returns></returns>
        public static List<Production> GetProductions(DateTime earliest, DateTime latest)
        {
            List<Production> items = new List<Production>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select prdtn.[ProductionID], prdtn.[ProductItemID], prdtn.[ProductionDate], " +
                "prdtn.[ProductionQuantity], prdtn.[ExpiryDate] from [tblProduction] prdtn " +
                "inner join [tblProductItem] prdi on prdi.[ProductItemID] = prdtn.[ProductItemID] " +
                "inner join [tblProduct] prd on prd.[ProductID] = prdi.[ProductID] " +
                $"where prdtn.[ProductionDate] >= '{earliest.Date}' and prdtn.[ProductionDate] <= '{latest.Date}'");

            while (reader.HasRows && reader.Read())
            {
                Production productionItem = new Production();
                productionItem.SetID(reader.GetInt64(0));
                productionItem.ProductItemID = reader.GetInt32(1);
                productionItem.ProductionDate = reader.GetDateTime(2);
                productionItem.Quantity = reader.GetInt16(3);
                productionItem.ExpiryDate = reader.GetDateTime(4);

                items.Add(productionItem);
            }

            reader.Close();

            return items;
        }

        public static DataTable GetAvailableProductionsTable(long eventID)
        {
            DataTable productions = new DataTable();
            string query = "select * from (select distinct prdtn.[ProductionID] as 'ProductionID', prd.[ProductName] as 'Product Name'," +
                "concat(prdsz.[SizeName], '(', prdsz.[SizeValue], ' ', prdsz.[Unit], ')') as 'Size'," +
                "prdtn.[ProductionQuantity] - isnull(aggtmp.[UsedQuantity], 0) as 'Remaining Quantity'," +
                "prdtn.[ProductionDate] as 'Production Date'," +
                "prdtn.[ExpiryDate] as 'Expiry Date' " +
                "from[tblProduction] prdtn " +
                "inner join[tblProductItem] prdi " +
                "on prdi.[ProductItemID] = prdtn.[ProductItemID] " +
                "inner join[tblProduct] prd " +
                "on prd.[ProductID] = prdi.[ProductID] " +
                "inner join[tblProductSize] prdsz " +
                "on prdsz.[SizeID] = prdi.[SizeID] " +
                "full outer join( " +
                "select[ProductionID], sum([Quantity]) as 'UsedQuantity' " +
                "from[tblEventProduct] " +
                "group by[ProductionID]" +
                ") aggtmp " +
                "on aggtmp.[ProductionID] = prdtn.[ProductionID]" +
                ") tbl " +
                $"where tbl.[Remaining Quantity] > 0 and tbl.[Expiry Date] > '{DateTime.Now.Date}' and tbl.[ProductionID] not in " +
                $"(select[ProductionID] from [tblEventProduct] where [EventID] = {eventID})";

            SqlCommand command = new SqlCommand(query, Connector.Connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(productions);
            }
            catch(Exception e)
            {
                return null;
            }
            return productions;
        }

        /// <summary>
        /// Get max ID in production table
        /// </summary>
        /// <returns></returns>
        public static long GetLastID()
        {
            long id = 0;
            SqlDataReader reader = Connector.Retrieve("select max([ProductionID]) from [tblProduction]");
            if(reader.Read())
            {
                id = reader.GetInt64(0);
            }
            reader.Close();
            return id;
        }

        public override string ToString()
        {
            return $"{ProductItem} {Quantity} {ProductionDate} {ExpiryDate}";
        }
    }
}