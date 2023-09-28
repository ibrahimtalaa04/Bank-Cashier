namespace Bank_Cashier
{
    partial class frmCredit
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
            this.rbtnDepit = new System.Windows.Forms.RadioButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAmount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAmount = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblClose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError = new System.Windows.Forms.Label();
            this.rbtnCredit = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbtnDepit
            // 
            this.rbtnDepit.AutoSize = true;
            this.rbtnDepit.Location = new System.Drawing.Point(260, 135);
            this.rbtnDepit.Name = "rbtnDepit";
            this.rbtnDepit.Size = new System.Drawing.Size(50, 17);
            this.rbtnDepit.TabIndex = 0;
            this.rbtnDepit.TabStop = true;
            this.rbtnDepit.Text = "Depit";
            this.rbtnDepit.UseVisualStyleBackColor = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(166, 62);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(144, 25);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "Credit/Depit";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtAmount.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtAmount.BorderThickness = 2;
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAmount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtAmount.isPassword = false;
            this.txtAmount.Location = new System.Drawing.Point(119, 189);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(248, 36);
            this.txtAmount.TabIndex = 17;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(165, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(156, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(154, 35);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblAmount.Location = new System.Drawing.Point(119, 175);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 15);
            this.lblAmount.TabIndex = 16;
            this.lblAmount.Text = "Amount:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(181, 296);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(20, 16);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Or";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.lblClose.Location = new System.Drawing.Point(200, 296);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(57, 16);
            this.lblClose.TabIndex = 22;
            this.lblClose.Text = "click here";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(254, 296);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(48, 16);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "to close";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(156, 322);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 23;
            this.lblError.Text = "lblError";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbtnCredit
            // 
            this.rbtnCredit.AutoSize = true;
            this.rbtnCredit.Location = new System.Drawing.Point(151, 135);
            this.rbtnCredit.Name = "rbtnCredit";
            this.rbtnCredit.Size = new System.Drawing.Size(52, 17);
            this.rbtnCredit.TabIndex = 0;
            this.rbtnCredit.TabStop = true;
            this.rbtnCredit.Text = "Credit";
            this.rbtnCredit.UseVisualStyleBackColor = true;
            // 
            // frmCredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(482, 344);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.rbtnCredit);
            this.Controls.Add(this.rbtnDepit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCredit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCredit";
            this.Load += new System.EventHandler(this.frmCredit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAmount;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.RadioButton rbtnDepit;
        public System.Windows.Forms.RadioButton rbtnCredit;
    }
}