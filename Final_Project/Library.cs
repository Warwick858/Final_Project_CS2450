using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Library
    {
        //Data Members:
        private string name;
        private List<Book> books;
        private List<Book> overdueBooks;
        private List<Patron> patrons;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Library()
        {
            name = "";
            books = new List<Book>();
            overdueBooks = new List<Book>();
            patrons = new List<Patron>();
        } // end default constructor

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        public Library(string _name, List<Book> _books, List<Book> _overdueBooks, List<Patron> _patrons)
        {
            name = _name;
            books = _books;
            overdueBooks = _overdueBooks;
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
            return overdueBooks;
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
        public void readBooks(StreamReader _data)
        {

        } // end method readBooks()




    } // end class Library
} // end namespace Final_Project
