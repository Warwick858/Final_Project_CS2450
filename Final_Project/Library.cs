using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Final_Project
{
    [XmlRoot]
    public class Library
    {
        //Data Members:
        private static Library instance;

        [XmlElement]
        public string name;

        [XmlArray]
        public List<Book> books;

        //[XmlArray]
        //List<string> overdueBooks;

        [XmlArray]
        public List<Patron> patrons;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        private Library()
        {
            name = "";
            books = new List<Book>();
            //overdueBooks = new List<string>();
            patrons = new List<Patron>();
        } // end default constructor

        //The getInstance method
        //Purpose: To create a new instance of Library if it doesn't already exist, else return existing instance
        //Parameters: None
        //Return: instance in the form of a Library object
        public static Library getInstance()
        {
            //If Library instance does NOT exist
            if (instance == null)
            {
                instance = new Library(); // create new instance and save
            } // end if
                
            return instance;
        } // end method getInstance()

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        private Library(string _name, List<Book> _books, List<string> _overdueBooks, List<Patron> _patrons)
        {
            name = _name;
            books = _books;
            //overdueBooks = _overdueBooks;
            patrons = _patrons;
        } // end parameterized constructor

        //The getName method
        //Purpose: To return the value of name
        //Parameters: None
        //Return: name in the form of a string
        public string getName()
        {
            return name;
        } // end method getName()

        //The getBooks method
        //Purpose: To return the list of books
        //Parameters: None
        //Return: books in the form of a List of Book objects
        public List<Book> getBooks()
        {
            return books;
        } // end method getBooks()

        //The getOverdueBooks method
        //Purpose: To return the list of overdue books
        //Parameters: None
        //Return: overdueBooks in the form of a List of Book objects
        public List<Book> getOverdueBooks()
        {
            //return (List<Book>)books.Where(x => overdueBooks.Exists(y => y == x.uniqueId));

            DateTime currentDate = getCurrentDate();

            return books.Where(x => x.getDueDate().Date.CompareTo(currentDate.Date) < 0).ToList<Book>();  // zreview (change date to virtual date later)

            //Use Linq and lambda expression to get a list of all the overdue books
            //return books.Where(x => x.getDueDate() > currentDate).ToList<Book>();  // zreview (change date to virtual date later)
        } // end method getOverdueBooks()

        //The getPatrons method
        //Purpose: To return the list of patrons
        //Parameters: None
        //Return: patrons in the form of a List of Patron objects
        public List<Patron> getPatrons()
        {
            return patrons;
        } // end method getPatrons()

        //The getCurrentDate method
        //Purpose: To return the selected date from the fastforward form, or todays date is fastforward form is null
        //Parameters: None
        //Return: currentDate in the form of a DateTime object
        public DateTime getCurrentDate()
        {
            //Initialize currentDate to Now
            DateTime currentDate = DateTime.Now;

            //If FastForward form exists
            if (Application.OpenForms.OfType<FastForward>().Any())
            {
                //Get a reference to the form
                FastForward fastForward = Application.OpenForms.OfType<FastForward>().First();

                //Get the calendarFF control's selected date
                currentDate = fastForward.calendarFF.SelectionRange.Start;
            } // end if

            return currentDate;
        } // end method getCurrentDate()

        //The readBooks method
        //Purpose: To read books from file and save as books
        //Parameters: A StreamReader object represented as _data
        //Return: None
        public bool readBooks(StreamReader _data)
        {
            try
            {
                //Create new XmlSerializer using Library as type
                XmlSerializer xs = new XmlSerializer(typeof(Library));

                //Save streamReader as textReader object
                TextReader textReader = _data;

                //Deserialize XML Library using textReader and save
                instance = (Library)xs.Deserialize(textReader);
            } // end try
            catch (Exception e)
            {
                return false;
            } // end catch

            return true;
        } // end method readBooks()
    } // end class Library
} // end namespace Final_Project
