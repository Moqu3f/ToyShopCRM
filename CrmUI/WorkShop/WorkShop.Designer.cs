namespace CrmUI.WorkShop
{
    partial class WorkShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Sum = new System.Windows.Forms.TextBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button_Sell = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_Clear = new System.Windows.Forms.Button();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button_WriteOff = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.button_Return = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox_Sum);
            this.tabPage1.Controls.Add(this.listBox2);
            this.tabPage1.Controls.Add(this.button_Sell);
            this.tabPage1.Controls.Add(this.button_Add);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.button_Clear);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Продаж";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(290, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "До сплати";
            // 
            // textBox_Sum
            // 
            this.textBox_Sum.Location = new System.Drawing.Point(358, 283);
            this.textBox_Sum.Name = "textBox_Sum";
            this.textBox_Sum.Size = new System.Drawing.Size(184, 20);
            this.textBox_Sum.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(290, 7);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(476, 238);
            this.listBox2.TabIndex = 7;
            // 
            // button_Sell
            // 
            this.button_Sell.Location = new System.Drawing.Point(8, 317);
            this.button_Sell.Name = "button_Sell";
            this.button_Sell.Size = new System.Drawing.Size(761, 89);
            this.button_Sell.TabIndex = 6;
            this.button_Sell.Text = "Продати";
            this.button_Sell.UseVisualStyleBackColor = true;
            this.button_Sell.Click += new System.EventHandler(this.button_Sell_Click);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(8, 277);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(276, 31);
            this.button_Add.TabIndex = 4;
            this.button_Add.Text = "Додати у замовлення";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(8, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(276, 264);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(290, 251);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(480, 20);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Очистити";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // TabPage2
            // 
            this.TabPage2.Controls.Add(this.listBox3);
            this.TabPage2.Controls.Add(this.button_WriteOff);
            this.TabPage2.Location = new System.Drawing.Point(4, 22);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(780, 412);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "Списання";
            this.TabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(8, 6);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(274, 329);
            this.listBox3.TabIndex = 2;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // button_WriteOff
            // 
            this.button_WriteOff.Location = new System.Drawing.Point(8, 353);
            this.button_WriteOff.Name = "button_WriteOff";
            this.button_WriteOff.Size = new System.Drawing.Size(274, 53);
            this.button_WriteOff.TabIndex = 1;
            this.button_WriteOff.Text = "Списати";
            this.button_WriteOff.UseVisualStyleBackColor = true;
            this.button_WriteOff.Click += new System.EventHandler(this.button_WriteOff_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.listBox4);
            this.tabPage3.Controls.Add(this.button_Return);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(780, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Повернення";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 377);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(6, 16);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(206, 342);
            this.listBox4.TabIndex = 4;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.listBox4_SelectedIndexChanged);
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(219, 372);
            this.button_Return.Name = "button_Return";
            this.button_Return.Size = new System.Drawing.Size(538, 33);
            this.button_Return.TabIndex = 3;
            this.button_Return.Text = "Повернути";
            this.button_Return.UseVisualStyleBackColor = true;
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(219, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(538, 354);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 364);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // WorkShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "WorkShop";
            this.Text = "WorkShop";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.TabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.ListBox listBox4;

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Return;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.ListBox listBox3;

        private System.Windows.Forms.Button button_WriteOff;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox_Sum;

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TabPage2;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Sell;
        private System.Windows.Forms.ListBox listBox2;
    }
}