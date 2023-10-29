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
    public partial class SearchDish : Form
    {
        string lines;

        public SearchDish()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Exit searchDish
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllText("dish.txt");
            if (!File.Exists(dishSearch.Text + ".txt")) //Error if the file does not exist according to the user input
            {
                MessageBox.Show(dishSearch.Text + " was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (File.Exists(dishSearch.Text + ".txt")) //Displays the dish if the file exists according to the user input
            {
                
                if (!lines.Contains(dishSearch.Text, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Dish not found. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (lines.Contains(dishSearch.Text, StringComparison.OrdinalIgnoreCase)) //allows the user to search for the function without relying on case-sensitive characters
                {
                    richTextBox1.Clear();
                    List<string> dishInfo = new List<string>();
                    dishInfo = File.ReadAllLines(dishSearch.Text + ".txt").ToList();
                    foreach (var line in dishInfo)
                    {
                        string[] dishSplit = line.Split(','); ////Splits the line into an array of its own
                        richTextBox1.AppendText("Dish: " + dishSplit[0] + "\n");
                        richTextBox1.AppendText("Price: " + dishSplit[1] + "\n");
                        richTextBox1.AppendText("Calories (kJ): " + dishSplit[2] + "\n");
                        richTextBox1.AppendText("Meal Type: " + dishSplit[3] + "\n");
                        richTextBox1.AppendText("Allergens: " + dishSplit[4] + "\n");
                        richTextBox1.AppendText("Additional Information: " + dishSplit[5] + "\n");
                    }
                }
                
            }
        }



        private void dishSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
