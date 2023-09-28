namespace Bank_Cashier
{
    partial class frmUpdateRate
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblError = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtRate = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblRate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNote = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::Bank_Cashier.Properties.Resources.credit_card_regular_24__1_;
            this.pictureBox1.Location = new System.Drawing.Point(262, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblTitle.Location = new System.Drawing.Point(120, 189);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(420, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Update the rate of Saving Accounts";
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(236, 375);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(54, 13);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "label Error";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(239, 337);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(167, 35);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtRate
            // 
            this.txtRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRate.BackColor = System.Drawing.Color.White;
            this.txtRate.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtRate.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtRate.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtRate.BorderThickness = 2;
            this.txtRate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRate.isPassword = false;
            this.txtRate.Location = new System.Drawing.Point(203, 268);
            this.txtRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(230, 41);
            this.txtRate.TabIndex = 1;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRate
            // 
            this.lblRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblRate.AutoSize = true;
            this.lblRate.BackColor = System.Drawing.Color.White;
            this.lblRate.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblRate.Location = new System.Drawing.Point(200, 254);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(37, 15);
            this.lblRate.TabIndex = 9;
            this.lblRate.Text = "Rate:";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblNote.Location = new System.Drawing.Point(236, 393);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(54, 13);
            this.lblNote.TabIndex = 10;
            this.lblNote.Text = "label Error";
            // 
            // frmUpdateRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(646, 514);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUpdateRate";
            this.Text = "frmUpdateRate";
            this.Load += new System.EventHandler(this.frmUpdateRate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnUpdate;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtRate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRate;
        private System.Windows.Forms.Label lblNote;
    }
}