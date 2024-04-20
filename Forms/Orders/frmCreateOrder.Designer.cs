﻿namespace BookSYS.Forms.Clients
{
    partial class frmCreateOrder
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.cboBookId = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgBookOrders = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.cboBookRevId = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.mnuHeader = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.cboClientId = new System.Windows.Forms.ComboBox();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookOrders)).BeginInit();
            this.mnuHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.label3);
            this.grpOrder.Controls.Add(this.label14);
            this.grpOrder.Controls.Add(this.txtTitleSearch);
            this.grpOrder.Controls.Add(this.cboBookId);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.dgBookOrders);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.btnAddBook);
            this.grpOrder.Controls.Add(this.txtQuantity);
            this.grpOrder.Controls.Add(this.cboBookRevId);
            this.grpOrder.Controls.Add(this.btnRemove);
            this.grpOrder.Controls.Add(this.btnSubmit);
            this.grpOrder.Enabled = false;
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOrder.Location = new System.Drawing.Point(0, 144);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(573, 403);
            this.grpOrder.TabIndex = 19;
            this.grpOrder.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(361, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 57;
            this.label3.Text = "Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Underline);
            this.label14.Location = new System.Drawing.Point(14, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 18);
            this.label14.TabIndex = 56;
            this.label14.Text = "Title";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtTitleSearch.Location = new System.Drawing.Point(12, 72);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(210, 23);
            this.txtTitleSearch.TabIndex = 54;
            // 
            // cboBookId
            // 
            this.cboBookId.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cboBookId.FormattingEnabled = true;
            this.cboBookId.Location = new System.Drawing.Point(228, 72);
            this.cboBookId.Name = "cboBookId";
            this.cboBookId.Size = new System.Drawing.Size(126, 23);
            this.cboBookId.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline);
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 53;
            this.label2.Text = "Add Book";
            // 
            // dgBookOrders
            // 
            this.dgBookOrders.AllowUserToAddRows = false;
            this.dgBookOrders.AllowUserToDeleteRows = false;
            this.dgBookOrders.AllowUserToResizeColumns = false;
            this.dgBookOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgBookOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgBookOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(88)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgBookOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgBookOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgBookOrders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgBookOrders.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgBookOrders.Location = new System.Drawing.Point(12, 101);
            this.dgBookOrders.Name = "dgBookOrders";
            this.dgBookOrders.ReadOnly = true;
            this.dgBookOrders.Size = new System.Drawing.Size(539, 204);
            this.dgBookOrders.TabIndex = 52;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(18, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(158, 18);
            this.lblTotal.TabIndex = 49;
            this.lblTotal.Text = "Total: 000000.00";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddBook.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnAddBook.Location = new System.Drawing.Point(471, 72);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(74, 23);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtQuantity.Location = new System.Drawing.Point(364, 72);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(101, 23);
            this.txtQuantity.TabIndex = 5;
            // 
            // cboBookRevId
            // 
            this.cboBookRevId.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cboBookRevId.FormattingEnabled = true;
            this.cboBookRevId.Location = new System.Drawing.Point(364, 311);
            this.cboBookRevId.Name = "cboBookRevId";
            this.cboBookRevId.Size = new System.Drawing.Size(101, 23);
            this.cboBookRevId.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnRemove.Location = new System.Drawing.Point(471, 311);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(74, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Verdana", 18F);
            this.btnSubmit.Location = new System.Drawing.Point(364, 340);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(181, 47);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Place Order";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // mnuHeader
            // 
            this.mnuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.mnuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuHeader.Location = new System.Drawing.Point(0, 0);
            this.mnuHeader.Name = "mnuHeader";
            this.mnuHeader.Size = new System.Drawing.Size(574, 24);
            this.mnuHeader.TabIndex = 21;
            this.mnuHeader.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 49);
            this.panel1.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Order";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txtNameSearch);
            this.pnlSearch.Controls.Add(this.cboClientId);
            this.pnlSearch.Location = new System.Drawing.Point(0, 73);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(573, 69);
            this.pnlSearch.TabIndex = 41;
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
            // frmCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(574, 549);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuHeader);
            this.Controls.Add(this.grpOrder);
            this.Name = "frmCreateOrder";
            this.Text = "frmCreateOrder";
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookOrders)).EndInit();
            this.mnuHeader.ResumeLayout(false);
            this.mnuHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MenuStrip mnuHeader;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboBookRevId;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgBookOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.ComboBox cboClientId;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.ComboBox cboBookId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
    }
}