using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_Reservation_System
{
    public partial class Booking_Form : Form
    {
        public Booking_Form()
        {
            InitializeComponent();
        }

        private void Booking_Form_Load(object sender, EventArgs e)
        {
            
        }

        private void btnrooms_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="") 
            {
                label3.Visible = true;
                MessageBox.Show("Complete Your Data");
                label3.Visible = false;
                txtname.Focus();
                return;

            }
            else if (txtphone.Text == "")
            {
                label4.Visible = true;
                MessageBox.Show("Complete Your Data");
                label4.Visible = false;
                txtphone.Focus();
                return;
            }
            else if (txtphone.Text.Length!= 11)
            {
                MessageBox.Show("Invalid Number Phone!");
                txtphone.Focus();
                return;
            }
            Customer c = new Customer();

            c.Name = txtname.Text;

            long phone;
            if (!long.TryParse(txtphone.Text, out phone))
            {
                MessageBox.Show("Invalid phone number!");
                return;
            }

            c.Phone = phone;
            if (txtroom.Text == "")
            {
                label5.Visible = true;
                MessageBox.Show("Complete Your Data");
                label5.Visible = false;
                txtroom.Focus();
                return;
            }
            
            int roomNum;
            if (!int.TryParse(txtroom.Text, out roomNum))
            {
                MessageBox.Show("Invalid room number!");
                return;
            }
            
            bool result = Program.system.BookRoom(roomNum, c);

            if (result)
            {
                lblsucces.Visible = true;
                MessageBox.Show("Booked Successfully!");         
                lblsucces.Visible = false;
                StreamWriter sw = new StreamWriter("customer data.txt", true);
                string customerData = "customer Data:_\n Name : " + c.Name + "\nPhone : 0" + phone + "\nRoom Number : " + roomNum+"\n---------------------";
                sw.WriteLine(customerData);
                sw.Close();

            }

            else
                MessageBox.Show("Room Not Available!");
            
            

            



        }

        private void lblprice_Click(object sender, EventArgs e)
        {

            

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int roomNum;

            if (!int.TryParse(txtroom.Text, out roomNum))
            {
                MessageBox.Show("Enter valid room number!");
                return;
            }

            float price = Program.system.priceByRoomNum(roomNum);

            if (price == 0)
            {
                MessageBox.Show("Room not found!");
                return;
            }

            decimal total = (decimal)price * numofnight.Value;

            lblprice.Text = total.ToString();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.NavajoWhite;
        }

        private void btnrooms_MouseHover(object sender, EventArgs e)
        {
            btnrooms.ForeColor = Color.NavajoWhite;
        }

        private void btnrooms_MouseLeave(object sender, EventArgs e)
        {
            btnrooms.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            int roomNum;

            if (int.TryParse(txtroom.Text, out roomNum))
            {
                Program.system.CancelBooking(roomNum);

                MessageBox.Show("Booking cancelled!");
                
                return;
            }
            MessageBox.Show("Invalid room number!");


        }

        private void btncancel_MouseHover(object sender, EventArgs e)
        {
            btncancel.ForeColor = Color.Red;
        }

        private void btncancel_MouseLeave(object sender, EventArgs e)
        {
            btncancel.ForeColor = Color.Black;

        }
    }
}
