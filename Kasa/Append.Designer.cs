namespace Kasa
{
    partial class Append
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Append));
            this.remove = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.wholesaler = new System.Windows.Forms.ComboBox();
            this.wholesaler_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.product_type_name = new System.Windows.Forms.TextBox();
            this.product_type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // remove
            // 
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.remove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.remove.Image = ((System.Drawing.Image)(resources.GetObject("remove.Image")));
            this.remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.remove.Location = new System.Drawing.Point(351, 135);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(90, 39);
            this.remove.TabIndex = 13;
            this.remove.Text = "Kaldır";
            this.remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // insert
            // 
            this.insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insert.Image = ((System.Drawing.Image)(resources.GetObject("insert.Image")));
            this.insert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.insert.Location = new System.Drawing.Point(351, 90);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(90, 39);
            this.insert.TabIndex = 14;
            this.insert.Text = "Ekle";
            this.insert.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // wholesaler
            // 
            this.wholesaler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.wholesaler.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wholesaler.ForeColor = System.Drawing.SystemColors.WindowText;
            this.wholesaler.Location = new System.Drawing.Point(55, 141);
            this.wholesaler.Margin = new System.Windows.Forms.Padding(4);
            this.wholesaler.Name = "wholesaler";
            this.wholesaler.Size = new System.Drawing.Size(290, 29);
            this.wholesaler.TabIndex = 15;
            // 
            // wholesaler_name
            // 
            this.wholesaler_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.wholesaler_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wholesaler_name.Location = new System.Drawing.Point(55, 93);
            this.wholesaler_name.Name = "wholesaler_name";
            this.wholesaler_name.Size = new System.Drawing.Size(290, 33);
            this.wholesaler_name.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(115, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 48);
            this.label1.TabIndex = 17;
            this.label1.Text = "Toptancı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 48);
            this.label2.TabIndex = 22;
            this.label2.Text = "Ürün Cinsi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product_type_name
            // 
            this.product_type_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.product_type_name.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.product_type_name.Location = new System.Drawing.Point(55, 225);
            this.product_type_name.Name = "product_type_name";
            this.product_type_name.Size = new System.Drawing.Size(290, 33);
            this.product_type_name.TabIndex = 21;
            // 
            // product_type
            // 
            this.product_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.product_type.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.product_type.ForeColor = System.Drawing.SystemColors.WindowText;
            this.product_type.Location = new System.Drawing.Point(55, 273);
            this.product_type.Margin = new System.Windows.Forms.Padding(4);
            this.product_type.Name = "product_type";
            this.product_type.Size = new System.Drawing.Size(290, 29);
            this.product_type.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(351, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 18;
            this.button1.Text = "Kaldır";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(351, 222);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 39);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ekle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Append
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 371);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.product_type_name);
            this.Controls.Add(this.product_type);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wholesaler_name);
            this.Controls.Add(this.wholesaler);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.insert);
            this.Name = "Append";
            this.Text = "Append";
            this.Shown += new System.EventHandler(this.Append_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button remove;
        private Button insert;
        private ComboBox wholesaler;
        private TextBox wholesaler_name;
        private Label label1;
        private Label label2;
        private TextBox product_type_name;
        private ComboBox product_type;
        private Button button1;
        private Button button2;
    }
}