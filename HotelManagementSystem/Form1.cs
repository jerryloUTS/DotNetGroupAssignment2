namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceptionistForm frm = new ReceptionistForm();
            frm.Show();
            this.Hide();
        }
    }
}