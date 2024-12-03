using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Airline_Reservation
{
    public partial class Flight3 : Form
    {
        private int seat;

      

        public Flight3(int count)
        {
            InitializeComponent();
            seat =  count;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool GetHasChildren()
        {
            return panel1.HasChildren;
        }

        private void Continue_Click(object sender, EventArgs e, bool hasChildren)
        {
            
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            int checkedCount = 0;

            // Iterate through the controls in the panel
            foreach (Control control in panel1.Controls) // Replace 'panel1' with your Panel's name
            {
                if (control is CheckBox CheckBox && CheckBox.Checked)
                {
                    checkedCount++;

                }

                
            }
            if (checkedCount != seat)
            {
                //CheckBox.Checked = false; // Uncheck the checkbox
                MessageBox.Show("passenger count & selected seat no is not equal", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Payment payment = new Payment();
                this.Hide();
                payment.ShowDialog();
            }
        }
    }
}
