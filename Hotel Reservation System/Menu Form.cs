using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Hotel_Reservation_System
{
    public partial class menufrm : Form
    {
        public menufrm()
        {
            InitializeComponent();
        }

        private void btnbooking_Click(object sender, EventArgs e)
        {
            Booking_Form frm = new Booking_Form();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Rooms_Form frm = new Rooms_Form();
            frm.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menufrm_Load(object sender, EventArgs e)
        {
            Program.system.LoadRooms();

            if (Program.system.roomCount == 0)
            {
                Program.system.AddRoom(new SingleRoom(100, 100));
                Program.system.AddRoom(new SingleRoom(101, 100));

                Program.system.AddRoom(new DoubleRoom(115, 150));
                Program.system.AddRoom(new DoubleRoom(116, 150));

                Program.system.AddRoom(new SuiteRoom(130, 300));
                Program.system.AddRoom(new SuiteRoom(131, 300));
            }
           

        }

        private void btnbooking_MouseHover(object sender, EventArgs e)
        {
            btnbooking.ForeColor = Color.Gold;
        }

        private void btnbooking_MouseLeave(object sender, EventArgs e)
        {
            btnbooking.ForeColor=Color.LemonChiffon;
        }

        private void btnrooms_MouseHover(object sender, EventArgs e)
        {
            btnrooms.ForeColor=Color.Gold;
        }

        private void btnrooms_MouseLeave(object sender, EventArgs e)
        {
            btnrooms.ForeColor = Color.LemonChiffon;
        }

        private void btnexit_MouseHover(object sender, EventArgs e)
        {
            btnexit.ForeColor=Color.Gold;
        }

        private void btnexit_MouseLeave(object sender, EventArgs e)
        {
            btnexit.ForeColor = Color.LemonChiffon;
        }

        private void btnmang_Click(object sender, EventArgs e)
        {
            txtpass.Visible = true;
            txtpass.Focus();
       
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtpass.Text == "024@579")
                {
                    Admin_Form admin = new Admin_Form();
                    admin.ShowDialog();
                    return;
                }
                else
                {
                    MessageBox.Show("invalid Password");
                    txtpass.Text = "";
                    txtpass.Focus();


                }
            }
        }
    }
}
