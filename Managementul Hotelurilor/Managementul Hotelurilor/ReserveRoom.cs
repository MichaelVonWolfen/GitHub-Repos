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
using System.Net.Mail;
using System.Globalization;

namespace Managementul_Hotelurilor
{
    public partial class ReserveRoom : MetroFramework.Forms.MetroForm
    {
        private double VAT;
        private string currency;
        public ReserveRoom(string Country)
        {
            InitializeComponent();
            try
            {
                //List<RegionInfo> Reg = new List<RegionInfo>();

                VAT = DAL.GlobalDictionary.Vat[Country];
                var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
                var Region = regions.FirstOrDefault(region => region.EnglishName.Contains(Country));
                currency = Region.CurrencySymbol;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                richTextBox_ConfReservationOrShowError.ForeColor = Color.Red;
                richTextBox_ConfReservationOrShowError.Text = "Error:\n" + timeComming.ToString("dd MMM yyyy") + " greater than " + timeLeaving.Date.ToString("dd MMM yyyy") +
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
            richTextBox_ConfReservationOrShowError.ForeColor = Color.FromArgb(52, 106, 237);
            richTextBox_ConfReservationOrShowError.Text = String.Format("Confirm Reservation!\n" +
                                                  "User: UNDEFINED TODO :P\n" +
                                                  "Room ID: " + rented_Room.ROOM_ID + "\n" +
                                                  "Date Coming: " + rented_Room.START_DATE + "\n" +
                                                  "DateLeaving: " + rented_Room.END_DATE + "\n" +
                                                  "Reservation Identifier:" + rented_Room.ReservationID + "\n\n" +
                                                  "Total Cost: " + AddVAT(Form1.ReserveRoom.Price, VAT) + " " + currency);
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

                            //DONE: Send a confirmation email
                            SendEmail();
                            //Solved: Add all data to a CSV file

                            SaveToCSV(rent, Form1.ReserveRoom);

                            //MessageBox.Show("Room succesfully Rented in period " + dateComming_picker.Value.ToString() + "-" + dateLeaving_picker.Value.ToString());
                            //this.Close(); 
                        }
                        catch (OracleException OE)
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


            tb_Hotel.Text = DAL.GlobalDictionary.HotelsDictionary[Room.Hotel_ID].ToString();
            tb_RoomID.Text = Room.Room_ID.ToString();
            tb_RoomType.Text = Room.Room_Name;
            tb_FamilyOriented.Text = Room.FamilyType;
            tb_UniqueClientID.Text = GenerateUniqueID();

            double price = AddVAT(Room.Price, VAT);
            //TO DO: Add checker for switz pricing
            tb_Price.Text = (price).ToString() +" "+ currency;
            


        }
        private string GenerateUniqueID()
        {
            string UniqueID = DateTime.UtcNow.ToString("HHyyfff-MMddss-ssfff-");
            Random r = new Random();
            return UniqueID + r.Next(1000).ToString();
        }
        private void ReserveRoom_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            AllTextboxReservation_Update();
            richTextBox_ConfReservationOrShowError.Text = "";
            dateComming_picker.CustomFormat = "dd MMM yyyy";
            dateLeaving_picker.CustomFormat = "dd MMM yyyy";
        }

        private void SendEmail()
        {
            var Room = Form1.ReserveRoom;
         
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("hotelmanagement8.2019@gmail.com");
                mail.To.Add("mihai_stoica66@yahoo.com");
                mail.Subject = "Confirm Reservation.";
                mail.Body = String.Format("\tWe happily confirm your reservation in room {0}, in the Hotel {1}," +
                                            "with is {2} that costs {3} {8} per day." +
                                            "\n\t Your reservation starts on {4} and ends on {5}." +
                                            "\n\n\t\t\tTotal Price:{7} {8}\n" +
                                            "\nFor any issues please use your order ID when contacting us: {6}" +
                                            "\n\n Have a nice day! :)",
                                            Room.Room_ID,DAL.GlobalDictionary.HotelsDictionary[Room.Hotel_ID], Room.FamilyType, AddVAT(Room.Price, VAT), dateComming_picker.Value.ToString("dd MM yyyy"), dateLeaving_picker.Value.ToString("dd MM yyyy"),
                                            tb_UniqueClientID.Text,GetFullPriceWithVAT(Room.Price,VAT), currency);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("hotelmanagement8.2019", "HotelManagement#1");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Confirmation mail Sent!");
            
           
        }
        private void SaveToCSV(Entities.Rent_Rooms rent_Rooms, Entities.Rooms rooms)
        {
            DAL.Log.WriteCSV(rent_Rooms, rooms);
        }
        private double AddVAT(double costWithoutVAT, double VAT)
        {
            double costWithVAT;
            costWithVAT = costWithoutVAT * (1 + VAT / 100);
            if (costWithVAT - (int)costWithVAT > 0.5)
                return (int)costWithVAT + 0.5;
            else
                return (int)costWithVAT;
            
        }
        private double GetFullPrice(double price)
        {
            return price * (dateLeaving_picker.Value - dateComming_picker.Value).TotalDays;
        }
        private double GetFullPriceWithVAT(double price, double VAT)
        {
            return AddVAT(GetFullPrice(price), VAT);
        }
        private void DateLeaving_picker_ValueChanged(object sender, EventArgs e)
        {
            tb_FullPrice.Text = string.Format("{0} {1}",GetFullPriceWithVAT(Form1.ReserveRoom.Price, VAT),currency);
            tb_FullPriceNoVAT.Text = string.Format("{0} {1}", GetFullPrice(Form1.ReserveRoom.Price), currency);
        }

        private void DateComming_picker_ValueChanged(object sender, EventArgs e)
        {
            tb_FullPrice.Text = string.Format("{0} {1}", GetFullPriceWithVAT(Form1.ReserveRoom.Price, VAT), currency);
            tb_FullPriceNoVAT.Text = string.Format("{0} {1}", GetFullPrice(Form1.ReserveRoom.Price), currency);
        }

        private void B_calculator_Click(object sender, EventArgs e)
        {
            try
            {
                tb_Manually_CalculatedFullPrice.Text = String.Format("{0} {1}", AddVAT(Double.Parse(tb_ManualPrice.Text), Double.Parse(tb_ManualVAT.Text)), currency);
            }
            catch (Exception)
            {

            }
        }
    }
}
