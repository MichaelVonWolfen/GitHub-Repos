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

namespace Managementul_Hotelurilor
{
    public partial class ReserveRoom : Form
    {
        public ReserveRoom()
        {
            InitializeComponent();
        }

        private void B_CommitReservation_Click(object sender, EventArgs e)
        {
            DateTime timeComming = dateComming_picker.Value;
            DateTime timeLeaving = dateLeaving_picker.Value;
            //if time coming> timeleaving => Error (you can't leave before you come
            if(tb_FamilyOriented.Text == "" || tb_Hotel.Text == "" || tb_RoomID.Text == "" || tb_RoomType.Text == "")
            {
                MessageBox.Show("ERROR!\nNo Room selected.");
                return;
            }
            if(timeLeaving.CompareTo(timeComming) < 0)
            {
                Error_LABEL.Text = "Error:\n" + timeComming.ToString("dd MMM yyyy") + " greater than " + timeLeaving.Date.ToString("dd MMM yyyy") +
                                                "\nDate leaving must be grater than comming date.";
                return;
            }
            switch (Form1.ReserveRoom.Status.ToUpper())
            {
                case "OCUPIED":
                    {
                        MessageBox.Show("Room is Ocupied.\nCan't make a reservation to this room.");
                        break;
                    }
                case "UNCKOWN":
                    {
                        MessageBox.Show("Room status is uncknown.\nCan't make a reservation to this room.");
                        break;
                    }
                case "UNOCUPIED":
                    {
                        MakeReservation();
                        break;
                    }
            }
            //TO DO:check if room availeble and show a Response
           //TO DO: If room availeble save in a new table
        }
        private void AddConfirmationRichTextbox(Entities.Rent_Rooms rented_Room)
        {
            richTextBox_ConfirmReservation.Text = "Confirm Reservation!\n" +
                                                  "User: UNDEFINED TODO :P\n" +
                                                  "Room ID: " + rented_Room.ROOM_ID + "\n" +
                                                  "Date Coming: " + rented_Room.START_DATE + "\n" +
                                                  "DateLeaving: " + rented_Room.END_DATE + "\n" +
                                                  "Reservation Identifier:" + rented_Room.ReservationID;
        }
        private void MakeReservation()
        {
            switch(MessageBox.Show("Making reservation?", "Room available", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            Entities.Rent_Rooms rent = new Entities.Rent_Rooms(dateComming_picker.Value, dateLeaving_picker.Value, Int32.Parse(tb_RoomID.Text),tb_UniqueClientID.Text);
                            DAL.Dal_Rent_Rooms.InsertRenter(rent);
                            AddConfirmationRichTextbox(rent);
                            //MessageBox.Show("Room succesfully Rented in period " + dateComming_picker.Value.ToString() + "-" + dateLeaving_picker.Value.ToString());
                            //this.Close(); 
                        }
                        catch(OracleException OE)
                        {

                            DAL.Log.LogMessage(OE);
                            MessageBox.Show("Error occured!");
                        }
                        break;
                    }
                case DialogResult.No:
                    {

                        break;
                    }
            }

        }
        /// <summary>
        /// Updates all the textboxes from the Reservation Form with the current values of the curent selected row in Form1's gridview
        /// </summary>
        public void AllTextboxReservation_Update()
        {
            var Room = Form1.ReserveRoom;

            tb_Hotel.Text = Room.Hotel_ID.ToString();
            tb_RoomID.Text = Room.Room_ID.ToString();
            tb_RoomType.Text = Room.Room_Name;
            tb_FamilyOriented.Text = Room.FamilyType;
            tb_UniqueClientID.Text = GenerateUniqueID();


        }
        private string GenerateUniqueID()
        {
            string UniqueID = DateTime.UtcNow.ToString("HHyyfff-MMddss-ssfff-");
            Random r = new Random();
            return UniqueID + r.Next(1000).ToString();
        }
        private void ReserveRoom_Load(object sender, EventArgs e)
        {
            AllTextboxReservation_Update();
            Error_LABEL.Text = "";
            dateComming_picker.CustomFormat = "dd MMM yyyy";
            dateLeaving_picker.CustomFormat = "dd MMM yyyy";
        }
    }
}
