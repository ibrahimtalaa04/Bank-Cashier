namespace Bank_Cashier
{
    partial class frmEditAccount
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnEditAcount = new System.Windows.Forms.Button();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.rbtnSaving = new System.Windows.Forms.RadioButton();
            this.txtFees = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtBalance = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblFees = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblBalance = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblAddAccount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(452, 500);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(223, 43);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(184, 546);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(69, 16);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "label Error";
            // 
            // btnEditAcount
            // 
            this.btnEditAcount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEditAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnEditAcount.FlatAppearance.BorderSize = 0;
            this.btnEditAcount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnEditAcount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnEditAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAcount.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAcount.ForeColor = System.Drawing.Color.White;
            this.btnEditAcount.Location = new System.Drawing.Point(171, 500);
            this.btnEditAcount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditAcount.Name = "btnEditAcount";
            this.btnEditAcount.Size = new System.Drawing.Size(223, 43);
            this.btnEditAcount.TabIndex = 23;
            this.btnEditAcount.Text = "Edit Account";
            this.btnEditAcount.UseVisualStyleBackColor = false;
            this.btnEditAcount.Click += new System.EventHandler(this.btnEditAcount_Click);
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.rbtnChecking.Location = new System.Drawing.Point(452, 351);
            this.rbtnChecking.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(135, 20);
            this.rbtnChecking.TabIndex = 18;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking Account";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.Type_Checked);
            // 
            // rbtnSaving
            // 
            this.rbtnSaving.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnSaving.AutoSize = true;
            this.rbtnSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.rbtnSaving.Location = new System.Drawing.Point(156, 351);
            this.rbtnSaving.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnSaving.Name = "rbtnSaving";
            this.rbtnSaving.Size = new System.Drawing.Size(121, 20);
            this.rbtnSaving.TabIndex = 13;
            this.rbtnSaving.TabStop = true;
            this.rbtnSaving.Text = "Saving Account";
            this.rbtnSaving.UseVisualStyleBackColor = true;
            this.rbtnSaving.CheckedChanged += new System.EventHandler(this.Type_Checked);
            // 
            // txtFees
            // 
            this.txtFees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtFees.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtFees.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtFees.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtFees.BorderThickness = 2;
            this.txtFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFees.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFees.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFees.isPassword = false;
            this.txtFees.Location = new System.Drawing.Point(448, 402);
            this.txtFees.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(259, 50);
            this.txtFees.TabIndex = 20;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtBalance
            // 
            this.txtBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBalance.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtBalance.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtBalance.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtBalance.BorderThickness = 2;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBalance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBalance.isPassword = false;
            this.txtBalance.Location = new System.Drawing.Point(156, 402);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(259, 50);
            this.txtBalance.TabIndex = 19;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtName.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtName.BorderThickness = 2;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.isPassword = false;
            this.txtName.Location = new System.Drawing.Point(156, 256);
            this.txtName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(259, 50);
            this.txtName.TabIndex = 10;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblFees
            // 
            this.lblFees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblFees.Location = new System.Drawing.Point(444, 385);
            this.lblFees.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(48, 18);
            this.lblFees.TabIndex = 14;
            this.lblFees.Text = "Fees:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtEmail.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEmail.isPassword = false;
            this.txtEmail.Location = new System.Drawing.Point(448, 256);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 50);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblBalance.Location = new System.Drawing.Point(152, 385);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(64, 18);
            this.lblBalance.TabIndex = 15;
            this.lblBalance.Text = "Balance";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblEmail.Location = new System.Drawing.Point(448, 239);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 18);
            this.lblEmail.TabIndex = 16;
            this.lblEmail.Text = "Email:";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblName.Location = new System.Drawing.Point(152, 239);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "Name:";
            // 
            // lblAddAccount
            // 
            this.lblAddAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddAccount.AutoSize = true;
            this.lblAddAccount.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblAddAccount.Location = new System.Drawing.Point(240, 160);
            this.lblAddAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddAccount.Name = "lblAddAccount";
            this.lblAddAccount.Size = new System.Drawing.Size(341, 40);
            this.lblAddAccount.TabIndex = 12;
            this.lblAddAccount.Text = "Create New Account";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Bank_Cashier.Properties.Resources.client_svgrepo_com;
            this.pictureBox1.Location = new System.Drawing.Point(323, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(31, 633);
            this.panel1.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(829, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 633);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(31, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 23);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(31, 610);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(798, 23);
            this.panel4.TabIndex = 25;
            // 
            // frmEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 633);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnEditAcount);
            this.Controls.Add(this.rbtnChecking);
            this.Controls.Add(this.rbtnSaving);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddAccount);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditAccount";
            this.Load += new System.EventHandler(this.frmEditAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEditAcount;
        public System.Windows.Forms.RadioButton rbtnChecking;
        public System.Windows.Forms.RadioButton rbtnSaving;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtFees;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtBalance;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFees;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBalance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}