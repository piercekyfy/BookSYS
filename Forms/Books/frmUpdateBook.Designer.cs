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
            this.label1 = new System.Windows.Forms.Label();
            this.mnuCreateBook = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.cboId = new System.Windows.Forms.ComboBox();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTitleSearch = new System.Windows.Forms.TextBox();
            this.ckbAvailable = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mnuCreateBook.SuspendLayout();
            this.grpBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Update Book";
            // 
            // mnuCreateBook
            // 
            this.mnuCreateBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuCreateBook.Location = new System.Drawing.Point(0, 0);
            this.mnuCreateBook.Name = "mnuCreateBook";
            this.mnuCreateBook.Size = new System.Drawing.Size(388, 24);
            this.mnuCreateBook.TabIndex = 3;
            this.mnuCreateBook.Text = "menuStrip1";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(38, 20);
            this.mnuExit.Text = "Exit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.Location = new System.Drawing.Point(207, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID:";
            // 
            // cboId
            // 
            this.cboId.FormattingEnabled = true;
            this.cboId.Location = new System.Drawing.Point(245, 58);
            this.cboId.Name = "cboId";
            this.cboId.Size = new System.Drawing.Size(126, 21);
            this.cboId.TabIndex = 6;
            this.cboId.SelectedIndexChanged += new System.EventHandler(this.cboId_SelectedIndexChanged);
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.label9);
            this.grpBook.Controls.Add(this.ckbAvailable);
            this.grpBook.Controls.Add(this.btnSubmit);
            this.grpBook.Controls.Add(this.txtQuantity);
            this.grpBook.Controls.Add(this.txtPrice);
            this.grpBook.Controls.Add(this.txtPageCount);
            this.grpBook.Controls.Add(this.txtDescription);
            this.grpBook.Controls.Add(this.txtAuthor);
            this.grpBook.Controls.Add(this.label8);
            this.grpBook.Controls.Add(this.label7);
            this.grpBook.Controls.Add(this.label6);
            this.grpBook.Controls.Add(this.label5);
            this.grpBook.Controls.Add(this.label4);
            this.grpBook.Controls.Add(this.txtTitle);
            this.grpBook.Controls.Add(this.label3);
            this.grpBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBook.Location = new System.Drawing.Point(15, 85);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(356, 340);
            this.grpBook.TabIndex = 7;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Update {Title}";
            this.grpBook.Visible = false;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label8.Location = new System.Drawing.Point(16, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label7.Location = new System.Drawing.Point(16, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 22);
            this.label7.TabIndex = 25;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label6.Location = new System.Drawing.Point(16, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Page #:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(16, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 23;
            this.label5.Text = "Description:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(16, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(117, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(211, 26);
            this.txtTitle.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(16, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Title:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(196, 305);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(154, 29);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Update";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label10.Location = new System.Drawing.Point(21, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 22);
            this.label10.TabIndex = 33;
            this.label10.Text = "Title:";
            // 
            // txtTitleSearch
            // 
            this.txtTitleSearch.Location = new System.Drawing.Point(77, 58);
            this.txtTitleSearch.Name = "txtTitleSearch";
            this.txtTitleSearch.Size = new System.Drawing.Size(124, 20);
            this.txtTitleSearch.TabIndex = 34;
            this.txtTitleSearch.TextChanged += new System.EventHandler(this.txtTitleSearch_TextChanged);
            // 
            // ckbAvailable
            // 
            this.ckbAvailable.AutoSize = true;
            this.ckbAvailable.Checked = true;
            this.ckbAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbAvailable.Location = new System.Drawing.Point(117, 312);
            this.ckbAvailable.Name = "ckbAvailable";
            this.ckbAvailable.Size = new System.Drawing.Size(15, 14);
            this.ckbAvailable.TabIndex = 32;
            this.ckbAvailable.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label9.Location = new System.Drawing.Point(16, 308);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 33;
            this.label9.Text = "Available:";
            // 
            // frmUpdateBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 450);
            this.Controls.Add(this.txtTitleSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.cboId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mnuCreateBook);
            this.Controls.Add(this.label1);
            this.Name = "frmUpdateBook";
            this.Text = "frmUpdateBook";
            this.mnuCreateBook.ResumeLayout(false);
            this.mnuCreateBook.PerformLayout();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuCreateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboId;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTitleSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbAvailable;
    }
}