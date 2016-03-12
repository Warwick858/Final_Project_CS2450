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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        } // end method MainForm_Load()

        private void adminPicBox_Click(object sender, EventArgs e)
        {

        } // end method adminPicBox_Click()

        private void rentPicBox_Click(object sender, EventArgs e)
        {
            RentBook rentBook = new RentBook();

            rentBook.Show();
        } // end method rentPicBox_Click()

        private void accountPicBox_Click(object sender, EventArgs e)
        {

        } // end method accountPicBox_Click()
    } // end class MainForm
} // end namespace Final_Project
