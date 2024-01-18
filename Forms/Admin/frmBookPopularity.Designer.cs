namespace BookSYS.Forms.Admin
{
    partial class frmBookPopularity
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
            this.mnuCreateBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.grdBooks = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuCreateBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuCreateBook
            // 
            this.mnuCreateBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuCreateBook.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBook.Name = "mnuCreateBook";
            this.mnuCreateBook.Size = new System.Drawing.Size(688, 24);
            this.mnuCreateBook.TabIndex = 1;
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
            // grdBooks
            // 
            this.grdBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBooks.Location = new System.Drawing.Point(12, 76);
            this.grdBooks.Name = "grdBooks";
            this.grdBooks.Size = new System.Drawing.Size(664, 208);
            this.grdBooks.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(170, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Annual Book Popularity Analysis";
            // 
            // frmBookPopularity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdBooks);
            this.Controls.Add(this.mnuCreateBook);
            this.Name = "frmBookPopularity";
            this.Text = "frmBookPopularity";
            this.mnuCreateBook.ResumeLayout(false);
            this.mnuCreateBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCreateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.DataGridView grdBooks;
        private System.Windows.Forms.Label label1;
    }
}