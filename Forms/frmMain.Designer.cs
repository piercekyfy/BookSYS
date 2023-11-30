namespace BookSYS
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picBookRow = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispatchOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.listOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBookRow)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBookRow
            // 
            this.picBookRow.Image = ((System.Drawing.Image)(resources.GetObject("picBookRow.Image")));
            this.picBookRow.Location = new System.Drawing.Point(0, 271);
            this.picBookRow.Name = "picBookRow";
            this.picBookRow.Size = new System.Drawing.Size(801, 179);
            this.picBookRow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookRow.TabIndex = 0;
            this.picBookRow.TabStop = false;
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem,
            this.mnuClients,
            this.mnuExit,
            this.ordersToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateBook,
            this.mnuUpdateBook,
            this.mnuRemoveBook});
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // mnuCreateBook
            // 
            this.mnuCreateBook.Name = "mnuCreateBook";
            this.mnuCreateBook.Size = new System.Drawing.Size(117, 22);
            this.mnuCreateBook.Text = "Create";
            this.mnuCreateBook.Click += new System.EventHandler(this.mnuCreateBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(117, 22);
            this.mnuUpdateBook.Text = "Update";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(117, 22);
            this.mnuRemoveBook.Text = "Remove";
            this.mnuRemoveBook.Click += new System.EventHandler(this.mnuRemoveBook_Click);
            // 
            // mnuClients
            // 
            this.mnuClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenAccount,
            this.mnuUpdateAccount,
            this.mnuCloseAccount});
            this.mnuClients.Name = "mnuClients";
            this.mnuClients.Size = new System.Drawing.Size(55, 20);
            this.mnuClients.Text = "Clients";
            // 
            // mnuOpenAccount
            // 
            this.mnuOpenAccount.Name = "mnuOpenAccount";
            this.mnuOpenAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuOpenAccount.Text = "Open Account";
            this.mnuOpenAccount.Click += new System.EventHandler(this.mnuOpenAccount_Click);
            // 
            // mnuUpdateAccount
            // 
            this.mnuUpdateAccount.Name = "mnuUpdateAccount";
            this.mnuUpdateAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuUpdateAccount.Text = "Update Account";
            this.mnuUpdateAccount.Click += new System.EventHandler(this.mnuUpdateAccount_Click);
            // 
            // mnuCloseAccount
            // 
            this.mnuCloseAccount.Name = "mnuCloseAccount";
            this.mnuCloseAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuCloseAccount.Text = "Close Account";
            this.mnuCloseAccount.Click += new System.EventHandler(this.mnuCloseAccount_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateOrder,
            this.mnuDispatchOrder,
            this.mnuProcessPayment,
            this.mnuCancelOrder,
            this.listOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // mnuCreateOrder
            // 
            this.mnuCreateOrder.Name = "mnuCreateOrder";
            this.mnuCreateOrder.Size = new System.Drawing.Size(180, 22);
            this.mnuCreateOrder.Text = "Create Order";
            this.mnuCreateOrder.Click += new System.EventHandler(this.mnuCreateOrder_Click);
            // 
            // mnuDispatchOrder
            // 
            this.mnuDispatchOrder.Name = "mnuDispatchOrder";
            this.mnuDispatchOrder.Size = new System.Drawing.Size(180, 22);
            this.mnuDispatchOrder.Text = "Dispatch Order";
            this.mnuDispatchOrder.Click += new System.EventHandler(this.mnuDispatchOrder_Click);
            // 
            // mnuProcessPayment
            // 
            this.mnuProcessPayment.Name = "mnuProcessPayment";
            this.mnuProcessPayment.Size = new System.Drawing.Size(180, 22);
            this.mnuProcessPayment.Text = "Process Payment";
            this.mnuProcessPayment.Click += new System.EventHandler(this.mnuProcessPayment_Click);
            // 
            // mnuCancelOrder
            // 
            this.mnuCancelOrder.Name = "mnuCancelOrder";
            this.mnuCancelOrder.Size = new System.Drawing.Size(180, 22);
            this.mnuCancelOrder.Text = "Cancel Order";
            this.mnuCancelOrder.Click += new System.EventHandler(this.mnuCancelOrder_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 106);
            this.label2.TabIndex = 3;
            this.label2.Text = "BookSYS";
            // 
            // listOrdersToolStripMenuItem
            // 
            this.listOrdersToolStripMenuItem.Name = "listOrdersToolStripMenuItem";
            this.listOrdersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOrdersToolStripMenuItem.Text = "List Orders";
            this.listOrdersToolStripMenuItem.Click += new System.EventHandler(this.listOrdersToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBookRow);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "BookSYS - [MainMenu]";
            ((System.ComponentModel.ISupportInitialize)(this.picBookRow)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBookRow;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuClients;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAccount;
        private System.Windows.Forms.ToolStripMenuItem mnuCreateOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuDispatchOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuProcessPayment;
        private System.Windows.Forms.ToolStripMenuItem mnuCancelOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem listOrdersToolStripMenuItem;
    }
}