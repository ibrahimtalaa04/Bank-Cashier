namespace Bank_Cashier
{
    partial class frmHome
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
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCountAll = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCountSaving = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCountChecking = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblCountRate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Mono", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblTitle.Location = new System.Drawing.Point(55, 53);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(503, 40);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Welcome to Molo Bank System";
            // 
            // lblCountAll
            // 
            this.lblCountAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCountAll.AutoSize = true;
            this.lblCountAll.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.lblCountAll.Location = new System.Drawing.Point(57, 159);
            this.lblCountAll.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountAll.Name = "lblCountAll";
            this.lblCountAll.Size = new System.Drawing.Size(178, 23);
            this.lblCountAll.TabIndex = 13;
            this.lblCountAll.Text = "The number of All";
            // 
            // lblCountSaving
            // 
            this.lblCountSaving.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCountSaving.AutoSize = true;
            this.lblCountSaving.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountSaving.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.lblCountSaving.Location = new System.Drawing.Point(55, 215);
            this.lblCountSaving.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountSaving.Name = "lblCountSaving";
            this.lblCountSaving.Size = new System.Drawing.Size(216, 23);
            this.lblCountSaving.TabIndex = 13;
            this.lblCountSaving.Text = "The number of Saving";
            // 
            // lblCountChecking
            // 
            this.lblCountChecking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCountChecking.AutoSize = true;
            this.lblCountChecking.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountChecking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.lblCountChecking.Location = new System.Drawing.Point(55, 273);
            this.lblCountChecking.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountChecking.Name = "lblCountChecking";
            this.lblCountChecking.Size = new System.Drawing.Size(238, 23);
            this.lblCountChecking.TabIndex = 13;
            this.lblCountChecking.Text = "The number of Checking";
            // 
            // lblCountRate
            // 
            this.lblCountRate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCountRate.AutoSize = true;
            this.lblCountRate.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.lblCountRate.Location = new System.Drawing.Point(55, 330);
            this.lblCountRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountRate.Name = "lblCountRate";
            this.lblCountRate.Size = new System.Drawing.Size(276, 23);
            this.lblCountRate.TabIndex = 13;
            this.lblCountRate.Text = "The rate in Saving Accounts\'";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 633);
            this.Controls.Add(this.lblCountRate);
            this.Controls.Add(this.lblCountChecking);
            this.Controls.Add(this.lblCountSaving);
            this.Controls.Add(this.lblCountAll);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHome";
            this.Text = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCountAll;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCountSaving;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCountChecking;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCountRate;
    }
}