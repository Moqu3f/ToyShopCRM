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
        private Catalog.Catalog _catalog;
        private WorkShop.WorkShop _workshop;
        private Reporting.Reporting _reporting;
        public Form1()
        {
            db = new CrmContext();

            _catalog = new Catalog.Catalog(db);
            _workshop = new WorkShop.WorkShop(db);
            _reporting = new Reporting.Reporting(db);
            InitializeComponent();
        }

        private void button_Catalog_Click(object sender, EventArgs e)
        {
            _catalog.ShowDialog();
        }

        private void button_WorkShop_Click(object sender, EventArgs e)
        {
            _workshop.ShowDialog();
        }

        private void button_Zvit_Click(object sender, EventArgs e)
        {
            _reporting.ShowDialog();
        }
    }
}