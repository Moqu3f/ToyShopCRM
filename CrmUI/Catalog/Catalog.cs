using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CrmBL.model;
using MetroFramework.Controls;

namespace CrmUI.Catalog
{
    public partial class Catalog : Form
    {
        private CrmContext db;
        private Cart _cart;
        private CashDesk _cashDesk;
        private Product selectedProduct;
        public Catalog(CrmContext db)
        {
            InitializeComponent();

            this.db = db;

            if (!db.Products.Any())
            {
                TestData(db);
            }
            
            UpdateCatalog();

        }

        private void UpdateCatalog()
        {
            listbox_delete.DataSource = db.Products.ToList();
            listbox_edit.DataSource = db.Products.ToList();

            listbox_edit.DisplayMember = "Name";
            listbox_delete.DisplayMember = "Name";

            listbox_delete.ValueMember = "Code";


        }

        private void textBox_Find_KeyUp(object sender, KeyEventArgs e)
        {
            listbox_delete.DataSource = db.Products.Where(q => q.Name.Contains(((TextBox)sender).Text)).ToList();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (selectedProduct == null)
            {
                MessageBox.Show("Товар не вибрано");
                return;
            }

            if (listbox_delete.Items.Count == 0)
            {
                clearAllTextBoxes();
                MessageBox.Show("Всі товари вже видалені");
                return;
            }


            if (MessageBox.Show("Ви впевнені, що хочете видалити товар?", "Підтверждення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.Products.Remove(selectedProduct);
                db.SaveChanges();
                UpdateCatalog();
                if (listbox_delete.Items.Count == 0) { clearAllTextBoxes(); }
            }
        }

        private void clearAllTextBoxes()
        {
            textBox_EditName.Clear();
            textBox_EditCount.Clear();
            textBox_EditCode.Clear();
            textBox_EditPrice.Clear();

            textBox_DeleteName.Clear();
            textBox_DeleteCount.Clear();
            textBox_DeleteCode.Clear();
            textBox_DeletePrice.Clear();
        }

        #region TestData

        private void TestData(CrmContext db)
        {
            var productList = new List<Product>
            {
                new Product() { Code = "AD5071", Count = 60, Name = "Кубик рубика", Price = 60 },
                new Product() { Code = "DJ2149", Count = 60, Name = "Поп-іт", Price = 150 },
                new Product() { Code = "GS9244", Count = 60, Name = "Тетріс", Price = 90 },
                new Product() { Code = "KD8901", Count = 60, Name = "Набор лего 1", Price = 100 },
                new Product() { Code = "VD4144", Count = 60, Name = "Набор лего 2", Price = 150 },
                new Product() { Code = "KP2000", Count = 60, Name = "Набор лего 3", Price = 180 },
                new Product() { Code = "QN1244", Count = 60, Name = "Набор лего 4", Price = 220 }
            };
            db.Products.AddRange(productList);
            //
            //
            //
            var card = new Cart();
            var card2 = new Cart();
            card.Add(productList[1]);
            card.Add(productList[2]);
            card.Add(productList[0]);
            card.Add(productList[0]);
            card.Add(productList[0]);
            card2.Add(productList[2]);
            card2.Add(productList[2]);
            card2.Add(productList[5]);
            card2.Add(productList[5]);
            card2.Add(productList[5]);
            CashDesk _cashDesk = new CashDesk(db)
            {
                IsModel = false
            };
            _cashDesk.AddCard(card);
            _cashDesk.Sell(Status.Sells);
            db.SaveChanges();

        }

        #endregion

        private void button_Edit_Click(object sender, EventArgs e)
        {
            var name = textBox_EditName.Text;
            var code = textBox_EditCode.Text;

            if (name == String.Empty)
            {
                MessageBox.Show("Поле код не заповнено");
                return;
            }

            if (code == String.Empty)
            {
                MessageBox.Show("Поле код не заповнено");
                return;
            }


            if (int.TryParse(textBox_EditCount.Text, out int count) == false)
            {
                MessageBox.Show("Поле кількість має невірний формат");
                return;
            }

            if (double.TryParse(textBox_EditPrice.Text, out double price) == false)
            {
                MessageBox.Show("Поле ціна має невірний формат");
                return;
            }

            if (selectedProduct == null)
            {
                MessageBox.Show("Товар для редагування не вибрано");
                return;
            }



            selectedProduct.Name = name;
            selectedProduct.Code = code;
            selectedProduct.Count = count;
            selectedProduct.Price = price;

            db.SaveChanges();
            UpdateCatalog();
            MessageBox.Show($"Товар {name} успішно відредагований");
        }

        private void listboxEdit_SeelectedIndexChanged(object snder, EventArgs e)
        {
            selectedProduct = (Product)listbox_edit.SelectedItem;
            //listBox1.DataSource = db.Products.ToList();

            textBox_EditName.Text = selectedProduct.Name;
            textBox_EditCount.Text = selectedProduct.Count.ToString();
            textBox_EditCode.Text = selectedProduct.Code;
            textBox_EditPrice.Text = selectedProduct.Price.ToString(CultureInfo.InvariantCulture);
        }

        private void textBox_FindEdit_KeyUp(object sender, KeyEventArgs e)
        {
            listbox_edit.DataSource = db.Products.Where(q => q.Name.Contains(((TextBox)sender).Text)).ToList();
        }

        private void listboxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)listbox_edit.SelectedItem;
            //listBox1.DataSource = db.Products.ToList();

            textBox_EditName.Text = selectedProduct.Name;
            textBox_EditCount.Text = selectedProduct.Count.ToString();
            textBox_EditCode.Text = selectedProduct.Code;
            textBox_EditPrice.Text = selectedProduct.Price.ToString(CultureInfo.InvariantCulture);
        }

        private void listboxDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)listbox_delete.SelectedItem;
            //listBox1.DataSource = db.Products.ToList();

            textBox_DeleteName.Text = selectedProduct.Name;
            textBox_DeleteCount.Text = selectedProduct.Count.ToString();
            textBox_DeleteCode.Text = selectedProduct.Code;
            textBox_DeletePrice.Text = selectedProduct.Price.ToString(CultureInfo.InvariantCulture);
        }

        private void button_addMetro_Click(object sender, EventArgs e)
        {
            //TODO:Проверка на пустые поля + валидация :)
            var name = textbox_nameMetro.Text;
            var code = textbox_codeMetro.Text;

            var result = db.Products.Where(q => q.Code == code || q.Name == name).Any();

            if (name == String.Empty)
            {
                MessageBox.Show("Поле назва товару не заповнено");
                return;
            }

            if (code == String.Empty)
            {
                MessageBox.Show("Поле код товару не заповнено");
                return;
            }

            if (int.TryParse(textbox_countMetro.Text, out int count) == false)
            {
                MessageBox.Show("Кількість товару має невірний формат");
                return;
            }

            if (double.TryParse(textbox_priceMetro.Text, out double price) == false)
            {
                MessageBox.Show("Ціна товару має невірний формат");
                return;
            }


            if (result)
            {
                MessageBox.Show("Таке ім'я або код вже є");
                return;
            }

            db.Products.Add(new Product { Code = code, Name = name, Price = price, Count = count });
            db.SaveChanges();
            UpdateCatalog();

            MessageBox.Show($"Товар {name} успішно доданий");
        }
    }
}