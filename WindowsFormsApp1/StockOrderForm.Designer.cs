namespace WindowsFormsApp1
{
    partial class StockOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOrderForm));
            this.panel_header = new System.Windows.Forms.Panel();
            this.btn_addproducts = new System.Windows.Forms.Button();
            this.label_welcome = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.panel_orderedstock = new System.Windows.Forms.Panel();
            this.panel_headingPR = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_orderinventory = new System.Windows.Forms.Panel();
            this.panel_products = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_orderstock = new System.Windows.Forms.Button();
            this.tablelayoutpanel_products = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.QuantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.button_getproducts = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.print_btn = new System.Windows.Forms.Button();
            this.panel_header.SuspendLayout();
            this.panel_container.SuspendLayout();
            this.panel_orderedstock.SuspendLayout();
            this.panel_headingPR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel_products.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tablelayoutpanel_products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).BeginInit();
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
            this.panel_header.Size = new System.Drawing.Size(889, 46);
            this.panel_header.TabIndex = 21;
            // 
            // btn_addproducts
            // 
            this.btn_addproducts.Location = new System.Drawing.Point(9, 10);
            this.btn_addproducts.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addproducts.Name = "btn_addproducts";
            this.btn_addproducts.Size = new System.Drawing.Size(80, 28);
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
            this.label_welcome.Location = new System.Drawing.Point(325, 0);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(192, 45);
            this.label_welcome.TabIndex = 22;
            this.label_welcome.Text = "Order Stock";
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.panel_orderedstock);
            this.panel_container.Controls.Add(this.panel_orderinventory);
            this.panel_container.Controls.Add(this.panel_products);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 46);
            this.panel_container.Margin = new System.Windows.Forms.Padding(2);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(889, 531);
            this.panel_container.TabIndex = 22;
            // 
            // panel_orderedstock
            // 
            this.panel_orderedstock.Controls.Add(this.panel_headingPR);
            this.panel_orderedstock.Controls.Add(this.dataGridView3);
            this.panel_orderedstock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_orderedstock.Location = new System.Drawing.Point(556, 0);
            this.panel_orderedstock.Margin = new System.Windows.Forms.Padding(2);
            this.panel_orderedstock.Name = "panel_orderedstock";
            this.panel_orderedstock.Size = new System.Drawing.Size(333, 531);
            this.panel_orderedstock.TabIndex = 2;
            // 
            // panel_headingPR
            // 
            this.panel_headingPR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_headingPR.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_headingPR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_headingPR.Controls.Add(this.label1);
            this.panel_headingPR.Location = new System.Drawing.Point(7, 5);
            this.panel_headingPR.Margin = new System.Windows.Forms.Padding(2);
            this.panel_headingPR.Name = "panel_headingPR";
            this.panel_headingPR.Size = new System.Drawing.Size(320, 54);
            this.panel_headingPR.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 50);
            this.label1.TabIndex = 24;
            this.label1.Text = "Purchase Requisition";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView3.Location = new System.Drawing.Point(7, 63);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(320, 458);
            this.dataGridView3.TabIndex = 26;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            this.dataGridView3.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellDoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quantity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Order date";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Order number";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel_orderinventory
            // 
            this.panel_orderinventory.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_orderinventory.Location = new System.Drawing.Point(314, 0);
            this.panel_orderinventory.Margin = new System.Windows.Forms.Padding(2);
            this.panel_orderinventory.Name = "panel_orderinventory";
            this.panel_orderinventory.Size = new System.Drawing.Size(242, 531);
            this.panel_orderinventory.TabIndex = 1;
            this.panel_orderinventory.Visible = false;
            // 
            // panel_products
            // 
            this.panel_products.Controls.Add(this.panel2);
            this.panel_products.Controls.Add(this.tablelayoutpanel_products);
            this.panel_products.Controls.Add(this.panel1);
            this.panel_products.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_products.Location = new System.Drawing.Point(0, 0);
            this.panel_products.Margin = new System.Windows.Forms.Padding(2);
            this.panel_products.Name = "panel_products";
            this.panel_products.Size = new System.Drawing.Size(314, 531);
            this.panel_products.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.print_btn);
            this.panel2.Controls.Add(this.button_orderstock);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 466);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 65);
            this.panel2.TabIndex = 27;
            // 
            // button_orderstock
            // 
            this.button_orderstock.Location = new System.Drawing.Point(9, 11);
            this.button_orderstock.Margin = new System.Windows.Forms.Padding(2);
            this.button_orderstock.Name = "button_orderstock";
            this.button_orderstock.Size = new System.Drawing.Size(291, 24);
            this.button_orderstock.TabIndex = 25;
            this.button_orderstock.Text = "Order stock";
            this.button_orderstock.UseVisualStyleBackColor = true;
            this.button_orderstock.Click += new System.EventHandler(this.button_orderstock_Click);
            // 
            // tablelayoutpanel_products
            // 
            this.tablelayoutpanel_products.ColumnCount = 1;
            this.tablelayoutpanel_products.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelayoutpanel_products.Controls.Add(this.dataGridView2, 0, 1);
            this.tablelayoutpanel_products.Controls.Add(this.dataGridView1, 0, 0);
            this.tablelayoutpanel_products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelayoutpanel_products.Location = new System.Drawing.Point(0, 58);
            this.tablelayoutpanel_products.Margin = new System.Windows.Forms.Padding(2);
            this.tablelayoutpanel_products.Name = "tablelayoutpanel_products";
            this.tablelayoutpanel_products.RowCount = 2;
            this.tablelayoutpanel_products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelayoutpanel_products.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablelayoutpanel_products.Size = new System.Drawing.Size(314, 473);
            this.tablelayoutpanel_products.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.RemoveButton,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(2, 238);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(310, 233);
            this.dataGridView2.TabIndex = 26;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
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
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Column4";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
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
            this.Column3,
            this.EditButton,
            this.ProductId});
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(310, 232);
            this.dataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // EditButton
            // 
            this.EditButton.HeaderText = "";
            this.EditButton.MinimumWidth = 6;
            this.EditButton.Name = "EditButton";
            this.EditButton.Text = "Select";
            this.EditButton.UseColumnTextForButtonValue = true;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Column4";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.QuantityNumericUpDown);
            this.panel1.Controls.Add(this.button_getproducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 58);
            this.panel1.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Order Threshold";
            // 
            // QuantityNumericUpDown
            // 
            this.QuantityNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityNumericUpDown.Location = new System.Drawing.Point(100, 18);
            this.QuantityNumericUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.QuantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.QuantityNumericUpDown.Name = "QuantityNumericUpDown";
            this.QuantityNumericUpDown.Size = new System.Drawing.Size(56, 26);
            this.QuantityNumericUpDown.TabIndex = 23;
            // 
            // button_getproducts
            // 
            this.button_getproducts.Location = new System.Drawing.Point(161, 18);
            this.button_getproducts.Margin = new System.Windows.Forms.Padding(2);
            this.button_getproducts.Name = "button_getproducts";
            this.button_getproducts.Size = new System.Drawing.Size(71, 24);
            this.button_getproducts.TabIndex = 24;
            this.button_getproducts.Text = "Get products";
            this.button_getproducts.UseVisualStyleBackColor = true;
            this.button_getproducts.Click += new System.EventHandler(this.button_getproducts_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // print_btn
            // 
            this.print_btn.Location = new System.Drawing.Point(9, 38);
            this.print_btn.Margin = new System.Windows.Forms.Padding(2);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(291, 24);
            this.print_btn.TabIndex = 26;
            this.print_btn.Text = "Print";
            this.print_btn.UseVisualStyleBackColor = true;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // StockOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(889, 577);
            this.Controls.Add(this.panel_container);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StockOrderForm";
            this.Text = "StockOrderForm";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_container.ResumeLayout(false);
            this.panel_orderedstock.ResumeLayout(false);
            this.panel_headingPR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel_products.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tablelayoutpanel_products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button btn_addproducts;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Panel panel_orderedstock;
        private System.Windows.Forms.Panel panel_orderinventory;
        private System.Windows.Forms.Panel panel_products;
        private System.Windows.Forms.NumericUpDown QuantityNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_getproducts;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tablelayoutpanel_products;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_orderstock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel_headingPR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button print_btn;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}