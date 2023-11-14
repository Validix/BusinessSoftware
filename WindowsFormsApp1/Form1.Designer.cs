namespace WindowsFormsApp1
{
    partial class Form1
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_productDetails = new System.Windows.Forms.Panel();
            this.label_quantity = new System.Windows.Forms.Label();
            this.pb_icon = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button_addtocart = new System.Windows.Forms.Button();
            this.panel_cart = new System.Windows.Forms.Panel();
            this.button_placeorder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.button_viewcart = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel_container.SuspendLayout();
            this.panel_productDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
            this.panel_cart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 46);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(306, 531);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_container.Controls.Add(this.panel_productDetails);
            this.panel_container.Controls.Add(this.panel_cart);
            this.panel_container.Controls.Add(this.flowLayoutPanel1);
            this.panel_container.Controls.Add(this.panel_header);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Margin = new System.Windows.Forms.Padding(2);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(889, 577);
            this.panel_container.TabIndex = 1;
            // 
            // panel_productDetails
            // 
            this.panel_productDetails.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_productDetails.Controls.Add(this.label_quantity);
            this.panel_productDetails.Controls.Add(this.pb_icon);
            this.panel_productDetails.Controls.Add(this.lbl_title);
            this.panel_productDetails.Controls.Add(this.lbl_price);
            this.panel_productDetails.Controls.Add(this.richTextBox1);
            this.panel_productDetails.Controls.Add(this.QuantityNumericUpDown);
            this.panel_productDetails.Controls.Add(this.button_addtocart);
            this.panel_productDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_productDetails.Location = new System.Drawing.Point(306, 277);
            this.panel_productDetails.Margin = new System.Windows.Forms.Padding(2);
            this.panel_productDetails.Name = "panel_productDetails";
            this.panel_productDetails.Size = new System.Drawing.Size(583, 300);
            this.panel_productDetails.TabIndex = 17;
            this.panel_productDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_productDetails_Paint);
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_quantity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_quantity.Location = new System.Drawing.Point(244, 259);
            this.label_quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(68, 20);
            this.label_quantity.TabIndex = 15;
            this.label_quantity.Text = "Quantity";
            // 
            // pb_icon
            // 
            this.pb_icon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_icon.Location = new System.Drawing.Point(19, 18);
            this.pb_icon.Margin = new System.Windows.Forms.Padding(2);
            this.pb_icon.Name = "pb_icon";
            this.pb_icon.Size = new System.Drawing.Size(212, 225);
            this.pb_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_icon.TabIndex = 1;
            this.pb_icon.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoEllipsis = true;
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_title.Location = new System.Drawing.Point(244, 18);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(43, 20);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "Title";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_price.Location = new System.Drawing.Point(244, 46);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(65, 18);
            this.lbl_price.TabIndex = 11;
            this.lbl_price.Text = "Sub Title";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(244, 76);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(240, 166);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(314, 257);
            this.QuantityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(64, 26);
            this.QuantityNumericUpDown.TabIndex = 14;
            // 
            // button_addtocart
            // 
            this.button_addtocart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_addtocart.Location = new System.Drawing.Point(392, 254);
            this.button_addtocart.Margin = new System.Windows.Forms.Padding(2);
            this.button_addtocart.Name = "button_addtocart";
            this.button_addtocart.Size = new System.Drawing.Size(91, 30);
            this.button_addtocart.TabIndex = 12;
            this.button_addtocart.Text = "Add to cart";
            this.button_addtocart.UseVisualStyleBackColor = false;
            this.button_addtocart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_cart
            // 
            this.panel_cart.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_cart.Controls.Add(this.button_placeorder);
            this.panel_cart.Controls.Add(this.dataGridView1);
            this.panel_cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_cart.Location = new System.Drawing.Point(306, 46);
            this.panel_cart.Margin = new System.Windows.Forms.Padding(2);
            this.panel_cart.Name = "panel_cart";
            this.panel_cart.Size = new System.Drawing.Size(583, 231);
            this.panel_cart.TabIndex = 2;
            this.panel_cart.Visible = false;
            this.panel_cart.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cart_Paint);
            // 
            // button_placeorder
            // 
            this.button_placeorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_placeorder.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_placeorder.Location = new System.Drawing.Point(404, 184);
            this.button_placeorder.Margin = new System.Windows.Forms.Padding(2);
            this.button_placeorder.Name = "button_placeorder";
            this.button_placeorder.Size = new System.Drawing.Size(164, 30);
            this.button_placeorder.TabIndex = 17;
            this.button_placeorder.Text = "Place Order";
            this.button_placeorder.UseVisualStyleBackColor = false;
            this.button_placeorder.Click += new System.EventHandler(this.button_placeorder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.RemoveButton,
            this.ProductId});
            this.dataGridView1.Location = new System.Drawing.Point(17, 16);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(551, 162);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Price";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // RemoveButton
            // 
            this.RemoveButton.HeaderText = "";
            this.RemoveButton.MinimumWidth = 6;
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseColumnTextForButtonValue = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Column4";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_header.Controls.Add(this.label_welcome);
            this.panel_header.Controls.Add(this.button_logout);
            this.panel_header.Controls.Add(this.button_login);
            this.panel_header.Controls.Add(this.button_viewcart);
            this.panel_header.Controls.Add(this.btn_refresh);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(889, 46);
            this.panel_header.TabIndex = 18;
            // 
            // label_welcome
            // 
            this.label_welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_welcome.AutoSize = true;
            this.label_welcome.Font = new System.Drawing.Font("Arial Narrow", 29.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_welcome.Location = new System.Drawing.Point(370, 0);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(171, 45);
            this.label_welcome.TabIndex = 22;
            this.label_welcome.Text = "Get ready!";
            // 
            // button_logout
            // 
            this.button_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_logout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_logout.Location = new System.Drawing.Point(824, 9);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(56, 28);
            this.button_logout.TabIndex = 21;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_login
            // 
            this.button_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_login.Location = new System.Drawing.Point(824, 10);
            this.button_login.Margin = new System.Windows.Forms.Padding(2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(56, 28);
            this.button_login.TabIndex = 20;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_viewcart
            // 
            this.button_viewcart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_viewcart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_viewcart.Location = new System.Drawing.Point(45, 6);
            this.button_viewcart.Margin = new System.Windows.Forms.Padding(2);
            this.button_viewcart.Name = "button_viewcart";
            this.button_viewcart.Size = new System.Drawing.Size(32, 35);
            this.button_viewcart.TabIndex = 19;
            this.button_viewcart.Text = "🛒";
            this.button_viewcart.UseVisualStyleBackColor = false;
            this.button_viewcart.Click += new System.EventHandler(this.button_viewcart_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_refresh.Location = new System.Drawing.Point(7, 6);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(34, 35);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "🔄";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 577);
            this.Controls.Add(this.panel_container);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_productDetails.ResumeLayout(false);
            this.panel_productDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.panel_cart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.PictureBox pb_icon;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button button_addtocart;
        private System.Windows.Forms.Panel panel_cart;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label_quantity;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button button_viewcart;
        private System.Windows.Forms.Panel panel_productDetails;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_placeorder;
        private System.Windows.Forms.Label label_welcome;
    }
}

