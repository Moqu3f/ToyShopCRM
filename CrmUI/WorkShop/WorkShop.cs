using CrmBL.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUI.WorkShop
{
    public partial class WorkShop : Form
    {
        CrmContext db;
        private Cart _cart; 
        private Cart _cart2; 
        private CashDesk _cashDesk;
        private List<Product> products;

        public WorkShop(CrmContext db)
        {
            _cart = new Cart();
            
            products = new List<Product>();
            InitializeComponent();
            this.db = db;
            listBox1.DataSource = db.Products.ToList();
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";

            listBox3.DataSource = db.Products.ToList();
            listBox3.DisplayMember = "Name";

            listBox4.DataSource = db.Checks.Where(q => q.Status == Status.Sells).ToList();
            listBox4.DisplayMember = "Id";

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //selectedItem = (Product)listBox1.SelectedItem;
        }
        Product selectedItem = null;
        private void button_Add_Click(object sender, EventArgs e)
        {
            selectedItem = (Product)listBox1.SelectedItem;
            listBox2.Items.Add(selectedItem);
            _cart.Add(selectedItem);

            textBox_Sum.Text = _cart.Price + "";
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            textBox_Sum.Text = String.Empty;
        }

        private void button_Sell_Click(object sender, EventArgs e)
        {
            CashDesk _cashDesk = new CashDesk(db)
            {
                IsModel = false
            };
            _cashDesk.AddCard(_cart);
            _cashDesk.Sell(Status.Sells);
            
            db.SaveChanges();
            MessageBox.Show("Успішна покупка");
            listBox2.Items.Clear();
            db.SaveChanges();
            _cart = new Cart();
        }

        private Product SelectedWriteOffListBox;
        private void button_WriteOff_Click(object sender, EventArgs e)
        {
            _cart2 = new Cart();
            _cart2.Add(SelectedWriteOffListBox);
            CashDesk _cashDesk = new CashDesk(db)
            {
                IsModel = false
            };
            _cashDesk.AddCard(_cart2);
            _cashDesk.Sell(Status.WriteOff);
            db.SaveChanges();
            MessageBox.Show("Списано");
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedWriteOffListBox = (Product)listBox3.SelectedItem;
    
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private Check ItemReturn = null;
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            ItemReturn = (Check)listBox4.SelectedItem;
            var result = from sell in db.Sells
                join p in db.Products on sell.ProductId equals p.Id
                join c in db.Checks on sell.CheckId equals c.Id
                where 
                    c.Id == ItemReturn.Id 
                select new
                {
                    Name = p.Name,
                    Price = p.Price,
                };
            
            dataGridView1.DataSource = result.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button_Return_Click(object sender, EventArgs e)
        {
            CashDesk _cashDesk = new CashDesk(db)
            {
                IsModel = true
            };
            _cashDesk.Cart = new Cart();
            var sum = _cashDesk.ReturnProduct(ItemReturn);
            MessageBox.Show($"Покупку №{ItemReturn.Id} повернено на суму {sum}");
            listBox4.DataSource = db.Checks.Where(q => q.Status == Status.Sells).ToList();
        }
    }
}
