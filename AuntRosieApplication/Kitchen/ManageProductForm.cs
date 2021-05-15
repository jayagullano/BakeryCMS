/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Provides navigation to various screens to manage products
 * Date: 2020-12-17
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AuntRosieApp.Kitchen
{
    public partial class frmManageProduct : Form
    {
        public frmManageProduct()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Load background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManageProduct_Load(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            /*pnlButton.Left = (this.Width - pnlButton.Width) / 2;*/
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

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

        private void frmManageProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Navigate to screen to add product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click_1(object sender, EventArgs e)
        {
            AuntRosieApplication.Kitchen.frmAddProduct frm = new AuntRosieApplication.Kitchen.frmAddProduct();
            frm.Left = (this.Parent.Width - frm.Width) / 2;
            this.Close();
            
            //frm.Top = (this.Height - frm.Height) / 2;
            //frm.Activate();
            frm.ShowDialog();

            
        }

        /// <summary>
        /// Navigate to screen to add product size variety
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddProductSize_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Kitchen.frmGiveProductSize frm = new AuntRosieApplication.Kitchen.frmGiveProductSize();
            frm.Left = (this.Parent.Width - frm.Width) / 2;
            this.Close();

            //frm.Top = (this.Height - frm.Height) / 2;
            //frm.Activate();
            frm.ShowDialog();
        }

        /// <summary>
        /// Navigate to screen to edit product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Kitchen.frmUpdateProduct frm = new AuntRosieApplication.Kitchen.frmUpdateProduct();
            frm.Left = (this.Parent.Width - frm.Width) / 2;
            this.Close();

            //frm.Top = (this.Height - frm.Height) / 2;
            //frm.Activate();
            frm.ShowDialog();
        }

        /// <summary>
        /// Navigate to screen to manage product nutrition
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AuntRosieApplication.Kitchen.frmManageProductNutrition mpn = 
                new AuntRosieApplication.Kitchen.frmManageProductNutrition();
            mpn.ShowDialog();
        }

        /// <summary>
        /// Navigate to screen to manage product ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManageProductIngredients_Click(object sender, EventArgs e)
        {
            this.Close();
            AuntRosieApplication.Kitchen.frmManageProductIngredients frm =
                new AuntRosieApplication.Kitchen.frmManageProductIngredients();
            frm.ShowDialog();
        }

        /// <summary>
        /// Navigate to screen to view products
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            AuntRosieApplication.Kitchen.frmViewProducts frm = new AuntRosieApplication.Kitchen.frmViewProducts();
            frm.ShowDialog();
        }
    }
}
