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
        private List<Product> product_SellItem;

        private string[] SellsItems;

        public WorkShop(CrmContext db)
        {
            _cart = new Cart();

            product_SellItem = new List<Product>();
            InitializeComponent();
            this.db = db;
            listBox1.DataSource = db.Products.ToList();
            listBox1.DisplayMember = "Name";
            listBox2.DisplayMember = "Name";

            listBox3.DataSource = db.Products.ToList();
            listBox3.DisplayMember = "Name";

            listBox4.DataSource = db.Checks.Where(q => q.Status == Status.Sells).ToList();
            listBox4.DisplayMember = "Id";


            //Metro ListView Sells


            #region ListView Sells

            SellsItems = new string[4];
            listview_sells.BeginUpdate();
            listview_sells.Items.Clear();
            listview_sells.View = View.Details;
            listview_sells.Columns.Add("Код");
            listview_sells.Columns.Add("Назва");
            listview_sells.Columns.Add("Ціна");
            ListViewItem listViewItemSells;
            foreach (var item in db.Products)
            {
                SellsItems[0] = item.Code;
                SellsItems[1] = item.Name;
                SellsItems[2] = item.Price.ToString();

                listViewItemSells = new ListViewItem(SellsItems);
                listview_sells.Items.Add(listViewItemSells);
            }

            listview_sells.Columns[0].TextAlign = HorizontalAlignment.Right;
            listview_sells.Columns[1].TextAlign = HorizontalAlignment.Center;
            listview_sells.Columns[2].TextAlign = HorizontalAlignment.Left;
            listview_sells.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview_sells.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listview_sells.EndUpdate();
            listview_sells.AllowSorting = true;
            #endregion

            #region ListView MetroListSellOrders

            SellsItemsOrder = new string[4];
            listview_sellOrders.BeginUpdate();
            listview_sellOrders.Items.Clear();
            listview_sellOrders.View = View.Details;
            listview_sellOrders.Columns.Add("Код");
            listview_sellOrders.Columns.Add("Назва");
            listview_sellOrders.Columns.Add("Ціна");
            listview_sellOrders.Columns[0].TextAlign = HorizontalAlignment.Right;
            listview_sellOrders.Columns[1].TextAlign = HorizontalAlignment.Center;
            listview_sellOrders.Columns[2].TextAlign = HorizontalAlignment.Left;
            listview_sellOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview_sellOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listview_sellOrders.EndUpdate();
            listview_sellOrders.AllowSorting = true;


            #endregion



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
        string[] SellsItemsOrder = new string[4];

        private void button_addOrder_Click(object sender, EventArgs e)
        {
            #region MetroListViews to List<Product>
            var a = listview_sells.SelectedItems;
            var code = a[0].Text;
            var selectedItem = db.Products.Where(q => q.Code == code).FirstOrDefault();
            product_SellItem.Add(selectedItem);
            #endregion

            InitialSellListView(product_SellItem);

            _cart.Add(selectedItem);
            textbox_summaryPrice.Text = _cart.Price + "";

        }

        private void InitialSellListView(List<Product> list)
        {
            listview_sellOrders.BeginUpdate();
            listview_sellOrders.Items.Clear();
            SellsItemsOrder = new string[4];

            ListViewItem listViewItemSells;
            foreach (var item in product_SellItem)
            {
                SellsItemsOrder[0] = item.Code;
                SellsItemsOrder[1] = item.Name;
                SellsItemsOrder[2] = item.Price.ToString();

                listViewItemSells = new ListViewItem(SellsItemsOrder);
                listview_sellOrders.Items.Add(listViewItemSells);
            }
            listview_sellOrders.EndUpdate();
            listview_sellOrders.AllowSorting = true;
        }



        // CashDesk _cashDesk = new CashDesk(db)
        // {
        //     IsModel = false
        // };
        // _cashDesk.AddCard(_cart);
        // _cashDesk.Sell(Status.Sells);
        // MessageBox.Show("Успішна покупка");
        // textbox_summaryPrice.Text = "0";
        // listview_sellOrders.Items.Clear();
        // _cart = new Cart();

        private void button_sellOrder_Click_1(object sender, EventArgs e)
        {
            CashDesk _cashDesk = new CashDesk(db)
            {
                IsModel = false
            };
            _cashDesk.AddCard(_cart);
            _cashDesk.Sell(Status.Sells);
            MessageBox.Show("Успішна покупка");
            textbox_summaryPrice.Text = "0";
            listview_sellOrders.Items.Clear();
            _cart = new Cart();

        }


        private void button_clearOrder_Click_1(object sender, EventArgs e)
        {
            textbox_summaryPrice.Text = "0";
            listview_sellOrders.Items.Clear();
        }
    }
}
