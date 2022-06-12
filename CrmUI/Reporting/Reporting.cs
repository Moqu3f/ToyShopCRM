using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CrmBL.model;
using MetroFramework.Controls;

namespace CrmUI.Reporting
{
    public partial class Reporting : Form
    {
        private string[] financeArray;
        private string[] productArray;
        private string[] writeOffArray;
        private string[] SellArray;
        private CrmContext db;

        public Reporting(CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            //ListViewItem itm;


            #region list Write Off
              var resultWriteOfff = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                select new
                {
                    SheckCode = sell.SellId,
                    ProductCode = p.Code,
                    ProductName = p.Name,
                    Price = p.Price,
                    Date = c.Created,
                    Status = c.Status
                };

            writeOffArray = new string[5];
            metroListView_WriteOff.BeginUpdate();
            metroListView_WriteOff.Items.Clear();
            metroListView_WriteOff.View = View.Details;
            metroListView_WriteOff.Columns.Add("Id продажі");
            metroListView_WriteOff.Columns.Add("Код товару");
            metroListView_WriteOff.Columns.Add("Назва товару");
            metroListView_WriteOff.Columns.Add("Ціна");
            metroListView_WriteOff.Columns.Add("Дата списання");
            ListViewItem lvi4;
            
            foreach (var item in resultWriteOfff.ToList())
            {
                writeOffArray[0] = item.SheckCode.ToString();

                if (item.Status == Status.WriteOff)
                {
                    writeOffArray[1] = item.ProductCode.ToString();
                    writeOffArray[2] = item.ProductName;
                    writeOffArray[3] = item.Price.ToString();
                    writeOffArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    lvi4 = new ListViewItem(writeOffArray);
                    metroListView_WriteOff.Items.Add(lvi4);
                }
            }

            
        

            metroListView_WriteOff.Columns[0].TextAlign = HorizontalAlignment.Center;
            metroListView_WriteOff.Columns[1].TextAlign = HorizontalAlignment.Center;
            metroListView_WriteOff.Columns[2].TextAlign = HorizontalAlignment.Center;
            metroListView_WriteOff.Columns[3].TextAlign = HorizontalAlignment.Center;
            metroListView_WriteOff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView_WriteOff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView_WriteOff.GridLines = true;
            metroListView_WriteOff.EndUpdate();
            metroListView_WriteOff.AllowSorting = true;
            

            #endregion 

            #region Metro list Sell

            var resultSell = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                select new
                {
                    SheckCode = sell.SellId,
                    ProductCode = p.Code,
                    ProductName = p.Name,
                    Price = p.Price,
                    Date = c.Created,
                    Status = c.Status
                };

            SellArray = new string[5];
            metroListView_Sell.BeginUpdate();
            metroListView_Sell.Items.Clear();
            metroListView_Sell.View = View.Details;
            metroListView_Sell.Columns.Add("Id продажі");
            metroListView_Sell.Columns.Add("Код товару");
            metroListView_Sell.Columns.Add("Назва товару");
            metroListView_Sell.Columns.Add("Ціна");
            metroListView_Sell.Columns.Add("Дата");
            ListViewItem lvi3;
            
            foreach (var item in resultSell.ToList())
            {
                SellArray[0] = item.SheckCode.ToString();

                if (item.Status == Status.Sells)
                {
                    SellArray[1] = item.ProductCode.ToString();
                    SellArray[2] = item.ProductName;
                    SellArray[3] = item.Price.ToString();
                    SellArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    lvi3 = new ListViewItem(SellArray);
                    metroListView_Sell.Items.Add(lvi3);
                }
            }

            
        

            metroListView_Sell.Columns[0].TextAlign = HorizontalAlignment.Center;
            metroListView_Sell.Columns[1].TextAlign = HorizontalAlignment.Center;
            metroListView_Sell.Columns[2].TextAlign = HorizontalAlignment.Center;
            metroListView_Sell.Columns[3].TextAlign = HorizontalAlignment.Center;
            metroListView_Sell.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView_Sell.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView_Sell.GridLines = true;
            metroListView_Sell.EndUpdate();
            metroListView_Sell.AllowSorting = true;
    


    #endregion
            
            #region Metro list Product

            var listProduct = db.Products.ToList();
            
            productArray = new string[3];
            metroListView_Product.BeginUpdate();
            metroListView_Product.Items.Clear();
            metroListView_Product.View = View.Details;
            metroListView_Product.Columns.Add("Код товару");
            metroListView_Product.Columns.Add("Назва товару");
            metroListView_Product.Columns.Add("Залишки товару");
            metroListView_Product.Columns[0].TextAlign = HorizontalAlignment.Center;
            metroListView_Product.Columns[1].TextAlign = HorizontalAlignment.Center;
            metroListView_Product.Columns[2].TextAlign = HorizontalAlignment.Center;

            metroListView_Product.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView_Product.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView_Product.GridLines = true;
            
            metroListView_Product.AllowSorting = true;
             
            ListViewItem lvi2;
            foreach (var item in listProduct.ToList())
            {
                productArray[0] = item.Code;
                productArray[1] = item.Name;
                productArray[2] = item.Count.ToString();
                    
                lvi2 = new ListViewItem(productArray);
                metroListView_Product.Items.Add(lvi2);
            }

            metroListView_Product.EndUpdate();
            #endregion

            #region Metro list Finance
            
            var result = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                select new
                {
                    SheckCode = sell.SellId,
                    ProductCode = p.Code,
                    ProductName = p.Name,
                    Price = p.Price,
                    Date = c.Created,
                    Status = c.Status
                };

            financeArray = new string[6];
            metroListView1.BeginUpdate();
            metroListView1.Items.Clear();
            metroListView1.View = View.Details;
            metroListView1.Columns.Add("Id продажі");
            metroListView1.Columns.Add("Код товару");
            metroListView1.Columns.Add("Назва товару");
            metroListView1.Columns.Add("Ціна");
            metroListView1.Columns.Add("Дата");
            metroListView1.Columns.Add("Статус");
            ListViewItem lvi;
            foreach (var item in result.ToList())
            {
                financeArray[0] = item.SheckCode.ToString();
                //financeArray[2] = item.CountSell.ToString();

                if (item.Status == Status.Sells)
                {
                    financeArray[1] = item.ProductCode.ToString();
                    financeArray[2] = item.ProductName;
                    financeArray[3] = item.Price.ToString();
                    financeArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    financeArray[5] = "Продажа";
                }

                if (item.Status == Status.WriteOff)
                {
                    financeArray[1] = item.ProductCode.ToString();
                    financeArray[2] = item.ProductName;
                    financeArray[3] = item.Price * -1 + " ";
                    financeArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    financeArray[5] = "Списання";
                }

                if (item.Status == Status.Return)
                {
                    financeArray[1] = item.ProductCode.ToString();
                    financeArray[2] = item.ProductName;
                    financeArray[3] = "0";
                    financeArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    financeArray[5] = "Повернення";
                }

                lvi = new ListViewItem(financeArray);
                metroListView1.Items.Add(lvi);
            }

            metroListView1.Columns[0].TextAlign = HorizontalAlignment.Center;
            metroListView1.Columns[1].TextAlign = HorizontalAlignment.Center;
            metroListView1.Columns[2].TextAlign = HorizontalAlignment.Center;
            metroListView1.Columns[3].TextAlign = HorizontalAlignment.Center;
            metroListView1.Columns[4].TextAlign = HorizontalAlignment.Center;
            metroListView1.Columns[5].TextAlign = HorizontalAlignment.Center;

            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView1.GridLines = true;
            metroListView1.EndUpdate();
            metroListView1.AllowSorting = true;

            #endregion
        }


