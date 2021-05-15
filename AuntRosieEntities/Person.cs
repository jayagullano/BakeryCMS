using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class Person : RosieEntity
    {
        private string firstName;
        private string lastName;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }

        public override void Create(SqlTransaction transaction = null)
        {
            
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            
        }

        public override void Update(SqlTransaction transaction = null)
        {
            
        }
    }
}