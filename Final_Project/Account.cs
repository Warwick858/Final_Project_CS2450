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
    partial class Account : Form
    {
        //Data Members:
        private Patron patron;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Account()
        {
            InitializeComponent();
        } // end default constructor

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        public Account(Patron _patron)
        {
            patron = _patron;
        } // end parameterized constructor






    } // end class Account
} // end namespace Final_Project
