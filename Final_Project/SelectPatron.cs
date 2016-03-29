using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class SelectPatron : Form
    {
        public string currentPatronID = Library.getInstance().patrons.First().uniqueId;
        public SelectPatron()
        {
            InitializeComponent();
            patronListBox.Items.Clear();
            patronListBox.Items.AddRange(Library.getInstance().getPatrons().Select(x => x.name).ToArray());
            patronListBox.Refresh();
        }

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
        }

        private void patronListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set label to selected patron
            selectedPatronNameLbl.Text = patronListBox.Text;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            if (patronListBox.SelectedItems.Count != 0)
            {
                DialogResult = DialogResult.OK;

                currentPatronID = Library.getInstance().patrons.First(x => x.name == patronListBox.CheckedItems[0].ToString()).uniqueId;

            }
            else
            {
                DialogResult = DialogResult.Abort;
            }
            Close();
        }
    }
}
