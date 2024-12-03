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
    public partial class Booking : Form
    {
        private string depDate;
        private string arrDate;
        private string go;
        private string fromwhere;

        public Booking()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.ShowDialog();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.ShowDialog();
        }

        private void flightbtn_Click(object sender, EventArgs e)
        {
            Flight_1 flight_1 = new Flight_1();
            this.Hide();
            flight_1.ShowDialog();
        }

        private void BKDetails_Click(object sender, EventArgs e)
        {
            Details details = new Details(depDate, arrDate, fromwhere, go);
            details.ShowDialog();
        }
    }
}
