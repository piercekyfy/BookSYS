namespace BookSYS.Forms.Books
{
    partial class frmUpdateBook
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
            this.mnuHeader = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.mnuHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuHeader
            // 
            this.mnuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.mnuHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuHeader.Location = new System.Drawing.Point(0, 0);
            this.mnuHeader.Name = "mnuHeader";
            this.mnuHeader.Size = new System.Drawing.Size(707, 24);
            this.mnuHeader.TabIndex = 3;
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
            // cboId
            // 
            this.cboId.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(232, 35);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(152, 23);
            this.cboId.TabIndex = 2;
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.txtTitleSearch.Location = new System.Drawing.Point(16, 35);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(210, 23);
            this.txtTitleSearch.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 49);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Book";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline);
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 23);
            this.label11.TabIndex = 35;
            this.label11.Text = "Search";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.pnlSearch.Controls.Add(this.label11);
            this.pnlSearch.Controls.Add(this.txtTitleSearch);
            this.pnlSearch.Controls.Add(this.cboId);
            this.pnlSearch.Location = new System.Drawing.Point(0, 73);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(707, 69);
            this.pnlSearch.TabIndex = 36;
            // 
            // grpBook
            // 
            this.grpBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.grpBook.Controls.Add(this.btnSubmit);
            this.grpBook.Controls.Add(this.txtISBN);
            this.grpBook.Controls.Add(this.label3);
            this.grpBook.Controls.Add(this.txtQuantity);
            this.grpBook.Controls.Add(this.txtPrice);
            this.grpBook.Controls.Add(this.txtPublisher);
            this.grpBook.Controls.Add(this.txtDescription);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.label10);
            this.grpBook.Controls.Add(this.label4);
            this.grpBook.Controls.Add(this.label12);
            this.grpBook.Controls.Add(this.label13);
            this.grpBook.Controls.Add(this.txtTitle);
            this.grpBook.Controls.Add(this.label14);
            this.grpBook.Enabled = false;
            this.grpBook.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBook.Location = new System.Drawing.Point(0, 148);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(707, 337);
            this.grpBook.TabIndex = 37;
            this.grpBook.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Location = new System.Drawing.Point(513, 280);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(141, 36);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(21, 293);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(331, 23);
            this.txtISBN.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "ISBN";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(513, 241);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(141, 23);
            this.txtQuantity.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(362, 241);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(141, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPublisher.Location = new System.Drawing.Point(21, 241);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(331, 23);
            this.txtPublisher.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(21, 105);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(668, 107);
            this.txtDescription.TabIndex = 3;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(358, 53);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(331, 23);
            this.txtAuthor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(358, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 23);
            this.label10.TabIndex = 25;
            this.label10.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 24;
            this.label4.Text = "Publisher";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 23);
            this.label12.TabIndex = 23;
            this.label12.Text = "Description";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(354, 27);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 23);
            this.label13.TabIndex = 22;
            this.label13.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(21, 53);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(331, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 23);
            this.label14.TabIndex = 20;
            this.label14.Text = "Title";
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(200)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(707, 487);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuHeader);
            this.Name = "frmUpdateBook";
            this.Text = "frmUpdateBook";
            this.mnuHeader.ResumeLayout(false);
            this.mnuHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuHeader;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label14;
    }
}