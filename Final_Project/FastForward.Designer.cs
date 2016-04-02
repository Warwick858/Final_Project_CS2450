namespace Final_Project
{
    partial class FastForward
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastForward));
            this.calendarFF = new System.Windows.Forms.MonthCalendar();
            this.instructionsLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calendarFF
            // 
            this.calendarFF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarFF.Location = new System.Drawing.Point(9, 102);
            this.calendarFF.Margin = new System.Windows.Forms.Padding(0);
            this.calendarFF.MaxSelectionCount = 1;
            this.calendarFF.Name = "calendarFF";
            this.calendarFF.ShowToday = false;
            this.calendarFF.ShowTodayCircle = false;
            this.calendarFF.TabIndex = 0;
            this.calendarFF.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendarFF_DateChanged);
            // 
            // instructionsLbl
            // 
            this.instructionsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.instructionsLbl.AutoSize = true;
            this.instructionsLbl.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLbl.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLbl.ForeColor = System.Drawing.Color.Black;
            this.instructionsLbl.Location = new System.Drawing.Point(27, 12);
            this.instructionsLbl.Name = "instructionsLbl";
            this.instructionsLbl.Size = new System.Drawing.Size(246, 87);
            this.instructionsLbl.TabIndex = 16;
            this.instructionsLbl.Text = "Select the Date Below\r\nThat Should Represent\r\n\"Today\"";
            this.instructionsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FastForward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 306);
            this.Controls.Add(this.instructionsLbl);
            this.Controls.Add(this.calendarFF);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FastForward";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Fast-Forward";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label instructionsLbl;
        public System.Windows.Forms.MonthCalendar calendarFF;
    }
}