namespace Final_Project
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            this.patronNameLbl = new System.Windows.Forms.Label();
            this.patronLbl = new System.Windows.Forms.Label();
            this.accountSummaryLbl = new System.Windows.Forms.Label();
            this.doneBtn = new System.Windows.Forms.Button();
            this.currentBooksListBox = new System.Windows.Forms.ListBox();
            this.returnItemsLbl = new System.Windows.Forms.Label();
            this.returningBooksListBox = new System.Windows.Forms.ListBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.cancelReturnBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patronNameLbl
            // 
            this.patronNameLbl.AutoSize = true;
            this.patronNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.patronNameLbl.Font = new System.Drawing.Font("DengXian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronNameLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.patronNameLbl.Location = new System.Drawing.Point(285, 118);
            this.patronNameLbl.Name = "patronNameLbl";
            this.patronNameLbl.Size = new System.Drawing.Size(188, 24);
            this.patronNameLbl.TabIndex = 46;
            this.patronNameLbl.Text = "Place Holder Text";
            // 
            // patronLbl
            // 
            this.patronLbl.AutoSize = true;
            this.patronLbl.BackColor = System.Drawing.Color.Transparent;
            this.patronLbl.Font = new System.Drawing.Font("DengXian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.patronLbl.Location = new System.Drawing.Point(196, 118);
            this.patronLbl.Name = "patronLbl";
            this.patronLbl.Size = new System.Drawing.Size(83, 24);
            this.patronLbl.TabIndex = 43;
            this.patronLbl.Text = "Patron:";
            // 
            // accountSummaryLbl
            // 
            this.accountSummaryLbl.AutoSize = true;
            this.accountSummaryLbl.BackColor = System.Drawing.Color.Transparent;
            this.accountSummaryLbl.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSummaryLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.accountSummaryLbl.Location = new System.Drawing.Point(141, 53);
            this.accountSummaryLbl.Name = "accountSummaryLbl";
            this.accountSummaryLbl.Size = new System.Drawing.Size(348, 57);
            this.accountSummaryLbl.TabIndex = 41;
            this.accountSummaryLbl.Text = "Account Summary";
            // 
            // doneBtn
            // 
            this.doneBtn.BackColor = System.Drawing.Color.Black;
            this.doneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.doneBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.doneBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.doneBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doneBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneBtn.ForeColor = System.Drawing.Color.White;
            this.doneBtn.Location = new System.Drawing.Point(991, 554);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(105, 41);
            this.doneBtn.TabIndex = 70;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // currentBooksListBox
            // 
            this.currentBooksListBox.BackColor = System.Drawing.Color.DarkRed;
            this.currentBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentBooksListBox.ForeColor = System.Drawing.Color.White;
            this.currentBooksListBox.FormattingEnabled = true;
            this.currentBooksListBox.ItemHeight = 25;
            this.currentBooksListBox.Location = new System.Drawing.Point(93, 171);
            this.currentBooksListBox.Name = "currentBooksListBox";
            this.currentBooksListBox.Size = new System.Drawing.Size(394, 304);
            this.currentBooksListBox.TabIndex = 71;
            // 
            // returnItemsLbl
            // 
            this.returnItemsLbl.AutoSize = true;
            this.returnItemsLbl.BackColor = System.Drawing.Color.Transparent;
            this.returnItemsLbl.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnItemsLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.returnItemsLbl.Location = new System.Drawing.Point(713, 53);
            this.returnItemsLbl.Name = "returnItemsLbl";
            this.returnItemsLbl.Size = new System.Drawing.Size(260, 57);
            this.returnItemsLbl.TabIndex = 72;
            this.returnItemsLbl.Text = "Return Items";
            // 
            // returningBooksListBox
            // 
            this.returningBooksListBox.BackColor = System.Drawing.Color.DarkRed;
            this.returningBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returningBooksListBox.ForeColor = System.Drawing.Color.White;
            this.returningBooksListBox.FormattingEnabled = true;
            this.returningBooksListBox.ItemHeight = 25;
            this.returningBooksListBox.Location = new System.Drawing.Point(657, 171);
            this.returningBooksListBox.Name = "returningBooksListBox";
            this.returningBooksListBox.Size = new System.Drawing.Size(394, 304);
            this.returningBooksListBox.TabIndex = 73;
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.Black;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.returnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(519, 237);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(105, 41);
            this.returnBtn.TabIndex = 74;
            this.returnBtn.Text = "Return";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.Black;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(839, 554);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(105, 41);
            this.updateBtn.TabIndex = 75;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // cancelReturnBtn
            // 
            this.cancelReturnBtn.BackColor = System.Drawing.Color.Black;
            this.cancelReturnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelReturnBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cancelReturnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.cancelReturnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelReturnBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelReturnBtn.ForeColor = System.Drawing.Color.White;
            this.cancelReturnBtn.Location = new System.Drawing.Point(519, 367);
            this.cancelReturnBtn.Name = "cancelReturnBtn";
            this.cancelReturnBtn.Size = new System.Drawing.Size(105, 41);
            this.cancelReturnBtn.TabIndex = 76;
            this.cancelReturnBtn.Text = "Cancel";
            this.cancelReturnBtn.UseVisualStyleBackColor = false;
            this.cancelReturnBtn.Click += new System.EventHandler(this.cancelReturnBtn_Click);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.backgroundlow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 635);
            this.Controls.Add(this.cancelReturnBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.returningBooksListBox);
            this.Controls.Add(this.returnItemsLbl);
            this.Controls.Add(this.currentBooksListBox);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.patronNameLbl);
            this.Controls.Add(this.patronLbl);
            this.Controls.Add(this.accountSummaryLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label patronNameLbl;
        private System.Windows.Forms.Label patronLbl;
        private System.Windows.Forms.Label accountSummaryLbl;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.ListBox currentBooksListBox;
        private System.Windows.Forms.Label returnItemsLbl;
        private System.Windows.Forms.ListBox returningBooksListBox;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button cancelReturnBtn;
    }
}