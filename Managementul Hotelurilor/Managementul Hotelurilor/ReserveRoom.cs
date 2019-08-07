using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managementul_Hotelurilor
{
    public partial class ReserveRoom : Form
    {
        private Entities.Rooms RoomReserve;
        private DataTable All_Rooms;
        public ReserveRoom()
        {
            InitializeComponent();
        }

        private void B_CommitReservation_Click(object sender, EventArgs e)
        {
            DateTime timeComming = dateComming_picker.Value;
            DateTime timeLeaving = dateLeaving_picker.Value;

            switch (Form1.ReserveRoom.Status.ToUpper())
            {
                case "O":
                    {
                        MessageBox.Show("Room is Ocupied.\nCan't make a reservation to this room.");
                        break;
                    }
                case "UCK":
                    {
                        MessageBox.Show("Room status is uncknown.\nCan't make a reservation to this room.");
                        break;
                    }
                case "U":
                    {
                        MakeReservation();
                        break;
                    }
            }
            //TO DO:check if room availeble and show a Response
           //TO DO: If room availeble save in a new table
        }
        private void MakeReservation()
        {
            switch(MessageBox.Show("Making reservation?", "Room available", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    {
                        //Yes Processing
                        break;
                    }
                case DialogResult.No:
                    {
                        //No Processing
                        break;
                    }
            }

        }
    }
}
