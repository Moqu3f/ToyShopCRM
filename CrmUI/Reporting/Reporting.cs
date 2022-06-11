using System;
using System.Linq;
using System.Windows.Forms;
using CrmBL.model;

namespace CrmUI.Reporting
{
    public partial class Reporting : Form
    {
        private string[] tovarArray;
        private string[] financeArray;
        private CrmContext db;
        
        public Reporting(CrmContext db)
        {
            tovarArray = new string[2];
            InitializeComponent();
            this.db = db;
            ListViewItem itm;
            var listProduct = db.Products.ToList();
            
            var result = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                select new
                {
                    SheckCode = c.Id,
                    Price = p.Price,
                    Status = c.Status
                };

            financeArray = new string[3];
            listView_Finance.View = View.Details;
            listView_Finance.GridLines = true;
            listView_Finance.FullRowSelect = true;
            listView_Finance.Columns.Add("Код чека");
            listView_Finance.Columns.Add("Прибуток");
            listView_Finance.Columns.Add("Статус");
            
            foreach (var item in result.ToList())
            {
                financeArray[0] = item.SheckCode.ToString();
                //financeArray[2] = item.CountSell.ToString();

                if (item.Status == Status.Sells)
                {
                    financeArray[2] = "Продажа";
                    financeArray[1] = item.Price.ToString();

                }

                if (item.Status == Status.WriteOff)
                {
                    financeArray[2] = "Списання";
                    financeArray[1] = item.Price * -1 + " ";
                }

                if (item.Status == Status.Return)
                {
                    financeArray[2] = "Повернення";
                    financeArray[1] = "0";

                }

                
                itm = new ListViewItem(financeArray);
                listView_Finance.Items.Add(itm);
            }
            
                
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            
            listView1.Columns.Add("ProductName", 100);
            listView1.Columns.Add("ProductPrice", 100);
            
            foreach (var item in listProduct)
            {
                tovarArray[0] = item.Name;
                tovarArray[1] = item.Price.ToString();
               
                itm = new ListViewItem(tovarArray);
                listView1.Items.Add(itm);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}