using System.ComponentModel;

namespace CrmUI.Reporting
{
    partial class Reporting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textbox_findByCode = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_all = new MetroFramework.Controls.MetroRadioButton();
            this.button_day = new MetroFramework.Controls.MetroRadioButton();
            this.button_mounth = new MetroFramework.Controls.MetroRadioButton();
            this.button_year = new MetroFramework.Controls.MetroRadioButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroListView_Product = new MetroFramework.Controls.MetroListView();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroListView_Sell = new MetroFramework.Controls.MetroListView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroListView_WriteOff = new MetroFramework.Controls.MetroListView();
            this.metroPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.groupBox2);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.metroTabControl1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(1, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(963, 425);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textbox_findByCode);
            this.groupBox2.Location = new System.Drawing.Point(671, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 48);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Код товару";
            // 
            // textbox_findByCode
            // 
            // 
            // 
            // 
            this.textbox_findByCode.CustomButton.Image = null;
            this.textbox_findByCode.CustomButton.Location = new System.Drawing.Point(243, 1);
            this.textbox_findByCode.CustomButton.Name = "";
            this.textbox_findByCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textbox_findByCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_findByCode.CustomButton.TabIndex = 1;
            this.textbox_findByCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_findByCode.CustomButton.UseSelectable = true;
            this.textbox_findByCode.CustomButton.Visible = false;
            this.textbox_findByCode.Lines = new string[0];
            this.textbox_findByCode.Location = new System.Drawing.Point(6, 19);
            this.textbox_findByCode.MaxLength = 32767;
            this.textbox_findByCode.Name = "textbox_findByCode";
            this.textbox_findByCode.PasswordChar = '\0';
            this.textbox_findByCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_findByCode.SelectedText = "";
            this.textbox_findByCode.SelectionLength = 0;
            this.textbox_findByCode.SelectionStart = 0;
            this.textbox_findByCode.ShortcutsEnabled = true;
            this.textbox_findByCode.Size = new System.Drawing.Size(265, 23);
            this.textbox_findByCode.TabIndex = 4;
            this.textbox_findByCode.UseSelectable = true;
            this.textbox_findByCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_findByCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.textbox_findByCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_findByCode_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.button_all);
            this.groupBox1.Controls.Add(this.button_day);
            this.groupBox1.Controls.Add(this.button_mounth);
            this.groupBox1.Controls.Add(this.button_year);
            this.groupBox1.Location = new System.Drawing.Point(671, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дата";
            // 
            // button_all
            // 
            this.button_all.Checked = true;
            this.button_all.Location = new System.Drawing.Point(6, 111);
            this.button_all.Name = "button_all";
            this.button_all.Size = new System.Drawing.Size(104, 24);
            this.button_all.TabIndex = 3;
            this.button_all.TabStop = true;
            this.button_all.Tag = "All";
            this.button_all.Text = "Усі";
            this.button_all.UseSelectable = true;
            this.button_all.CheckedChanged += new System.EventHandler(this.button_all_CheckedChanged);
            // 
            // button_day
            // 
            this.button_day.Location = new System.Drawing.Point(6, 81);
            this.button_day.Name = "button_day";
            this.button_day.Size = new System.Drawing.Size(104, 24);
            this.button_day.TabIndex = 2;
            this.button_day.Tag = "Day";
            this.button_day.Text = "День";
            this.button_day.UseSelectable = true;
            this.button_day.CheckedChanged += new System.EventHandler(this.button_all_CheckedChanged);
            // 
            // button_mounth
            // 
            this.button_mounth.Location = new System.Drawing.Point(6, 51);
            this.button_mounth.Name = "button_mounth";
            this.button_mounth.Size = new System.Drawing.Size(104, 24);
            this.button_mounth.TabIndex = 1;
            this.button_mounth.Tag = "Mounth";
            this.button_mounth.Text = "Місяць";
            this.button_mounth.UseSelectable = true;
            this.button_mounth.CheckedChanged += new System.EventHandler(this.button_all_CheckedChanged);
            // 
            // button_year
            // 
            this.button_year.Location = new System.Drawing.Point(6, 21);
            this.button_year.Name = "button_year";
            this.button_year.Size = new System.Drawing.Size(104, 24);
            this.button_year.TabIndex = 0;
            this.button_year.Tag = "Year";
            this.button_year.Text = "Рік";
            this.button_year.UseSelectable = true;
            this.button_year.CheckedChanged += new System.EventHandler(this.button_all_CheckedChanged);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage5);
            this.metroTabControl1.Location = new System.Drawing.Point(13, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(652, 400);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroListView1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(644, 358);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Фінанси";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroListView1
            // 
            this.metroListView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(0, 0);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(641, 345);
            this.metroListView1.TabIndex = 2;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.SelectedIndexChanged += new System.EventHandler(this.metroListView1_SelectedIndexChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(644, 358);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Залишки";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroListView_Product);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 349);
            this.panel1.TabIndex = 2;
            // 
            // metroListView_Product
            // 
            this.metroListView_Product.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView_Product.FullRowSelect = true;
            this.metroListView_Product.Location = new System.Drawing.Point(3, 3);
            this.metroListView_Product.Name = "metroListView_Product";
            this.metroListView_Product.OwnerDraw = true;
            this.metroListView_Product.Size = new System.Drawing.Size(632, 339);
            this.metroListView_Product.TabIndex = 0;
            this.metroListView_Product.UseCompatibleStateImageBehavior = false;
            this.metroListView_Product.UseSelectable = true;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.panel2);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(644, 358);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Продано";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroListView_Sell);
            this.panel2.Location = new System.Drawing.Point(-4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 359);
            this.panel2.TabIndex = 2;
            // 
            // metroListView_Sell
            // 
            this.metroListView_Sell.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView_Sell.FullRowSelect = true;
            this.metroListView_Sell.Location = new System.Drawing.Point(7, 3);
            this.metroListView_Sell.Name = "metroListView_Sell";
            this.metroListView_Sell.OwnerDraw = true;
            this.metroListView_Sell.Size = new System.Drawing.Size(635, 349);
            this.metroListView_Sell.TabIndex = 0;
            this.metroListView_Sell.UseCompatibleStateImageBehavior = false;
            this.metroListView_Sell.UseSelectable = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.panel3);
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(644, 358);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Списано";
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroListView_WriteOff);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 352);
            this.panel3.TabIndex = 0;
            // 
            // metroListView_WriteOff
            // 
            this.metroListView_WriteOff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.metroListView_WriteOff.FullRowSelect = true;
            this.metroListView_WriteOff.Location = new System.Drawing.Point(3, 3);
            this.metroListView_WriteOff.Name = "metroListView_WriteOff";
            this.metroListView_WriteOff.OwnerDraw = true;
            this.metroListView_WriteOff.Size = new System.Drawing.Size(632, 346);
            this.metroListView_WriteOff.TabIndex = 0;
            this.metroListView_WriteOff.UseCompatibleStateImageBehavior = false;
            this.metroListView_WriteOff.UseSelectable = true;
            // 
            // Reporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 424);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Reporting";
            this.Text = "Reporting";
            this.metroPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroListView metroListView_WriteOff;

        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroListView metroListView_Sell;

        private MetroFramework.Controls.MetroListView metroListView_Product;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.GroupBox groupBox2;

        private MetroFramework.Controls.MetroRadioButton button_mounth;
        private MetroFramework.Controls.MetroRadioButton button_day;
        private MetroFramework.Controls.MetroRadioButton button_all;
        private MetroFramework.Controls.MetroTextBox textbox_findByCode;

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroRadioButton button_year;

        private System.Windows.Forms.TabPage tabPage5;

        private MetroFramework.Controls.MetroListView metroListView1;

        private MetroFramework.Controls.MetroTabPage metroTabPage3;

        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        #endregion
    }
}