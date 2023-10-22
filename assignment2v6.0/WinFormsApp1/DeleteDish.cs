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
    public partial class DeleteDish : Form
    {
        public DeleteDish()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllText("dish.txt");
            if (!File.Exists(deleteDishTxtBox.Text + ".txt"))
            {
                MessageBox.Show("Dish not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (File.Exists(deleteDishTxtBox.Text + ".txt"))
            {
                if (!lines.Contains(deleteDishTxtBox.Text))
                {
                    MessageBox.Show("Dish not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (lines.Contains(deleteDishTxtBox.Text))
                {
                    DialogResult dialogResult = MessageBox.Show("User found. Would you like to delete " + deleteDishTxtBox.Text + "?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var tempFile = Path.GetTempFileName();
                        var linesToKeep = File.ReadLines("dish.txt").Where(l => l != deleteDishTxtBox.Text);

                        File.WriteAllLines(tempFile, linesToKeep);

                        File.Delete("dish.txt");
                        File.Move(tempFile, "dish.txt");


                    }

                    if (dialogResult == DialogResult.No)
                    {

                    }

                }
            }
        }
    }
}
