using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Reservation
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void flightbtn_Click(object sender, EventArgs e)
        {
            Flight_1 flight_1 = new Flight_1();
            this.Hide();
            flight_1.ShowDialog();
         
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
    }
}
