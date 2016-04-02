using System;
using System.IO;
using System.Windows.Forms;

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
        //Purpose: To call readBooks() and populate the listBoxes with their corresponding data
        //Parameters: None
        //Return: None
        private void readData()
        {
            //Create streamReader object using library.xml
            StreamReader data = new StreamReader(Environment.CurrentDirectory + "/library.xml");

            //Read in XML
            Library.getInstance().readBooks(data);

            //Close the stream
            data.Close();

            //Get instance of Library and save 
            library = Library.getInstance();

            //Populate list boxes with appropriate data
            foreach (Book book in library.getBooks())
            {
                allBooksListBox.Items.Add(book.getTitle());
            } // end foreach
            foreach (Patron patron in library.getPatrons())
            {
                allPatronsListBox.Items.Add(patron.getName());
            } // end foreach
            foreach (Book book in library.getOverdueBooks())
            {
                overdueBooksListBox.Items.Add(book.getTitle());
            } // end foreach
        } // end method readData()

        public void refreshOverdueBooks()
        {
            overdueBooksListBox.Items.Clear();

            foreach (Book book in library.getOverdueBooks())
            {
                overdueBooksListBox.Items.Add(book.getTitle());
            } // end foreach
        }

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
