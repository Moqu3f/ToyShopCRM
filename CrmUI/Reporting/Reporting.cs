using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CrmBL.model;

namespace CrmUI.Reporting
{
    public partial class Reporting : Form
    {
        private string[] financeArray;
        private CrmContext db;

        public Reporting(CrmContext db)
        {
            InitializeComponent();
            this.db = db;
            //ListViewItem itm;
            var listProduct = db.Products.ToList();
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
    }
}