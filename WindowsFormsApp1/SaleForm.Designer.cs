namespace WindowsFormsApp1
{
    partial class SaleForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label_orderpermonth = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_welcome = new System.Windows.Forms.Label();
            this.button_viewsale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.datetimepicker_year = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datetimepicker_month = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label_orderperyear = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label_orderpermonth);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(67, 119);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 141);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Orders per Month";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_orderpermonth
            // 
            this.label_orderpermonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_orderpermonth.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderpermonth.Location = new System.Drawing.Point(0, 0);
            this.label_orderpermonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_orderpermonth.Name = "label_orderpermonth";
            this.label_orderpermonth.Size = new System.Drawing.Size(150, 109);
            this.label_orderpermonth.TabIndex = 1;
            this.label_orderpermonth.Text = "37";
            this.label_orderpermonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 140);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 1);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_header.Controls.Add(this.label_welcome);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(889, 46);
            this.panel_header.TabIndex = 21;
            // 
            // label_welcome
            // 
            this.label_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_welcome.Font = new System.Drawing.Font("Arial Narrow", 29.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_welcome.Location = new System.Drawing.Point(0, 0);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(889, 46);
            this.label_welcome.TabIndex = 22;
            this.label_welcome.Text = "Sale";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_viewsale
            // 
            this.button_viewsale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_viewsale.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_viewsale.Location = new System.Drawing.Point(436, 65);
            this.button_viewsale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_viewsale.Name = "button_viewsale";
            this.button_viewsale.Size = new System.Drawing.Size(72, 24);
            this.button_viewsale.TabIndex = 29;
            this.button_viewsale.Text = "View sale";
            this.button_viewsale.UseVisualStyleBackColor = false;
            this.button_viewsale.Click += new System.EventHandler(this.button_viewsale_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "per year:";
            // 
            // datetimepicker_year
            // 
            this.datetimepicker_year.CustomFormat = "yyyy";
            this.datetimepicker_year.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.datetimepicker_year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker_year.Location = new System.Drawing.Point(281, 67);
            this.datetimepicker_year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimepicker_year.Name = "datetimepicker_year";
            this.datetimepicker_year.Size = new System.Drawing.Size(151, 24);
            this.datetimepicker_year.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Per month:";
            // 
            // datetimepicker_month
            // 
            this.datetimepicker_month.CustomFormat = "MMMM";
            this.datetimepicker_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.datetimepicker_month.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepicker_month.Location = new System.Drawing.Point(67, 67);
            this.datetimepicker_month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datetimepicker_month.Name = "datetimepicker_month";
            this.datetimepicker_month.Size = new System.Drawing.Size(151, 24);
            this.datetimepicker_month.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label_orderperyear);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(281, 119);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 141);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 116);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Orders per Year";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_orderperyear
            // 
            this.label_orderperyear.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_orderperyear.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_orderperyear.Location = new System.Drawing.Point(0, 0);
            this.label_orderperyear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_orderperyear.Name = "label_orderperyear";
            this.label_orderperyear.Size = new System.Drawing.Size(150, 109);
            this.label_orderperyear.TabIndex = 1;
            this.label_orderperyear.Text = "37";
            this.label_orderperyear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DimGray;
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 140);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(150, 1);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(889, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_viewsale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetimepicker_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datetimepicker_month);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label_orderpermonth;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Button button_viewsale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datetimepicker_year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetimepicker_month;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_orderperyear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
    }
}