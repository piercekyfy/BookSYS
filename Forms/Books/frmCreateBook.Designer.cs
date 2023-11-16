namespace BookSYS.Forms.Books
{
    partial class frmCreateBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mnuCreateBook.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuCreateBook
            // 
            this.mnuCreateBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuCreateBook.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBook.Name = "mnuCreateBook";
            this.mnuCreateBook.Size = new System.Drawing.Size(390, 24);
            this.mnuCreateBook.TabIndex = 0;
            this.mnuCreateBook.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Create Book";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.txtISBN);
            this.grpBook.Controls.Add(this.label3);
            this.grpBook.Controls.Add(this.btnSubmit);
            this.grpBook.Controls.Add(this.txtQuantity);
            this.grpBook.Controls.Add(this.txtPrice);
            this.grpBook.Controls.Add(this.txtPageCount);
            this.grpBook.Controls.Add(this.txtDescription);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.label10);
            this.grpBook.Controls.Add(this.label11);
            this.grpBook.Controls.Add(this.label12);
            this.grpBook.Controls.Add(this.label13);
            this.grpBook.Controls.Add(this.txtTitle);
            this.grpBook.Controls.Add(this.label14);
            this.grpBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBook.Location = new System.Drawing.Point(17, 72);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(356, 371);
            this.grpBook.TabIndex = 18;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Details";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(196, 337);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 29);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Create";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(117, 276);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(69, 26);
            this.txtQuantity.TabIndex = 31;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(117, 244);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(69, 26);
            this.txtPrice.TabIndex = 30;
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(117, 212);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(69, 26);
            this.txtPageCount.TabIndex = 29;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(10, 127);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(340, 79);
            this.txtDescription.TabIndex = 28;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(117, 64);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(211, 26);
            this.txtAuthor.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(16, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "Quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(16, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 22);
            this.label10.TabIndex = 25;
            this.label10.Text = "Price:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label11.Location = new System.Drawing.Point(16, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 24;
            this.label11.Text = "Page #:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label12.Location = new System.Drawing.Point(16, 102);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 22);
            this.label12.TabIndex = 23;
            this.label12.Text = "Description:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label13.Location = new System.Drawing.Point(16, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 22);
            this.label13.TabIndex = 22;
            this.label13.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(117, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 26);
            this.txtTitle.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label14.Location = new System.Drawing.Point(16, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 22);
            this.label14.TabIndex = 20;
            this.label14.Text = "Title:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(117, 309);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(133, 26);
            this.txtISBN.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(16, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 33;
            this.label3.Text = "ISBN:";
            // 
            // frmCreateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 455);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mnuCreateBook);
            this.MainMenuStrip = this.mnuCreateBook;
            this.Name = "frmCreateBook";
            this.Text = "CreateBook";
            this.mnuCreateBook.ResumeLayout(false);
            this.mnuCreateBook.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuCreateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label3;
    }
}