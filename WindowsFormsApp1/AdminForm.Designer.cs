namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_logout = new System.Windows.Forms.Button();
            this.button_products = new System.Windows.Forms.Button();
            this.button_orders = new System.Windows.Forms.Button();
            this.button_sale = new System.Windows.Forms.Button();
            this.button_users = new System.Windows.Forms.Button();
            this.button_orderstock = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_header.Controls.Add(this.label_welcome);
            this.panel_header.Controls.Add(this.button_logout);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(889, 46);
            this.panel_header.TabIndex = 19;
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
            this.label_welcome.Click += new System.EventHandler(this.label_welcome_Click);
            // 
            // button_logout
            // 
            this.button_logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_logout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_logout.Location = new System.Drawing.Point(824, 10);
            this.button_logout.Margin = new System.Windows.Forms.Padding(2);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(56, 28);
            this.button_logout.TabIndex = 21;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = false;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_products
            // 
            this.button_products.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_products.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_products.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_products.Location = new System.Drawing.Point(194, 120);
            this.button_products.Margin = new System.Windows.Forms.Padding(2);
            this.button_products.Name = "button_products";
            this.button_products.Size = new System.Drawing.Size(204, 142);
            this.button_products.TabIndex = 23;
            this.button_products.Text = "Product";
            this.button_products.UseVisualStyleBackColor = false;
            this.button_products.Click += new System.EventHandler(this.button_products_Click);
            // 
            // button_orders
            // 
            this.button_orders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_orders.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_orders.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_orders.Location = new System.Drawing.Point(402, 120);
            this.button_orders.Margin = new System.Windows.Forms.Padding(2);
            this.button_orders.Name = "button_orders";
            this.button_orders.Size = new System.Drawing.Size(123, 224);
            this.button_orders.TabIndex = 24;
            this.button_orders.Text = "Orders";
            this.button_orders.UseVisualStyleBackColor = false;
            this.button_orders.Click += new System.EventHandler(this.button_orders_Click);
            // 
            // button_sale
            // 
            this.button_sale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_sale.BackColor = System.Drawing.Color.White;
            this.button_sale.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sale.Location = new System.Drawing.Point(194, 267);
            this.button_sale.Margin = new System.Windows.Forms.Padding(2);
            this.button_sale.Name = "button_sale";
            this.button_sale.Size = new System.Drawing.Size(204, 224);
            this.button_sale.TabIndex = 25;
            this.button_sale.Text = "Sale";
            this.button_sale.UseVisualStyleBackColor = false;
            this.button_sale.Click += new System.EventHandler(this.button_sale_Click);
            // 
            // button_users
            // 
            this.button_users.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_users.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_users.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_users.Location = new System.Drawing.Point(402, 349);
            this.button_users.Margin = new System.Windows.Forms.Padding(2);
            this.button_users.Name = "button_users";
            this.button_users.Size = new System.Drawing.Size(283, 142);
            this.button_users.TabIndex = 26;
            this.button_users.Text = "Users";
            this.button_users.UseVisualStyleBackColor = false;
            this.button_users.Click += new System.EventHandler(this.button_users_Click);
            // 
            // button_orderstock
            // 
            this.button_orderstock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_orderstock.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_orderstock.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_orderstock.Location = new System.Drawing.Point(530, 120);
            this.button_orderstock.Margin = new System.Windows.Forms.Padding(2);
            this.button_orderstock.Name = "button_orderstock";
            this.button_orderstock.Size = new System.Drawing.Size(155, 224);
            this.button_orderstock.TabIndex = 27;
            this.button_orderstock.Text = "Order Stock";
            this.button_orderstock.UseVisualStyleBackColor = false;
            this.button_orderstock.Click += new System.EventHandler(this.button_orderstock_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(889, 577);
            this.ControlBox = false;
            this.Controls.Add(this.button_orderstock);
            this.Controls.Add(this.button_users);
            this.Controls.Add(this.button_sale);
            this.Controls.Add(this.button_orders);
            this.Controls.Add(this.button_products);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load_1);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Button button_products;
        private System.Windows.Forms.Button button_orders;
        private System.Windows.Forms.Button button_sale;
        private System.Windows.Forms.Button button_users;
        private System.Windows.Forms.Button button_orderstock;
    }
}