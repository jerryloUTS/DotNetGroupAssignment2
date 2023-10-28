using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment2
{
    public partial class viewReservations : Form
    {
        public viewReservations()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Set up the columns
            dataGridView.Columns.Add("Room", "Room");
            dataGridView.Columns.Add("Date & Time", "Date & Time");
            //dataGridView.Columns.Add("Time", "Time");
            dataGridView.Columns.Add("Guests", "Guests");

            // Load and populate data from the DiningReservations text file
            LoadReservationsFromFile();
        }

        private void LoadReservationsFromFile()
        {
            try
            {
                // Read all lines from the DiningReservations text file
                string[] lines = File.ReadAllLines("DinnerReservations.txt");

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    // Check if the line has at least four parts
                    if (parts.Length >= 4)
                    {
                        // Extract values
                        string room = parts[0].Trim();
                        //string date = parts[1].Trim();
                        string dateTime = parts[2].Trim();
                        string guests = parts[3].Trim();

                        // Add the data to the DataGridView
                        dataGridView.Rows.Add(room, dateTime, guests);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The file is not found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
