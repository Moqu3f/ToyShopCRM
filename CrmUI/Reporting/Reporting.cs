using System;
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
            ListViewItem itm;
            var listProduct = db.Products.ToList();
            var result = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                select new
                {
                    SheckCode = sell.SellId,
                    ProductCode = p.Id,
                    Price = p.Price,
                    Status = c.Status
                };
            financeArray = new string[4];
            metroListView1.BeginUpdate();
            metroListView1.Items.Clear();
            metroListView1.View = View.Details;
            metroListView1.Columns.Add("Id продажі");
            metroListView1.Columns.Add("Код товару");
            metroListView1.Columns.Add("Ціна");
            metroListView1.Columns.Add("Статус");
            ListViewItem lvi;
            foreach (var item in result.ToList())
            {
                financeArray[0] = item.SheckCode.ToString();
                //financeArray[2] = item.CountSell.ToString();

                if (item.Status == Status.Sells)
                {
                    financeArray[1] = item.ProductCode.ToString();
                    financeArray[2] = item.Price.ToString();
                    financeArray[3] = "Продажа";
                }

                if (item.Status == Status.WriteOff)
                {
                    financeArray[1] = item.ProductCode  + " ";
                    financeArray[2] = item.Price * -1 + " ";
                    financeArray[3] = "Списання";
                }

                if (item.Status == Status.Return)
                {
                    financeArray[1] = item.ProductCode  + " ";
                    financeArray[2] = "0";
                    financeArray[3] = "Повернення";

                }
                lvi = new ListViewItem(financeArray);
                metroListView1.Items.Add(lvi);
            }
            metroListView1.Columns[0].TextAlign = HorizontalAlignment.Right;
            metroListView1.Columns[1].TextAlign = HorizontalAlignment.Center;
            metroListView1.Columns[2].TextAlign = HorizontalAlignment.Left;
            metroListView1.Columns[3].TextAlign = HorizontalAlignment.Left;
            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            metroListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            metroListView1.EndUpdate();
            metroListView1.AllowSorting = true;
        }

    }
}