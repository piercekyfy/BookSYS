namespace BookSYS.Forms
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
            System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem mnuClients;
            System.Windows.Forms.ToolStripMenuItem mnuExit;
            System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuCreateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloseAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCreateOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDispatchOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProcessPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.listOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBookPopularity = new System.Windows.Forms.ToolStripMenuItem();
            this.picBookRow = new System.Windows.Forms.PictureBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuDBConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.picDBConnection = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuYearlyRevenue = new System.Windows.Forms.ToolStripMenuItem();
            booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            mnuClients = new System.Windows.Forms.ToolStripMenuItem();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBookRow)).BeginInit();
            this.mnuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateBook,
            this.mnuUpdateBook,
            this.mnuRemoveBook});
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            booksToolStripMenuItem.Text = "Books";
            // 
            // mnuCreateBook
            // 
            this.mnuCreateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuCreateBook.Name = "mnuCreateBook";
            this.mnuCreateBook.Size = new System.Drawing.Size(117, 22);
            this.mnuCreateBook.Text = "Create";
            this.mnuCreateBook.Click += new System.EventHandler(this.mnuCreateBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(117, 22);
            this.mnuUpdateBook.Text = "Update";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(117, 22);
            this.mnuRemoveBook.Text = "Remove";
            this.mnuRemoveBook.Click += new System.EventHandler(this.mnuRemoveBook_Click);
            // 
            // mnuClients
            // 
            mnuClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            mnuClients.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenAccount,
            this.mnuUpdateAccount,
            this.mnuCloseAccount});
            mnuClients.Name = "mnuClients";
            mnuClients.Size = new System.Drawing.Size(55, 20);
            mnuClients.Text = "Clients";
            // 
            // mnuOpenAccount
            // 
            this.mnuOpenAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuOpenAccount.Name = "mnuOpenAccount";
            this.mnuOpenAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuOpenAccount.Text = "Open Account";
            this.mnuOpenAccount.Click += new System.EventHandler(this.mnuOpenAccount_Click);
            // 
            // mnuUpdateAccount
            // 
            this.mnuUpdateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuUpdateAccount.Name = "mnuUpdateAccount";
            this.mnuUpdateAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuUpdateAccount.Text = "Update Account";
            this.mnuUpdateAccount.Click += new System.EventHandler(this.mnuUpdateAccount_Click);
            // 
            // mnuCloseAccount
            // 
            this.mnuCloseAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuCloseAccount.Name = "mnuCloseAccount";
            this.mnuCloseAccount.Size = new System.Drawing.Size(160, 22);
            this.mnuCloseAccount.Text = "Close Account";
            this.mnuCloseAccount.Click += new System.EventHandler(this.mnuCloseAccount_Click);
            // 
            // mnuExit
            // 
            mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            mnuExit.Name = "mnuExit";
            mnuExit.Size = new System.Drawing.Size(38, 20);
            mnuExit.Text = "Exit";
            mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCreateOrder,
            this.mnuDispatchOrder,
            this.mnuProcessPayment,
            this.mnuCancelOrder,
            this.listOrdersToolStripMenuItem});
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            ordersToolStripMenuItem.Text = "Orders";
            // 
            // mnuCreateOrder
            // 
            this.mnuCreateOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuCreateOrder.Name = "mnuCreateOrder";
            this.mnuCreateOrder.Size = new System.Drawing.Size(164, 22);
            this.mnuCreateOrder.Text = "Create Order";
            this.mnuCreateOrder.Click += new System.EventHandler(this.mnuCreateOrder_Click);
            // 
            // mnuDispatchOrder
            // 
            this.mnuDispatchOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuDispatchOrder.Name = "mnuDispatchOrder";
            this.mnuDispatchOrder.Size = new System.Drawing.Size(164, 22);
            this.mnuDispatchOrder.Text = "Dispatch Order";
            this.mnuDispatchOrder.Click += new System.EventHandler(this.mnuDispatchOrder_Click);
            // 
            // mnuProcessPayment
            // 
            this.mnuProcessPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuProcessPayment.Name = "mnuProcessPayment";
            this.mnuProcessPayment.Size = new System.Drawing.Size(164, 22);
            this.mnuProcessPayment.Text = "Process Payment";
            this.mnuProcessPayment.Click += new System.EventHandler(this.mnuProcessPayment_Click);
            // 
            // mnuCancelOrder
            // 
            this.mnuCancelOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuCancelOrder.Name = "mnuCancelOrder";
            this.mnuCancelOrder.Size = new System.Drawing.Size(164, 22);
            this.mnuCancelOrder.Text = "Cancel Order";
            this.mnuCancelOrder.Click += new System.EventHandler(this.mnuCancelOrder_Click);
            // 
            // listOrdersToolStripMenuItem
            // 
            this.listOrdersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.listOrdersToolStripMenuItem.Name = "listOrdersToolStripMenuItem";
            this.listOrdersToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listOrdersToolStripMenuItem.Text = "List Orders";
            this.listOrdersToolStripMenuItem.Click += new System.EventHandler(this.listOrdersToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBookPopularity,
            this.mnuYearlyRevenue});
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // mnuBookPopularity
            // 
            this.mnuBookPopularity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuBookPopularity.Name = "mnuBookPopularity";
            this.mnuBookPopularity.Size = new System.Drawing.Size(180, 22);
            this.mnuBookPopularity.Text = "Book Popularity";
            this.mnuBookPopularity.Click += new System.EventHandler(this.mnuBookPopularity_Click);
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
            this.mnuMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            booksToolStripMenuItem,
            mnuClients,
            mnuExit,
            ordersToolStripMenuItem,
            adminToolStripMenuItem,
            this.mnuDBConnect});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(800, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "mnuMain";
            // 
            // mnuDBConnect
            // 
            this.mnuDBConnect.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuDBConnect.Name = "mnuDBConnect";
            this.mnuDBConnect.Size = new System.Drawing.Size(96, 20);
            this.mnuDBConnect.Text = "Connect to DB";
            this.mnuDBConnect.Click += new System.EventHandler(this.mnuDBConnect_Click);
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
            // picDBConnection
            // 
            this.picDBConnection.BackColor = System.Drawing.Color.Red;
            this.picDBConnection.Location = new System.Drawing.Point(653, 5);
            this.picDBConnection.Name = "picDBConnection";
            this.picDBConnection.Size = new System.Drawing.Size(13, 14);
            this.picDBConnection.TabIndex = 5;
            this.picDBConnection.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Book wholesales, made wholesome.";
            // 
            // mnuYearlyRevenue
            // 
            this.mnuYearlyRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(173)))), ((int)(((byte)(153)))));
            this.mnuYearlyRevenue.Name = "mnuYearlyRevenue";
            this.mnuYearlyRevenue.Size = new System.Drawing.Size(180, 22);
            this.mnuYearlyRevenue.Text = "Yearly Revenue";
            this.mnuYearlyRevenue.Click += new System.EventHandler(this.mnuYearlyRevenue_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDBConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picBookRow);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.Text = "BookSYS - [MainMenu]";
            ((System.ComponentModel.ISupportInitialize)(this.picBookRow)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDBConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBookRow;
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
        private System.Windows.Forms.ToolStripMenuItem mnuBookPopularity;
        private System.Windows.Forms.ToolStripMenuItem mnuDBConnect;
        private System.Windows.Forms.PictureBox picDBConnection;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevenue;
    }
}