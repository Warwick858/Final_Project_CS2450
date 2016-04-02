using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

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
        //public Account()
        //{
        //    InitializeComponent();
        //} // end default constructor

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        public Account(Patron _patron)
        {
            InitializeComponent();

            patron = _patron;
        } // end parameterized constructor

        //The Account_Load method
        //Purpose: To load the current patron's myBooks data
        //Parameters: The object generating the event and the event args
        //Return: None
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
                    currentBooksListBox.Items.Add(book.getTitle() + " - Due: " + book.getDueDate().ToShortDateString());
                } // end foreach
            } // end if
        } // end method Account_Load()

        //The returnBtn_Click method
        //Purpose: To move the selected books from currentBooks list box to returningBooks list books
        //Parameters: The object generating the event and the event args
        //Return: None
        private void returnBtn_Click(object sender, EventArgs e)
        {
            //Initialize list of strings to hold returning selections
            List<string> switchOver = new List<string>();

            //Foreach selection in currentBooksListBox
            foreach (string item in currentBooksListBox.SelectedItems)
            {
                switchOver.Add(item);
            } // end foreach

            foreach (string item in switchOver)
            {
                //Add selection to returning list box
                returningBooksListBox.Items.Add(item);

                //Remove selection from current books list box
                currentBooksListBox.Items.Remove(item);
            } // end foreach
        } // end method returnBtn_Click()

        //The cancelReturnBtn_Click
        //Purpose: To return the books in returningBooks list box back to currentBooks list box
        //Parameters: The object generating the event and the event args
        //Return: None
        private void cancelReturnBtn_Click(object sender, EventArgs e)
        {
            //Initialize list of strings to hold returning selections
            List<string> switchMe = new List<string>();

            //Foreach selection in returningBooksListBox
            foreach (string item in returningBooksListBox.Items)
            {
                switchMe.Add(item);
            } // end foreach

            foreach (string item in switchMe)
            {
                //Add selection to current books list box
                currentBooksListBox.Items.Add(item);

                //Remove selection from returning books list box
                returningBooksListBox.Items.Remove(item);
            } // end foreach
        } // end method cancelReturnBtn_Click

        //The updateBtn_Click method
        //Purpose: To prompt the user to confirm return selections and settle the patron's account
        //Parameters: The object sending the event and the event args
        //Return: None
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //Declare & Initialize helper vars
            string displayMe = "\n\n";

            //Foreach book title in the returningBooks list box
            foreach (string s in returningBooksListBox.Items)
            {
                //Concatenate each book title into one string
                displayMe += s + "\n";
            } // end foreach
                
            //If books have been selected for return
            if (returningBooksListBox.Items.Count != 0)
            {
                //Show MessageBox to have user confirm book returns
                DialogResult result = MessageBox.Show("Are you sure you want to return the following items?: "
                                + displayMe, "Confirm", MessageBoxButtons.YesNo);

                //If user clicked yes
                if (result == DialogResult.Yes)
                {
                    settleAccount();
                } // end if
            } // end for
            else // no books have been selected for return
            {
                //Show MessageBox to inform user they have not selected any books to return
                MessageBox.Show("You have not selected any books to return. ", "No Books To Return");
            } // end else
        } // end method updateBtn_Click()

        //The doneBtn_Click method
        //Purpose: To settle the patrons account and close the account form
        //Parameters: The object sending the event and the event args
        //Return: None
        private void doneBtn_Click(object sender, EventArgs e)
        {
            //Declare & Initialize helper vars
            string displayMe = "\n\n";

            //Foreach book title in the returningBooks list box
            foreach (string s in returningBooksListBox.Items)
            {
                //Concatenate each book title into one string
                displayMe += s + "\n";
            } // end foreach

            //If books have been selected for return
            if (returningBooksListBox.Items.Count != 0)
            {
                //Show MessageBox to have user confirm book returns
                DialogResult result = MessageBox.Show("Are you sure you want to return the following items?: "
                                + displayMe, "Confirm", MessageBoxButtons.YesNo);

                //If user clicked yes
                if (result == DialogResult.Yes)
                {
                    settleAccount();
                } // end if
            } // end for

            //Write to file
            writeData();

            //Close AccountForm
            Close();
        } // end method doneBtn_Click()

        //The settleAccount method
        //Purpose: To remove the selected books from the patrons myBooks list, and change each book objects checkedOut data member to false
        //Parameters: None
        //Return: None
        public void settleAccount()
        {
            //Remove books from patrons myBooks
            //Change book object in library to not checked out
            foreach (string s in returningBooksListBox.Items)
            {
                patron.myBooks.Remove(Library.getInstance().books.First(x => (x.getTitle() + " - Due: " + x.getDueDate().ToShortDateString()) == s).uniqueId);
                Book book = Library.getInstance().books.First(x => (x.getTitle() + " - Due: " + x.getDueDate().ToShortDateString()) == s);
                book.checkedOut = false;
                book.rentedBy = "";
            } // end foreach

            //Clear the returningBooks list box
            returningBooksListBox.Items.Clear();
        } // end method settleAccount()

        //The writeData method
        //Purpose: To write the current instance of Library out to the XML file previously selected
        //Parameters: None
        //Return: None
        private void writeData()
        {
            //Get reference to main form
            MainForm mainForm = System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm;

            //Get XML file path
            string previousFilePath = mainForm.getFilePath();

            //class data member 'filePath' holds a string of the filePath originally opened to read the data.
            //Use filePath var to write data back to same file
            if (previousFilePath != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Library));
                TextWriter text = new StreamWriter(previousFilePath);
                serializer.Serialize(text, Library.getInstance());

                text.Close();
            } // end if
        } // end method writeData()
    } // end class Account
} // end namespace Final_Project
