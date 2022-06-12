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
            this.components = new System.ComponentModel.Container();
            MetroFramework.Controls.MetroButton button_catalog;
            MetroFramework.Controls.MetroButton button_store;
            MetroFramework.Controls.MetroButton button_report;
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            button_catalog = new MetroFramework.Controls.MetroButton();
            button_store = new MetroFramework.Controls.MetroButton();
            button_report = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_catalog
            // 
            button_catalog.BackColor = System.Drawing.SystemColors.Control;
            button_catalog.Cursor = System.Windows.Forms.Cursors.Hand;
            button_catalog.FontSize = MetroFramework.MetroButtonSize.Tall;
            button_catalog.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            button_catalog.Location = new System.Drawing.Point(135, 81);
            button_catalog.Name = "button_catalog";
            button_catalog.Size = new System.Drawing.Size(436, 75);
            button_catalog.Style = MetroFramework.MetroColorStyle.White;
            button_catalog.TabIndex = 3;
            button_catalog.TabStop = false;
            button_catalog.Text = "Робота з каталогом";
            button_catalog.Theme = MetroFramework.MetroThemeStyle.Light;
            button_catalog.UseSelectable = true;
            button_catalog.Click += new System.EventHandler(this.button_Catalog_Click);
            // 
            // button_store
            // 
            button_store.Cursor = System.Windows.Forms.Cursors.Hand;
            button_store.FontSize = MetroFramework.MetroButtonSize.Tall;
            button_store.Location = new System.Drawing.Point(135, 180);
            button_store.Name = "button_store";
            button_store.Size = new System.Drawing.Size(436, 84);
            button_store.Style = MetroFramework.MetroColorStyle.Blue;
            button_store.TabIndex = 4;
            button_store.TabStop = false;
            button_store.Text = "Робота магазину";
            button_store.Theme = MetroFramework.MetroThemeStyle.Light;
            button_store.UseSelectable = true;
            button_store.Click += new System.EventHandler(this.button_WorkShop_Click);
            // 
            // button_report
            // 
            button_report.Cursor = System.Windows.Forms.Cursors.Hand;
            button_report.FontSize = MetroFramework.MetroButtonSize.Tall;
            button_report.Location = new System.Drawing.Point(135, 290);
            button_report.Name = "button_report";
            button_report.Size = new System.Drawing.Size(436, 81);
            button_report.Style = MetroFramework.MetroColorStyle.Blue;
            button_report.TabIndex = 5;
            button_report.TabStop = false;
            button_report.Text = "Звітність";
            button_report.Theme = MetroFramework.MetroThemeStyle.Light;
            button_report.UseSelectable = true;
            button_report.Click += new System.EventHandler(this.button_Zvit_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::CrmUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 496);
            this.Controls.Add(button_report);
            this.Controls.Add(button_store);
            this.Controls.Add(button_catalog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Магазин іграшок";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        private MetroFramework.Components.MetroStyleManager metroStyleManager1;

        #endregion
    }
}