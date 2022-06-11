using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CrmBL.model;

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
            
            //TestData(db);
            listBox1.DataSource = db.Products.ToList();
            listboxEdit.DataSource = db.Products.ToList();
            listboxEdit.DisplayMember = "Code";
            listBox1.ValueMember = "Code";
            listBox1.DisplayMember = "Name";
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void textBox_Find_KeyUp(object sender, KeyEventArgs e)
        {
            listBox1.DataSource = db.Products.Where(q => q.Name.Contains(((TextBox)sender).Text)).ToList();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if(selectedProduct != null) //TODO: ShowDialogResult
            {
                db.Products.Remove(selectedProduct);
                db.SaveChanges();
            }
            listBox1.DataSource = db.Products.ToList();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            //TODO:Проверка на пустые поля + валидация :)
            var name = textBox_Name.Text;
            var code = textBox_Code.Text;
            int count = Convert.ToInt32(textBox_Count.Text);
            double price = Convert.ToDouble(textBox_Price.Text);

            var result = db.Products.Where(q => q.Code == code || q.Name == name).Any();
            if (result)
                MessageBox.Show("Таке ім'я або код вже є");
            else
            {
                db.Products.Add(new Product { Code = code, Name = name, Price = price, Count = count });
                db.SaveChanges();
                MessageBox.Show($"Додано {code}-{name}-{price}-{count}");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)listBox1.SelectedItem;
            //listBox1.DataSource = db.Products.ToList();

            textBox_EditName.Text = selectedProduct.Name;
            textBox_EditCount.Text = selectedProduct.Count.ToString();
            textBox_EditCode.Text = selectedProduct.Code;
            textBox_EditPrice.Text = selectedProduct.Price.ToString(CultureInfo.InvariantCulture);
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
            int count = Convert.ToInt32(textBox_EditCount.Text);
            double price = Convert.ToDouble(textBox_EditPrice.Text);


            if (true) //TODO: Проверка на пустые поля потом
            {
                selectedProduct.Name = name;
                selectedProduct.Code = code;
                selectedProduct.Count = count;
                selectedProduct.Price = price;

                db.SaveChanges();
                MessageBox.Show($"Редаговано {name}-{code}-{count}-{price}");
            }
            


        }

        private void textBox_FindEdit_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void listboxEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedProduct = (Product)listboxEdit.SelectedItem;
            //listBox1.DataSource = db.Products.ToList();

            textBox_Delete_Name.Text = selectedProduct.Name;
            textBox_Delete_Count.Text = selectedProduct.Count.ToString();
            textBox_Delete_Code.Text = selectedProduct.Code;
            textBox_Delete_Price.Text = selectedProduct.Price.ToString(CultureInfo.InvariantCulture);
        }

        private void textBox_FindEdit_KeyUp(object sender, KeyEventArgs e)
        {
            listboxEdit.DataSource = db.Products.Where(q => q.Name.Contains(((TextBox)sender).Text)).ToList();
        }
    }
}