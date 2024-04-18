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
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.grpOrderSpecific = new System.Windows.Forms.GroupBox();
            this.dgBookOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuCreateBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboClientId = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.grpOrderSpecific.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookOrders)).BeginInit();
            this.mnuCreateBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.dgOrders);
            this.grpOrder.Controls.Add(this.grpOrderSpecific);
            this.grpOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpOrder.Location = new System.Drawing.Point(17, 142);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(578, 441);
            this.grpOrder.TabIndex = 19;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Orders";
            this.grpOrder.Visible = false;
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.AllowUserToDeleteRows = false;
            this.dgOrders.AllowUserToResizeColumns = false;
            this.dgOrders.AllowUserToResizeRows = false;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrders.Location = new System.Drawing.Point(12, 24);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.Size = new System.Drawing.Size(555, 204);
            this.dgOrders.TabIndex = 54;
            this.dgOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrders_CellClick);
            // 
            // grpOrderSpecific
            // 
            this.grpOrderSpecific.Controls.Add(this.dgBookOrders);
            this.grpOrderSpecific.Location = new System.Drawing.Point(6, 234);
            this.grpOrderSpecific.Name = "grpOrderSpecific";
            this.grpOrderSpecific.Size = new System.Drawing.Size(561, 201);
            this.grpOrderSpecific.TabIndex = 53;
            this.grpOrderSpecific.TabStop = false;
            this.grpOrderSpecific.Visible = false;
            // 
            // dgBookOrders
            // 
            this.dgBookOrders.AllowUserToAddRows = false;
            this.dgBookOrders.AllowUserToDeleteRows = false;
            this.dgBookOrders.AllowUserToResizeColumns = false;
            this.dgBookOrders.AllowUserToResizeRows = false;
            this.dgBookOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookOrders.Location = new System.Drawing.Point(6, 15);
            this.dgBookOrders.Name = "dgBookOrders";
            this.dgBookOrders.ReadOnly = true;
            this.dgBookOrders.Size = new System.Drawing.Size(549, 170);
            this.dgBookOrders.TabIndex = 53;
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
            this.mnuCreateBook.Size = new System.Drawing.Size(610, 24);
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
            this.ClientSize = new System.Drawing.Size(610, 595);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.grpOrderSpecific.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBookOrders)).EndInit();
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
        private System.Windows.Forms.GroupBox grpOrderSpecific;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.DataGridView dgBookOrders;
    }
}