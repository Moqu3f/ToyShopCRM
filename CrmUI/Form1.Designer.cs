namespace CrmUI
{
    partial class Form1
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
            this.button_Catalog = new System.Windows.Forms.Button();
            this.button_WorkShop = new System.Windows.Forms.Button();
            this.button_Zvit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Catalog
            // 
            this.button_Catalog.Location = new System.Drawing.Point(12, 12);
            this.button_Catalog.Name = "button_Catalog";
            this.button_Catalog.Size = new System.Drawing.Size(230, 89);
            this.button_Catalog.TabIndex = 0;
            this.button_Catalog.Text = "Робота з каталогом";
            this.button_Catalog.UseVisualStyleBackColor = true;
            this.button_Catalog.Click += new System.EventHandler(this.button_Catalog_Click);
            // 
            // button_WorkShop
            // 
            this.button_WorkShop.Location = new System.Drawing.Point(12, 107);
            this.button_WorkShop.Name = "button_WorkShop";
            this.button_WorkShop.Size = new System.Drawing.Size(230, 89);
            this.button_WorkShop.TabIndex = 1;
            this.button_WorkShop.Text = "Робота магазину";
            this.button_WorkShop.UseVisualStyleBackColor = true;
            this.button_WorkShop.Click += new System.EventHandler(this.button_WorkShop_Click);
            // 
            // button_Zvit
            // 
            this.button_Zvit.Location = new System.Drawing.Point(13, 202);
            this.button_Zvit.Name = "button_Zvit";
            this.button_Zvit.Size = new System.Drawing.Size(229, 89);
            this.button_Zvit.TabIndex = 2;
            this.button_Zvit.Text = "Звітність";
            this.button_Zvit.UseVisualStyleBackColor = true;
            this.button_Zvit.Click += new System.EventHandler(this.button_Zvit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(249, 450);
            this.Controls.Add(this.button_Zvit);
            this.Controls.Add(this.button_WorkShop);
            this.Controls.Add(this.button_Catalog);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button_Zvit;

        private System.Windows.Forms.Button button_Catalog;

        #endregion

        private System.Windows.Forms.Button button_WorkShop;
    }
}