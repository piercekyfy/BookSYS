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
            this.mnuClients = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // mnuClients
            // 
            this.mnuClients.Name = "mnuClients";
            this.mnuClients.Size = new System.Drawing.Size(55, 20);
            this.mnuClients.Text = "Clients";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.booksToolStripMenuItem.Text = "Books";
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.ordersToolStripMenuItem.Text = "Orders";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}