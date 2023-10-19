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
    public partial class AddCustomerForm : Form
    {
        private HotelMain hotelMain;
        public AddCustomerForm(HotelMain hotelMain)
        {
            InitializeComponent();
            this.hotelMain = hotelMain;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //this is used to generate random numbers for customer id's.
            Random random = new Random();
            int randumCustId = random.Next(1000, 10000);
            //customer basic details
            string firstName = txtFname.Text;
            string lastName = txtLname.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            //address details
            string addressLine1 = txtAdrressL1.Text;
            string? addressLine2 = txtAddressL2.Text;
            string city = cmbCity.Text;
            string? state = cmbState.Text;
            string country = cmbCountry.Text;
            string postCode = txtPostCode.Text;

            //credit card detilas
            string cardIsuer = cmbCardIssuer.Text;
            DateTime expiryDate = dtpExpiryDate.Value;
            DateTime issueDate = dtpIssueDate.Value;
            string cardNumber = txtCardNumber.Text;
            string cvc = txtCvc.Text;

            Address address = new Address(addressLine1, addressLine2, city, state, country, postCode);
            CreditCard creditCard = new CreditCard(cardNumber, cvc, cardIsuer, issueDate, expiryDate);
            Customer customer = new Customer(randumCustId, firstName, lastName, email, phone, address, creditCard);

            hotelMain.Addcustomer(customer);
            //used for testing
            hotelMain.printAllCustomers();
            MessageBox.Show("Customer is added to the system");
            this.Hide();
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
