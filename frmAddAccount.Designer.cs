namespace Bank_Cashier
{
    partial class frmAddAccount
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
            this.lblAddAccount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblBalance = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtBalance = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblFees = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFees = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.rbtnSaving = new System.Windows.Forms.RadioButton();
            this.rbtnChecking = new System.Windows.Forms.RadioButton();
            this.btnAddAcount = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddAccount
            // 
            this.lblAddAccount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAddAccount.AutoSize = true;
            this.lblAddAccount.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblAddAccount.Location = new System.Drawing.Point(193, 142);
            this.lblAddAccount.Name = "lblAddAccount";
            this.lblAddAccount.Size = new System.Drawing.Size(266, 32);
            this.lblAddAccount.TabIndex = 2;
            this.lblAddAccount.Text = "Create New Account";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblName.Location = new System.Drawing.Point(127, 206);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblEmail.Location = new System.Drawing.Point(349, 206);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(43, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
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
            this.txtEmail.Location = new System.Drawing.Point(349, 220);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(194, 41);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtName.Location = new System.Drawing.Point(130, 220);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(194, 41);
            this.txtName.TabIndex = 1;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblBalance
            // 
            this.lblBalance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblBalance.Location = new System.Drawing.Point(127, 320);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 15);
            this.lblBalance.TabIndex = 3;
            this.lblBalance.Text = "Balance";
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
            this.txtBalance.Location = new System.Drawing.Point(130, 334);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(194, 41);
            this.txtBalance.TabIndex = 5;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblFees
            // 
            this.lblFees.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFees.AutoSize = true;
            this.lblFees.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblFees.Location = new System.Drawing.Point(346, 320);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(37, 15);
            this.lblFees.TabIndex = 3;
            this.lblFees.Text = "Fees:";
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
            this.txtFees.Location = new System.Drawing.Point(349, 334);
            this.txtFees.Margin = new System.Windows.Forms.Padding(4);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(194, 41);
            this.txtFees.TabIndex = 6;
            this.txtFees.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rbtnSaving
            // 
            this.rbtnSaving.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnSaving.AutoSize = true;
            this.rbtnSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.rbtnSaving.Location = new System.Drawing.Point(130, 285);
            this.rbtnSaving.Name = "rbtnSaving";
            this.rbtnSaving.Size = new System.Drawing.Size(101, 17);
            this.rbtnSaving.TabIndex = 3;
            this.rbtnSaving.TabStop = true;
            this.rbtnSaving.Text = "Saving Account";
            this.rbtnSaving.UseVisualStyleBackColor = true;
            this.rbtnSaving.CheckedChanged += new System.EventHandler(this.Type_Checked);
            // 
            // rbtnChecking
            // 
            this.rbtnChecking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rbtnChecking.AutoSize = true;
            this.rbtnChecking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.rbtnChecking.Location = new System.Drawing.Point(352, 285);
            this.rbtnChecking.Name = "rbtnChecking";
            this.rbtnChecking.Size = new System.Drawing.Size(113, 17);
            this.rbtnChecking.TabIndex = 4;
            this.rbtnChecking.TabStop = true;
            this.rbtnChecking.Text = "Checking Account";
            this.rbtnChecking.UseVisualStyleBackColor = true;
            this.rbtnChecking.CheckedChanged += new System.EventHandler(this.Type_Checked);
            // 
            // btnAddAcount
            // 
            this.btnAddAcount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddAcount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnAddAcount.FlatAppearance.BorderSize = 0;
            this.btnAddAcount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnAddAcount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnAddAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAcount.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAcount.ForeColor = System.Drawing.Color.White;
            this.btnAddAcount.Location = new System.Drawing.Point(141, 410);
            this.btnAddAcount.Name = "btnAddAcount";
            this.btnAddAcount.Size = new System.Drawing.Size(167, 35);
            this.btnAddAcount.TabIndex = 7;
            this.btnAddAcount.Text = "Create Account";
            this.btnAddAcount.UseVisualStyleBackColor = false;
            this.btnAddAcount.Click += new System.EventHandler(this.btnAddAcount_Click);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(151, 456);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(54, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "label Error";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(361, 410);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 35);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Bank_Cashier.Properties.Resources.client_svgrepo_com;
            this.pictureBox1.Location = new System.Drawing.Point(255, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblNote.Location = new System.Drawing.Point(150, 488);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(55, 13);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "label Note";
            // 
            // frmAddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 614);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnAddAcount);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAccount";
            this.Text = "frmAddAccount";
            this.Load += new System.EventHandler(this.frmAddAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAddAccount;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtEmail;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblBalance;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtBalance;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFees;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtFees;
        private System.Windows.Forms.Button btnAddAcount;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNote;
        public System.Windows.Forms.RadioButton rbtnSaving;
        public System.Windows.Forms.RadioButton rbtnChecking;
    }
}