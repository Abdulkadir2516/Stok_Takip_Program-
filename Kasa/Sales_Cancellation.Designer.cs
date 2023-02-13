namespace Kasa
{
    partial class Sales_Cancellation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales_Cancellation));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.barcode = new System.Windows.Forms.TextBox();
            this.refresh = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.barcode);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 76);
            this.groupBox1.TabIndex = 8;
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
            this.barcode.TextChanged += new System.EventHandler(this.barcode_TextChanged);
            this.barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.barcode_KeyDown);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refresh.Location = new System.Drawing.Point(598, 41);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(104, 37);
            this.refresh.TabIndex = 38;
            this.refresh.Text = "Yenile";
            this.refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.find.Image = ((System.Drawing.Image)(resources.GetObject("find.Image")));
            this.find.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.find.Location = new System.Drawing.Point(352, 41);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(104, 37);
            this.find.TabIndex = 39;
            this.find.Text = "Bul";
            this.find.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove.Image = ((System.Drawing.Image)(resources.GetObject("remove.Image")));
            this.remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove.Location = new System.Drawing.Point(475, 40);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(104, 37);
            this.remove.TabIndex = 40;
            this.remove.Text = "Çıkar";
            this.remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(754, 344);
            this.groupBox2.TabIndex = 41;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Satışlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 310);
            this.dataGridView1.TabIndex = 0;
            // 
            // Sales_Cancellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.find);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.groupBox1);
            this.Name = "Sales_Cancellation";
            this.Text = "Satış İptali";
            this.Shown += new System.EventHandler(this.Sales_Cancellation_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox barcode;
        private Label refresh;
        private Label find;
        private Label remove;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
    }
}