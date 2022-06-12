using System.ComponentModel;

namespace CrmUI.Catalog
{
    partial class Catalog
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
            this.button_addMetro = new MetroFramework.Controls.MetroButton();
            this.textbox_countMetro = new MetroFramework.Controls.MetroTextBox();
            this.textbox_priceMetro = new MetroFramework.Controls.MetroTextBox();
            this.textbox_nameMetro = new MetroFramework.Controls.MetroTextBox();
            this.textbox_codeMetro = new MetroFramework.Controls.MetroTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_DeleteCount = new System.Windows.Forms.TextBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_DeletePrice = new System.Windows.Forms.TextBox();
            this.textBox_DeleteCode = new System.Windows.Forms.TextBox();
            this.textBox_DeleteName = new System.Windows.Forms.TextBox();
            this.textBox_FindDelete = new System.Windows.Forms.TextBox();
            this.listbox_delete = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_EditCount = new System.Windows.Forms.TextBox();
            this.button_Edit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_EditPrice = new System.Windows.Forms.TextBox();
            this.textBox_EditCode = new System.Windows.Forms.TextBox();
            this.textBox_EditName = new System.Windows.Forms.TextBox();
            this.textBox_FindEdit = new System.Windows.Forms.TextBox();
            this.listbox_edit = new System.Windows.Forms.ListBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroTabControl1.SuspendLayout();
            this.tabPage9.SuspendLayout();
            this.tabPage10.SuspendLayout();
            this.tabPage11.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_addMetro
            // 
            this.button_addMetro.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.button_addMetro.Location = new System.Drawing.Point(10, 229);
            this.button_addMetro.Name = "button_addMetro";
            this.button_addMetro.Size = new System.Drawing.Size(163, 35);
            this.button_addMetro.TabIndex = 7;
            this.button_addMetro.Text = "Додати товар";
            this.button_addMetro.UseSelectable = true;
            this.button_addMetro.Click += new System.EventHandler(this.button_addMetro_Click);
            // 
            // textbox_countMetro
            // 
            // 
            // 
            // 
            this.textbox_countMetro.CustomButton.Image = null;
            this.textbox_countMetro.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.textbox_countMetro.CustomButton.Name = "";
            this.textbox_countMetro.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textbox_countMetro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_countMetro.CustomButton.TabIndex = 1;
            this.textbox_countMetro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_countMetro.CustomButton.UseSelectable = true;
            this.textbox_countMetro.CustomButton.Visible = false;
            this.textbox_countMetro.Lines = new string[] {
        "1"};
            this.textbox_countMetro.Location = new System.Drawing.Point(10, 198);
            this.textbox_countMetro.MaxLength = 32767;
            this.textbox_countMetro.Name = "textbox_countMetro";
            this.textbox_countMetro.PasswordChar = '\0';
            this.textbox_countMetro.PromptText = "Кількість товару";
            this.textbox_countMetro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_countMetro.SelectedText = "";
            this.textbox_countMetro.SelectionLength = 0;
            this.textbox_countMetro.SelectionStart = 0;
            this.textbox_countMetro.ShortcutsEnabled = true;
            this.textbox_countMetro.Size = new System.Drawing.Size(163, 25);
            this.textbox_countMetro.TabIndex = 6;
            this.textbox_countMetro.Text = "1";
            this.textbox_countMetro.UseSelectable = true;
            this.textbox_countMetro.WaterMark = "Кількість товару";
            this.textbox_countMetro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_countMetro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_priceMetro
            // 
            // 
            // 
            // 
            this.textbox_priceMetro.CustomButton.Image = null;
            this.textbox_priceMetro.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.textbox_priceMetro.CustomButton.Name = "";
            this.textbox_priceMetro.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textbox_priceMetro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_priceMetro.CustomButton.TabIndex = 1;
            this.textbox_priceMetro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_priceMetro.CustomButton.UseSelectable = true;
            this.textbox_priceMetro.CustomButton.Visible = false;
            this.textbox_priceMetro.Lines = new string[] {
        "0"};
            this.textbox_priceMetro.Location = new System.Drawing.Point(10, 144);
            this.textbox_priceMetro.MaxLength = 32767;
            this.textbox_priceMetro.Name = "textbox_priceMetro";
            this.textbox_priceMetro.PasswordChar = '\0';
            this.textbox_priceMetro.PromptText = "Ціна товару";
            this.textbox_priceMetro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_priceMetro.SelectedText = "";
            this.textbox_priceMetro.SelectionLength = 0;
            this.textbox_priceMetro.SelectionStart = 0;
            this.textbox_priceMetro.ShortcutsEnabled = true;
            this.textbox_priceMetro.Size = new System.Drawing.Size(163, 25);
            this.textbox_priceMetro.TabIndex = 5;
            this.textbox_priceMetro.Text = "0";
            this.textbox_priceMetro.UseSelectable = true;
            this.textbox_priceMetro.WaterMark = "Ціна товару";
            this.textbox_priceMetro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_priceMetro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_nameMetro
            // 
            // 
            // 
            // 
            this.textbox_nameMetro.CustomButton.Image = null;
            this.textbox_nameMetro.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.textbox_nameMetro.CustomButton.Name = "";
            this.textbox_nameMetro.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textbox_nameMetro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_nameMetro.CustomButton.TabIndex = 1;
            this.textbox_nameMetro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_nameMetro.CustomButton.UseSelectable = true;
            this.textbox_nameMetro.CustomButton.Visible = false;
            this.textbox_nameMetro.Lines = new string[0];
            this.textbox_nameMetro.Location = new System.Drawing.Point(10, 90);
            this.textbox_nameMetro.MaxLength = 32767;
            this.textbox_nameMetro.Name = "textbox_nameMetro";
            this.textbox_nameMetro.PasswordChar = '\0';
            this.textbox_nameMetro.PromptText = "Назва товару";
            this.textbox_nameMetro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_nameMetro.SelectedText = "";
            this.textbox_nameMetro.SelectionLength = 0;
            this.textbox_nameMetro.SelectionStart = 0;
            this.textbox_nameMetro.ShortcutsEnabled = true;
            this.textbox_nameMetro.Size = new System.Drawing.Size(163, 25);
            this.textbox_nameMetro.TabIndex = 4;
            this.textbox_nameMetro.UseSelectable = true;
            this.textbox_nameMetro.WaterMark = "Назва товару";
            this.textbox_nameMetro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_nameMetro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // textbox_codeMetro
            // 
            // 
            // 
            // 
            this.textbox_codeMetro.CustomButton.Image = null;
            this.textbox_codeMetro.CustomButton.Location = new System.Drawing.Point(139, 1);
            this.textbox_codeMetro.CustomButton.Name = "";
            this.textbox_codeMetro.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.textbox_codeMetro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textbox_codeMetro.CustomButton.TabIndex = 1;
            this.textbox_codeMetro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textbox_codeMetro.CustomButton.UseSelectable = true;
            this.textbox_codeMetro.CustomButton.Visible = false;
            this.textbox_codeMetro.Lines = new string[0];
            this.textbox_codeMetro.Location = new System.Drawing.Point(10, 37);
            this.textbox_codeMetro.MaxLength = 32767;
            this.textbox_codeMetro.Name = "textbox_codeMetro";
            this.textbox_codeMetro.PasswordChar = '\0';
            this.textbox_codeMetro.PromptText = "Код товару";
            this.textbox_codeMetro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textbox_codeMetro.SelectedText = "";
            this.textbox_codeMetro.SelectionLength = 0;
            this.textbox_codeMetro.SelectionStart = 0;
            this.textbox_codeMetro.ShortcutsEnabled = true;
            this.textbox_codeMetro.Size = new System.Drawing.Size(163, 25);
            this.textbox_codeMetro.TabIndex = 3;
            this.textbox_codeMetro.UseSelectable = true;
            this.textbox_codeMetro.WaterMark = "Код товару";
            this.textbox_codeMetro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textbox_codeMetro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "Кількість товару";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ціна товару";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва товару";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Код товару";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(269, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Кількість товару";
            // 
            // textBox_DeleteCount
            // 
            this.textBox_DeleteCount.Enabled = false;
            this.textBox_DeleteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DeleteCount.Location = new System.Drawing.Point(269, 235);
            this.textBox_DeleteCount.Name = "textBox_DeleteCount";
            this.textBox_DeleteCount.Size = new System.Drawing.Size(189, 26);
            this.textBox_DeleteCount.TabIndex = 10;
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(269, 271);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(180, 67);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Видалити";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(269, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ціна товару";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(269, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Назва товару";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(269, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Код товару";
            // 
            // textBox_DeletePrice
            // 
            this.textBox_DeletePrice.Enabled = false;
            this.textBox_DeletePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DeletePrice.Location = new System.Drawing.Point(269, 169);
            this.textBox_DeletePrice.Name = "textBox_DeletePrice";
            this.textBox_DeletePrice.Size = new System.Drawing.Size(189, 26);
            this.textBox_DeletePrice.TabIndex = 3;
            // 
            // textBox_DeleteCode
            // 
            this.textBox_DeleteCode.Enabled = false;
            this.textBox_DeleteCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DeleteCode.Location = new System.Drawing.Point(269, 50);
            this.textBox_DeleteCode.Name = "textBox_DeleteCode";
            this.textBox_DeleteCode.Size = new System.Drawing.Size(189, 26);
            this.textBox_DeleteCode.TabIndex = 4;
            // 
            // textBox_DeleteName
            // 
            this.textBox_DeleteName.Enabled = false;
            this.textBox_DeleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_DeleteName.Location = new System.Drawing.Point(269, 105);
            this.textBox_DeleteName.Name = "textBox_DeleteName";
            this.textBox_DeleteName.Size = new System.Drawing.Size(189, 26);
            this.textBox_DeleteName.TabIndex = 5;
            // 
            // textBox_FindDelete
            // 
            this.textBox_FindDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FindDelete.Location = new System.Drawing.Point(3, 343);
            this.textBox_FindDelete.Name = "textBox_FindDelete";
            this.textBox_FindDelete.Size = new System.Drawing.Size(260, 29);
            this.textBox_FindDelete.TabIndex = 1;
            this.textBox_FindDelete.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Find_KeyUp);
            // 
            // listbox_delete
            // 
            this.listbox_delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listbox_delete.FormattingEnabled = true;
            this.listbox_delete.Location = new System.Drawing.Point(3, 23);
            this.listbox_delete.Name = "listbox_delete";
            this.listbox_delete.Size = new System.Drawing.Size(260, 314);
            this.listbox_delete.TabIndex = 0;
            this.listbox_delete.SelectedIndexChanged += new System.EventHandler(this.listboxDelete_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(269, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "Кількість товару";
            // 
            // textBox_EditCount
            // 
            this.textBox_EditCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EditCount.Location = new System.Drawing.Point(269, 235);
            this.textBox_EditCount.Name = "textBox_EditCount";
            this.textBox_EditCount.Size = new System.Drawing.Size(189, 26);
            this.textBox_EditCount.TabIndex = 21;
            this.textBox_EditCount.Tag = "edited";
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(269, 271);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(180, 67);
            this.button_Edit.TabIndex = 20;
            this.button_Edit.Text = "Редагувати";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(269, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Ціна товару";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(269, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 23);
            this.label11.TabIndex = 19;
            this.label11.Text = "Назва товару";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(269, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 17;
            this.label12.Text = "Код товару";
            // 
            // textBox_EditPrice
            // 
            this.textBox_EditPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EditPrice.Location = new System.Drawing.Point(269, 169);
            this.textBox_EditPrice.Name = "textBox_EditPrice";
            this.textBox_EditPrice.Size = new System.Drawing.Size(189, 26);
            this.textBox_EditPrice.TabIndex = 14;
            this.textBox_EditPrice.Tag = "edited";
            // 
            // textBox_EditCode
            // 
            this.textBox_EditCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EditCode.Location = new System.Drawing.Point(269, 50);
            this.textBox_EditCode.Name = "textBox_EditCode";
            this.textBox_EditCode.Size = new System.Drawing.Size(189, 26);
            this.textBox_EditCode.TabIndex = 15;
            this.textBox_EditCode.Tag = "edited";
            // 
            // textBox_EditName
            // 
            this.textBox_EditName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_EditName.Location = new System.Drawing.Point(269, 105);
            this.textBox_EditName.Name = "textBox_EditName";
            this.textBox_EditName.Size = new System.Drawing.Size(189, 26);
            this.textBox_EditName.TabIndex = 16;
            this.textBox_EditName.Tag = "edited";
            // 
            // textBox_FindEdit
            // 
            this.textBox_FindEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FindEdit.Location = new System.Drawing.Point(3, 348);
            this.textBox_FindEdit.Name = "textBox_FindEdit";
            this.textBox_FindEdit.Size = new System.Drawing.Size(260, 29);
            this.textBox_FindEdit.TabIndex = 13;
            this.textBox_FindEdit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FindEdit_KeyUp);
            // 
            // listbox_edit
            // 
            this.listbox_edit.FormattingEnabled = true;
            this.listbox_edit.Location = new System.Drawing.Point(3, 22);
            this.listbox_edit.Name = "listbox_edit";
            this.listbox_edit.Size = new System.Drawing.Size(260, 316);
            this.listbox_edit.TabIndex = 12;
            this.listbox_edit.SelectedIndexChanged += new System.EventHandler(this.listboxEdit_SelectedIndexChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(95, 19);
            this.metroLabel1.TabIndex = 23;
            this.metroLabel1.Text = "Назви товарів";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 1);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 19);
            this.metroLabel2.TabIndex = 24;
            this.metroLabel2.Text = "Назви товарів";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage9);
            this.metroTabControl1.Controls.Add(this.tabPage10);
            this.metroTabControl1.Controls.Add(this.tabPage11);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(756, 435);
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.metroPanel1);
            this.tabPage9.Location = new System.Drawing.Point(4, 38);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(748, 383);
            this.tabPage9.TabIndex = 0;
            this.tabPage9.Text = "Додавання товару";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.metroPanel2);
            this.tabPage10.Location = new System.Drawing.Point(4, 38);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(748, 393);
            this.tabPage10.TabIndex = 1;
            this.tabPage10.Text = "Видалення товару";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.metroPanel3);
            this.tabPage11.Location = new System.Drawing.Point(4, 38);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(748, 393);
            this.tabPage11.TabIndex = 2;
            this.tabPage11.Text = "Редагування товару";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.button_addMetro);
            this.metroPanel1.Controls.Add(this.textbox_priceMetro);
            this.metroPanel1.Controls.Add(this.textbox_countMetro);
            this.metroPanel1.Controls.Add(this.label7);
            this.metroPanel1.Controls.Add(this.textbox_nameMetro);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.textbox_codeMetro);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.label3);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 6);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(742, 342);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.textBox_DeleteCount);
            this.metroPanel2.Controls.Add(this.label8);
            this.metroPanel2.Controls.Add(this.listbox_delete);
            this.metroPanel2.Controls.Add(this.button_Delete);
            this.metroPanel2.Controls.Add(this.textBox_FindDelete);
            this.metroPanel2.Controls.Add(this.label4);
            this.metroPanel2.Controls.Add(this.textBox_DeleteName);
            this.metroPanel2.Controls.Add(this.label5);
            this.metroPanel2.Controls.Add(this.textBox_DeleteCode);
            this.metroPanel2.Controls.Add(this.label6);
            this.metroPanel2.Controls.Add(this.textBox_DeletePrice);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(3, 9);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(742, 388);
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.label9);
            this.metroPanel3.Controls.Add(this.button_Edit);
            this.metroPanel3.Controls.Add(this.textBox_EditCount);
            this.metroPanel3.Controls.Add(this.listbox_edit);
            this.metroPanel3.Controls.Add(this.label10);
            this.metroPanel3.Controls.Add(this.textBox_FindEdit);
            this.metroPanel3.Controls.Add(this.label11);
            this.metroPanel3.Controls.Add(this.textBox_EditName);
            this.metroPanel3.Controls.Add(this.label12);
            this.metroPanel3.Controls.Add(this.textBox_EditCode);
            this.metroPanel3.Controls.Add(this.textBox_EditPrice);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(3, 10);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(742, 383);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 476);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Catalog";
            this.Text = "Catalog";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage9.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            this.tabPage11.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_EditCount;
        private System.Windows.Forms.Button button_Edit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_EditPrice;
        private System.Windows.Forms.TextBox textBox_EditCode;
        private System.Windows.Forms.TextBox textBox_EditName;
        private System.Windows.Forms.TextBox textBox_FindEdit;
        private System.Windows.Forms.ListBox listbox_edit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_DeleteCount;

        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_DeletePrice;
        private System.Windows.Forms.TextBox textBox_DeleteCode;
        private System.Windows.Forms.TextBox textBox_DeleteName;

        private System.Windows.Forms.ListBox listbox_delete;
        private System.Windows.Forms.TextBox textBox_FindDelete;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        #endregion

        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private MetroFramework.Controls.MetroTextBox textbox_priceMetro;
        private MetroFramework.Controls.MetroTextBox textbox_nameMetro;
        private MetroFramework.Controls.MetroTextBox textbox_codeMetro;
        private MetroFramework.Controls.MetroTextBox textbox_countMetro;
        private MetroFramework.Controls.MetroButton button_addMetro;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
    }
}