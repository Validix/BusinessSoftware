namespace WindowsFormsApp1
{
    partial class ManageProuctsForm
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_addproducts = new System.Windows.Forms.Button();
            this.label_welcome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_editproduct = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.panel_viewproducts = new System.Windows.Forms.Panel();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_editproduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.panel_viewproducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_header.Controls.Add(this.btn_addproducts);
            this.panel_header.Controls.Add(this.label_welcome);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(741, 53);
            this.panel_header.TabIndex = 20;
            // 
            // btn_addproducts
            // 
            this.btn_addproducts.Location = new System.Drawing.Point(8, 12);
            this.btn_addproducts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addproducts.Name = "btn_addproducts";
            this.btn_addproducts.Size = new System.Drawing.Size(67, 32);
            this.btn_addproducts.TabIndex = 23;
            this.btn_addproducts.Text = "Add Product";
            this.btn_addproducts.UseVisualStyleBackColor = true;
            this.btn_addproducts.Click += new System.EventHandler(this.btn_addproducts_Click);
            // 
            // label_welcome
            // 
            this.label_welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Arial Narrow", 29.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_welcome.Location = new System.Drawing.Point(233, 6);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(273, 45);
            this.label_welcome.TabIndex = 22;
            this.label_welcome.Text = "Manage Products";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column3,
            this.RemoveButton,
            this.EditButton,
            this.ProductId,
            this.ProductImage});
            this.dataGridView1.Location = new System.Drawing.Point(8, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(726, 383);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // RemoveButton
            // 
            this.RemoveButton.HeaderText = "";
            this.RemoveButton.MinimumWidth = 6;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.ReadOnly = true;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseColumnTextForButtonValue = true;
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "";
            this.EditButton.MinimumWidth = 6;
            this.EditButton.Name = "EditButton";
            this.EditButton.ReadOnly = true;
            this.EditButton.Text = "Edit";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Column4";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // ProductImage
            // 
            this.ProductImage.HeaderText = "";
            this.ProductImage.MinimumWidth = 6;
            this.ProductImage.Name = "ProductImage";
            this.ProductImage.ReadOnly = true;
            this.ProductImage.Visible = false;
            // 
            // panel_editproduct
            // 
            this.panel_editproduct.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_editproduct.Controls.Add(this.button_save);
            this.panel_editproduct.Controls.Add(this.btn_upload);
            this.panel_editproduct.Controls.Add(this.pb_image);
            this.panel_editproduct.Controls.Add(this.label2);
            this.panel_editproduct.Controls.Add(this.txt_description);
            this.panel_editproduct.Controls.Add(this.QuantityNumericUpDown);
            this.panel_editproduct.Controls.Add(this.label4);
            this.panel_editproduct.Controls.Add(this.label3);
            this.panel_editproduct.Controls.Add(this.txt_price);
            this.panel_editproduct.Controls.Add(this.label1);
            this.panel_editproduct.Controls.Add(this.txt_title);
            this.panel_editproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_editproduct.Location = new System.Drawing.Point(0, 53);
            this.panel_editproduct.Margin = new System.Windows.Forms.Padding(2);
            this.panel_editproduct.Name = "panel_editproduct";
            this.panel_editproduct.Size = new System.Drawing.Size(741, 203);
            this.panel_editproduct.TabIndex = 22;
            this.panel_editproduct.Visible = false;
            this.panel_editproduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_editproduct_Paint);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(438, 167);
            this.button_save.Margin = new System.Windows.Forms.Padding(2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(58, 24);
            this.button_save.TabIndex = 26;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(367, 167);
            this.btn_upload.Margin = new System.Windows.Forms.Padding(2);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(68, 24);
            this.btn_upload.TabIndex = 24;
            this.btn_upload.Text = "Upload Image";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // pb_image
            // 
            this.pb_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_image.InitialImage = null;
            this.pb_image.Location = new System.Drawing.Point(367, 67);
            this.pb_image.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(130, 94);
            this.pb_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_image.TabIndex = 25;
            this.pb_image.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description";
            // 
            // txt_description
            // 
            this.txt_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_description.Location = new System.Drawing.Point(63, 67);
            this.txt_description.Margin = new System.Windows.Forms.Padding(2);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(262, 94);
            this.txt_description.TabIndex = 22;
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(367, 23);
            this.QuantityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(128, 26);
            this.QuantityNumericUpDown.TabIndex = 21;
            this.QuantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_price.Location = new System.Drawing.Point(197, 22);
            this.txt_price.Margin = new System.Windows.Forms.Padding(2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(131, 26);
            this.txt_price.TabIndex = 18;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Title";
            // 
            // txt_title
            // 
            this.txt_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_title.Location = new System.Drawing.Point(37, 22);
            this.txt_title.Margin = new System.Windows.Forms.Padding(2);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(131, 26);
            this.txt_title.TabIndex = 16;
            // 
            // panel_viewproducts
            // 
            this.panel_viewproducts.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_viewproducts.Controls.Add(this.dataGridView1);
            this.panel_viewproducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_viewproducts.Location = new System.Drawing.Point(0, 256);
            this.panel_viewproducts.Margin = new System.Windows.Forms.Padding(2);
            this.panel_viewproducts.Name = "panel_viewproducts";
            this.panel_viewproducts.Size = new System.Drawing.Size(741, 410);
            this.panel_viewproducts.TabIndex = 23;
            // 
            // ManageProuctsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 666);
            this.Controls.Add(this.panel_viewproducts);
            this.Controls.Add(this.panel_editproduct);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManageProuctsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageProuctsForm";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_editproduct.ResumeLayout(false);
            this.panel_editproduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.panel_viewproducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button btn_addproducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_editproduct;
        private System.Windows.Forms.Panel panel_viewproducts;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.PictureBox pb_image;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveButton;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewImageColumn ProductImage;
    }
}