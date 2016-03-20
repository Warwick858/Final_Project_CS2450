using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Final_Project
{
    public enum TYPE_PATRON { ADULT, CHILD };
    [Serializable]
    public class Patron
    {
        //Data Members:
        [XmlElement]
        public string uniqueId;
        [XmlElement]
        public string name;
        [XmlElement]
        public TYPE_PATRON type;
        [XmlElement]
        public int maxBooks;
        [XmlArray]
        public List<string> myBooks;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Patron()
        {
            uniqueId = Guid.NewGuid().ToString();
            name = "";
            type = TYPE_PATRON.ADULT;
            maxBooks = 6;
            myBooks = new List<string>();
        } // end default constructor

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        public Patron(string _name, TYPE_PATRON _type, List<string> _myBooks)
        {
            uniqueId = Guid.NewGuid().ToString();
            name = _name;
            type = _type;
            if (_type == TYPE_PATRON.ADULT)
                maxBooks = 6;
            else
                maxBooks = 3;
            myBooks = _myBooks == null ? new List<string>() : _myBooks;
        } // end parameterized constructor

        //The getName method
        //Purpose: To return the value of name
        //Parameters: None
        //Return: name in the form of a string
        public string getName()
        {
            return name;
        } // end method getName()

        //The getType method
        //Purpose: To return the value of type
        //Parameters: None
        //Return: type in the form of a string
        public TYPE_PATRON getType()
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
            // linq expression to get books pointers
            return (List<Book>)Library.getInstance().books.Where(x => myBooks.Exists(y => y == x.uniqueId));
        } // end method getMyBooks()

        //The setName method
        //Purpose: To set name to the given value
        //Parameters: A string represented as _name
        //Return: None
        public void setName(string _name)
        {
            name = _name;
        } // end method setName()

        //The setType method
        //Purpose: To set type to the given value
        //Parameters: A string represented as _type
        //Return: None
        public void setType(TYPE_PATRON _type)
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
        public void setMyBooks(List<string> _myBooks)
        {
            myBooks = _myBooks;
        } // end method setMyBooks()

        //The addBook method
        //Purpose: To add the given book to this Patron's myBooks list
        //Parameters: A Book object represented as _book
        //Return: None
        public void addBook(Book _book)
        {
            myBooks.Add(_book.uniqueId);
            //  set the book as check out for that patron and checked out to true
            Library.getInstance().books.First(x => x.uniqueId == _book.uniqueId).rentedBy = uniqueId;
            Library.getInstance().books.First(x => x.uniqueId == _book.uniqueId).checkedOut = true;
        } // end method addBook()

        //The removeBooks method
        //Purpose: To remove the given book from this Patron's myBooks list
        //Parameters: A Book object represented as _book
        //Return: None
        public void removeBook(string _book)
        {
            myBooks.Remove(_book);
        } // end method removeBooks()



    } // end class Patron
} // end namespace Final_Project
