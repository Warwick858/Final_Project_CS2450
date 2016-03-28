using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace Final_Project
{
    public partial class Admin : Form
    {
        //Data Members:
        private Library library;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Admin()
        {
            InitializeComponent();

            readData();
        } // end default constructor

        //The readData method
        //Purpose:
        //Parameters:
        //Return: None
        public void readData()
        {
            //Create streamReader object using library.xml
            StreamReader data = new StreamReader(Environment.CurrentDirectory + "/library.xml");

            //Read in XML
            Library.getInstance().readBooks(data);

            //Get instance of Library and save 
            library = Library.getInstance();

            foreach (Book book in library.getBooks())
            {
                allBooksListBox.Items.Add(book.getTitle());
            }

            foreach (Patron patron in library.getPatrons())
            {
                allPatronsListBox.Items.Add(patron.getName());
            }

            foreach (Book book in library.getOverdueBooks())
            {
                overdueBooksListBox.Items.Add(book.getTitle());
            }


        } // end method readData()

        //The doneBtn_Click method
        //Purpose: To terminate the application and close the program
        //Parameters: The object generating the event and the event args
        //Return: None
        private void doneBtn_Click(object sender, EventArgs e)
        {
            //Close the AdminForm
            Close();
        } // end method doneBtn_Click()
    } // end class Admin
} // end namespace Final_Project
