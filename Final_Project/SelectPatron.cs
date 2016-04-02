using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class SelectPatron : Form
    {
        //Data Members:
        public string currentPatronID = Library.getInstance().patrons.First().uniqueId;

        //The default constructor
        //Purpose: To initialize the form and populate the current patron's rented books
        //Parameters: None
        //Return: None
        public SelectPatron()
        {
            InitializeComponent();
            patronListBox.Items.Clear();
            patronListBox.Items.AddRange(Library.getInstance().getPatrons().Select(x => x.name).ToArray());
            patronListBox.Refresh();
        } // end default constructor

        //The patronListBox_ItemCheck method
        //Purpose: To prevent the user from selecting multiple patrons
        //Parameters: The object sending the event and the event args
        //Return: None
        private void patronListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Iterate through patronListBox items
            for (int i = 0; i < patronListBox.Items.Count; i++)
            {
                //If the current item is not the most recently checked
                if (i != e.Index)
                {
                    //Uncheck the item
                    patronListBox.SetItemChecked(i, false);
                } // end if
            } // end for
        } // end method patronListBox_ItemCheck()

        //The patronListBox_SelectedIndexChanged method
        //Purpose: To set the patronName label to the value of the selection in the patronListBox
        //Parameters: The object sending the event and the event args
        //Return: None
        private void patronListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set label to selected patron
            selectedPatronNameLbl.Text = patronListBox.Text;
        } // end method patronListBox_SelectedIndexChanged()

        //The doneBtn_Click method
        //Purpose: 
        //Parameters: The object sending the event and the event args
        //Return: None
        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (patronListBox.SelectedItems.Count != 0)
            {
                DialogResult = DialogResult.OK;

                currentPatronID = Library.getInstance().patrons.First(x => x.name == patronListBox.CheckedItems[0].ToString()).uniqueId;
            } // end if
            else
            {
                DialogResult = DialogResult.Abort;
            } // end else

            Close();
        } // end method doneBtn_Click()
    } // end class SelectPatron
} // end namespace Final_Project
