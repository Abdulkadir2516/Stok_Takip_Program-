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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scanner = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7,
            this.Column10,
            this.Column9,
            this.Column8,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(23, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(971, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // scanner
            // 
            this.scanner.Location = new System.Drawing.Point(449, 15);
            this.scanner.Name = "scanner";
            this.scanner.Size = new System.Drawing.Size(108, 33);
            this.scanner.TabIndex = 1;
            this.scanner.Text = "Tara";
            this.scanner.UseVisualStyleBackColor = true;
            this.scanner.Click += new System.EventHandler(this.scanner_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Barkod";
            this.Column1.Name = "Column1";
            this.Column1.Width = 69;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ürün Adı";
            this.Column2.Name = "Column2";
            this.Column2.Width = 79;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ürün Cinsi";
            this.Column3.Name = "Column3";
            this.Column3.Width = 87;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Toptancı";
            this.Column4.Name = "Column4";
            this.Column4.Width = 77;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Adet";
            this.Column6.Name = "Column6";
            this.Column6.Width = 57;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Geliş Fiyatı";
            this.Column5.Name = "Column5";
            this.Column5.Width = 88;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Satış Fiyatı";
            this.Column7.Name = "Column7";
            this.Column7.Width = 87;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Stok Miktarı";
            this.Column10.Name = "Column10";
            this.Column10.Width = 95;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Önceki Fiyatı";
            this.Column9.Name = "Column9";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "İndirimli Satış Fiyatı";
            this.Column8.Name = "Column8";
            this.Column8.Width = 97;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Tarih";
            this.Column11.Name = "Column11";
            this.Column11.Width = 57;
            // 
            // Multiple_Add_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1068, 492);
            this.Controls.Add(this.scanner);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Multiple_Add_Product";
            this.Text = "Multiple_Add_Product";
            this.Shown += new System.EventHandler(this.Multiple_Add_Product_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
    }
}