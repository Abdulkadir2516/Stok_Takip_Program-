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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ana_Ekran));
            tabControl = new TabControl();
            contextMenuStrip1 = new ContextMenuStrip(components);
            change_price = new ToolStripMenuItem();
            sil = new ToolStripMenuItem();
            exceleAktarToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            tabPage4 = new TabPage();
            dataGridView4 = new DataGridView();
            tabPage5 = new TabPage();
            dataGridView5 = new DataGridView();
            panel1 = new Panel();
            learn_price = new Button();
            backup = new Button();
            sales_cancellation = new Button();
            button1 = new Button();
            stock = new Button();
            daily_sales = new Button();
            add_product = new Button();
            groupBox1 = new GroupBox();
            barcode = new TextBox();
            groupBox2 = new GroupBox();
            total = new TextBox();
            groupBox3 = new GroupBox();
            piece = new Label();
            amount = new Label();
            unit_cost = new Label();
            label3 = new Label();
            label55 = new Label();
            label4 = new Label();
            product_name = new Label();
            label1 = new Label();
            approve = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            dataGridView6 = new DataGridView();
            groupBox4 = new GroupBox();
            productName = new TextBox();
            tabControl.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.AllowDrop = true;
            tabControl.ContextMenuStrip = contextMenuStrip1;
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Controls.Add(tabPage4);
            tabControl.Controls.Add(tabPage5);
            tabControl.HotTrack = true;
            tabControl.Location = new Point(32, 306);
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1146, 312);
            tabControl.TabIndex = 11;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { change_price, sil, exceleAktarToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(185, 70);
            // 
            // change_price
            // 
            change_price.Name = "change_price";
            change_price.Size = new Size(184, 22);
            change_price.Text = "Ürün Fiyatını Değiştir";
            change_price.Click += change_price_Click;
            // 
            // sil
            // 
            sil.Name = "sil";
            sil.Size = new Size(184, 22);
            sil.Text = "Sil";
            sil.Click += sil_Click;
            // 
            // exceleAktarToolStripMenuItem
            // 
            exceleAktarToolStripMenuItem.Name = "exceleAktarToolStripMenuItem";
            exceleAktarToolStripMenuItem.Size = new Size(184, 22);
            exceleAktarToolStripMenuItem.Text = "Excel'e Aktar";
            exceleAktarToolStripMenuItem.Click += exceleAktarToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.AllowDrop = true;
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.ImeMode = ImeMode.On;
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1138, 284);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1. Satış";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1126, 272);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.AllowDrop = true;
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.ImeMode = ImeMode.On;
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1138, 284);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "2. Satış";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(6, 6);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(1126, 272);
            dataGridView2.StandardTab = true;
            dataGridView2.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.AllowDrop = true;
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.ImeMode = ImeMode.On;
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1138, 284);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "3. Satış";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.Size = new Size(1126, 272);
            dataGridView3.StandardTab = true;
            dataGridView3.TabIndex = 1;
            // 
            // tabPage4
            // 
            tabPage4.AllowDrop = true;
            tabPage4.Controls.Add(dataGridView4);
            tabPage4.ImeMode = ImeMode.On;
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1138, 284);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "4. Satış";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToAddRows = false;
            dataGridView4.AllowUserToDeleteRows = false;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(6, 6);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.Size = new Size(1126, 272);
            dataGridView4.StandardTab = true;
            dataGridView4.TabIndex = 1;
            // 
            // tabPage5
            // 
            tabPage5.AllowDrop = true;
            tabPage5.Controls.Add(dataGridView5);
            tabPage5.ImeMode = ImeMode.On;
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(1138, 284);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "5. Satış";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.AllowUserToAddRows = false;
            dataGridView5.AllowUserToDeleteRows = false;
            dataGridView5.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(6, 6);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView5.Size = new Size(1126, 272);
            dataGridView5.StandardTab = true;
            dataGridView5.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(learn_price);
            panel1.Controls.Add(backup);
            panel1.Controls.Add(sales_cancellation);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(stock);
            panel1.Controls.Add(daily_sales);
            panel1.Controls.Add(add_product);
            panel1.Location = new Point(32, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 64);
            panel1.TabIndex = 6;
            // 
            // learn_price
            // 
            learn_price.FlatStyle = FlatStyle.Popup;
            learn_price.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            learn_price.Image = (Image)resources.GetObject("learn_price.Image");
            learn_price.ImageAlign = ContentAlignment.MiddleLeft;
            learn_price.Location = new Point(819, 3);
            learn_price.Name = "learn_price";
            learn_price.Size = new Size(157, 56);
            learn_price.TabIndex = 13;
            learn_price.Text = "Fiyat Öğren";
            learn_price.TextAlign = ContentAlignment.MiddleRight;
            learn_price.UseVisualStyleBackColor = false;
            learn_price.Click += learn_price_Click;
            // 
            // backup
            // 
            backup.FlatStyle = FlatStyle.Popup;
            backup.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            backup.Image = (Image)resources.GetObject("backup.Image");
            backup.ImageAlign = ContentAlignment.MiddleLeft;
            backup.Location = new Point(982, 3);
            backup.Name = "backup";
            backup.Size = new Size(157, 56);
            backup.TabIndex = 12;
            backup.Text = "Yedek Al";
            backup.TextAlign = ContentAlignment.MiddleRight;
            backup.UseVisualStyleBackColor = false;
            backup.Click += backup_Click;
            // 
            // sales_cancellation
            // 
            sales_cancellation.FlatStyle = FlatStyle.Popup;
            sales_cancellation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            sales_cancellation.Image = (Image)resources.GetObject("sales_cancellation.Image");
            sales_cancellation.ImageAlign = ContentAlignment.MiddleLeft;
            sales_cancellation.Location = new Point(656, 3);
            sales_cancellation.Name = "sales_cancellation";
            sales_cancellation.Size = new Size(157, 56);
            sales_cancellation.TabIndex = 11;
            sales_cancellation.Text = "Satış İptali";
            sales_cancellation.TextAlign = ContentAlignment.MiddleRight;
            sales_cancellation.UseVisualStyleBackColor = false;
            sales_cancellation.Click += sales_cancellation_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(493, 3);
            button1.Name = "button1";
            button1.Size = new Size(157, 56);
            button1.TabIndex = 10;
            button1.Text = "Satış Durumu";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // stock
            // 
            stock.FlatStyle = FlatStyle.Popup;
            stock.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            stock.Image = (Image)resources.GetObject("stock.Image");
            stock.ImageAlign = ContentAlignment.MiddleLeft;
            stock.Location = new Point(330, 3);
            stock.Name = "stock";
            stock.Size = new Size(157, 56);
            stock.TabIndex = 9;
            stock.Text = "Stok Durumu";
            stock.TextAlign = ContentAlignment.MiddleRight;
            stock.UseVisualStyleBackColor = false;
            stock.Click += stock_Click;
            // 
            // daily_sales
            // 
            daily_sales.FlatStyle = FlatStyle.Popup;
            daily_sales.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            daily_sales.Image = (Image)resources.GetObject("daily_sales.Image");
            daily_sales.ImageAlign = ContentAlignment.MiddleLeft;
            daily_sales.Location = new Point(167, 3);
            daily_sales.Name = "daily_sales";
            daily_sales.Size = new Size(157, 56);
            daily_sales.TabIndex = 8;
            daily_sales.Text = "Günlük Ciro";
            daily_sales.TextAlign = ContentAlignment.MiddleRight;
            daily_sales.UseVisualStyleBackColor = false;
            daily_sales.Click += daily_sales_Click;
            // 
            // add_product
            // 
            add_product.FlatStyle = FlatStyle.Popup;
            add_product.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            add_product.Image = (Image)resources.GetObject("add_product.Image");
            add_product.ImageAlign = ContentAlignment.MiddleLeft;
            add_product.Location = new Point(4, 3);
            add_product.Name = "add_product";
            add_product.Size = new Size(157, 56);
            add_product.TabIndex = 7;
            add_product.Text = "Ürün Ekleme";
            add_product.TextAlign = ContentAlignment.MiddleRight;
            add_product.UseVisualStyleBackColor = false;
            add_product.Click += add_product_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(barcode);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(32, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 76);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Barkodu Okutunuz..";
            // 
            // barcode
            // 
            barcode.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            barcode.Location = new Point(6, 28);
            barcode.Name = "barcode";
            barcode.Size = new Size(312, 34);
            barcode.TabIndex = 8;
            barcode.KeyDown += barcode_KeyDown;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(total);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(32, 184);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(324, 105);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Toplam Nakit Tutarı";
            // 
            // total
            // 
            total.Font = new Font("Segoe UI Semibold", 28F, FontStyle.Bold);
            total.Location = new Point(6, 33);
            total.Name = "total";
            total.Size = new Size(312, 57);
            total.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(piece);
            groupBox3.Controls.Add(amount);
            groupBox3.Controls.Add(unit_cost);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label55);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(product_name);
            groupBox3.Controls.Add(label1);
            groupBox3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox3.Location = new Point(374, 89);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(804, 200);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ürün Bilgileri";
            // 
            // piece
            // 
            piece.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            piece.Location = new Point(149, 108);
            piece.Name = "piece";
            piece.Size = new Size(648, 37);
            piece.TabIndex = 0;
            piece.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // amount
            // 
            amount.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            amount.Location = new Point(149, 145);
            amount.Name = "amount";
            amount.Size = new Size(648, 37);
            amount.TabIndex = 12;
            amount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // unit_cost
            // 
            unit_cost.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            unit_cost.Location = new Point(149, 69);
            unit_cost.Name = "unit_cost";
            unit_cost.Size = new Size(648, 37);
            unit_cost.TabIndex = 12;
            unit_cost.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label3.Location = new Point(76, 145);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 0;
            label3.Text = "Tutar:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label55.Location = new Point(74, 108);
            label55.Name = "label55";
            label55.Size = new Size(65, 28);
            label55.TabIndex = 0;
            label55.Text = "Adeti:";
            label55.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label4.Location = new Point(22, 69);
            label4.Name = "label4";
            label4.Size = new Size(117, 28);
            label4.TabIndex = 0;
            label4.Text = "Birim Fiyatı:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // product_name
            // 
            product_name.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            product_name.Location = new Point(149, 28);
            product_name.Name = "product_name";
            product_name.Size = new Size(648, 37);
            product_name.TabIndex = 11;
            product_name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            label1.Location = new Point(41, 28);
            label1.Name = "label1";
            label1.Size = new Size(98, 28);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // approve
            // 
            approve.FlatStyle = FlatStyle.Popup;
            approve.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            approve.Image = (Image)resources.GetObject("approve.Image");
            approve.ImageAlign = ContentAlignment.MiddleLeft;
            approve.Location = new Point(32, 624);
            approve.Name = "approve";
            approve.Size = new Size(149, 53);
            approve.TabIndex = 12;
            approve.Text = "Onayla (F7)";
            approve.TextAlign = ContentAlignment.MiddleRight;
            approve.UseVisualStyleBackColor = false;
            approve.Click += approve_Click;
            // 
            // dataGridView6
            // 
            dataGridView6.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView6.Location = new Point(1203, 148);
            dataGridView6.Name = "dataGridView6";
            dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView6.Size = new Size(509, 466);
            dataGridView6.TabIndex = 13;
            dataGridView6.CellContentClick += dataGridView6_CellContentClick;
            dataGridView6.KeyDown += dataGridView6_KeyDown;
            dataGridView6.MouseDoubleClick += dataGridView6_MouseDoubleClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(productName);
            groupBox4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            groupBox4.Location = new Point(1203, 66);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 76);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Ürün Adı Giriniz:";
            // 
            // productName
            // 
            productName.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            productName.Location = new Point(6, 28);
            productName.Name = "productName";
            productName.Size = new Size(312, 34);
            productName.TabIndex = 8;
            productName.TextChanged += productName_TextChanged;
            // 
            // Ana_Ekran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            CausesValidation = false;
            ClientSize = new Size(1737, 681);
            Controls.Add(groupBox4);
            Controls.Add(dataGridView6);
            Controls.Add(approve);
            Controls.Add(tabControl);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Ana_Ekran";
            Text = "Ana Ekran";
            WindowState = FormWindowState.Maximized;
            Shown += Ana_Ekran_Shown;
            KeyDown += Ana_Ekran_KeyDown;
            tabControl.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView6).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
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
        private DataGridView dataGridView6;
        private GroupBox groupBox4;
        private TextBox productName;
    }
}