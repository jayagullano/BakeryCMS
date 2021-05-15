using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class FullTimeEmployee : Employee
    {
        private double salary;
        private DateTime employementDate;
        private int status;
        private DateTime terminationDate;

        public override void Create(SqlTransaction transaction = null)
        {
            base.Create(transaction);
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