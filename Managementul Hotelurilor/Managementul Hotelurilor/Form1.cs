using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MetroFramework;

namespace Managementul_Hotelurilor
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Entities.Rooms ReserveRoom = new Entities.Rooms();
        public static DataTable AllRooms;
        private Color color_Light_Mode_blue = Color.FromArgb(45, 100, 148);
        private Color color_Dark_Mode_Blue = Color.FromArgb(33,67,149);
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }
        #endregion
        // Set of Particular functions specialized on reseting certain components
        #region Button Rseters
        private void ResetALL_ExeceptCountriesCitiesHotels()
        {
            tb_RoomName.Enabled = false;
            tb_RoomName.Text = "";

            tB_HotelName.Enabled = false;
            tB_HotelName.Text = "";

            tb_RoomType.Enabled = false;
            tb_RoomType.Text = "";

            button_Reservation.Enabled = false;
        }
        private void ResetAll_ExceptCountriesCities()
        { 
            comboBox_Hotels.Items.Clear();
            comboBox_Hotels.Enabled = false;

            availeble_Rooms_gridView.Enabled = false;
            availeble_Rooms_gridView.DataSource = null;

            ResetALL_ExeceptCountriesCitiesHotels();

        }
        private void ResetAll_ExceptCountries()
        {
            comboBox_city.Items.Clear();
            comboBox_city.Enabled = false;
            ResetAll_ExceptCountriesCities();

        }
        private void B_Reset_Click(object sender, EventArgs e)
        {
            comboBox_Country.Items.Clear();
            comboBox_Country.Enabled = false;
            b_Hotels.Enabled = true;

            ResetAll_ExceptCountries();
        }
        #endregion

        #region Search Hotel Rooms
        private void ComboBox_city_SelectedValueChanged(object sender, EventArgs e)
        {
            ResetAll_ExceptCountriesCities();
            comboBox_Hotels.Enabled = true;
            try
            {
                int ID = DAL.Dal_Locations.GetLocationID(comboBox_city.Text, DAL.GlobalDictionary.LocationDictionary);

                DAL.DAL_Hotels hotels = new DAL.DAL_Hotels(ID);

                foreach (string s in hotels.HotelsDictionary.Values)
                {
                    comboBox_Hotels.Items.Add(s);
                }
                DAL.GlobalDictionary.HotelsDictionary = hotels.HotelsDictionary;

            }
            catch (OracleException OEx)
            {
                DAL.Log.LogMessage(OEx);
                MessageBox.Show("Errorr occured!");
            }
        //TO DO: Punere Hoteluri dintr-un oras intr-un combobox pentru hoteluri
        }       
        private void ComboBox_Country_SelectedValueChanged(object sender, EventArgs e)
        {
            ResetAll_ExceptCountries();
            b_Hotels.Enabled = false;
            comboBox_city.Enabled = true;

            int ID = DAL.Dal_Countries.GetCountryID(comboBox_Country.Text);
            try
            {
                DAL.Dal_Locations Locatii = new DAL.Dal_Locations(ID);
                foreach (string s in Locatii.LocationDictionary.Values)
                {
                    comboBox_city.Items.Add(s);
                }
                DAL.GlobalDictionary.LocationDictionary = Locatii.LocationDictionary;

            }
            catch (OracleException OEx)
            {

                DAL.Log.LogMessage(OEx);
                MessageBox.Show("Error occured!");
            }
            //TO DO: ADD Elements from Location in a Combobox for location
        }

        private void B_Hotels_Click(object sender, EventArgs e)
        {
            comboBox_Country.Enabled = true;
            comboBox_Country.Sorted = true;
            comboBox_Country.Items.Clear();

            b_Hotels.Enabled = false;
            button_Reservation.Enabled = false;

            try
            {
                foreach (string s in DAL.Dal_Countries.CountriesDictionary.Values)
                {
                    comboBox_Country.Items.Add(s);
                }

            }
            catch (OracleException OEx)
            {
                DAL.Log.LogMessage(OEx);
                MessageBox.Show("Error occured!");
            }
    //SOLVED: ADD  ELEMENTS FROM COUNTRY TABLE IN A COMBOBOX
        }
        private void ComboBox_Hotels_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetALL_ExeceptCountriesCitiesHotels();

            int ID = DAL.DAL_Hotels.GetHotelID(comboBox_Hotels.Text,DAL.GlobalDictionary.HotelsDictionary);
            availeble_Rooms_gridView.Enabled = true;
            try
            {
                DataTable dataTable = DAL.Dal_Rooms.GetRooms(ID);
                availeble_Rooms_gridView.DataSource = dataTable;
               //availeble_Rooms_gridView.Columns["RoomID"].Visible = false;
                //availeble_Rooms_gridView.Columns["Status"].Visible = false;
                availeble_Rooms_gridView.Columns["Hotel ID"].Visible = false;

                //Se vor da mai departe in alt form camerele cand se decide sa se realizeze rezervarea
                AllRooms = dataTable;
                availeble_Rooms_gridView.Focus();


            }
            catch (OracleException OEx)
            {

                DAL.Log.LogMessage(OEx);
                MessageBox.Show("Error occured!");
            }
        }
        #endregion

        #region View Ocupied AND Not Ocupied Rooms
        private void B_Rooms_Click(object sender, EventArgs e)
        {
            Form_Reservations form_Reservations = new Form_Reservations("SelectAllRoomsOcupied");
            form_Reservations.Text = "Ocupied Rooms from all Hotels";
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Form_Reservations")
                {
                    frm.Close();
                    break;
                }
            }

            form_Reservations.Show();
            
        }
        private void B_UnocupiedRooms_Click(object sender, EventArgs e)
        {
            Form_Reservations form_Reservations = new Form_Reservations("SelectAllRoomsNOTOcupied");
            form_Reservations.Text = "Unocupied Rooms from all Hotels";
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "Form_Reservations")
                {
                    frm.Close();
                    break;
                }
            }

            form_Reservations.Show();
        }

        #endregion

        private void Availeble_Rooms_gridView_SelectionChanged(object sender, EventArgs e)
        {
            //Enable Texboxes and reservsation button
            tb_RoomName.Enabled = true;
            tB_HotelName.Enabled = true;
            tb_RoomType.Enabled = true;

            button_Reservation.Enabled = true;

            foreach (DataGridViewRow row in availeble_Rooms_gridView.Rows)
            {
                if (row.Selected)
                {
                    //fills the texboxes and a reserve room variabl ewith th acontents of current selected room
                    tb_RoomName.Text = row.Cells["Room Name"].Value.ToString();
                    tb_RoomType.Text = row.Cells["Family Room"].Value.ToString();
                    tB_HotelName.Text = row.Cells[2].Value.ToString();

                    ReserveRoom.Room_Name = row.Cells["Room Name"].Value.ToString();
                    ReserveRoom.FamilyType = row.Cells["Family Room"].Value.ToString();
                    ReserveRoom.Hotel_ID = Int32.Parse(row.Cells["Hotel ID"].Value.ToString());
                    ReserveRoom.Status = row.Cells["Status"].Value.ToString();
                    ReserveRoom.Room_ID = Int32.Parse(row.Cells["RoomID"].Value.ToString());

                    FormCollection fc = Application.OpenForms;

                    //TO DO: Actualizarea datelor din formul de realizare de rezervari fara a deshide din nou acel form + LOG mesages

                    foreach (Form frm in fc)
                    {
                        if (frm.Name == "ReserveRoom")
                        {
                            frm.Close();

                            ReserveRoom RR = new ReserveRoom();
                            RR.Show();

                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void Button_Reservation_Click(object sender, EventArgs e)
        {

            ReserveRoom rooms = new ReserveRoom();
            FormCollection fc = Application.OpenForms;

            foreach (Form frm in fc)
            {
                if (frm.Name == "ReserveRoom")
                {
                    frm.Close();
                    break;
                }
            }
            rooms.Show();
        }

        private void Availeble_Rooms_gridView_MouseEnter(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        //    this.StyleManager = metroStyleManager_change_to_dark_or_light_mode;
        //    metroStyleManager_change_to_dark_or_light_mode.Theme = MetroThemeStyle.Dark;
        }



        private void Form1_Resize(object sender, EventArgs e)
        {
        }

        private void Availeble_Rooms_gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
