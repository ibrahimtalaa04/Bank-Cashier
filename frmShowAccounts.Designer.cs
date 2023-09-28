namespace Bank_Cashier
{
    partial class frmShowAccounts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvAccounts = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btncredit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNote = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAccounts
            // 
            this.gvAccounts.AllowUserToAddRows = false;
            this.gvAccounts.AllowUserToDeleteRows = false;
            this.gvAccounts.AllowUserToResizeColumns = false;
            this.gvAccounts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "Null";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAccounts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvAccounts.BackgroundColor = System.Drawing.Color.White;
            this.gvAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvAccounts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAccounts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btncredit,
            this.btnUpdate});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvAccounts.DefaultCellStyle = dataGridViewCellStyle4;
            this.gvAccounts.DoubleBuffered = true;
            this.gvAccounts.EnableHeadersVisualStyles = false;
            this.gvAccounts.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvAccounts.HeaderForeColor = System.Drawing.Color.White;
            this.gvAccounts.Location = new System.Drawing.Point(0, 67);
            this.gvAccounts.Name = "gvAccounts";
            this.gvAccounts.ReadOnly = true;
            this.gvAccounts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvAccounts.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gvAccounts.RowHeadersVisible = false;
            this.gvAccounts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvAccounts.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gvAccounts.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvAccounts.RowTemplate.ReadOnly = true;
            this.gvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvAccounts.Size = new System.Drawing.Size(800, 384);
            this.gvAccounts.TabIndex = 1;
            this.gvAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvAccounts_CellClick);
            // 
            // btncredit
            // 
            this.btncredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.btncredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncredit.HeaderText = "Credit/Depit";
            this.btncredit.Name = "btncredit";
            this.btncredit.ReadOnly = true;
            this.btncredit.Text = "Credit/Depit";
            this.btncredit.ToolTipText = "Credit or Depit from the Balance";
            this.btncredit.UseColumnTextForButtonValue = true;
            // 
            // btnUpdate
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.DefaultCellStyle = dataGridViewCellStyle3;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.HeaderText = "Update";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ReadOnly = true;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseColumnTextForButtonValue = true;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblNote.Location = new System.Drawing.Point(12, 44);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(72, 20);
            this.lblNote.TabIndex = 2;
            this.lblNote.Text = "lblNote";
            // 
            // frmShowAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.gvAccounts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowAccounts";
            this.Text = "frmShowAccounts";
            this.Load += new System.EventHandler(this.frmShowAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvAccounts;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNote;
        private System.Windows.Forms.DataGridViewButtonColumn btncredit;
        private System.Windows.Forms.DataGridViewButtonColumn btnUpdate;
    }
}