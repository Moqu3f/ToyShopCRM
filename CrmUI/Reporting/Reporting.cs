using System;
using System.Linq;
using System.Windows.Forms;
using CrmBL.model;

namespace CrmUI.Reporting
{
    public partial class Reporting : Form
    {
        private string[] tovarArray;
        private CrmContext db;
        
        public Reporting(CrmContext db)
        {
            tovarArray = new string[2];
            InitializeComponent();
            this.db = db;
            ListViewItem itm;
            var listProduct = db.Products.ToList();

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