using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AuntRosieEntities
{
    public abstract class RosieEntity
    {
        private static DBConnector connector;

        public static DBConnector Connector { get => connector; set => connector = value; }

        public abstract void Create(SqlTransaction transaction = null);
        public abstract void Delete(SqlTransaction transaction = null);
        public abstract void Update(SqlTransaction transaction = null);
    }
}