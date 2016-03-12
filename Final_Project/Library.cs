using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Library
    {
        //Data Members:
        private List<Book> books;
        private List<Book> overdueBooks;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Library()
        {
            books = new List<Book>();
            overdueBooks = new List<Book>();
        } // end default constructor

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        public Library(List<Book> _books, List<Book> _overdueBooks)
        {
            books = _books;
            overdueBooks = _overdueBooks;
        } // end parameterized constructor

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




    } // end class Library
} // end namespace Final_Project
