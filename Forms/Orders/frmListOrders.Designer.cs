﻿namespace BookSYS.Forms.Clients
{
    partial class frmListOrders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgBookOrders = new System.Windows.Forms.DataGridView();
            this.mnuCreateBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.cboClientId = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookOrders)).BeginInit();
            this.mnuCreateBook.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.dgOrders);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.label14);
            this.grpOrder.Controls.Add(this.dgBookOrders);
            this.grpOrder.Enabled = false;
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOrder.Location = new System.Drawing.Point(0, 136);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(573, 501);
            this.grpOrder.TabIndex = 19;
            this.grpOrder.TabStop = false;
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.AllowUserToResizeColumns = false;
            this.dgOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgOrders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgOrders.Location = new System.Drawing.Point(16, 43);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.Size = new System.Drawing.Size(535, 204);
            this.dgOrders.TabIndex = 60;
            this.dgOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(18, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Contents";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline);
            this.label14.Location = new System.Drawing.Point(13, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 58;
            this.label14.Text = "Orders";
            // 
            // dgBookOrders
            // 
            this.dgBookOrders.AllowUserToAddRows = false;
            this.dgBookOrders.AllowUserToDeleteRows = false;
            this.dgBookOrders.AllowUserToResizeColumns = false;
            this.dgBookOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBookOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgBookOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBookOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgBookOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBookOrders.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgBookOrders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgBookOrders.Location = new System.Drawing.Point(16, 276);
            this.dgBookOrders.Name = "dgBookOrders";
            this.dgBookOrders.ReadOnly = true;
            this.dgBookOrders.Size = new System.Drawing.Size(535, 204);
            this.dgBookOrders.TabIndex = 54;
            // 
            // mnuCreateBook
            // 
            this.mnuCreateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.mnuCreateBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuCreateBook.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBook.Name = "mnuCreateBook";
            this.mnuCreateBook.Size = new System.Drawing.Size(574, 24);
            this.mnuCreateBook.TabIndex = 21;
            this.mnuCreateBook.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txtNameSearch);
            this.pnlSearch.Controls.Add(this.cboClientId);
            this.pnlSearch.Location = new System.Drawing.Point(0, 72);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(573, 69);
            this.pnlSearch.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline);
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Client Search";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtNameSearch.Location = new System.Drawing.Point(16, 35);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(210, 23);
            this.txtNameSearch.TabIndex = 1;
            // 
            // cboClientId
            // 
            this.cboClientId.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cboClientId.FormattingEnabled = true;
            this.cboClientId.Location = new System.Drawing.Point(232, 35);
            this.cboClientId.Name = "cboClientId";
            this.cboClientId.Size = new System.Drawing.Size(126, 23);
            this.cboClientId.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 49);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Orders";
            // 
            // frmListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(574, 639);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuCreateBook);
            this.Controls.Add(this.grpOrder);
            this.Name = "frmListOrders";
            this.Text = "frmListOrders";
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookOrders)).EndInit();
            this.mnuCreateBook.ResumeLayout(false);
            this.mnuCreateBook.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.MenuStrip mnuCreateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.ComboBox cboClientId;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgBookOrders;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
    }
}