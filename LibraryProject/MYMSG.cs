using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    internal class MYMSG
    {
        //
        // ADD MESSAGE
        public void AddMessage()
        {
            MessageBox.Show("Item has been saved successfully.", "Save Item",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        // EDIT MESSAGE
        public void EditMessage()
        {
            MessageBox.Show("Item has been edited successfully.", "Edit Item",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        // DELETE MESSAGE
        public void DeleteMessage()
        {
            MessageBox.Show("Item has been deleted.", "Delete Item",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        // CONFIRM DELETE MESSAGE
        public DialogResult ConfirmDeleteMessage()
        {
            DialogResult ans = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return ans;
        }        

        //
        // ITEM EXIST MESSAGE
        public void ItemExist()
        {
            MessageBox.Show("The item is already existed.", "Existed Item",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // SELECT ITEM WARNING MESSAGE
        public void SelectItem()
        {
            MessageBox.Show("Please select an item.", "Select Item",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // VALUE EMPTY WARNING MESSAGE
        public void EmptyItem(String empty)
        {
            MessageBox.Show(empty + " cannot be empty", "Empty Value Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // VALUE NOT FOUND MESSAGE
        public void NotFindItem()
        {
            MessageBox.Show("Value hasn't been found.", "Value Not Found",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //
        // VALUE NOT FOUND MESSAGE
        public void DataNotSave()
        {
            MessageBox.Show("Data isn't saved.", "Save Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //
        // CIRCULATION RETURNED ERROR
        public void UniqueReturned()
        {
            MessageBox.Show("This data has already been saved as RETURNED", "RETURNED Error",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
