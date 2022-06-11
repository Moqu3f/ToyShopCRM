﻿using System.ComponentModel;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView_Finance = new System.Windows.Forms.ListView();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_LeftOvers = new System.Windows.Forms.TabPage();
            this.tabPage_Sell = new System.Windows.Forms.TabPage();
            this.tabPage_WriteOff = new System.Windows.Forms.TabPage();
            this.tabPage_Finance = new System.Windows.Forms.TabPage();
            this.metroListView1 = new MetroFramework.Controls.MetroListView();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage_Finance.SuspendLayout();
            this.SuspendLayout();
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(15, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 335);
            this.tabControl1.TabIndex = 0;
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(931, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Залишки";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.listView1.Location = new System.Drawing.Point(6, 67);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(908, 222);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(931, 309);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Продано";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(931, 309);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Списано";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage1.Controls.Add(this.listView_Finance);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(931, 309);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Фінанси";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.listView_Finance.Location = new System.Drawing.Point(6, 34);
            this.listView_Finance.Name = "listView_Finance";
            this.listView_Finance.Size = new System.Drawing.Size(754, 222);
            this.listView_Finance.TabIndex = 0;
            this.listView_Finance.UseCompatibleStateImageBehavior = false;
            this.metroTabControl1.Controls.Add(this.tabPage_LeftOvers);
            this.metroTabControl1.Controls.Add(this.tabPage_Sell);
            this.metroTabControl1.Controls.Add(this.tabPage_WriteOff);
            this.metroTabControl1.Controls.Add(this.tabPage_Finance);
            this.metroTabControl1.Location = new System.Drawing.Point(19, 366);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 3;
            this.metroTabControl1.Size = new System.Drawing.Size(951, 315);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            this.tabPage_LeftOvers.Location = new System.Drawing.Point(4, 38);
            this.tabPage_LeftOvers.Name = "tabPage_LeftOvers";
            this.tabPage_LeftOvers.Size = new System.Drawing.Size(943, 273);
            this.tabPage_LeftOvers.TabIndex = 0;
            this.tabPage_LeftOvers.Text = "Залишки";
            this.tabPage_Sell.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Sell.Name = "tabPage_Sell";
            this.tabPage_Sell.Size = new System.Drawing.Size(943, 273);
            this.tabPage_Sell.TabIndex = 1;
            this.tabPage_Sell.Text = "Продано";
            this.tabPage_WriteOff.Location = new System.Drawing.Point(4, 38);
            this.tabPage_WriteOff.Name = "tabPage_WriteOff";
            this.tabPage_WriteOff.Size = new System.Drawing.Size(943, 273);
            this.tabPage_WriteOff.TabIndex = 2;
            this.tabPage_WriteOff.Text = "Списано";
            this.tabPage_Finance.Controls.Add(this.metroListView1);
            this.tabPage_Finance.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Finance.Name = "tabPage_Finance";
            this.tabPage_Finance.Size = new System.Drawing.Size(943, 273);
            this.tabPage_Finance.TabIndex = 3;
            this.tabPage_Finance.Text = "Фінанси";
            this.metroListView1.FullRowSelect = true;
            this.metroListView1.Location = new System.Drawing.Point(3, 3);
            this.metroListView1.Name = "metroListView1";
            this.metroListView1.OwnerDraw = true;
            this.metroListView1.Size = new System.Drawing.Size(937, 267);
            this.metroListView1.Style = MetroFramework.MetroColorStyle.Default;
            this.metroListView1.TabIndex = 1;
            this.metroListView1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroListView1.UseCompatibleStateImageBehavior = false;
            this.metroListView1.UseSelectable = true;
            this.metroListView1.View = System.Windows.Forms.View.List;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 693);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Reporting";
            this.Text = "Reporting";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage_Finance.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabPage tabPage_LeftOvers;
        private System.Windows.Forms.TabPage tabPage_Sell;
        private System.Windows.Forms.TabPage tabPage_WriteOff;
        private System.Windows.Forms.TabPage tabPage_Finance;
        private MetroFramework.Controls.MetroListView metroListView1;

        private MetroFramework.Controls.MetroTabControl metroTabControl1;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView_Finance;

        private System.Windows.Forms.ListView listView1;

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion
    }
}