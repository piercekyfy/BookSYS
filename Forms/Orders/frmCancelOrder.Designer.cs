namespace BookSYS.Forms.Clients
{
    partial class frmCancelOrder
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboOrderId = new System.Windows.Forms.ComboBox();
            this.libBooks = new System.Windows.Forms.ListBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuCreateBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboClientId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            this.mnuCreateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.cboOrderId);
            this.grpOrder.Controls.Add(this.libBooks);
            this.grpOrder.Controls.Add(this.btnSubmit);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOrder.Location = new System.Drawing.Point(17, 142);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(356, 369);
            this.grpOrder.TabIndex = 19;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Orders";
            this.grpOrder.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblTotal.Location = new System.Drawing.Point(190, 300);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(146, 22);
            this.lblTotal.TabIndex = 50;
            this.lblTotal.Text = "Total: 000000.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 41;
            this.label2.Text = "Order Contents:";
            // 
            // cboOrderId
            // 
            this.cboOrderId.FormattingEnabled = true;
            this.cboOrderId.Location = new System.Drawing.Point(15, 25);
            this.cboOrderId.Name = "cboOrderId";
            this.cboOrderId.Size = new System.Drawing.Size(321, 28);
            this.cboOrderId.TabIndex = 3;
            this.cboOrderId.SelectedIndexChanged += new System.EventHandler(this.cboOrderId_SelectedIndexChanged);
            // 
            // libBooks
            // 
            this.libBooks.FormattingEnabled = true;
            this.libBooks.ItemHeight = 20;
            this.libBooks.Location = new System.Drawing.Point(10, 93);
            this.libBooks.Name = "libBooks";
            this.libBooks.Size = new System.Drawing.Size(344, 204);
            this.libBooks.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(96, 325);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 29);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Cancel Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cancel Order";
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
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Location = new System.Drawing.Point(77, 103);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(124, 20);
            this.txtNameSearch.TabIndex = 1;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.txtNameSearch_TextChanged);
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
            this.cboClientId.SelectedIndexChanged += new System.EventHandler(this.cboClientId_SelectedIndexChanged);
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
            // frmCancelOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 526);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNameSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboClientId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.mnuCreateBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpOrder);
            this.Name = "frmCancelOrder";
            this.Text = "frmCancelOrder";
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.mnuCreateBook.ResumeLayout(false);
            this.mnuCreateBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuCreateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboClientId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox libBooks;
        private System.Windows.Forms.ComboBox cboOrderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
    }
}