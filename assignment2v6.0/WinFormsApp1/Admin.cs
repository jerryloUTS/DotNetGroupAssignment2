using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class Admin : Form
    {
        LoginForm loginform;

        public Admin(LoginForm loginform, string username) //logs in to Admin according to the user's input; in this case, the correct login is the one with the Admin role. 
        {
            InitializeComponent();
            this.loginform = loginform;
        }

        private void usernameLbl_Click(object sender, EventArgs e)
        {

        }

        private void usertypeComboBx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchRoom f1 = new SearchRoom();
            f1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e) //Opens DeleteUser.
        {
            DeleteUser f1 = new DeleteUser();
            f1.Show();
        }

        private void AllCustomerBtn_Click(object sender, EventArgs e) //Opens AllCustomers.
        {
            AllCustomers f1 = new AllCustomers();
            f1.Show();
        }

        private void button10_Click(object sender, EventArgs e) //Opens SearchCustomer.
        {
            SearchCustomer f1 = new SearchCustomer();
            f1.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e) //Closes the Admin menu.
        {
            Close();
            loginform.Show();
        }

        private void button15_Click(object sender, EventArgs e) //Opens AddDish.
        {
            AddDish f1 = new AddDish();
            f1.Show();
        }


        private void button14_Click(object sender, EventArgs e) //Opens SearchDish.
        {
            SearchDish f1 = new SearchDish();
            f1.Show();
        }

        private void button13_Click(object sender, EventArgs e) //Opens AllDishes.
        {
            AllDishes f1 = new AllDishes();
            f1.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) //Opens AllRooms.
        {
            AllRooms f1 = new AllRooms();
            f1.Show();
        }

        private void button2_Click_1(object sender, EventArgs e) //Opens AddRoom.
        {
            AddRoom f1 = new AddRoom();
            f1.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) //Opens DeleteDish.
        {
            DeleteDish f1 = new DeleteDish();
            f1.Show();
        }

        private void viewComplaints_Click(object sender, EventArgs e) //Opens viewComplaints.
        {
            viewIncidents f1 = new viewIncidents();
            f1.Show();
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e) //Opens AddEmployee.
        {
            AddEmployee f1 = new AddEmployee();
            f1.Show();
        }
    }
}
