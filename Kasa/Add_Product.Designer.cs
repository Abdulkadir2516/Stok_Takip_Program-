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
            label1 = new Label();
            label2 = new Label();
            piece = new ComboBox();
            label3 = new Label();
            product_name = new TextBox();
            barcode = new TextBox();
            label4 = new Label();
            label5 = new Label();
            purchase_price = new TextBox();
            label6 = new Label();
            wholesaler = new ComboBox();
            product_type = new ComboBox();
            discount_price = new TextBox();
            label7 = new Label();
            label8 = new Label();
            sales_price = new TextBox();
            number = new TextBox();
            label9 = new Label();
            min_limit = new TextBox();
            label10 = new Label();
            update = new Button();
            insert = new Button();
            remove = new Button();
            clear = new Button();
            date = new TextBox();
            label11 = new Label();
            add_wholesaler = new Button();
            label12 = new Label();
            numericUpDown1 = new NumericUpDown();
            multiple_add = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(113, 60);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 21);
            label1.TabIndex = 0;
            label1.Text = "Birimi: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(91, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 1;
            label2.Text = "Ürün Adı: ";
            // 
            // piece
            // 
            piece.DropDownStyle = ComboBoxStyle.DropDownList;
            piece.ForeColor = SystemColors.WindowText;
            piece.Items.AddRange(new object[] { "AD", "KG", "GR", "BR", "PK" });
            piece.Location = new Point(181, 57);
            piece.Margin = new Padding(4);
            piece.Name = "piece";
            piece.Size = new Size(54, 29);
            piece.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(243, 60);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Barkodu: ";
            // 
            // product_name
            // 
            product_name.CharacterCasing = CharacterCasing.Upper;
            product_name.Location = new Point(181, 93);
            product_name.Name = "product_name";
            product_name.Size = new Size(317, 29);
            product_name.TabIndex = 1;
            product_name.KeyDown += product_name_KeyDown;
            // 
            // barcode
            // 
            barcode.Location = new Point(329, 57);
            barcode.Name = "barcode";
            barcode.Size = new Size(169, 29);
            barcode.TabIndex = 0;
            barcode.KeyDown += barcode_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(91, 131);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 6;
            label4.Text = "Toptancı: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(80, 166);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 21);
            label5.TabIndex = 8;
            label5.Text = "Ürün Cinsi: ";
            // 
            // purchase_price
            // 
            purchase_price.Location = new Point(181, 198);
            purchase_price.Name = "purchase_price";
            purchase_price.Size = new Size(109, 29);
            purchase_price.TabIndex = 4;
            purchase_price.KeyDown += purchase_price_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label6.Location = new Point(85, 201);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 10;
            label6.Text = "Alış Fiyatı: ";
            // 
            // wholesaler
            // 
            wholesaler.DropDownStyle = ComboBoxStyle.DropDownList;
            wholesaler.ForeColor = SystemColors.WindowText;
            wholesaler.Location = new Point(181, 129);
            wholesaler.Margin = new Padding(4);
            wholesaler.Name = "wholesaler";
            wholesaler.Size = new Size(317, 29);
            wholesaler.TabIndex = 2;
            wholesaler.KeyDown += wholesaler_KeyDown;
            // 
            // product_type
            // 
            product_type.DropDownStyle = ComboBoxStyle.DropDownList;
            product_type.ForeColor = SystemColors.WindowText;
            product_type.Location = new Point(181, 163);
            product_type.Margin = new Padding(4);
            product_type.Name = "product_type";
            product_type.Size = new Size(317, 29);
            product_type.TabIndex = 3;
            product_type.KeyDown += product_type_KeyDown;
            // 
            // discount_price
            // 
            discount_price.Location = new Point(181, 233);
            discount_price.Name = "discount_price";
            discount_price.Size = new Size(109, 29);
            discount_price.TabIndex = 6;
            discount_price.KeyDown += discount_price_KeyDown;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(54, 236);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(112, 21);
            label7.TabIndex = 14;
            label7.Text = "İndirimli Fiyat:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(297, 201);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(94, 21);
            label8.TabIndex = 16;
            label8.Text = "Satış Fiyatı: ";
            // 
            // sales_price
            // 
            sales_price.Location = new Point(389, 199);
            sales_price.Name = "sales_price";
            sales_price.Size = new Size(109, 29);
            sales_price.TabIndex = 5;
            sales_price.KeyDown += sales_price_KeyDown;
            // 
            // number
            // 
            number.Location = new Point(389, 269);
            number.Name = "number";
            number.Size = new Size(109, 29);
            number.TabIndex = 8;
            number.KeyDown += number_KeyDown;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(328, 269);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 20;
            label9.Text = "Adet: ";
            // 
            // min_limit
            // 
            min_limit.Location = new Point(181, 268);
            min_limit.Name = "min_limit";
            min_limit.Size = new Size(109, 29);
            min_limit.TabIndex = 7;
            min_limit.Text = "1";
            min_limit.KeyDown += min_limit_KeyDown;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label10.Location = new Point(91, 272);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(75, 21);
            label10.TabIndex = 18;
            label10.Text = "Alt Limit:";
            // 
            // update
            // 
            update.FlatStyle = FlatStyle.Popup;
            update.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            update.Image = (Image)resources.GetObject("update.Image");
            update.ImageAlign = ContentAlignment.MiddleLeft;
            update.Location = new Point(53, 306);
            update.Name = "update";
            update.Size = new Size(113, 56);
            update.TabIndex = 9;
            update.Text = "Güncelle";
            update.TextAlign = ContentAlignment.MiddleRight;
            update.UseVisualStyleBackColor = false;
            update.Click += update_Click;
            // 
            // insert
            // 
            insert.FlatStyle = FlatStyle.Popup;
            insert.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            insert.Image = (Image)resources.GetObject("insert.Image");
            insert.ImageAlign = ContentAlignment.MiddleLeft;
            insert.Location = new Point(410, 306);
            insert.Name = "insert";
            insert.Size = new Size(113, 56);
            insert.TabIndex = 12;
            insert.Text = "Ekle";
            insert.TextAlign = ContentAlignment.MiddleRight;
            insert.UseVisualStyleBackColor = false;
            insert.Click += insert_Click;
            // 
            // remove
            // 
            remove.FlatStyle = FlatStyle.Popup;
            remove.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            remove.Image = (Image)resources.GetObject("remove.Image");
            remove.ImageAlign = ContentAlignment.MiddleLeft;
            remove.Location = new Point(291, 306);
            remove.Name = "remove";
            remove.Size = new Size(113, 56);
            remove.TabIndex = 11;
            remove.Text = "Kaldır";
            remove.TextAlign = ContentAlignment.MiddleRight;
            remove.UseVisualStyleBackColor = false;
            remove.Click += remove_Click;
            // 
            // clear
            // 
            clear.FlatStyle = FlatStyle.Popup;
            clear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            clear.Image = (Image)resources.GetObject("clear.Image");
            clear.ImageAlign = ContentAlignment.MiddleLeft;
            clear.Location = new Point(172, 306);
            clear.Name = "clear";
            clear.Size = new Size(113, 56);
            clear.TabIndex = 10;
            clear.Text = "Temizle";
            clear.TextAlign = ContentAlignment.MiddleRight;
            clear.UseVisualStyleBackColor = false;
            clear.Click += clear_Click;
            // 
            // date
            // 
            date.Enabled = false;
            date.Location = new Point(389, 233);
            date.Name = "date";
            date.ReadOnly = true;
            date.Size = new Size(109, 29);
            date.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label11.Location = new Point(328, 236);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(52, 21);
            label11.TabIndex = 22;
            label11.Text = "Tarih: ";
            // 
            // add_wholesaler
            // 
            add_wholesaler.FlatStyle = FlatStyle.Popup;
            add_wholesaler.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            add_wholesaler.Image = (Image)resources.GetObject("add_wholesaler.Image");
            add_wholesaler.Location = new Point(505, 129);
            add_wholesaler.Name = "add_wholesaler";
            add_wholesaler.Size = new Size(66, 63);
            add_wholesaler.TabIndex = 23;
            add_wholesaler.TextAlign = ContentAlignment.MiddleRight;
            add_wholesaler.UseVisualStyleBackColor = false;
            add_wholesaler.Click += add_wholesaler_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label12.Location = new Point(504, 60);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(77, 21);
            label12.TabIndex = 25;
            label12.Text = "Kâr Oranı";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(504, 88);
            numericUpDown1.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(77, 29);
            numericUpDown1.TabIndex = 5;
            numericUpDown1.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // multiple_add
            // 
            multiple_add.FlatStyle = FlatStyle.Popup;
            multiple_add.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            multiple_add.Image = (Image)resources.GetObject("multiple_add.Image");
            multiple_add.ImageAlign = ContentAlignment.TopCenter;
            multiple_add.Location = new Point(504, 198);
            multiple_add.Name = "multiple_add";
            multiple_add.Size = new Size(108, 99);
            multiple_add.TabIndex = 26;
            multiple_add.Text = "Çoklu Ürün ekleme";
            multiple_add.TextAlign = ContentAlignment.BottomCenter;
            multiple_add.UseVisualStyleBackColor = false;
            multiple_add.Click += multiple_add_Click;
            // 
            // Add_Product
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(666, 409);
            Controls.Add(multiple_add);
            Controls.Add(numericUpDown1);
            Controls.Add(label12);
            Controls.Add(add_wholesaler);
            Controls.Add(date);
            Controls.Add(label11);
            Controls.Add(clear);
            Controls.Add(remove);
            Controls.Add(insert);
            Controls.Add(update);
            Controls.Add(number);
            Controls.Add(label9);
            Controls.Add(min_limit);
            Controls.Add(label10);
            Controls.Add(sales_price);
            Controls.Add(label8);
            Controls.Add(discount_price);
            Controls.Add(label7);
            Controls.Add(product_type);
            Controls.Add(wholesaler);
            Controls.Add(purchase_price);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(barcode);
            Controls.Add(product_name);
            Controls.Add(label3);
            Controls.Add(piece);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Add_Product";
            Text = "Add_Product";
            Shown += Add_Product_Shown;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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