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
    public partial class Form_Reservations : Form
    {
        private string StoreProcName;

        public Form_Reservations()
        {
            InitializeComponent();
        }

        public Form_Reservations(string StoreProcName)
        {
            this.StoreProcName = StoreProcName;
            InitializeComponent();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Reservations_Load(object sender, EventArgs e)
        {
            GV_OcupiedRooms.DataSource = DAL.Dal_Rooms.GetOcupiedRooms(StoreProcName);

            GV_OcupiedRooms.Columns["Hotel ID"].Visible = false;
            //TO DO: Implement view all Reserved Rooms in a GridView
        }
    }
}
