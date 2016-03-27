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

        //The changeTodaysDateToolStripMenuItem_Click method
        //Purpose: To initialize and show the FastForward form
        //Parameters: The object generating the event and the event args
        //Return: None
        private void changeTodaysDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } // end method changeTodaysDateToolStripMenuItem_Click()

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

            #region XML File Generator
            #if false
            Library myLib = Library.getInstance();
            myLib.name = "UVU CS2450 Library";
            //  generate list of names
            StreamReader srNames = new StreamReader("names.txt");
            List<string> fakeNames = new List<string>();
            while (!srNames.EndOfStream)
                fakeNames.Add(Regex.Match(srNames.ReadLine().Trim(), @"[a-zA-Z]*\W+[a-zA-Z]*").Value);
            srNames.Close();
            int inc = 0;
            foreach(string name in fakeNames)
            {
                myLib.patrons.Add(new Patron(name, inc % 2 == 0 ? TYPE_PATRON.ADULT : TYPE_PATRON.CHILD, null));
                inc++;
            }
            //  generate list of books
            StreamReader srBooks = new StreamReader("books.txt");
            List<string> fakeBooks = new List<string>();
            while (!srBooks.EndOfStream)
                fakeBooks.Add(srBooks.ReadLine().Trim());
            srBooks.Close();
            inc = 0;
            foreach(string book in fakeBooks)
            {
                myLib.books.Add(new Book(book, inc % 4 == 0 ? TYPE_BOOK.ADULT : inc % 4 == 1 ? TYPE_BOOK.CHILD : inc % 4 == 2 ? TYPE_BOOK.DVD : TYPE_BOOK.VIDEOTAPE, false, DateTime.MinValue));
                inc++;
            }
            //  adults have 2 weeks from when checked out book
            //  children have 1 week
            //  dvd's are always 2 days
            //  videotapes are always 3 days
            //  children only childrens, adults only adults
            //  adults up to 6 items checked out
            //  children up to 3
            //  
            //  assign checked out items to different patrons at different times following criteria
            for (int x = 0; x < 55; x++)
            {
                if (myLib.books[x].type == TYPE_BOOK.ADULT)
                {
                    if (myLib.patrons[x].type == TYPE_PATRON.ADULT)
                    {
                        myLib.patrons[x].addBook(myLib.books[x]);
                        myLib.books[x].rentBook(myLib.patrons[x], DateTime.Today);
                    }
                    else
                    {

                    }
                }
                else if (myLib.books[x].type == TYPE_BOOK.CHILD)
                {
                    if (myLib.patrons[x].type == TYPE_PATRON.ADULT)
                    {

                    }
                    else
                    {
                        myLib.patrons[x].addBook(myLib.books[x]);
                        myLib.books[x].rentBook(myLib.patrons[x], DateTime.Today);
                    }
                }
                else if (myLib.books[x].type == TYPE_BOOK.DVD)
                {
                    myLib.patrons[x].addBook(myLib.books[x]);
                    myLib.books[x].rentBook(myLib.patrons[x], DateTime.Today);
                }
                else
                {
                    myLib.patrons[x].addBook(myLib.books[x]);
                    myLib.books[x].rentBook(myLib.patrons[x], DateTime.Today);
                }
            }


            //for (int x = 0; x < 5; x++)
            //{
            //    myLib.books.Add(new Book("Book" + x, x % 2 == 0 ? TYPE_BOOK.ADULT : TYPE_BOOK.CHILD, false, DateTime.Today.AddDays(20)));
            //    myLib.books.Add(new Book("Book" + (x + 1) * 5, x % 2 == 0 ? TYPE_BOOK.DVD : TYPE_BOOK.VIDEOTAPE, false, DateTime.Today));
            //    myLib.patrons.Add(new Patron("Patron" + x, x % 2 == 0 ? TYPE_PATRON.ADULT : TYPE_PATRON.CHILD, null));
            //    myLib.patrons[x].addBook(myLib.books[x % 2 == 0 ? x : x + 1]);
            //}

            // make sudo date time class that is completely static

            filePath = "biglibrary.xml";//  adjust hardcoded file path later (remove this line)
#endif
            #endregion
            if (filePath != null)
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Library));
                TextWriter text = new StreamWriter(filePath);
                serializer.Serialize(text, Library.getInstance());
            }

        } // end method MainForm_FormClosing()


    } // end class MainForm
} // end namespace Final_Project
