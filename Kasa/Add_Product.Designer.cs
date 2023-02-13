namespace Kasa
{
    partial class Add_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Product));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.piece = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.product_name = new System.Windows.Forms.TextBox();
            this.barcode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.purchase_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.wholesaler = new System.Windows.Forms.ComboBox();
            this.product_type = new System.Windows.Forms.ComboBox();
            this.discount_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sales_price = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.min_limit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.add_wholesaler = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.multiple_add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Birimi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(91, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adı: ";
            // 
            // piece
            // 
            this.piece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.piece.ForeColor = System.Drawing.SystemColors.WindowText;
            this.piece.Items.AddRange(new object[] {
            "AD",
            "KG",
            "GR",
            "BR",
            "PK"});
            this.piece.Location = new System.Drawing.Point(181, 57);
            this.piece.Margin = new System.Windows.Forms.Padding(4);
            this.piece.Name = "piece";
            this.piece.Size = new System.Drawing.Size(54, 29);
            this.piece.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(243, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Barkodu: ";
            // 
            // product_name
            // 
            this.product_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.product_name.Location = new System.Drawing.Point(181, 93);
            this.product_name.Name = "product_name";
            this.product_name.Size = new System.Drawing.Size(317, 29);
            this.product_name.TabIndex = 1;
            this.product_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.product_name_KeyDown);
            // 
            // barcode
            // 
            this.barcode.Location = new System.Drawing.Point(329, 57);
            this.barcode.Name = "barcode";
            this.barcode.Size = new System.Drawing.Size(169, 29);
            this.barcode.TabIndex = 0;
            this.barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(91, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toptancı: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(80, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ürün Cinsi: ";
            // 
            // purchase_price
            // 
            this.purchase_price.Location = new System.Drawing.Point(181, 198);
            this.purchase_price.Name = "purchase_price";
            this.purchase_price.Size = new System.Drawing.Size(109, 29);
            this.purchase_price.TabIndex = 4;
            this.purchase_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.purchase_price_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(85, 201);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alış Fiyatı: ";
            // 
            // wholesaler
            // 
            this.wholesaler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wholesaler.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wholesaler.Location = new System.Drawing.Point(181, 129);
            this.wholesaler.Margin = new System.Windows.Forms.Padding(4);
            this.wholesaler.Name = "wholesaler";
            this.wholesaler.Size = new System.Drawing.Size(317, 29);
            this.wholesaler.TabIndex = 2;
            this.wholesaler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.wholesaler_KeyDown);
            // 
            // product_type
            // 
            this.product_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_type.ForeColor = System.Drawing.SystemColors.WindowText;
            this.product_type.Location = new System.Drawing.Point(181, 163);
            this.product_type.Margin = new System.Windows.Forms.Padding(4);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(317, 29);
            this.product_type.TabIndex = 3;
            this.product_type.KeyDown += new System.Windows.Forms.KeyEventHandler(this.product_type_KeyDown);
            // 
            // discount_price
            // 
            this.discount_price.Location = new System.Drawing.Point(181, 233);
            this.discount_price.Name = "discount_price";
            this.discount_price.Size = new System.Drawing.Size(109, 29);
            this.discount_price.TabIndex = 6;
            this.discount_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discount_price_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(54, 236);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "İndirimli Fiyat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(297, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "Satış Fiyatı: ";
            // 
            // sales_price
            // 
            this.sales_price.Location = new System.Drawing.Point(389, 199);
            this.sales_price.Name = "sales_price";
            this.sales_price.Size = new System.Drawing.Size(109, 29);
            this.sales_price.TabIndex = 5;
            this.sales_price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sales_price_KeyDown);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(389, 269);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(109, 29);
            this.number.TabIndex = 8;
            this.number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.number_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(328, 269);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Adet: ";
            // 
            // min_limit
            // 
            this.min_limit.Location = new System.Drawing.Point(181, 268);
            this.min_limit.Name = "min_limit";
            this.min_limit.Size = new System.Drawing.Size(109, 29);
            this.min_limit.TabIndex = 7;
            this.min_limit.Text = "1";
            this.min_limit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.min_limit_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(91, 272);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 21);
            this.label10.TabIndex = 18;
            this.label10.Text = "Alt Limit:";
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.update.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.update.Image = ((System.Drawing.Image)(resources.GetObject("update.Image")));
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(53, 306);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(113, 56);
            this.update.TabIndex = 9;
            this.update.Text = "Güncelle";
            this.update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // insert
            // 
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insert.Location = new System.Drawing.Point(410, 306);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(113, 56);
            this.insert.TabIndex = 12;
            this.insert.Text = "Ekle";
            this.insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // remove
            // 
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove.Image = ((System.Drawing.Image)(resources.GetObject("remove.Image")));
            this.remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove.Location = new System.Drawing.Point(291, 306);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(113, 56);
            this.remove.TabIndex = 11;
            this.remove.Text = "Kaldır";
            this.remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // clear
            // 
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear.Location = new System.Drawing.Point(172, 306);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(113, 56);
            this.clear.TabIndex = 10;
            this.clear.Text = "Temizle";
            this.clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(389, 233);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(109, 29);
            this.date.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(328, 236);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Tarih: ";
            // 
            // add_wholesaler
            // 
            this.add_wholesaler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_wholesaler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_wholesaler.Image = ((System.Drawing.Image)(resources.GetObject("add_wholesaler.Image")));
            this.add_wholesaler.Location = new System.Drawing.Point(505, 129);
            this.add_wholesaler.Name = "add_wholesaler";
            this.add_wholesaler.Size = new System.Drawing.Size(66, 63);
            this.add_wholesaler.TabIndex = 23;
            this.add_wholesaler.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_wholesaler.UseVisualStyleBackColor = false;
            this.add_wholesaler.Click += new System.EventHandler(this.add_wholesaler_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(504, 60);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 25;
            this.label12.Text = "Kâr Oranı";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(504, 88);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 29);
            this.numericUpDown1.TabIndex = 5;
            // 
            // multiple_add
            // 
            this.multiple_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiple_add.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.multiple_add.Image = ((System.Drawing.Image)(resources.GetObject("multiple_add.Image")));
            this.multiple_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.multiple_add.Location = new System.Drawing.Point(504, 198);
            this.multiple_add.Name = "multiple_add";
            this.multiple_add.Size = new System.Drawing.Size(108, 99);
            this.multiple_add.TabIndex = 26;
            this.multiple_add.Text = "Çoklu Ürün ekleme";
            this.multiple_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiple_add.UseVisualStyleBackColor = false;
            this.multiple_add.Click += new System.EventHandler(this.multiple_add_Click);
            // 
            // Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(666, 409);
            this.Controls.Add(this.multiple_add);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.add_wholesaler);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.update);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.min_limit);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sales_price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.discount_price);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.product_type);
            this.Controls.Add(this.wholesaler);
            this.Controls.Add(this.purchase_price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.barcode);
            this.Controls.Add(this.product_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.piece);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Product";
            this.Text = "Add_Product";
            this.Shown += new System.EventHandler(this.Add_Product_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox piece;
        private Label label3;
        private TextBox product_name;
        private TextBox barcode;
        private Label label4;
        private Label label5;
        private TextBox purchase_price;
        private Label label6;
        private ComboBox wholesaler;
        private ComboBox product_type;
        private TextBox discount_price;
        private Label label7;
        private Label label8;
        private TextBox sales_price;
        private TextBox number;
        private Label label9;
        private TextBox min_limit;
        private Label label10;
        private Button update;
        private Button insert;
        private Button remove;
        private Button clear;
        private TextBox date;
        private Label label11;
        private Button add_wholesaler;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private Button multiple_add;
    }
}