namespace Bank_Cashier
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblIntro = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsername = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblClose = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblIntro.Location = new System.Drawing.Point(398, 174);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(219, 20);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = "Get started from login below";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtUsername.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtUsername.isPassword = false;
            this.txtUsername.Location = new System.Drawing.Point(379, 240);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(252, 46);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblUsername.Location = new System.Drawing.Point(379, 226);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(61, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtPassword.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPassword.isPassword = true;
            this.txtPassword.Location = new System.Drawing.Point(379, 307);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(252, 46);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblPassword.Location = new System.Drawing.Point(380, 293);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(61, 15);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(451, 405);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(20, 16);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Or";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(91)))), ((int)(((byte)(4)))));
            this.lblClose.Location = new System.Drawing.Point(470, 405);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(57, 16);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "click here";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(524, 405);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(48, 16);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "to close";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(432, 368);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(154, 35);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(380, 444);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "lblError";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(435, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(436, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = "Molo Bank System";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.pictureBox3.Image = global::Bank_Cashier.Properties.Resources.Logo_Print_Media;
            this.pictureBox3.Location = new System.Drawing.Point(58, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(141, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(439, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(101, 96);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-155, -44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 527);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(656, 480);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIntro;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblClose;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtUsername;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtPassword;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}