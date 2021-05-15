using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class ProductItem : RosieEntity
    {
        private int id;
        private byte sizeID;
        private decimal price;
        private short productID;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;
        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public ProductItem(byte sizeID, decimal price, short productID)
        {
            this.sizeID = sizeID;
            this.price = price;
            this.productID = productID;
        }

        public ProductItem()
        {
        }

        public Product Product
        {
            get
            {
                return Product.Retrieve(productID);
            }
            set
            {
                this.ProductID = value.Id;
                Update();
            }
        }

        public ProductSize ProductSize
        {
            get
            {
                return ProductSize.Retrieve(SizeID);
            }
            set
            {
                this.SizeID = value.Id;
                Update();
            }
        }

        public int Id { get => id;}
        public byte SizeID { get => sizeID; set => sizeID = value; }
        public decimal Price { get => price; set => price = value; }
        public short ProductID { get => productID; set => productID = value; }

        private void SetID(int id)
        {
            this.id = id;
        }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblProductItem]([ProductID], [SizeID], [Price]) values " +
                    "(@product, @size, @price)";

                SqlParameter productParam = new SqlParameter("@product", SqlDbType.SmallInt, 0);
                productParam.Value = ProductID;

                SqlParameter sizeParam = new SqlParameter("@size", SqlDbType.TinyInt, 0);
                sizeParam.Value = SizeID;

                SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Money, 0);
                priceParam.Value = Price;

                createPrepCmd.Parameters.Add(productParam);
                createPrepCmd.Parameters.Add(sizeParam);
                createPrepCmd.Parameters.Add(priceParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@product"].Value = ProductID;
                createPrepCmd.Parameters["@size"].Value = SizeID;
                createPrepCmd.Parameters["@price"].Value = Price;
            }

            id = Convert.ToInt32(Connector.Insert(createPrepCmd,true, transaction));
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblProductItem] where [ProductItemID]=@ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int, 0);
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
                updatePrepCmd.CommandText = "update [tblProductItem] set [ProductID]=@product, [SizeID]=@size, [Price]=@price " +
                    "where [ProductItemID]=@ID";

                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.SmallInt, 0);
                idParam.Value = Id;

                SqlParameter productParam = new SqlParameter("@product", SqlDbType.SmallInt, 0);
                productParam.Value = ProductID;

                SqlParameter sizeParam = new SqlParameter("@size", SqlDbType.TinyInt, 0);
                sizeParam.Value = SizeID;

                SqlParameter priceParam = new SqlParameter("@price", SqlDbType.Money, 0);
                priceParam.Value = Price;

                updatePrepCmd.Parameters.Add(idParam);
                updatePrepCmd.Parameters.Add(productParam);
                updatePrepCmd.Parameters.Add(sizeParam);
                updatePrepCmd.Parameters.Add(priceParam);

                updatePrepCmd.Prepare();
            }
            else
            {
                updatePrepCmd.Parameters["@ID"].Value = Id;
                updatePrepCmd.Parameters["@product"].Value = ProductID;
                updatePrepCmd.Parameters["@size"].Value = SizeID;
                updatePrepCmd.Parameters["@price"].Value = Price;
            }

            Connector.Update(updatePrepCmd, transaction);
        }

        public static ProductItem Retrieve(int id)
        {
            ProductItem productItem = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [ProductID], [SizeID], [Price] from [tblProductItem]" +
                    " where [ProductItemID] = @ID;";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.Int, 0);
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
                productItem = new ProductItem();
                productItem.SetID(id);
                productItem.ProductID = reader.GetInt16(0);
                productItem.SizeID = reader.GetByte(1);
                productItem.Price = reader.GetDecimal(2);
            }

            reader.Close();

            return productItem;
        }
        
        /// <summary>
        /// Get a list of all product items
        /// </summary>
        /// <param name="productionId"></param>
        /// <returns></returns>
        public static List<ProductItem> GetProductItems()
        {
            List<ProductItem> items = new List<ProductItem>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select [ProductItemID], [ProductID], [SizeID], [Price]" +
                "from [tblProductItem]");

            while (reader.HasRows && reader.Read())
            {
                ProductItem productItem = new ProductItem();
                productItem.SetID(reader.GetInt32(0));
                productItem.ProductID = reader.GetInt16(1);
                productItem.SizeID = reader.GetByte(2);
                productItem.Price = reader.GetDecimal(3);

                items.Add(productItem);
            }

            reader.Close();

            return items;
        }

        public override string ToString()
        {
            return $"{Product.Name} ({ProductSize.ToString()})";
        }
    }
}