using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using System.Data;

namespace AuntRosieEntities
{
    public class EventExpense : Expense
    {
        private long eventId;
        private long expenseId;

        public RosieEvent Event
        {
            get => default;
            set
            {
            }
        }

        private static SqlCommand createPrepCmd = null;

        public long EventID { get => eventId; set => eventId = value; }
        public long ExpensID { get => expenseId; set => expenseId = value; }




        /// <summary>
        /// Create a new part timer  payroll
        /// </summary>
        /// <param name="transaction"></param>
        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblEventExpenses]([ExpenseID]," +
                    "[EventID] )" +
                    " values (@expensId,@eventId )";


                SqlParameter eventIdParam = new SqlParameter("@eventId", SqlDbType.BigInt);
                eventIdParam.Value = EventID;
                createPrepCmd.Parameters.Add(eventIdParam);



                SqlParameter expensIdParam = new SqlParameter("@expensId", SqlDbType.BigInt);
                expensIdParam.Value =ExpensID;
                createPrepCmd.Parameters.Add(expensIdParam);
 




                createPrepCmd.Prepare();
            }
            else
            {


                createPrepCmd.Parameters["@eventId"].Value =EventID;
                createPrepCmd.Parameters["@expensId"].Value = ExpensID;
                

            }

            Connector.Insert(createPrepCmd, true, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            base.Delete(transaction);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            base.Update(transaction);
        }
    }
}