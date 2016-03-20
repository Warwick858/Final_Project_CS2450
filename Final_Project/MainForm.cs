using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Final_Project
{
    public partial class MainForm : Form
    {
        //Date Members:
        private string filePath;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public MainForm()
        {
            InitializeComponent();
        } // end default constructor

        //The setFilePath method
        //Purpose: To set filePath to the given value
        //Parameters: A string represented as _filePath
        //Return: None
        public void setFilePath(string _filePath)
        {
            filePath = _filePath;
        } // end method setFilePath()

        //The aboutToolStripMenuItem_Click method
        //Purpose: To display a MessageBox with application authors and details
        //Parameters: The object generating the event and the event args
        //Return: None
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CS2450 Final Project \nC# Group 2 \n\nTeam Members: \n\t• Jennifer Rivera - Project Manager "
                            + "\n\t• James LoForti - Designer/Developer \n\t• Zack Broadhead - Designer/Developer \n\t• Benjamin Dixon - Tester/Developer ", "About");
        } // end method aboutToolStripMenuItem_Click()

        //The closeToolStripMenuItem_Click method
        //Purpose: To terminate the application and close the program
        //Parameters: The object generating the event and the event args
        //Return: None
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close the application
            Close();
        } // end method closeToolStripMenuItem_Click()

        //The adminPicBox_Click method
        //Purpose: To instantiate and show the AdminForm
        //Parameters: The object generating the event and the event args
        //Return: None
        private void adminPicBox_Click(object sender, EventArgs e)
        {
            //Create new instance of AdminForm & show it
            Admin admin = new Admin();
            admin.Show();
        } // end method adminPicBox_Click()

        //The rentPicBox_Click method
        //Purpose: To instantiate and show the RentBookForm
        //Parameters: The object generating the event and the event args
        //Return: None
        private void rentPicBox_Click(object sender, EventArgs e)
        {
            //Create new instance of RentBookForm & show it
            RentBook rentBook = new RentBook();
            rentBook.Show();
        } // end method rentPicBox_Click()

        //The accountPicBox_Click method
        //Purpose: To instantiate and show the AccountForm
        //Parameters: The object generating the event and the event args
        //Return: None
        private void accountPicBox_Click(object sender, EventArgs e)
        {
            //Create new instance of AccountForm & show it
            Account account = new Account();
            account.Show();
        } // end method accountPicBox_Click()

        //The MainForm_FormClosing method
        //Purpose:
        //Parameters: The object generating the event and the event args
        //Return: None
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //class data member 'filePath' holds a string of the filePath originally opened to read the data.
            //Use filePath var to write data back to same file

            // zreview

            if (filePath != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Library));
                TextWriter text = new StreamWriter(filePath);
                serializer.Serialize(text, Library.getInstance());
            }

        } // end method MainForm_FormClosing()
    } // end class MainForm
} // end namespace Final_Project
