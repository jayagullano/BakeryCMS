using System;
using System.Data;
using System.Data.SqlClient;
namespace AuntRosieEntities
{
    public class Sale : RosieEntity
    {
        private long id;
        private long customerId;
        private DateTime saleDate;
        private string paymentMethod;

        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;
        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;


        public long Id { get => id; }
        
        public long CustomerId { get => customerId; set => customerId = value; }
        public DateTime SaleDate { get => saleDate; set => saleDate = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        private void SetID(long id)
        {
            this.id = id;
        }

        public Customer Customer
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
                createPrepCmd.CommandText = "insert into [tblSale]([CustomerID], [SaleDateTime], [PaymentMethod]) " +
                    "values (@customerID, @salDateTime, @paymentMethod)";


                SqlParameter customerIDParam = new SqlParameter("@customerID", SqlDbType.BigInt, 0);
                customerIDParam.Value = CustomerId;

                SqlParameter salDateTimeParam = new SqlParameter("@salDateTime", SqlDbType.DateTime, 0);
                salDateTimeParam.Value =SaleDate;

                

                SqlParameter paymentMethodParam = new SqlParameter("@paymentMethod", SqlDbType.Char,1);
                paymentMethodParam.Value = PaymentMethod;

                createPrepCmd.Parameters.Add(customerIDParam);
                createPrepCmd.Parameters.Add(salDateTimeParam);
                createPrepCmd.Parameters.Add(paymentMethodParam);
               

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@customerID"].Value = CustomerId;
                createPrepCmd.Parameters["@salDateTime"].Value = SaleDate;
                createPrepCmd.Parameters["@paymentMethod"].Value =PaymentMethod;
             
            }

           id=  Connector.Insert(createPrepCmd, true, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            DeleteSale(Id, transaction);
        }

        public static void DeleteSale(long id, SqlTransaction transaction = null)
        {
            if (deletePrepCmd is null)
            {
                deletePrepCmd = new SqlCommand(null, Connector.Connection);
                deletePrepCmd.CommandText = "delete from [tblSale] where [SaleID]=@ID";


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

        /// <summary>
        ///  
        /// </summary>
        /// <param name="name">Name of the ingredient to retrieve</param>
        /// <returns></returns>
        public static long RetrieveMax()
        {
            
           long Maxid=-1;
            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select  Max([SaleID]) AS Expr1 from [tblSale]";



              
                retrieveIdPrepCmd.Prepare();
            }
            else
            {
                 
            }

            //Process result
            SqlDataReader reader = Connector.Retrieve(retrieveIdPrepCmd);
            if (reader.HasRows)
            {
                reader.Read();
               Maxid =  reader.GetInt64 (0);
               

            }

            reader.Close();

            return Maxid;
        }


        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }
    }
}