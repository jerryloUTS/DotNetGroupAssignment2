using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assignment2
{
    public partial class DeleteUser : Form
    {
        public DeleteUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllText("customerDB.txt");
            if (!File.Exists(deleteCustomerTxtBox.Text + ".txt"))
            {
                MessageBox.Show("no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else if (File.Exists(deleteCustomerTxtBox.Text + ".txt"))
            {
                if (!lines.Contains(deleteCustomerTxtBox.Text))
                {
                    MessageBox.Show("no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (lines.Contains(deleteCustomerTxtBox.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("User found. Would you like to delete " + deleteCustomerTxtBox.Text + "?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string tempFile = Path.GetTempFileName();
                        using (var sr = new StreamReader("login.txt"))
                        using (var sw = new StreamWriter(tempFile))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                if (line != deleteCustomerTxtBox.Text)
                                    sw.WriteLine(line);
                            }
                        }
                        File.Delete("login.txt");
                        File.Move(tempFile, "login.txt");
                        System.IO.File.Delete(deleteCustomerTxtBox.Text + ".txt");
                        
                        
                    }

                    if (dialogResult == DialogResult.No)
                    {
                        
                    }

                }
            }
        }
    }
}
