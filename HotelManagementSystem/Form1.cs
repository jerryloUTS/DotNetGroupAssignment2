using HotelManagementSystem.Models;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        private HotelMain hotelMain = new HotelMain();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistForm frm = new ReceptionistForm(hotelMain);
            frm.Show();
            this.Hide();
        }
        //this is used to initialise the hotel main upon load.
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}