namespace Final_Project
{
    partial class SelectPatron
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPatron));
            this.choosePatronLbl = new System.Windows.Forms.Label();
            this.patronListBox = new System.Windows.Forms.CheckedListBox();
            this.doneBtn = new System.Windows.Forms.Button();
            this.selectedPatronNameLbl = new System.Windows.Forms.Label();
            this.selectedPatronLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choosePatronLbl
            // 
            this.choosePatronLbl.AutoSize = true;
            this.choosePatronLbl.BackColor = System.Drawing.Color.Transparent;
            this.choosePatronLbl.Font = new System.Drawing.Font("Monotype Corsiva", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosePatronLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.choosePatronLbl.Location = new System.Drawing.Point(163, 51);
            this.choosePatronLbl.Name = "choosePatronLbl";
            this.choosePatronLbl.Size = new System.Drawing.Size(280, 57);
            this.choosePatronLbl.TabIndex = 13;
            this.choosePatronLbl.Text = "Choose Patron";
            // 
            // patronListBox
            // 
            this.patronListBox.BackColor = System.Drawing.Color.DarkRed;
            this.patronListBox.CheckOnClick = true;
            this.patronListBox.ColumnWidth = 165;
            this.patronListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patronListBox.ForeColor = System.Drawing.Color.White;
            this.patronListBox.FormattingEnabled = true;
            this.patronListBox.Location = new System.Drawing.Point(81, 138);
            this.patronListBox.MultiColumn = true;
            this.patronListBox.Name = "patronListBox";
            this.patronListBox.Size = new System.Drawing.Size(445, 354);
            this.patronListBox.Sorted = true;
            this.patronListBox.TabIndex = 14;
            this.patronListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.patronListBox_ItemCheck);
            this.patronListBox.SelectedIndexChanged += new System.EventHandler(this.patronListBox_SelectedIndexChanged);
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
            this.doneBtn.Location = new System.Drawing.Point(988, 557);
            this.doneBtn.Name = "doneBtn";
            this.doneBtn.Size = new System.Drawing.Size(105, 41);
            this.doneBtn.TabIndex = 15;
            this.doneBtn.Text = "Done";
            this.doneBtn.UseVisualStyleBackColor = false;
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
            // 
            // selectedPatronNameLbl
            // 
            this.selectedPatronNameLbl.AutoSize = true;
            this.selectedPatronNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.selectedPatronNameLbl.Font = new System.Drawing.Font("DengXian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPatronNameLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.selectedPatronNameLbl.Location = new System.Drawing.Point(695, 221);
            this.selectedPatronNameLbl.Name = "selectedPatronNameLbl";
            this.selectedPatronNameLbl.Size = new System.Drawing.Size(0, 40);
            this.selectedPatronNameLbl.TabIndex = 17;
            this.selectedPatronNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectedPatronLbl
            // 
            this.selectedPatronLbl.AutoSize = true;
            this.selectedPatronLbl.BackColor = System.Drawing.Color.Transparent;
            this.selectedPatronLbl.Font = new System.Drawing.Font("DengXian", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPatronLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.selectedPatronLbl.Location = new System.Drawing.Point(686, 170);
            this.selectedPatronLbl.Name = "selectedPatronLbl";
            this.selectedPatronLbl.Size = new System.Drawing.Size(277, 40);
            this.selectedPatronLbl.TabIndex = 16;
            this.selectedPatronLbl.Text = "Selected Patron:";
            // 
            // SelectPatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Final_Project.Properties.Resources.backgroundlow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1141, 635);
            this.Controls.Add(this.selectedPatronNameLbl);
            this.Controls.Add(this.selectedPatronLbl);
            this.Controls.Add(this.doneBtn);
            this.Controls.Add(this.patronListBox);
            this.Controls.Add(this.choosePatronLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SelectPatron";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPatron";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choosePatronLbl;
        private System.Windows.Forms.CheckedListBox patronListBox;
        private System.Windows.Forms.Button doneBtn;
        private System.Windows.Forms.Label selectedPatronNameLbl;
        private System.Windows.Forms.Label selectedPatronLbl;
    }
}