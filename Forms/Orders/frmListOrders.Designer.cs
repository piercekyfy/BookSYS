namespace BookSYS.Forms.Clients
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.grpOrderSpecific = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.libBooks = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.libOrders = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuCreateBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboClientId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            this.grpOrderSpecific.SuspendLayout();
            this.mnuCreateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.grpOrderSpecific);
            this.grpOrder.Controls.Add(this.libOrders);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOrder.Location = new System.Drawing.Point(17, 142);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(356, 337);
            this.grpOrder.TabIndex = 19;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Orders";
            this.grpOrder.Visible = false;
            // 
            // grpOrderSpecific
            // 
            this.grpOrderSpecific.Controls.Add(this.lblStatus);
            this.grpOrderSpecific.Controls.Add(this.libBooks);
            this.grpOrderSpecific.Controls.Add(this.lblTotal);
            this.grpOrderSpecific.Location = new System.Drawing.Point(6, 157);
            this.grpOrderSpecific.Name = "grpOrderSpecific";
            this.grpOrderSpecific.Size = new System.Drawing.Size(343, 180);
            this.grpOrderSpecific.TabIndex = 53;
            this.grpOrderSpecific.TabStop = false;
            this.grpOrderSpecific.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStatus.Location = new System.Drawing.Point(6, 22);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 22);
            this.lblStatus.TabIndex = 52;
            this.lblStatus.Text = "Status: Undispatched";
            // 
            // libBooks
            // 
            this.libBooks.FormattingEnabled = true;
            this.libBooks.ItemHeight = 20;
            this.libBooks.Location = new System.Drawing.Point(0, 52);
            this.libBooks.Name = "libBooks";
            this.libBooks.Size = new System.Drawing.Size(344, 124);
            this.libBooks.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTotal.Location = new System.Drawing.Point(193, 22);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(146, 22);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "Total: 000000.00";
            // 
            // libOrders
            // 
            this.libOrders.FormattingEnabled = true;
            this.libOrders.ItemHeight = 20;
            this.libOrders.Location = new System.Drawing.Point(6, 25);
            this.libOrders.Name = "libOrders";
            this.libOrders.Size = new System.Drawing.Size(344, 124);
            this.libOrders.TabIndex = 3;
            this.libOrders.SelectedIndexChanged += new System.EventHandler(this.libOrders_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "List Orders";
            // 
            // mnuCreateBook
            // 
            this.mnuCreateBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuCreateBook.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBook.Name = "mnuCreateBook";
            this.mnuCreateBook.Size = new System.Drawing.Size(392, 24);
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
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(77, 103);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(124, 20);
            this.txtNameSearch.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(13, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 37;
            this.label10.Text = "Name:";
            // 
            // cboClientId
            // 
            this.cboClientId.FormattingEnabled = true;
            this.cboClientId.Location = new System.Drawing.Point(245, 104);
            this.cboClientId.Name = "cboClientId";
            this.cboClientId.Size = new System.Drawing.Size(126, 21);
            this.cboClientId.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(207, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(12, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 39;
            this.label8.Text = "Client:";
            // 
            // frmListOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 481);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboClientId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mnuCreateBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOrder);
            this.Name = "frmListOrders";
            this.Text = "frmListOrders";
            this.grpOrder.ResumeLayout(false);
            this.grpOrderSpecific.ResumeLayout(false);
            this.grpOrderSpecific.PerformLayout();
            this.mnuCreateBook.ResumeLayout(false);
            this.mnuCreateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuCreateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboClientId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox libOrders;
        private System.Windows.Forms.GroupBox grpOrderSpecific;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox libBooks;
        private System.Windows.Forms.Label lblTotal;
    }
}