using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class SaleProduct : RosieEntity
    {
        private long eventProductId;
        private long saleId;
        private int saleQuantity;
        private double salePrice;

        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;
        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public Sale Sale
        {
            get => default;
            set
            {
            }
        }
      
        public long EventProductId { get => eventProductId; set => eventProductId = value; }
        public long SaleId { get => saleId; set => saleId = value; }
        public int SaleQuantity { get => saleQuantity; set => saleQuantity = value; }
        public double SalePrice { get => salePrice; set => salePrice = value; }
        public EventProduct EventProduct
        {
            get => default;
            set
            {
            }
        }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblSaleProducts]([EventProductID]," +
                    " [SaleID], [SaleQuantity],[SalePrice]) values " +
                    "(@eventProductID, @saleID, @saleQuantity, @salePrice)";

                SqlParameter eventProductParam = new SqlParameter("@eventProductID", SqlDbType.BigInt, 0);
                eventProductParam.Value = EventProductId;

                SqlParameter saleIDParam = new SqlParameter("@saleID", SqlDbType.BigInt, 0);
                saleIDParam.Value = SaleId;

                SqlParameter saleQuantityParam = new SqlParameter("@saleQuantity", SqlDbType.TinyInt, 0);
                saleQuantityParam.Value = SaleQuantity;

                SqlParameter salePriceParam = new SqlParameter("@salePrice", SqlDbType.Money, 0);
                salePriceParam.Value = SalePrice;

                createPrepCmd.Parameters.Add(eventProductParam);
                createPrepCmd.Parameters.Add(saleIDParam);
                createPrepCmd.Parameters.Add(saleQuantityParam);
                createPrepCmd.Parameters.Add(salePriceParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@eventProductID"].Value = EventProductId;
                createPrepCmd.Parameters["@saleID"].Value = SaleId;
                createPrepCmd.Parameters["@saleQuantity"].Value = SaleQuantity;
                createPrepCmd.Parameters["@salePrice"].Value = SalePrice;
            }

            Connector.Insert(createPrepCmd, true, transaction);
        }

    

    public override void Delete(SqlTransaction transaction = null)
        {
            DeleteProductSale(SaleId, EventProductId, transaction);
        }

        public static void DeleteProductSale(long saleId, long eventProductId, SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblSaleProducts] where" +
                    " [EventProductID]=@eventProductId , [SaleID]=@saleId";


                SqlParameter saleIdParam = new SqlParameter("@saleId", SqlDbType.BigInt, 0);
                saleIdParam.Value = saleId;

                deletePrepCmd.Parameters.Add(saleIdParam);

                SqlParameter eventProductIdParam = new SqlParameter("@eventProductId", SqlDbType.BigInt, 0);
                eventProductIdParam.Value = eventProductId;

                deletePrepCmd.Parameters.Add(eventProductIdParam);

                deletePrepCmd.Prepare();
            }
            else
            {
                deletePrepCmd.Parameters["@saleId"].Value =  saleId;
                deletePrepCmd.Parameters["@eventProductId"].Value = eventProductId;
            }

            Connector.Delete(deletePrepCmd, transaction);
        }


        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}