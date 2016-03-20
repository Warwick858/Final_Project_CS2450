using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //  Static method to get instance of singleton
        //  returns library object
        public static Library getInstance()
        {
            if (instance == null)
                instance = new Library();
            return instance;
        }

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
            //  This is a Linq and lambda expression that gets a list of all the pointers to the overdue books
            //return (List<Book>)books.Where(x => overdueBooks.Exists(y => y == x.uniqueId));
            return (List<Book>)books.Where(x => x.getDueDate().CompareTo(DateTime.Today) < 0);  // zreview (change date to virtual date later)
        } // end method getOverdueBooks()

        //The getPatrons method
        //Purpose: To return the list of patrons
        //Parameters: None
        //Return: patrons in the form of a List of Patron objects
        public List<Patron> getPatrons()
        {
            return patrons;
        } // end method getPatrons()

        //The readBooks method
        //Purpose: To read books from file and save as books
        //Parameters: A StreamReader object represented as _data
        //Return: None
        public bool readBooks(StreamReader _data)
        {
            // zreview
            try
            {
                //Library myLib = Library.getInstance();
                XmlSerializer xs = new XmlSerializer(typeof(Library));
                TextReader tr = _data;
                instance = (Library)xs.Deserialize(tr);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        } // end method readBooks()




    } // end class Library
} // end namespace Final_Project
