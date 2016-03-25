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
            InitializeComponent();

            patron = _patron;
        } // end parameterized constructor

        private void Account_Load(object sender, EventArgs e)
        {
            //If patron exists
            if (patron != null)
            {
                //Set label to patron name
                patronNameLbl.Text = patron.getName();

                //Foreach book the patron has checked out
                foreach (Book book in patron.getMyBooks())
                {
                    //Add it to the currentBooksListBox
                    currentBooksListBox.Items.Add(book.getTitle() + " - Due: " + book.getDueDate());
                } // end foreach
            } // end if
        } // end method Account_Load()

        private void returnBtn_Click(object sender, EventArgs e)
        {
            //Foreach selection in currentBooksListBox
            foreach (string item in currentBooksListBox.SelectedItems)
            {
                //Add selection to returning list box
                returningBooksListBox.Items.Add(item);

                //Remove selection from current books list box
                currentBooksListBox.Items.Remove(item);
            } // end foreach
        } // end method returnBtn_Click()

        private void cancelReturnBtn_Click(object sender, EventArgs e)
        {
            //Foreach selection in returningBooksListBox
            foreach (string item in returningBooksListBox.Items)
            {
                //Add selection to current books list box
                currentBooksListBox.Items.Add(item);

                //Remove selection from returning books list box
                returningBooksListBox.Items.Remove(item);
            } // end foreach
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Show MessageBox to have user confirm book returns
            DialogResult result = MessageBox.Show("Are you sure you want to return the following items?: "
                            + returningBooksListBox.Items.ToString(), "Confirm", MessageBoxButtons.YesNo);

            //If user clicked yes
            if (result == DialogResult.Yes)
            {
                settleAccount();
            } // end if
        } // end method updateBtn_Click()

        private void doneBtn_Click(object sender, EventArgs e)
        {
            //
            settleAccount();

            //Close AccountForm
            Close();
        }

        //The settleAccount method
        //Purpose:
        //Parameters:
        //Return:
        public void settleAccount()
        {
            //Remove books from patrons byBooks
            //Change book object in library to not checked out


        } // end method settleAccount()


    } // end class Account
} // end namespace Final_Project
