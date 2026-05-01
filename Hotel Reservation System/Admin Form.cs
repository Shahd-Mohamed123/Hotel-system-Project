using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservation_System
{
    public partial class Admin_Form : Form
    {
        public Admin_Form()
        {
            InitializeComponent();
        }

        private void Admin_Form_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Program.system.bookingCount; i++)
            {
                Booking b = Program.system.bookings[i];

                if (b != null)
                {
                    dataGridView1.Rows.Add(
                        b.Customer.Id,
                        b.Customer.Name,
                        b.Customer.Phone,
                        b.Room.RoomNum,
                        b.Room.Type
                    );
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaddsingle_Click(object sender, EventArgs e)
        {
            if(txtnum1.Text!="" )
            {
                int roomNum = int.Parse(txtnum1.Text);
                Program.system.AddRoom(new SingleRoom(roomNum, 100));
                MessageBox.Show("Single Room Added Successfully!");
            }
            else
            {
                MessageBox.Show("Complete Data !");
            }

        }

        private void btnadddouble_Click(object sender, EventArgs e)
        {
            if (txtnum2.Text != "")
            {
                int roomNum = int.Parse(txtnum2.Text);
                Program.system.AddRoom(new DoubleRoom(roomNum,150));
                MessageBox.Show("Double Room Added Successfully!");
            }
            else
            {
                MessageBox.Show("Complete Data !");
            }

        }

        private void btnaddsuit_Click(object sender, EventArgs e)
        {
            if (txtnums.Text != "" )
            {
                int roomNum = int.Parse(txtnums.Text);
                Program.system.AddRoom(new SuiteRoom(roomNum, 300));
                MessageBox.Show("Suite Room Added Successfully!");
            }
            else
            {
                MessageBox.Show("Complete Data !");
            }

        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            

        }
    }
}
