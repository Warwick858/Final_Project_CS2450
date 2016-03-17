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
            this.overdueBooksListBox = new System.Windows.Forms.ListBox();
            this.overdueBooksLbl = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // overdueBooksListBox
            // 
            this.overdueBooksListBox.FormattingEnabled = true;
            this.overdueBooksListBox.ItemHeight = 16;
            this.overdueBooksListBox.Location = new System.Drawing.Point(153, 108);
            this.overdueBooksListBox.Name = "overdueBooksListBox";
            this.overdueBooksListBox.Size = new System.Drawing.Size(834, 452);
            this.overdueBooksListBox.TabIndex = 0;
            // 
            // overdueBooksLbl
            // 
            this.overdueBooksLbl.AutoSize = true;
            this.overdueBooksLbl.BackColor = System.Drawing.Color.Transparent;
            this.overdueBooksLbl.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overdueBooksLbl.ForeColor = System.Drawing.Color.Black;
            this.overdueBooksLbl.Location = new System.Drawing.Point(425, 28);
            this.overdueBooksLbl.Name = "overdueBooksLbl";
            this.overdueBooksLbl.Size = new System.Drawing.Size(291, 57);
            this.overdueBooksLbl.TabIndex = 7;
            this.overdueBooksLbl.Text = "Overdue Books";
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
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 635);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.overdueBooksLbl);
            this.Controls.Add(this.overdueBooksListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox overdueBooksListBox;
        private System.Windows.Forms.Label overdueBooksLbl;
        private System.Windows.Forms.Button doneBtn;
    }
}