using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;

namespace AuntRosieEntities
{
    public class ProductSize : RosieEntity
    {
        private byte id;
        private string name;
        private string unit;
        private decimal value;

        /// <summary>
        /// Prepared statement to retrieve product by id
        /// </summary>
        private static SqlCommand retrieveIdPrepCmd = null;

        private static SqlCommand retrieveNamePrepCmd = null;

        private static SqlCommand createPrepCmd = null;
        private static SqlCommand deletePrepCmd = null;
        private static SqlCommand updatePrepCmd = null;

        public byte Id { get => id;}
        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public decimal Value { get => value; set => this.value = value; }

        private void SetID(byte id)
        {
            this.id = id;
        }

        public override void Create(SqlTransaction transaction = null)
        {
            if (createPrepCmd is null)
            {
                createPrepCmd = new SqlCommand(null, Connector.Connection);
                createPrepCmd.CommandText = "insert into [tblProductSize]([SizeName], [Unit], [SizeValue]) values " +
                    "(@name, @unit, @value)";


                SqlParameter nameParam = new SqlParameter("@name", SqlDbType.VarChar, 50);
                nameParam.Value = Name;

                SqlParameter unitParam = new SqlParameter("@unit", SqlDbType.VarChar, 20);
                unitParam.Value = Unit;

                SqlParameter valueParam = new SqlParameter("@value", SqlDbType.Decimal, 0);
                valueParam.Value = Value;

                createPrepCmd.Parameters.Add(nameParam);
                createPrepCmd.Parameters.Add(unitParam);
                createPrepCmd.Parameters.Add(valueParam);

                createPrepCmd.Prepare();
            }
            else
            {
                createPrepCmd.Parameters["@name"].Value = Name;
                createPrepCmd.Parameters["@unit"].Value = Unit;
                createPrepCmd.Parameters["@value"].Value = Value;
            }

            id = Convert.ToByte(Connector.Insert(createPrepCmd, true, transaction));
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Update(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public static ProductSize Retrieve(byte id)
        {
            ProductSize ProductSize = null;

            //Prepare statement
            if (retrieveIdPrepCmd is null)
            {
                retrieveIdPrepCmd = new SqlCommand(null, Connector.Connection);
                retrieveIdPrepCmd.CommandText = "select [SizeName], [Unit], [SizeValue] from [tblProductSize] where [SizeID] = @ID";


                SqlParameter idParam = new SqlParameter("@ID", SqlDbType.TinyInt, 0);
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
                ProductSize = new ProductSize();
                ProductSize.SetID(id);
                ProductSize.Name = reader.IsDBNull(0)? null : reader.GetString(0);
                ProductSize.Unit = reader.GetString(1);
                ProductSize.Value = reader.GetDecimal(2);
            }

            reader.Close();

            return ProductSize;
        }

        public static List<ProductSize> GetProductSizes()
        {
            List<ProductSize> sizes = new List<ProductSize>();

            //Process result
            SqlDataReader reader = Connector.Retrieve("select [SizeID], [SizeName], [Unit], [SizeValue]" +
                " from [tblProductSize]");
            while (reader.Read())
            {
                ProductSize size = new ProductSize();
                size.SetID(reader.GetByte(0));

                size.Name = reader.IsDBNull(1)? null : reader.GetString(1);
                size.Unit = reader.GetString(2);
                size.Value = reader.GetDecimal(3);

                sizes.Add(size);
            }

            reader.Close();

            return sizes;
        }

        public override string ToString()
        {
            return $"{(Name != null? ($"{Name} |"):"")} {Value} {Unit}";
        }
    }
}