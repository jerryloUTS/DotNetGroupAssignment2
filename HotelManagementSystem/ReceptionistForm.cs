using HotelManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class ReceptionistForm : Form
    {
        private HotelMain hotelMain;
        public ReceptionistForm(HotelMain hotelMain)
        {
            InitializeComponent();
            this.hotelMain = hotelMain;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm(hotelMain);
            DialogResult dResult = addCustomerForm.ShowDialog();

        }



        private void lbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReceptionistForm_Load(object sender, EventArgs e)
        {


            //adds the customers to the listbox
            foreach(Customer customer in hotelMain.Customers)
            {
                lbCustomers.Items.Add(customer);
            }
        }
    }
}
