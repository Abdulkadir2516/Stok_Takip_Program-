namespace Kasa
{
    partial class Stock_Durumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Durumu));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.find_barcode = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.find_product = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.product_type = new System.Windows.Forms.ComboBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.supplier = new System.Windows.Forms.ComboBox();
            this.clear = new System.Windows.Forms.Label();
            this.filter = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1354, 491);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stok Tablosu";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1333, 457);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.find_barcode);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(25, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 56);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkod Ara";
            // 
            // find_barcode
            // 
            this.find_barcode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.find_barcode.Location = new System.Drawing.Point(6, 21);
            this.find_barcode.Name = "find_barcode";
            this.find_barcode.Size = new System.Drawing.Size(231, 29);
            this.find_barcode.TabIndex = 0;
            this.find_barcode.TextChanged += new System.EventHandler(this.find_barcode_TextChanged);
            this.find_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.find_barcode_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.find_product);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(274, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 56);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ürün Ara";
            // 
            // find_product
            // 
            this.find_product.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.find_product.Location = new System.Drawing.Point(6, 21);
            this.find_product.Name = "find_product";
            this.find_product.Size = new System.Drawing.Size(231, 29);
            this.find_product.TabIndex = 0;
            this.find_product.TextChanged += new System.EventHandler(this.find_product_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(25, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 56);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Toplam Ürün Adeti";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(231, 29);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(274, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 56);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Toplam Alış Fiyatı";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(6, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(231, 29);
            this.textBox2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox3);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox6.Location = new System.Drawing.Point(523, 82);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 56);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Toplam Satış Fiyatı";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(6, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(231, 29);
            this.textBox3.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox4);
            this.groupBox7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox7.Location = new System.Drawing.Point(772, 82);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(243, 56);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Toplam Kâr";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(6, 21);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(231, 29);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.product_type);
            this.groupBox8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox8.Location = new System.Drawing.Point(523, 20);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(243, 56);
            this.groupBox8.TabIndex = 13;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Ürün Cinsi";
            // 
            // product_type
            // 
            this.product_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_type.FormattingEnabled = true;
            this.product_type.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.product_type.Location = new System.Drawing.Point(6, 20);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(231, 29);
            this.product_type.Sorted = true;
            this.product_type.TabIndex = 0;
            this.product_type.SelectedIndexChanged += new System.EventHandler(this.product_type_SelectedIndexChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.supplier);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox9.Location = new System.Drawing.Point(772, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(243, 56);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tedarikçi";
            // 
            // supplier
            // 
            this.supplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplier.FormattingEnabled = true;
            this.supplier.Location = new System.Drawing.Point(6, 20);
            this.supplier.Name = "supplier";
            this.supplier.Size = new System.Drawing.Size(231, 29);
            this.supplier.TabIndex = 0;
            this.supplier.SelectedIndexChanged += new System.EventHandler(this.supplier_SelectedIndexChanged);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear.Location = new System.Drawing.Point(1020, 33);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(104, 37);
            this.clear.TabIndex = 16;
            this.clear.Text = "Temizle";
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.filter.Image = ((System.Drawing.Image)(resources.GetObject("filter.Image")));
            this.filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filter.Location = new System.Drawing.Point(1130, 35);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(104, 37);
            this.filter.TabIndex = 17;
            this.filter.Text = "Filtrele";
            this.filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sum.Image = ((System.Drawing.Image)(resources.GetObject("sum.Image")));
            this.sum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sum.Location = new System.Drawing.Point(1020, 95);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(104, 37);
            this.sum.TabIndex = 18;
            this.sum.Text = "Topla";
            this.sum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(1130, 94);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(104, 37);
            this.refresh.TabIndex = 19;
            this.refresh.Text = "Yenile";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(1240, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 96);
            this.label1.TabIndex = 20;
            this.label1.Text = "Excel\'e Aktar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Stock_Durumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1370, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Stock_Durumu";
            this.Text = "Stock_Durumu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Stock_Durumu_Load);
            this.Shown += new System.EventHandler(this.Stock_Durumu_Shown);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private TextBox find_barcode;
        private GroupBox groupBox3;
        private TextBox find_product;
        private GroupBox groupBox4;
        private TextBox textBox1;
        private GroupBox groupBox5;
        private TextBox textBox2;
        private GroupBox groupBox6;
        private TextBox textBox3;
        private GroupBox groupBox7;
        private TextBox textBox4;
        private GroupBox groupBox8;
        private ComboBox product_type;
        private GroupBox groupBox9;
        private ComboBox supplier;
        private Label clear;
        private Label filter;
        private Label sum;
        private Label refresh;
        private DataGridView dataGridView2;
        private Label label1;
    }
}