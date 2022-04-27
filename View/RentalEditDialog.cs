﻿
using System;
using System.Windows.Forms;

namespace RentMe.View
{

    /// <summary>
    /// The dailog  provides user an option to change teh due date and quantity of an item available in the cart
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class RentalEditDialog : Form
    {

        public static string NewQuantity  { get; set; }
        public static DateTime NewDueDate { get; set; }

        private readonly string currentQuantity;
        private readonly DateTime currenDueDate;
        private int  AvailableQunatity;

        public RentalEditDialog()
        {
           
          
        }
        public RentalEditDialog(string quantitydata,DateTime dueDateUpdate, int availableQunatity)
        {
            InitializeComponent();
            this.currentQuantity = quantitydata;
            this.currenDueDate = dueDateUpdate;
            this.AvailableQunatity = availableQunatity;
            this.rentQuantityTextBox.Text = quantitydata;
            this.rentDateTimePicker.Value = dueDateUpdate;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (ValidateUpdateQuanityAndDueDate())
            {
                NewQuantity = this.rentQuantityTextBox.Text;
                NewDueDate = this.rentDateTimePicker.Value;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
           
        }



        private bool ValidateUpdateQuanityAndDueDate( )
        {
            int dueDays = (int)(RentalEditDialog.NewDueDate - DateTime.Today).TotalDays;
            if (this.currentQuantity == this.rentQuantityTextBox.Text &&
               this.rentDateTimePicker.Value == this.currenDueDate)
            {
                MessageBox.Show("No change detected in Quantity or Due date");
                return false;
            }
            else if (this.rentDateTimePicker.Value <= DateTime.Now)
            {
                MessageBox.Show("Due date cannot be today or less than current date ");
                return false;
            }

            if (Convert.ToInt32(this.rentQuantityTextBox.Text) > this.AvailableQunatity && dueDays > 365)
            {
                MessageBox.Show("Quantity exceeds to Available quantity or Due date exceeds 365 day limit.Please check.Avilablae quantity is "
                    + this.AvailableQunatity, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else if (Convert.ToInt32(this.rentQuantityTextBox.Text) > this.AvailableQunatity)
            {
                MessageBox.Show("Quantity exceeds to Available quantity.Please check.Available quantity is "
                 + this.AvailableQunatity, "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (dueDays > 365)
            {
                MessageBox.Show("Due date exceeds 365 day limit.Please check. ", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
       
    }
}
