using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Airline_Reservation
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(acc.Text) ||
                string.IsNullOrWhiteSpace(mm.Text) ||
                string.IsNullOrWhiteSpace(yyyy.Text) ||
            string.IsNullOrWhiteSpace(cvv.Text))
            {
                MessageBox.Show("All fields must be filled out.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(acc.Text, out int intValue))
            {
                MessageBox.Show("ACC Number must me integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!int.TryParse(mm.Text, out _))
            {
                MessageBox.Show("month must me integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!int.TryParse(yyyy.Text, out _))
            {
                MessageBox.Show("Year must me integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!int.TryParse(cvv.Text, out _))
            {
                MessageBox.Show("ACC Number must me integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            MessageBox.Show("payment is success", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            Booking booking = new Booking();
            this.Hide();
            booking.ShowDialog();

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
    }
}