        private void button_all_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            string tag = String.Empty;
            if (rb.Checked)
            {
                tag = rb.Tag.ToString();
                switch (tag)
                {
                    case "All":
                        MessageBox.Show("All");
                        break;
                    case "Year":
                        MessageBox.Show("Year");
                        break;
                    case "Mounth":
                        MessageBox.Show("Mounth");
                        break;
                    case "Day":
                        MessageBox.Show("Day");
                        break;
                    default:
                        break;
                }
            }
        }

        private void textbox_findByCode_KeyUp(object sender, KeyEventArgs e)
        {
            var listProduct = db.Products.ToList();
            var result = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                where
                    p.Code.Contains(((MetroFramework.Controls.MetroTextBox)sender).Text)
                select new
                {
                    SheckCode = sell.SellId,
                    ProductCode = p.Code,
                    ProductName = p.Name,
                    Price = p.Price,
                    Date = c.Created,
                    Status = c.Status
                };

            financeArray = new string[6];
            metroListView1.BeginUpdate();
            metroListView1.Items.Clear();
            ListViewItem lvi;
            //var resultTextFind = db.Products.Where(q => q.Code.Contains(((TextBox)sender).Text)).ToList();
            foreach (var item in result.ToList())
            {
                financeArray[0] = item.SheckCode.ToString();
                //financeArray[2] = item.CountSell.ToString();

                if (item.Status == Status.Sells)
                {
                    financeArray[1] = item.ProductCode.ToString();
                    financeArray[2] = item.ProductName;
                    financeArray[3] = item.Price.ToString();
                    financeArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    financeArray[5] = "Продажа";
                }

                if (item.Status == Status.WriteOff)
                {
                    financeArray[1] = item.ProductCode.ToString();
                    financeArray[2] = item.ProductName;
                    financeArray[3] = item.Price * -1 + " ";
                    financeArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    financeArray[5] = "Списання";
                }

                if (item.Status == Status.Return)
                {
                    financeArray[1] = item.ProductCode.ToString();
                    financeArray[2] = item.ProductName;
                    financeArray[3] = "0";
                    financeArray[4] = item.Date.ToString("hh:mm|dd.MM.yyyy");
                    financeArray[5] = "Повернення";
                }

                lvi = new ListViewItem(financeArray);
                metroListView1.Items.Add(lvi);
                metroListView1.EndUpdate();
            }
        }

        private void metroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}