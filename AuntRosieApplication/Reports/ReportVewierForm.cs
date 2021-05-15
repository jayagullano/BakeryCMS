/**
 * @author Mervat Mustafa
 * @description This form used to  hold the report viewre which used to preview the reports 
 * @since 2020-December
 */

using System;
 
using System.Windows.Forms;
 

namespace AuntRosieApplication
{
    public partial class ReportVewierForm : Form
    {
        private ReportDataSet aDataSet;
        //table adapter object
        private ReportDataSetTableAdapters.StockReportTableAdapter aStockAdapter;
        private ReportDataSetTableAdapters.LowStockTableAdapter aLowStockAdapter;
        private ReportDataSetTableAdapters.EmpEventTableAdapter aEmpEventAdapter;
        private ReportDataSetTableAdapters.ChangePriceTableAdapter aChangePriceAdapter;
       

        //New Reports
        private ReportDataSetTableAdapters.WorstSellingProductsTableAdapter aWorseProductsAdapter;
        private ReportDataSetTableAdapters.TotalRevenueTableAdapter aTotalRevenueAdapter;
        private ReportDataSetTableAdapters.NutritionInformationTableAdapter aNutritionAdapter;
        private ReportDataSetTableAdapters.TotalExpensesTableAdapter aTotalExpensesAdapter;
        private ReportDataSetTableAdapters.CustomerEligibleForPromosTableAdapter aCustomerPromosAdapter;
        private ReportDataSetTableAdapters.CustomerNumberOfPurchasesTableAdapter aCustomerPurchasesAdapter;
        private ReportDataSetTableAdapters.TopProductsTableAdapter aTopProductsAdapter;
        private ReportDataSetTableAdapters.ProductsToTurnProfitTableAdapter aProfitAdapter;
        private ReportDataSetTableAdapters.TopProductMarketsTableAdapter aTopMarketsAdapter;
        public ReportVewierForm()
        {
            InitializeComponent();
        }

        private void ReportVewierForm_Load(object sender, EventArgs e)

