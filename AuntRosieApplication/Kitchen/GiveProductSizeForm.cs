/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Create size varieties of products
 * Date: 2020-12-17
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieEntities;
using System.Data.SqlClient;

namespace AuntRosieApplication.Kitchen
{
    public partial class frmGiveProductSize : Form
    {
        List<Product> products = new List<Product>();
        List<ProductSize> sizes = new List<ProductSize>();

        public frmGiveProductSize()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e) { }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        /// <summary>
        /// Connect to database and load comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGiveProductSize_Load(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            pnlButton.Left = (this.Width - pnlButton.Width) / 2;


            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            products = Product.GetProducts();
            cmbProducts.DataSource = products;
            cmbProducts.DisplayMember = "Name";
            sizes = ProductSize.GetProductSizes();
            cmbSizes.DataSource = sizes;
        }

        /// <summary>
        /// Create new product variety
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Product selectedProduct = (Product)cmbProducts.SelectedItem;
            ProductSize selectedSize = (ProductSize)cmbSizes.SelectedItem;
            try
            {
                short productID = (selectedProduct).Id;
                byte size = (selectedSize).Id;
                decimal price = Convert.ToDecimal(txtPrice.Text);
                ProductItem newItem = new ProductItem(size, price, productID);
                newItem.Create();

                showMsg($"Successfully added product, {selectedProduct.Name} of size, {selectedSize}", true);
            }
            catch(SqlException se)
            {
                if(se.Message.Contains("duplicate key"))
                {
                    showMsg($"Product {selectedProduct.Name} already has a size of {selectedSize}. Please try again", false); 
                }
            }
        }

        /// <summary>
        /// Show error message
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="success"></param>
        private void showMsg(string msg, bool success)
        {
            if(success)
            {
                lblMsg.ForeColor = Color.Green;
            }
            else{
                lblMsg.ForeColor = Color.Red;
            }

            lblMsg.Text = msg;
        }

        /// <summary>
        /// Clear the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
        }

        /// <summary>
        /// Close the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }
    }
}
