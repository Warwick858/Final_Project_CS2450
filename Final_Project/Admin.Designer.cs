namespace Final_Project
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.libraryDataLbl = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.booksLbl = new System.Windows.Forms.Label();
            this.patronsLbl = new System.Windows.Forms.Label();
            this.overdueBooksLbl = new System.Windows.Forms.Label();
            this.allBooksListBox = new System.Windows.Forms.ListBox();
            this.allPatronsListBox = new System.Windows.Forms.ListBox();
            this.overdueBooksListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // libraryDataLbl
            // 
            this.libraryDataLbl.AutoSize = true;
            this.libraryDataLbl.BackColor = System.Drawing.Color.Transparent;
            this.libraryDataLbl.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libraryDataLbl.ForeColor = System.Drawing.Color.Black;
            this.libraryDataLbl.Location = new System.Drawing.Point(438, 28);
            this.libraryDataLbl.Name = "libraryDataLbl";
            this.libraryDataLbl.Size = new System.Drawing.Size(264, 57);
            this.libraryDataLbl.TabIndex = 7;
            this.libraryDataLbl.Text = "Library Data";
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Black;
            this.doneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(1003, 567);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(105, 41);
            this.doneBtn.TabIndex = 8;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // booksLbl
            // 
            this.booksLbl.AutoSize = true;
            this.booksLbl.BackColor = System.Drawing.Color.Transparent;
            this.booksLbl.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booksLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.booksLbl.Location = new System.Drawing.Point(146, 120);
            this.booksLbl.Name = "booksLbl";
            this.booksLbl.Size = new System.Drawing.Size(97, 34);
            this.booksLbl.TabIndex = 18;
            this.booksLbl.Text = "Books";
            // 
            // patronsLbl
            // 
            this.patronsLbl.AutoSize = true;
            this.patronsLbl.BackColor = System.Drawing.Color.Transparent;
            this.patronsLbl.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronsLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.patronsLbl.Location = new System.Drawing.Point(510, 120);
            this.patronsLbl.Name = "patronsLbl";
            this.patronsLbl.Size = new System.Drawing.Size(118, 34);
            this.patronsLbl.TabIndex = 19;
            this.patronsLbl.Text = "Patrons";
            // 
            // overdueBooksLbl
            // 
            this.overdueBooksLbl.AutoSize = true;
            this.overdueBooksLbl.BackColor = System.Drawing.Color.Transparent;
            this.overdueBooksLbl.Font = new System.Drawing.Font("DengXian", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueBooksLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.overdueBooksLbl.Location = new System.Drawing.Point(833, 120);
            this.overdueBooksLbl.Name = "overdueBooksLbl";
            this.overdueBooksLbl.Size = new System.Drawing.Size(223, 34);
            this.overdueBooksLbl.TabIndex = 20;
            this.overdueBooksLbl.Text = "Overdue Books";
            // 
            // allBooksListBox
            // 
            this.allBooksListBox.BackColor = System.Drawing.Color.DarkRed;
            this.allBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBooksListBox.ForeColor = System.Drawing.Color.White;
            this.allBooksListBox.FormattingEnabled = true;
            this.allBooksListBox.ItemHeight = 25;
            this.allBooksListBox.Location = new System.Drawing.Point(26, 162);
            this.allBooksListBox.Name = "allBooksListBox";
            this.allBooksListBox.Size = new System.Drawing.Size(336, 354);
            this.allBooksListBox.Sorted = true;
            this.allBooksListBox.TabIndex = 21;
            // 
            // allPatronsListBox
            // 
            this.allPatronsListBox.BackColor = System.Drawing.Color.DarkRed;
            this.allPatronsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allPatronsListBox.ForeColor = System.Drawing.Color.White;
            this.allPatronsListBox.FormattingEnabled = true;
            this.allPatronsListBox.ItemHeight = 25;
            this.allPatronsListBox.Location = new System.Drawing.Point(401, 162);
            this.allPatronsListBox.Name = "allPatronsListBox";
            this.allPatronsListBox.Size = new System.Drawing.Size(336, 354);
            this.allPatronsListBox.Sorted = true;
            this.allPatronsListBox.TabIndex = 22;
            // 
            // overdueBooksListBox
            // 
            this.overdueBooksListBox.BackColor = System.Drawing.Color.DarkRed;
            this.overdueBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueBooksListBox.ForeColor = System.Drawing.Color.White;
            this.overdueBooksListBox.FormattingEnabled = true;
            this.overdueBooksListBox.ItemHeight = 25;
            this.overdueBooksListBox.Location = new System.Drawing.Point(776, 162);
            this.overdueBooksListBox.Name = "overdueBooksListBox";
            this.overdueBooksListBox.Size = new System.Drawing.Size(336, 354);
            this.overdueBooksListBox.Sorted = true;
            this.overdueBooksListBox.TabIndex = 23;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 635);
            this.Controls.Add(this.overdueBooksListBox);
            this.Controls.Add(this.allPatronsListBox);
            this.Controls.Add(this.allBooksListBox);
            this.Controls.Add(this.overdueBooksLbl);
            this.Controls.Add(this.patronsLbl);
            this.Controls.Add(this.booksLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.libraryDataLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label libraryDataLbl;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label booksLbl;
        private System.Windows.Forms.Label patronsLbl;
        private System.Windows.Forms.Label overdueBooksLbl;
        private System.Windows.Forms.ListBox allBooksListBox;
        private System.Windows.Forms.ListBox allPatronsListBox;
        private System.Windows.Forms.ListBox overdueBooksListBox;
    }
}