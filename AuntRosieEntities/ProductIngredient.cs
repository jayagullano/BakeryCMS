using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;

namespace AuntRosieEntities
{
    public class ProductIngredient : RosieEntity
    {
        private int productItemId;
        private long ingredientId;
        private double quantity;
        private string unit;

        public Ingredient Ingredient
        {
            get => default;
            set
            {
            }
        }

        public ProductItem ProductItem
        {
            get => default;
            set
            {
            }
        }

        public int ProductItemId { get => productItemId; set => productItemId = value; }
        public long IngredientId { get => ingredientId; set => ingredientId = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public string Unit { get => unit; set => unit = value; }

        public override void Create(SqlTransaction transaction = null)
        {
            string query = "insert into [tblProductIngredient]([ProductItemID], [IngredientID], [Quantity], [Unit]) " +
                $"values ({ProductItemId}, {IngredientId}, {Quantity}, '{Unit}')";
            Connector.Insert(query, false, transaction);
        }

        public override void Delete(SqlTransaction transaction = null)
        {
            string query = $"delete from [tblProductIngredient] where " +
                $"[ProductItemID]={ProductItemId} and [IngredientID]={IngredientId}";
            Connector.Delete(query);
        }

        public override void Update(SqlTransaction transaction = null)
        {
            string query = $"update [tblProductIngredient] set [Quantity]={Quantity}, [Unit]='{Unit}' " +
                $"where [ProductItemID]={productItemId} and [IngredientID]={ingredientId}";
            Connector.Update(query);
        }

        public static ProductIngredient Retrieve(int productItemID, long ingredientID)
        {
            string query = $"select [Quantity], [Unit] from [tblProductIngredient] where [ProductItemID]={productItemID} " +
                $"and [IngredientID]={ingredientID}";

            ProductIngredient productIngredient = null;
            SqlDataReader reader = Connector.Retrieve(query);
            try
            {
                if (reader.Read())
                {
                    productIngredient = new ProductIngredient();
                    productIngredient.ProductItemId = productItemID;
                    productIngredient.IngredientId = ingredientID;
                    productIngredient.Quantity = (double)reader.GetDecimal(0);
                    productIngredient.Unit = reader.GetString(1);
                }

            }
            finally
            {
                reader.Close();
            }
            return productIngredient;
        }

        public static DataTable GetIngredientsTable(int productItemID)
        {
            DataTable ingredients = new DataTable();
            string query = "select pin.[IngredientID] as 'IngredientID', i.[IngredientName] as 'Ingredient Name', " +
                "it.[TypeName] as 'Type', " +
                "pin.[Quantity] as 'Quantity', pin.[Unit] as 'Unit' " +
                "from [tblProductIngredient] pin " +
                "inner join [tblProductItem] pi on pin.[ProductItemID]=pi.[ProductItemID] " +
                "inner join [tblIngredient] i on i.[IngredientID]=pin.[IngredientID] " +
                "inner join [tblIngredientType] it on i.[IngredientTypeID]=it.[IngredientTypeID] " +
                $"where pin.[ProductItemID]={productItemID}";

            SqlCommand command = new SqlCommand(query, Connector.Connection);
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ingredients);
            }
            catch
            {
                return null;
            }

            return ingredients;
        }
    }
}