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
    public partial class Rooms_Form : Form
    {
        public Rooms_Form()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ListRooms.Items.Clear();

            foreach (Room r in Program.system.GetRooms())
            {
                if (r != null)
                {
                    ListRooms.Items.Add(
                       $"Room {r.RoomNum} - {r.Type} - Price: {r.PricePerNight}$ - " +
                       $"{(r.IsAvailable ? "Available" : "Booked")}"
                    );

                }
            }
        }

        private void btnShow_MouseHover(object sender, EventArgs e)
        {
            btnShow.ForeColor = Color.BlanchedAlmond;
        }

        private void btnShow_MouseLeave(object sender, EventArgs e)
        {
            btnShow.ForeColor = Color.Black;

        }
    }
}
