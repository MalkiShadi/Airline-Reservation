using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation
{
    public partial class login : Form
    {
        public login()
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

        private void flightbtn_Click(object sender, EventArgs e)
        {
            Flight_1 flight_1 = new Flight_1();
            this.Hide();
            flight_1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fname.Text) ||
                string.IsNullOrWhiteSpace(lname.Text) ||
                string.IsNullOrWhiteSpace(DD.Text) ||
                string.IsNullOrWhiteSpace(MM.Text) ||
                string.IsNullOrWhiteSpace(year.Text) ||
                string.IsNullOrWhiteSpace(email.Text) ||
                string.IsNullOrWhiteSpace(pword.Text) )
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(fname.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("First Name contain no special symbols.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(lname.Text, @"^[A-Za-z0-9\s]+$"))
            {
                MessageBox.Show("Last Name contain no special symbols.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("email is not in correct format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("email is not in correct format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(DD.Text, out int intValue))
            {
                MessageBox.Show("Date must me integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            MessageBox.Show($"Login is success!");
        }
    }
}
