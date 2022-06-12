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
            listview_sells.GridLines = true;
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
            listview_sellOrders.Columns[0].TextAlign = HorizontalAlignment.Center;
            listview_sellOrders.Columns[1].TextAlign = HorizontalAlignment.Center;
            listview_sellOrders.Columns[2].TextAlign = HorizontalAlignment.Center;
            listview_sellOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview_sellOrders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listview_sellOrders.GridLines = true;
            listview_sellOrders.EndUpdate();
            listview_sellOrders.AllowSorting = true;


            #endregion

            #region MetroListWriteoffOrders

            SellsItems = new string[3];
            listview_writeoff.BeginUpdate();
            listview_writeoff.Items.Clear();
            listview_writeoff.View = View.Details;
            listview_writeoff.Columns.Add("Код");
            listview_writeoff.Columns.Add("Назва");
            listview_writeoff.Columns.Add("Ціна");
            listViewItemSells = new ListViewItem();
            foreach (var item in db.Products)
            {
                SellsItems[0] = item.Code;
                SellsItems[1] = item.Name;
                SellsItems[2] = item.Price.ToString();

                listViewItemSells = new ListViewItem(SellsItems);
                listview_writeoff.Items.Add(listViewItemSells);
            }

            listview_writeoff.Columns[0].TextAlign = HorizontalAlignment.Right;
            listview_writeoff.Columns[1].TextAlign = HorizontalAlignment.Center;
            listview_writeoff.Columns[2].TextAlign = HorizontalAlignment.Left;
            listview_writeoff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview_writeoff.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listview_writeoff.GridLines = true;
            listview_writeoff.EndUpdate();
            listview_writeoff.AllowSorting = true;
            #endregion

            #region MetroListCheckItem
            SellsItemsOrder = new string[4];
            listview_returnedChecks.BeginUpdate();
            listview_returnedChecks.Items.Clear();
            listview_returnedChecks.View = View.Details;
            listview_returnedChecks.Columns.Add("Код");
            listview_returnedChecks.Columns.Add("Назва");
            listview_returnedChecks.Columns.Add("Ціна");



            listViewItemSells = new ListViewItem();
            foreach (var item in db.Checks.Where(q => q.Status == Status.Sells))
            {
                SellsItems[0] = item.Id.ToString();
                SellsItems[1] = item.Price.ToString();

                listViewItemSells = new ListViewItem(SellsItems);
                listview_returnedChecks.Items.Add(listViewItemSells);
            }


            listview_returnedChecks.Columns[0].TextAlign = HorizontalAlignment.Center;
            listview_returnedChecks.Columns[1].TextAlign = HorizontalAlignment.Center;
            listview_returnedChecks.Columns[2].TextAlign = HorizontalAlignment.Center;
            listview_returnedChecks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview_returnedChecks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listview_returnedChecks.GridLines = true;
            listview_returnedChecks.EndUpdate();
            listview_returnedChecks.AllowSorting = true;
            #endregion

            #region MetroListReturnCheckItem
            SellsItemsOrder = new string[2];
            listview_checkItems.BeginUpdate();
            listview_checkItems.Items.Clear();
            listview_checkItems.View = View.Details;
            listview_checkItems.Columns.Add("Код");
            listview_checkItems.Columns.Add("Назва");
            listview_checkItems.Columns[0].TextAlign = HorizontalAlignment.Center;
            listview_checkItems.Columns[1].TextAlign = HorizontalAlignment.Center;
            listview_checkItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listview_checkItems.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listview_checkItems.GridLines = true;
            listview_checkItems.EndUpdate();
            listview_checkItems.AllowSorting = true;
            #endregion

        }
        

        Product selectedItem = null;
        
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
        
        
        private Check ItemReturn = null;
        
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

        private void button_clearOrder_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button_clearOrder_Click_1(object sender, EventArgs e)
        {
            textbox_summaryPrice.Text = "0";
            listview_sellOrders.Items.Clear();
        }

        private void listview_writeoff_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = listview_writeoff.FocusedItem;

            if (a != null)
            {
                var code = a.Text;
                var selectedItem = db.Products.Where(q => q.Code == code).FirstOrDefault();
                SelectedWriteOffListBox = selectedItem;

                label_infoWiteOff.Text = $"Назва товару: {SelectedWriteOffListBox.Name}\n" +
                                         $"Код товару: {SelectedWriteOffListBox.Code}\n" +
                                         $"Ціна товару: {SelectedWriteOffListBox.Price}\n" +
                                         $"Кількість товару: {SelectedWriteOffListBox.Count}";
            }
        }

        private void button_writteOffMetro_Click(object sender, EventArgs e)
        {
            #region MetroListViews to List<Product>
            //var a = listview_writeoff.SelectedItems;
            //var code = a[0].Text;
            //var selectedItem = db.Products.Where(q => q.Code == code).FirstOrDefault();
            //SelectedWriteOffListBox = selectedItem;
            #endregion

            if (SelectedWriteOffListBox != null)
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
            else
            {
                MessageBox.Show("Нічого не вибратороно");
            }
        }

        private void listview_sells_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void UpdateReturnedList()
        {
            var a = listview_returnedChecks.FocusedItem;
            SellsItems = new string[2];
            if (a != null)
            {
                listview_checkItems.BeginUpdate();
                listview_checkItems.Items.Clear();
                int code = Convert.ToInt32(a.Text);
                ItemReturn = db.Checks.Where(q => q.Id == code).FirstOrDefault();
                var result = from sell in db.Sells
                             join p in db.Products on sell.ProductId equals p.Id
                             join c in db.Checks on sell.CheckId equals c.Id
                             where
                                 c.Id == ItemReturn.Id && c.Status == Status.Sells
                             select new
                             {
                                 Name = p.Name,
                                 Price = p.Price,
                             };

                ListViewItem listViewItemSells;
                foreach (var item in result)
                {
                    SellsItems[0] = item.Name;
                    SellsItems[1] = item.Price.ToString();


                    listViewItemSells = new ListViewItem(SellsItems);
                    listview_checkItems.Items.Add(listViewItemSells);
                }
                listview_checkItems.EndUpdate();
            }
        }

        private void listview_returnedChecks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = listview_returnedChecks.FocusedItem;
            if (a != null)
            {
                int code = Convert.ToInt32(a.Text);
                ItemReturn = db.Checks.Where(q => q.Id == code).FirstOrDefault();
                UpdateReturnedList();
            }
        }

        private void button_returnAction_Click(object sender, EventArgs e)
        {
            CashDesk _cashDesk = new CashDesk(db)
            {
                IsModel = true
            };

            _cashDesk.Cart = new Cart();
            var sum = _cashDesk.ReturnProduct(ItemReturn);
            MessageBox.Show($"Покупку №{ItemReturn.Id} повернено на суму {sum}");
            UpdateReturnedList();
        }
    }
}
