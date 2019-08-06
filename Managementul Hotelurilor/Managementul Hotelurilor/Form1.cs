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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ComboBox_city_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox_Country_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void B_Reset_Click(object sender, EventArgs e)
        {
            comboBox_city.Text = "";
            comboBox_city.Enabled = false;
            comboBox_Country.Text = "";
            comboBox_Country.Enabled = false;
            comboBox_Hotels.Text = "";
            comboBox_Hotels.Enabled = false;
            availeble_Rooms_gridView.Enabled = false;
            availeble_Rooms_gridView.DataSource = null;
        }

        private void B_Hotels_Click(object sender, EventArgs e)
        {
            comboBox_Country.Enabled = true;
            //TO DO: ADD  ELEMENTS FROM COUNTRY TABLE IN A COMBOBOX
        }
    }
}
