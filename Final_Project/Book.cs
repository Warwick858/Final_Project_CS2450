using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Book
    {
        //Data Members:
        private string title;
        private string type;
        private bool checkedOut;
        private Patron rentedBy;
        private DateTime dueDate;

        //The default constructor
        //Purpose: To initialize data members to default values
        //Parameters: None
        //Return: None
        public Book()
        {
            title = "";
            type = "";
            checkedOut = false;
            rentedBy = new Patron();
            dueDate = new DateTime();
        } // end default constructor

        //The parameterized constructor
        //Purpose: To set data members to given values
        //Parameters: 
        //Return: None
        public Book(string _title, string _type, bool _checkedOut, Patron _rentedBy, DateTime _dueDate)
        {
            title = _title;
            type = _type;
            checkedOut = _checkedOut;
            rentedBy = _rentedBy;
            dueDate = _dueDate;
        } // end parameterized constructor

        //The getTitle method
        //Purpose: To return the value of title
        //Parameters: None
        //Return: title in the form of a string
        public string getTitle()
        {
            return title;
        } // end method getTitle()

        //The getType method
        //Purpose: To return the value of type
        //Parameters: None
        //Return: type in the form of a string
        public string getType()
        {
            return type;
        } // end method getType()

        //The getCheckedOut method
        //Purpose: To return the value of checkedOut
        //Parameters: None
        //Return: checkedOut in the form of a bool
        public bool getCheckedOut()
        {
            return checkedOut;
        } // end method getCheckedOut()

        //The getRentedBy method
        //Purpose: To return the value of rentedBy
        //Parameters: None
        //Return: rentedBy in the form of a Patron object
        public Patron getRentedBy()
        {
            return rentedBy;
        } // end method getRentedBy()

        //The getDueDate method
        //Purpose: To return the value of dueDate
        //Parameters: None
        //Return: dueDate in the form of a DateTime object
        public DateTime getDueDate()
        {
            return dueDate;
        } // end method getDueDate()

        //The setTitle method
        //Purpose: To set title to the given value
        //Parameters: A string represented as _title
        //Return: None
        public void setTitle(string _title)
        {
            title = _title;
        } // end method setTitle()

        //The setType method
        //Purpose: To set type to the given value
        //Parameters: A string represented as _type
        //Return: None
        public void setType(string _type)
        {
            type = _type;
        } // end method setType()

        //The setCheckedOut method
        //Purpose: To set checkedOut to the given value
        //Parameters: A bool represented as _checkedOut
        //Return: None
        public void setCheckedOut(bool _checkedOut)
        {
            checkedOut = _checkedOut;
        } // end method setCheckedOut()

        //The setRentedBy method
        //Purpose: To set rentedBy to the given value
        //Parameters: A Patron object represented as _renter
        //Return: None
        public void setRentedBy(Patron _renter)
        {
            rentedBy = _renter;
        } // end method setRentedBy()

        //The setdueDate method
        //Purpose: To set dueDate to the given value
        //Parameters: A DateTime object represented as _dueDate
        //Return: None
        public void setDueDate(DateTime _dueDate)
        {
            dueDate = _dueDate;
        } // end method setDueDate()

        //The rentBook method
        //Purpose: 
        //Parameters: 
        //Return: 
        public void rentBook()
        {
            //


            //
            checkedOut = true;
        } // end method rentBook()

        //The returnBook method
        //Purpose: 
        //Parameters: 
        //Return: 
        public void returnBook()
        {
            //

            //
            checkedOut = false;
        } // end method returnBook()


    } // end class Book
} // end namespace Final_Project
