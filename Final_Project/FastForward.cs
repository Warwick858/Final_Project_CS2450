using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FastForward : Form
    {
        public FastForward()
        {
            InitializeComponent();

            //Set form to bottom-left corner
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Bottom - Height);
            TopMost = true;
        } // end default constructor
    } // end class FastForward
} // end namespace Final_Project
