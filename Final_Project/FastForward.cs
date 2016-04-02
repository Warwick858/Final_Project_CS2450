using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class FastForward : Form
    {
        //The default constructor
        //Purpose: To initialize the form and set its location
        //Parameters: None
        //Return: None
        public FastForward()
        {
            InitializeComponent();

            //Set form to bottom-left corner
            Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Bottom - Height);
            TopMost = true;
        } // end default constructor

        //The calendarFF_DateChanged method
        //Purpose: To get the admin for if it exists, and refresh its overdue books list
        //Parameters: The object sending the event and the event args
        //Return: None
        private void calendarFF_DateChanged(object sender, DateRangeEventArgs e)
        {
            //If Admin form is open
            if (Application.OpenForms.OfType<Admin>().Any())
            {
                //Get reference to admin for if it exists
                Admin admin = System.Windows.Forms.Application.OpenForms["Admin"] as Admin;

                //Refresh the list of overdue books to reflect the new date
                admin.refreshOverdueBooks();
            } // end if
        } // end method calendarFF_DateChanged()
    } // end class FastForward
} // end namespace Final_Project
