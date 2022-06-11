using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBL.model;

namespace CrmUI
{
    public partial class Form1 : Form
    {
        CrmContext db;
        public Form1()
        {
            db = new CrmContext();
            InitializeComponent();
        }

        private void button_Catalog_Click(object sender, EventArgs e)
        {
            var item = new Catalog.Catalog(db);
            item.Show();
        }

        private void button_WorkShop_Click(object sender, EventArgs e)
        {
            var item = new WorkShop.WorkShop(db);
            item.Show();
        }

        private void button_Zvit_Click(object sender, EventArgs e)
        {
            var item = new Reporting.Reporting(db);
            item.Show();
        }
    }
}