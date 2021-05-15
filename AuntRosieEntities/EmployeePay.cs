using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace AuntRosieEntities
{
    public class EmployeePay : RosieEntity
    {
        private long employeeId;
        private DateTime paymentDate;
        private DateTime fromDate;
        private DateTime toDate;
        private double amount;
        private string paymentMethod;

        private static SqlCommand createPrepCmd = null;

        public long EmployeeID { get => employeeId; set => employeeId = value; }
        public double Amount { get => amount; set => amount= value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        public DateTime FromDate { get => fromDate; set => fromDate = value; }
        public DateTime ToDate { get => toDate; set => toDate = value; }
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
                createPrepCmd.CommandText = "insert into [tblPayroll]([EmployeeID]," +
                    "[PaymentDate],[FromDate],[ToDate] ,[Amount],[PaymentMethod] )" +
                    " values (@empId,@payDate,@fromDate,@toDate,@amount,@pymentMethod)";


                SqlParameter empIdParam = new SqlParameter("@empId", SqlDbType.BigInt);
                empIdParam.Value = EmployeeID;
                createPrepCmd.Parameters.Add(empIdParam);

                SqlParameter payDateParam = new SqlParameter("@payDate", SqlDbType.Date);
                payDateParam.Value = PaymentDate;
                createPrepCmd.Parameters.Add(payDateParam);

                SqlParameter fromDateParam = new SqlParameter("@fromDate", SqlDbType.Date);
                fromDateParam.Value = FromDate;
                createPrepCmd.Parameters.Add(fromDateParam);

                SqlParameter toDateParam = new SqlParameter("@toDate", SqlDbType.Date);
                toDateParam.Value = ToDate;
                createPrepCmd.Parameters.Add(toDateParam);

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
                createPrepCmd.Parameters["@fromDate"].Value = FromDate;
                createPrepCmd.Parameters["@toDate"].Value = ToDate;
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