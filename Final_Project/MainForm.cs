using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

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

        //The setFilePath method
        //Purpose: To set filePath to the given value
        //Parameters: A string represented as _filePath
        //Return: None
        public string getFilePath()
        {
            return filePath;
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

        //The changeTodaysDateToolStripMenuItem_Click method
        //Purpose: To initialize and show the FastForward form
        //Parameters: The object generating the event and the event args
        //Return: None
        private void changeTodaysDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //If FastForward form already exists
            if (Application.OpenForms.OfType<FastForward>().Any())
            {
                //Focus on it
                Application.OpenForms.OfType<FastForward>().First().Focus();
            } // end if
            else // FastForward form does NOT exist
            {
                //Create new FastForward Form and show it
                FastForward fastForward = new FastForward();
                fastForward.Owner = this;
                fastForward.Show();
            } // end else
        } // end method changeTodaysDateToolStripMenuItem_Click()

        //The adminPicBox_Click method
        //Purpose: To instantiate and show the AdminForm
        //Parameters: The object generating the event and the event args
        //Return: None
        private void adminPicBox_Click(object sender, EventArgs e)
        {
            //Create new instance of AdminForm & show it
            Admin admin = new Admin();
            admin.Owner = this;
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
            rentBook.Owner = this;
            rentBook.Show();
        } // end method rentPicBox_Click()

        //The accountPicBox_Click method
        //Purpose: To instantiate and show the AccountForm
        //Parameters: The object generating the event and the event args
        //Return: None
        private void accountPicBox_Click(object sender, EventArgs e)
        {
            if (Library.getInstance().patrons.Count == 0)
            {
                //Create streamReader object using library.xml
                StreamReader data = new StreamReader(Environment.CurrentDirectory + "/library.xml");

                //Read in XML data
                Library.getInstance().readBooks(data);

                //Close the stream
                data.Close();
            } // end if

            //Create new instance of SelectPatron and show it
            SelectPatron sp = new SelectPatron();
            DialogResult dr = sp.ShowDialog();

            //If a patron was selected
            if (dr == DialogResult.OK)
            {
                Patron patron = Library.getInstance().patrons.First(x => x.uniqueId == sp.currentPatronID);

                //Create new instance of AccountForm & show it
                Account account = new Account(patron);
                account.Owner = this;
                account.Show();
            } // end if
        } // end method accountPicBox_Click()

        //The MainForm_FormClosing method
        //Purpose: To write any changes back to XML file
        //Parameters: The object generating the event and the event args
        //Return: None
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //class data member 'filePath' holds a string of the filePath originally opened to read the data.
            //Use filePath var to write data back to same file
            if (filePath != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Library));
                TextWriter text = new StreamWriter(filePath);
                serializer.Serialize(text, Library.getInstance());

                text.Close();
            } // end if
        } // end method MainForm_FormClosing()
    } // end class MainForm
} // end namespace Final_Project
