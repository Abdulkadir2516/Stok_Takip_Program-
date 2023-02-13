namespace Kasa
{
    partial class Ana_Ekran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Ekran));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.change_price = new System.Windows.Forms.ToolStripMenuItem();
            this.sil = new System.Windows.Forms.ToolStripMenuItem();
            this.exceleAktarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.learn_price = new System.Windows.Forms.Button();
            this.backup = new System.Windows.Forms.Button();
            this.sales_cancellation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.Button();
            this.daily_sales = new System.Windows.Forms.Button();
            this.add_product = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barcode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.piece = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.Label();
            this.unit_cost = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.approve = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.ContextMenuStrip = this.contextMenuStrip1;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.HotTrack = true;
            this.tabControl.Location = new System.Drawing.Point(32, 306);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1146, 312);
            this.tabControl.TabIndex = 11;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.change_price,
            this.sil,
            this.exceleAktarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 70);
            // 
            // change_price
            // 
            this.change_price.Name = "change_price";
            this.change_price.Size = new System.Drawing.Size(184, 22);
            this.change_price.Text = "Ürün Fiyatını Değiştir";
            this.change_price.Click += new System.EventHandler(this.change_price_Click);
            // 
            // sil
            // 
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(184, 22);
            this.sil.Text = "Sil";
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // exceleAktarToolStripMenuItem
            // 
            this.exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            this.exceleAktarToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exceleAktarToolStripMenuItem.Text = "Excel\'e Aktar";
            this.exceleAktarToolStripMenuItem.Click += new System.EventHandler(this.exceleAktarToolStripMenuItem_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1138, 284);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1. Satış";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1126, 272);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AllowDrop = true;
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1138, 284);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2. Satış";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1126, 272);
            this.dataGridView2.StandardTab = true;
            this.dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.AllowDrop = true;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1138, 284);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3. Satış";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(1126, 272);
            this.dataGridView3.StandardTab = true;
            this.dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.AllowDrop = true;
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1138, 284);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4. Satış";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(6, 6);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(1126, 272);
            this.dataGridView4.StandardTab = true;
            this.dataGridView4.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.AllowDrop = true;
            this.tabPage5.Controls.Add(this.dataGridView5);
            this.tabPage5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1138, 284);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "5. Satış";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 6);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowTemplate.Height = 25;
            this.dataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView5.Size = new System.Drawing.Size(1126, 272);
            this.dataGridView5.StandardTab = true;
            this.dataGridView5.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.learn_price);
            this.panel1.Controls.Add(this.backup);
            this.panel1.Controls.Add(this.sales_cancellation);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.stock);
            this.panel1.Controls.Add(this.daily_sales);
            this.panel1.Controls.Add(this.add_product);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 64);
            this.panel1.TabIndex = 6;
            // 
            // learn_price
            // 
            this.learn_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.learn_price.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.learn_price.Image = ((System.Drawing.Image)(resources.GetObject("learn_price.Image")));
            this.learn_price.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.learn_price.Location = new System.Drawing.Point(819, 3);
            this.learn_price.Name = "learn_price";
            this.learn_price.Size = new System.Drawing.Size(157, 56);
            this.learn_price.TabIndex = 13;
            this.learn_price.Text = "Fiyat Öğren";
            this.learn_price.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.learn_price.UseVisualStyleBackColor = false;
            this.learn_price.Click += new System.EventHandler(this.learn_price_Click);
            // 
            // backup
            // 
            this.backup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backup.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backup.Image = ((System.Drawing.Image)(resources.GetObject("backup.Image")));
            this.backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backup.Location = new System.Drawing.Point(982, 3);
            this.backup.Name = "backup";
            this.backup.Size = new System.Drawing.Size(157, 56);
            this.backup.TabIndex = 12;
            this.backup.Text = "Yedek Al";
            this.backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.backup.UseVisualStyleBackColor = false;
            this.backup.Click += new System.EventHandler(this.backup_Click);
            // 
            // sales_cancellation
            // 
            this.sales_cancellation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sales_cancellation.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sales_cancellation.Image = ((System.Drawing.Image)(resources.GetObject("sales_cancellation.Image")));
            this.sales_cancellation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sales_cancellation.Location = new System.Drawing.Point(656, 3);
            this.sales_cancellation.Name = "sales_cancellation";
            this.sales_cancellation.Size = new System.Drawing.Size(157, 56);
            this.sales_cancellation.TabIndex = 11;
            this.sales_cancellation.Text = "Satış İptali";
            this.sales_cancellation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sales_cancellation.UseVisualStyleBackColor = false;
            this.sales_cancellation.Click += new System.EventHandler(this.sales_cancellation_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(493, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Satış Durumu";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // stock
            // 
            this.stock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.stock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stock.Image = ((System.Drawing.Image)(resources.GetObject("stock.Image")));
            this.stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stock.Location = new System.Drawing.Point(330, 3);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(157, 56);
            this.stock.TabIndex = 9;
            this.stock.Text = "Stok Durumu";
            this.stock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.stock.UseVisualStyleBackColor = false;
            this.stock.Click += new System.EventHandler(this.stock_Click);
            // 
            // daily_sales
            // 
            this.daily_sales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.daily_sales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.daily_sales.Image = ((System.Drawing.Image)(resources.GetObject("daily_sales.Image")));
            this.daily_sales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.daily_sales.Location = new System.Drawing.Point(167, 3);
            this.daily_sales.Name = "daily_sales";
            this.daily_sales.Size = new System.Drawing.Size(157, 56);
            this.daily_sales.TabIndex = 8;
            this.daily_sales.Text = "Günlük Ciro";
            this.daily_sales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.daily_sales.UseVisualStyleBackColor = false;
            this.daily_sales.Click += new System.EventHandler(this.daily_sales_Click);
            // 
            // add_product
            // 
            this.add_product.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_product.Image = ((System.Drawing.Image)(resources.GetObject("add_product.Image")));
            this.add_product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_product.Location = new System.Drawing.Point(4, 3);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(157, 56);
            this.add_product.TabIndex = 7;
            this.add_product.Text = "Ürün Ekleme";
            this.add_product.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_product.UseVisualStyleBackColor = false;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.barcode);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(32, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 76);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkodu Okutunuz..";
            // 
            // barcode
            // 
            this.barcode.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.barcode.Location = new System.Drawing.Point(6, 28);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(312, 34);
            this.barcode.TabIndex = 8;
            this.barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.total);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(32, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(324, 105);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam Nakit Tutarı";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total.Location = new System.Drawing.Point(6, 33);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(312, 57);
            this.total.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.piece);
            this.groupBox3.Controls.Add(this.amount);
            this.groupBox3.Controls.Add(this.unit_cost);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label55);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.product_name);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(374, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 200);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Bilgileri";
            // 
            // piece
            // 
            this.piece.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.piece.Location = new System.Drawing.Point(149, 108);
            this.piece.Name = "piece";
            this.piece.Size = new System.Drawing.Size(648, 37);
            this.piece.TabIndex = 0;
            this.piece.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amount
            // 
            this.amount.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amount.Location = new System.Drawing.Point(149, 145);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(648, 37);
            this.amount.TabIndex = 12;
            this.amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unit_cost
            // 
            this.unit_cost.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.unit_cost.Location = new System.Drawing.Point(149, 69);
            this.unit_cost.Name = "unit_cost";
            this.unit_cost.Size = new System.Drawing.Size(648, 37);
            this.unit_cost.TabIndex = 12;
            this.unit_cost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(76, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tutar:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label55.Location = new System.Drawing.Point(74, 108);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 28);
            this.label55.TabIndex = 0;
            this.label55.Text = "Adeti:";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(22, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Birim Fiyatı:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // product_name
            // 
            this.product_name.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.product_name.Location = new System.Drawing.Point(149, 28);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(648, 37);
            this.product_name.TabIndex = 11;
            this.product_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // approve
            // 
            this.approve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.approve.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.approve.Image = ((System.Drawing.Image)(resources.GetObject("approve.Image")));
            this.approve.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.approve.Location = new System.Drawing.Point(32, 624);
            this.approve.Name = "approve";
            this.approve.Size = new System.Drawing.Size(149, 53);
            this.approve.TabIndex = 12;
            this.approve.Text = "Onayla (F7)";
            this.approve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.approve.UseVisualStyleBackColor = false;
            this.approve.Click += new System.EventHandler(this.approve_Click);
            // 
            // Ana_Ekran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1213, 681);
            this.Controls.Add(this.approve);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Ana_Ekran";
            this.Text = "Ana Ekran";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Ana_Ekran_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ana_Ekran_KeyDown);
            this.tabControl.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button add_product;
        private Button daily_sales;
        private GroupBox groupBox1;
        private TextBox barcode;
        private GroupBox groupBox2;
        private TextBox total;
        private GroupBox groupBox3;
        private Label label3;
        private Label label4;
        private Label label1;
        private Label product_name;
        private Label amount;
        private Label unit_cost;
        private Label piece;
        private Label label55;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button stock;
        private TabControl tabControl;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private DataGridView dataGridView5;
        private Button approve;
        private Button button1;
        private Button sales_cancellation;
        private Button backup;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button learn_price;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem change_price;
        private ToolStripMenuItem sil;
        private ToolStripMenuItem exceleAktarToolStripMenuItem;
    }
}