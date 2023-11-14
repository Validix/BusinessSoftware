namespace WindowsFormsApp1
{
    partial class UsersForm
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
            this.panel_edituser = new System.Windows.Forms.Panel();
            this.button_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel_viewusers = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.EditButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_header.SuspendLayout();
            this.panel_edituser.SuspendLayout();
            this.panel_viewusers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel_header.Controls.Add(this.label_welcome);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(600, 46);
            this.panel_header.TabIndex = 19;
            // 
            // label_welcome
            // 
            this.label_welcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_welcome.Font = new System.Drawing.Font("Arial Narrow", 29.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_welcome.Location = new System.Drawing.Point(0, 0);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(600, 46);
            this.label_welcome.TabIndex = 22;
            this.label_welcome.Text = "Users";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_edituser
            // 
            this.panel_edituser.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_edituser.Controls.Add(this.button_save);
            this.panel_edituser.Controls.Add(this.label3);
            this.panel_edituser.Controls.Add(this.txt_password);
            this.panel_edituser.Controls.Add(this.label1);
            this.panel_edituser.Controls.Add(this.txt_username);
            this.panel_edituser.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_edituser.Location = new System.Drawing.Point(0, 46);
            this.panel_edituser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_edituser.Name = "panel_edituser";
            this.panel_edituser.Size = new System.Drawing.Size(600, 60);
            this.panel_edituser.TabIndex = 23;
            this.panel_edituser.Visible = false;
            this.panel_edituser.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_edituser_Paint);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(432, 19);
            this.button_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(110, 24);
            this.button_save.TabIndex = 26;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Password";
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_password.Location = new System.Drawing.Point(266, 19);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(156, 26);
            this.txt_password.TabIndex = 18;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_username.Location = new System.Drawing.Point(51, 19);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(156, 26);
            this.txt_username.TabIndex = 16;
            // 
            // panel_viewusers
            // 
            this.panel_viewusers.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_viewusers.Controls.Add(this.dataGridView1);
            this.panel_viewusers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_viewusers.Location = new System.Drawing.Point(0, 106);
            this.panel_viewusers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_viewusers.Name = "panel_viewusers";
            this.panel_viewusers.Size = new System.Drawing.Size(600, 260);
            this.panel_viewusers.TabIndex = 24;
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
            this.RemoveButton,
            this.EditButton,
            this.ProductId});
            this.dataGridView1.Location = new System.Drawing.Point(9, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(582, 237);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "User";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
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
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel_viewusers);
            this.Controls.Add(this.panel_edituser);
            this.Controls.Add(this.panel_header);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UsersForm";
            this.panel_header.ResumeLayout(false);
            this.panel_edituser.ResumeLayout(false);
            this.panel_edituser.PerformLayout();
            this.panel_viewusers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.Panel panel_edituser;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Panel panel_viewusers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveButton;
        private System.Windows.Forms.DataGridViewButtonColumn EditButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
    }
}