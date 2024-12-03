using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Airline_Reservation
{
    public partial class Flight_1 : Form
    {
    
        public Flight_1()
        {
            InitializeComponent();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }

        private void bookingbtn_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            this.Hide();
            booking.ShowDialog();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            int count;
           

            if (!int.TryParse(passenger.Text, out count))
            {
                MessageBox.Show("Invalid input. Please enter a valid integer.");
                return;
            }
           

            if (From.SelectedIndex != -1  && to.SelectedIndex != -1 && (DepatureDate.Value != DateTimePicker.MinimumDateTime) && (ReturnDate.Value != DateTimePicker.MinimumDateTime && count<=10)) // Check if an item is selected
            {
                string depDate = DepatureDate.Value.ToString("yyyy-MM-dd");
                string arrDate = ReturnDate.Value.ToString("yyyy-MM-dd");
                string fromwhere = From.SelectedItem.ToString();
                string go = to.SelectedItem.ToString();

                Flight_2 flight_2 = new Flight_2(depDate,count);
                this.Hide();
                flight_2.ShowDialog();
                
                Details details = new Details(depDate,arrDate,fromwhere,go);

            }
            else
            {
                MessageBox.Show("All fields must be filled, passenger count maximus is 10.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        

        }

        
    }
}
