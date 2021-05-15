using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AuntRosieEntities
{
    public class ProductNutrition : RosieEntity
    {
        private int productItemId=-1;
        private short nutritionId=-1;
        private double value = -1;
        private char valueType;

        public Nutrition Nutrition
        {
            get => default;
            set
            {
            }
        }

        public int ProductItemId { get => productItemId; set => productItemId = value; }
        public short NutritionId { get => nutritionId; set => nutritionId = value; }
        public double Value { get => value; set => this.value = value; }
        public char ValueType { get => valueType; set => valueType = value; }

        public override void Create(SqlTransaction transaction = null)
        {
            string query = $"insert into [tblProductNutrition]" +
                $"([ProductItemID], [NutritionID], [Value], [ValueType]) values " +
                $"({ProductItemId}, {NutritionId}, {Value}, '{ValueType}')";

            Connector.Insert(query, false, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            throw new NotImplementedException();
        }

        public override void Update(SqlTransaction transaction = null)
        {
            Connector.Update("update [tblProductNutrition] " +
                $"set [Value]={value}, [ValueType]='{valueType}' " +
                $"where [ProductItemID]={ProductItemId} and [NutritionID]={NutritionId}");
        }

        public static ProductNutrition Retrieve(short nutritionId, int productItemId)
        {
            ProductNutrition productNutrition = null;
            SqlDataReader reader = Connector.Retrieve("select [Value], [ValueType] from [tblProductNutrition] " +
                $"where [NutritionID]={nutritionId} and [ProductItemID] = {productItemId}");

            if(reader.Read())
            {
                productNutrition = new ProductNutrition();
                productNutrition.ProductItemId = productItemId;
                productNutrition.NutritionId = nutritionId;
                productNutrition.Value = (double)reader.GetDecimal(0);
                productNutrition.ValueType = reader.GetString(1)[0];
            }

            reader.Close();

            return productNutrition;
        }

        public static List<ProductNutrition> GetProductNutrition(short productId)
        {
            throw new System.NotImplementedException();
        }
    }
}