        {
            
            
            if (Classes.DBMethod.Reptype == "All-Stock")
            {
                LoadStockRep();
            }
            else if (Classes.DBMethod.Reptype == "Low-Stock")
            {
                LoadLowStockRep();

            }
            else if (Classes.DBMethod.Reptype == "Emp-Event")
            { LoadEmpEvent(); }
            else if (Classes.DBMethod.Reptype == "Diff-Price")
            { LoadDiffPrice(); }
            if (Classes.DBMethod.Reptype == "All-Stock")
            {
                LoadStockRep();
            }
            else if (Classes.DBMethod.Reptype == "Low-Stock")
            {
                LoadLowStockRep();

            }
            
            else if (Classes.DBMethod.Reptype == "Worst-Products")
            { LoadLowSellingProducts(); }
            else if (Classes.DBMethod.Reptype == "Total-Revenue")
            { LoadTotalRevenue(); }
            else if (Classes.DBMethod.Reptype == "Nutrition-Info")
            { LoadNutritionInfo(); }
            else if (Classes.DBMethod.Reptype == "Total-Expenses")
            { LoadTotalExpenses(); }
            else if (Classes.DBMethod.Reptype == "Customer-Promos")
            { LoadCustomerPromos(); }
            else if (Classes.DBMethod.Reptype == "Customer-Purchases")
            { LoadCustomerPurchases(); }
            else if (Classes.DBMethod.Reptype == "Top-Products")
            { LoadTopProducts(); }
            else if (Classes.DBMethod.Reptype == "Product-Profit")
            { LoadProductsProfit(); }
            else if (Classes.DBMethod.Reptype == "Top-Markets")
            { LoadTopMarkets(); }

        }

        
        private void  LoadStockRep()
        {
            StockReport astockRep = new StockReport();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aStockAdapter = new ReportDataSetTableAdapters.StockReportTableAdapter();
                //Fill the dataset 
               

                aStockAdapter.Fill(aDataSet.StockReport);
                //Assign the filled dataset as the data source for the report
                astockRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = astockRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadLowStockRep()
        {
            LowStockRep aLowStockRep = new LowStockRep();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aLowStockAdapter = new ReportDataSetTableAdapters.LowStockTableAdapter();
                //Fill the dataset 
               // aStockAdapter.Adapter.SelectCommand = new System.Data.SqlClient.SqlCommand(AuntRosieApplication.Inventory.frmInventoryStock.reportSql);


                aLowStockAdapter.Fill(aDataSet.LowStock);
                //Assign the filled dataset as the data source for the report
                aLowStockRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aLowStockRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }


        }
        private void LoadEmpEvent()
        {

            EmpEventRep aEmpEventRep = new EmpEventRep();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aEmpEventAdapter = new ReportDataSetTableAdapters.EmpEventTableAdapter();
                //Fill the dataset 
                   aEmpEventAdapter.Fill(aDataSet.EmpEvent);
                //Assign the filled dataset as the data source for the report
                aEmpEventRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aEmpEventRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }


        }
        private void LoadDiffPrice()
        {

            ChanagepriceRep aChangePriceRep = new ChanagepriceRep();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aChangePriceAdapter = new ReportDataSetTableAdapters.ChangePriceTableAdapter();

                aChangePriceAdapter.Fill(aDataSet.ChangePrice);
                //Assign the filled dataset as the data source for the report
                aChangePriceRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aChangePriceRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }




        }
        private void crvReports_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadLowSellingProducts()
        {

            WorstSellingProducts aWorseProductsRep = new WorstSellingProducts();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aWorseProductsAdapter = new ReportDataSetTableAdapters.WorstSellingProductsTableAdapter();
                //Fill the dataset 
                aWorseProductsAdapter.Fill(aDataSet.WorstSellingProducts);
                //Assign the filled dataset as the data source for the report
                aWorseProductsRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aWorseProductsRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadTotalRevenue()
        {

            TotalRevenue aTotalRevenueRep = new TotalRevenue();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aTotalRevenueAdapter = new ReportDataSetTableAdapters.TotalRevenueTableAdapter();
                //Fill the dataset 
                aTotalRevenueAdapter.Fill(aDataSet.TotalRevenue);
                //Assign the filled dataset as the data source for the report
                aTotalRevenueRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aTotalRevenueRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadNutritionInfo()
        {

            NutritionInformation aNutritionRep = new NutritionInformation();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aNutritionAdapter = new ReportDataSetTableAdapters.NutritionInformationTableAdapter();
                //Fill the dataset 
                aNutritionAdapter.Fill(aDataSet.NutritionInformation);
                //Assign the filled dataset as the data source for the report
                aNutritionRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aNutritionRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadTotalExpenses()
        {

            TotalExpenses aTotalExpRep = new TotalExpenses();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aTotalExpensesAdapter = new ReportDataSetTableAdapters.TotalExpensesTableAdapter();
                //Fill the dataset 
                aTotalExpensesAdapter.Fill(aDataSet.TotalExpenses);
                //Assign the filled dataset as the data source for the report
                aTotalExpRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aTotalExpRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadCustomerPromos()
        {

            CustomerPromos aPromosRep = new CustomerPromos();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aCustomerPromosAdapter = new ReportDataSetTableAdapters.CustomerEligibleForPromosTableAdapter();
                //Fill the dataset 
                aCustomerPromosAdapter.Fill(aDataSet.CustomerEligibleForPromos);
                //Assign the filled dataset as the data source for the report
                aPromosRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aPromosRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadCustomerPurchases()
        {

            CustomerPurchases aCustomerPurchase = new CustomerPurchases();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aCustomerPurchasesAdapter = new ReportDataSetTableAdapters.CustomerNumberOfPurchasesTableAdapter();
                //Fill the dataset 
                aCustomerPurchasesAdapter.Fill(aDataSet.CustomerNumberOfPurchases);
                //Assign the filled dataset as the data source for the report
                aCustomerPurchase.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aCustomerPurchase;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadTopProducts()
        {

            TopSellingProducts aTopProductsRep = new TopSellingProducts();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aTopProductsAdapter = new ReportDataSetTableAdapters.TopProductsTableAdapter();
                //Fill the dataset 
                aTopProductsAdapter.Fill(aDataSet.TopProducts);
                //Assign the filled dataset as the data source for the report
                aTopProductsRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aTopProductsRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadProductsProfit()
        {

            ProductsToTurnProfit aProfitRep = new ProductsToTurnProfit();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aProfitAdapter = new ReportDataSetTableAdapters.ProductsToTurnProfitTableAdapter();
                //Fill the dataset 
                aProfitAdapter.Fill(aDataSet.ProductsToTurnProfit);
                //Assign the filled dataset as the data source for the report
                aProfitRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aProfitRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }

        private void LoadTopMarkets()
        {

            TopProductMarket aTopMarketRep = new TopProductMarket();

            try
            {

                //Instantiate the dataset and table adapters
                aDataSet = new ReportDataSet();
                aTopMarketsAdapter = new ReportDataSetTableAdapters.TopProductMarketsTableAdapter();
                //Fill the dataset 
                aTopMarketsAdapter.Fill(aDataSet.TopProductMarkets);
                //Assign the filled dataset as the data source for the report
                aTopMarketRep.SetDataSource(aDataSet);
                //Set up the report viewer object on the form
                //show the runtime report object
                crvReports.ReportSource = aTopMarketRep;



            }
            catch (Exception ex)
            {
                //catch an exception thrown during data object intonation
                //or report generation and display based on the dataset
                MessageBox.Show("Data Error Encountered" + ex.ToString(), "ERROR");
            }
        }
    }
}
