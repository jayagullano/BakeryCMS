using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace AuntRosieEntities
{
    public class Expense : RosieEntity
    {
        private long id;
        private DateTime payDate;
        private double payValue;
        private string paymentMethod;
        private string payType;
        private string note;
        private static SqlCommand createPrepCmd = null;
        private static SqlCommand retrieveIdPrepCmd = null;
        public long ID { get => id; set => id = value; }
        public double PayValue { get => payValue; set => payValue = value; }
        public DateTime PaymentDate { get => payDate; set => payDate = value; }
        public string Note { get => note; set => note = value; }
        public string PayType { get => payType; set => payType = value; }
        public string ThisPaymentMethod { get => paymentMethod; set => paymentMethod = value; }



        /// <summary>
        /// Create a new part timer  payroll
        /// </summary>
        /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblMiscellaneousExpense]([ExpensePayDate]," +
                    "[ExpenseValue],[PaymentMethod],[ExpenseType],[ExpenseNote] )" +
                    " values (@date,@value,@payMethode,@type,@note)";


                SqlParameter exDateParam = new SqlParameter("@date", SqlDbType.Date);
                exDateParam.Value = PaymentDate;
                createPrepCmd.Parameters.Add(exDateParam);

               

                SqlParameter exNoteParam = new SqlParameter("@note", SqlDbType.Text,250);
                exNoteParam.Value = Note;
                createPrepCmd.Parameters.Add(exNoteParam);

                SqlParameter exTypeParam = new SqlParameter("@type", SqlDbType.Char,1);
                exTypeParam.Value = PayType;
                createPrepCmd.Parameters.Add(exTypeParam);

                SqlParameter paymentMethodParam = new SqlParameter("@payMethode", SqlDbType.Char, 1);
                paymentMethodParam.Value = ThisPaymentMethod;
                createPrepCmd.Parameters.Add(paymentMethodParam);

                SqlParameter amountParam = new SqlParameter("@value", SqlDbType.Money, 20);
                amountParam.Value = PayValue;
                createPrepCmd.Parameters.Add(amountParam);






                createPrepCmd.Prepare();
            }
            else
            {


                createPrepCmd.Parameters["@date"].Value = PaymentDate;
                createPrepCmd.Parameters["@note"].Value = Note;
                createPrepCmd.Parameters["@value"].Value = PayValue;
                createPrepCmd.Parameters["@payMethode"].Value = ThisPaymentMethod;
                createPrepCmd.Parameters["@type"].Value = PayType;
                
            }

            Connector.Insert(createPrepCmd, true, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public static long RetrieveMax()
        {

            long Maxid = -1;
            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select  Max([ExpenseID]) AS Expr1 from [tblMiscellaneousExpense]";




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
                Maxid = reader.GetInt64(0);


            }

            reader.Close();

            return Maxid;
        }


    }
}