namespace Kasa
{
    partial class Multiple_Add_Product
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
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            scanner = new Button();
            import_excel = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column6, Column5, Column7, Column10, Column9, Column8, Column11 });
            dataGridView1.Location = new Point(23, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(971, 345);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Barkod";
            Column1.Name = "Column1";
            Column1.Width = 69;
            // 
            // Column2
            // 
            Column2.HeaderText = "Ürün Adı";
            Column2.Name = "Column2";
            Column2.Width = 73;
            // 
            // Column3
            // 
            Column3.HeaderText = "Ürün Cinsi";
            Column3.Name = "Column3";
            Column3.Width = 80;
            // 
            // Column4
            // 
            Column4.HeaderText = "Toptancı";
            Column4.Name = "Column4";
            Column4.Width = 77;
            // 
            // Column6
            // 
            Column6.HeaderText = "Adet";
            Column6.Name = "Column6";
            Column6.Width = 57;
            // 
            // Column5
            // 
            Column5.HeaderText = "Geliş Fiyatı";
            Column5.Name = "Column5";
            Column5.Width = 81;
            // 
            // Column7
            // 
            Column7.HeaderText = "Satış Fiyatı";
            Column7.Name = "Column7";
            Column7.Width = 80;
            // 
            // Column10
            // 
            Column10.HeaderText = "Stok Miktarı";
            Column10.Name = "Column10";
            Column10.Width = 88;
            // 
            // Column9
            // 
            Column9.HeaderText = "Önceki Fiyatı";
            Column9.Name = "Column9";
            Column9.Width = 92;
            // 
            // Column8
            // 
            Column8.HeaderText = "İndirimli Satış Fiyatı";
            Column8.Name = "Column8";
            Column8.Width = 97;
            // 
            // Column11
            // 
            Column11.HeaderText = "Tarih";
            Column11.Name = "Column11";
            Column11.Width = 57;
            // 
            // scanner
            // 
            scanner.Location = new Point(449, 15);
            scanner.Name = "scanner";
            scanner.Size = new Size(108, 33);
            scanner.TabIndex = 1;
            scanner.Text = "Tara";
            scanner.UseVisualStyleBackColor = true;
            scanner.Click += scanner_Click;
            // 
            // import_excel
            // 
            import_excel.Location = new Point(582, 15);
            import_excel.Name = "import_excel";
            import_excel.Size = new Size(108, 33);
            import_excel.TabIndex = 2;
            import_excel.Text = "İçeri Aktar";
            import_excel.UseVisualStyleBackColor = true;
            import_excel.Click += import_excel_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Multiple_Add_Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1068, 492);
            Controls.Add(import_excel);
            Controls.Add(scanner);
            Controls.Add(dataGridView1);
            Name = "Multiple_Add_Product";
            Text = "Multiple_Add_Product";
            Shown += Multiple_Add_Product_Shown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button scanner;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column11;
        private Button import_excel;
        private OpenFileDialog openFileDialog1;
    }
}