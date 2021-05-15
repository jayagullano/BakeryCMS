using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace AuntRosieEntities
{
    public class EmployeeFullPay : RosieEntity
    {
        private long employeeId;
        private DateTime paymentDate;
        private int month;
        private int year;
        private int biWeekNo;
        private double amount;
        private string paymentMethod;

        private static SqlCommand createPrepCmd = null;

        public long EmployeeID { get => employeeId; set => employeeId = value; }
        public double Amount { get => amount; set => amount= value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        public int MonthNo { get => month; set => month = value; }
        public int YearNo { get => year; set => year = value; }
        public int BiWeekNo { get => biWeekNo; set => biWeekNo = value; }
        public string ThisPaymentMethod { get => paymentMethod; set => paymentMethod = value; }




        /// <summary>
        /// Create a new type of Inventory in
        /// </summary>
        /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblFullTimePayroll]([EmployeeID]," +
                    "    [PaymentDate],[Month],[BiweekNo] ,[Amount],[PaymentMethod],[Year] )" +
                    " values (@empId,@payDate,@month,@biWeek,@amount,@pymentMethod,@year)";


                SqlParameter empIdParam = new SqlParameter("@empId", SqlDbType.BigInt);
                empIdParam.Value = EmployeeID;
                createPrepCmd.Parameters.Add(empIdParam);

                SqlParameter payDateParam = new SqlParameter("@payDate", SqlDbType.Date);
                payDateParam.Value = PaymentDate;
                createPrepCmd.Parameters.Add(payDateParam);

                SqlParameter monthParam = new SqlParameter("@month", SqlDbType.TinyInt);
                monthParam.Value = MonthNo;
                createPrepCmd.Parameters.Add(monthParam);
                SqlParameter yearParam = new SqlParameter("@year", SqlDbType.SmallInt);
                yearParam.Value =YearNo;
                createPrepCmd.Parameters.Add(yearParam);

                SqlParameter biWeekParam = new SqlParameter("@biWeek", SqlDbType.TinyInt);
                biWeekParam.Value = BiWeekNo;
                createPrepCmd.Parameters.Add(biWeekParam);

                SqlParameter paymentMethodParam = new SqlParameter("@pymentMethod", SqlDbType.Char, 1);
                paymentMethodParam.Value = ThisPaymentMethod;
                createPrepCmd.Parameters.Add(paymentMethodParam);
 
                SqlParameter amountParam = new SqlParameter("@amount", SqlDbType.Money, 20);
                amountParam.Value = Amount;
                createPrepCmd.Parameters.Add(amountParam);

                 




                createPrepCmd.Prepare();
            }
            else
            {


                createPrepCmd.Parameters["@empId"].Value = EmployeeID;
                createPrepCmd.Parameters["@payDate"].Value = PaymentDate;
                createPrepCmd.Parameters["@month"].Value = MonthNo;
                createPrepCmd.Parameters["@year"].Value = YearNo;
                createPrepCmd.Parameters["@biWeek"].Value = biWeekNo;
                createPrepCmd.Parameters["@pymentMethod"].Value = ThisPaymentMethod;
                createPrepCmd.Parameters["@amount"].Value = Amount;
               
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
    }
}