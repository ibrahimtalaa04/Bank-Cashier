namespace Bank_Cashier
{
    partial class frmSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtnSearchName = new System.Windows.Forms.RadioButton();
            this.rbtnSearchId = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblError = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gvSearch = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btncredit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNote = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnSearchName
            // 
            this.rbtnSearchName.AutoSize = true;
            this.rbtnSearchName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.rbtnSearchName.Location = new System.Drawing.Point(282, 62);
            this.rbtnSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSearchName.Name = "rbtnSearchName";
            this.rbtnSearchName.Size = new System.Drawing.Size(53, 17);
            this.rbtnSearchName.TabIndex = 3;
            this.rbtnSearchName.TabStop = true;
            this.rbtnSearchName.Text = "Name";
            this.rbtnSearchName.UseVisualStyleBackColor = true;
            // 
            // rbtnSearchId
            // 
            this.rbtnSearchId.AutoSize = true;
            this.rbtnSearchId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.rbtnSearchId.Location = new System.Drawing.Point(218, 62);
            this.rbtnSearchId.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSearchId.Name = "rbtnSearchId";
            this.rbtnSearchId.Size = new System.Drawing.Size(34, 17);
            this.rbtnSearchId.TabIndex = 2;
            this.rbtnSearchId.TabStop = true;
            this.rbtnSearchId.Text = "Id";
            this.rbtnSearchId.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 91);
            this.lblError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(39, 13);
            this.lblError.TabIndex = 5;
            this.lblError.Text = "lblError";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Cascadia Mono", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSearch.Location = new System.Drawing.Point(23, 219);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(91, 30);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "label1";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtSearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtSearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.txtSearch.isPassword = false;
            this.txtSearch.Location = new System.Drawing.Point(33, 52);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 35);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblTitle.Location = new System.Drawing.Point(28, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 28);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "Search Page";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(184)))), ((int)(((byte)(1)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(372, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gvSearch
            // 
            this.gvSearch.AllowUserToAddRows = false;
            this.gvSearch.AllowUserToDeleteRows = false;
            this.gvSearch.AllowUserToResizeColumns = false;
            this.gvSearch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "Null";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvSearch.BackgroundColor = System.Drawing.Color.White;
            this.gvSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvSearch.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btncredit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvSearch.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gvSearch.DoubleBuffered = true;
            this.gvSearch.EnableHeadersVisualStyles = false;
            this.gvSearch.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.gvSearch.HeaderForeColor = System.Drawing.Color.White;
            this.gvSearch.Location = new System.Drawing.Point(0, 127);
            this.gvSearch.Name = "gvSearch";
            this.gvSearch.ReadOnly = true;
            this.gvSearch.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvSearch.RowHeadersWidth = 50;
            this.gvSearch.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSearch.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gvSearch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gvSearch.RowTemplate.ReadOnly = true;
            this.gvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvSearch.ShowCellErrors = false;
            this.gvSearch.ShowEditingIcon = false;
            this.gvSearch.Size = new System.Drawing.Size(600, 239);
            this.gvSearch.TabIndex = 5;
            this.gvSearch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvSearch_CellClick);
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
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(120)))), ((int)(((byte)(237)))));
            this.lblNote.Location = new System.Drawing.Point(29, 105);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(72, 20);
            this.lblNote.TabIndex = 11;
            this.lblNote.Text = "lblNote";
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.gvSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.rbtnSearchId);
            this.Controls.Add(this.rbtnSearchName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSearch";
            this.Text = "frmSearch";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rbtnSearchName;
        private System.Windows.Forms.RadioButton rbtnSearchId;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblSearch;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private System.Windows.Forms.Button btnSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid gvSearch;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNote;
        private System.Windows.Forms.DataGridViewButtonColumn btncredit;
    }
}