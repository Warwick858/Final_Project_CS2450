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

namespace Final_Project
{
    public partial class Admin : Form
    {
        //Data Members:
        private List<Book> overdueBooks;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Admin()
        {
            //Read overdue books from file
            readData();

            InitializeComponent();
        } // end default constructor

        //The readData method
        //Purpose:
        //Parameters:
        //Return: None
        public void readData()
        {
            //
            StreamReader data = new StreamReader("C://test.txt");



            //overdueBooks = 

            //
            overdueBooksListBox.Items.Add(overdueBooks);
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
