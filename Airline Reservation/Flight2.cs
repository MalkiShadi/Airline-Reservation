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
    public partial class Flight_2 : Form
    {
     
      
        public int seat;

        public Flight_2(string depDate, int count)
        {
            InitializeComponent();

            dtxt1.Text = depDate;
            dtxt2.Text = depDate;
            dtxt3.Text = depDate;
            seat = count;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtx3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Flight_2_Load(object sender, EventArgs e)
        {

        }

        private void choice1_Click(object sender, EventArgs e)
        {
            Flight3 flight3 = new Flight3(seat);
            this.Hide();
            flight3.ShowDialog();
            
        }

        private void choice2_Click(object sender, EventArgs e)
        {
            Flight3 flight3 = new Flight3(seat);
            this.Hide();
            flight3.ShowDialog();
        }

        private void choice3_Click(object sender, EventArgs e)
        {
            Flight3 flight3 = new Flight3(seat);
            this.Hide();
            flight3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
