using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Patron
    {
        //Data Members:
        private string type;
        private int maxBooks;
        private List<Book> myBooks;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Patron()
        {
            type = "";
            maxBooks = 0;
            myBooks = new List<Book>();
        } // end default constructor

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        public Patron(string _type, int _maxBooks, List<Book> _myBooks)
        {
            type = _type;
            maxBooks = _maxBooks;
            myBooks = _myBooks;
        } // end parameterized constructor

        //The getType method
        //Purpose: To return the value of type
        //Parameters: None
        //Return: type in the form of a string
        public string getType()
        {
            return type;
        } // end method getType()

        //The getMaxBooks method
        //Purpose: To return the value of maxBooks
        //Parameters: None
        //Return: maxBooks in the form of an int
        public int getMaxBooks()
        {
            return maxBooks;
        } // end method getMaxBooks()

        //The getMyBooks method
        //Purpose: To return the list of myBooks
        //Parameters: None
        //Return: myBooks in the form of a List of Book objects
        public List<Book> getMyBooks()
        {
            return myBooks;
        } // end method getMyBooks()

        //The setType method
        //Purpose: To set type to the given value
        //Parameters: A string represented as _type
        //Return: None
        public void setType(string _type)
        {
            type = _type;
        } // end method setType

        //The setMaxBooks method
        //Purpose: To set type to the given value
        //Parameters: An int represented as _maxBooks
        //Return: None
        public void setMaxBooks(int _maxBooks)
        {
            maxBooks = _maxBooks;
        } // end method setMaxBooks()

        //The setMyBooks method
        //Purpose: To set myBooks to the given list
        //Parameters: A List of Book objects represented as _myBooks
        //Return: None
        public void setMyBooks(List<Book> _myBooks)
        {
            myBooks = _myBooks;
        } // end method setMyBooks()

        //The addBook method
        //Purpose: To add the given book to this Patron's myBooks list
        //Parameters: A Book object represented as _book
        //Return: None
        public void addBook(Book _book)
        {
            myBooks.Add(_book);
        } // end method addBook()

        //The removeBooks method
        //Purpose: To remove the given book from this Patron's myBooks list
        //Parameters: A Book object represented as _book
        //Return: None
        public void removeBook(Book _book)
        {
            myBooks.Remove(_book);
        } // end method removeBooks()



    } // end class Patron
} // end namespace Final_Project
