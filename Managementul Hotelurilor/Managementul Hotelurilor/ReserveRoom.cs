using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Managementul_Hotelurilor
{
    public partial class ReserveRoom : MetroFramework.Forms.MetroForm
    {
        private double VAT;
        private string currency;
        private string UniqueID;
        private string country_name;
        private Entities.RentCars rentedCar = null;
        private readonly string Standard_currency = "USD";
        private bool alreadyGeneratedID;
        private string Car;
        public ReserveRoom(string Country)
        {
            InitializeComponent();
            try
            {
                //List<RegionInfo> Reg = new List<RegionInfo>();

                VAT = DAL.GlobalDictionary.Vat[Country];

                Form1.ReserveRoom.Price = float.Parse(CurrencyConversion((decimal)Form1.ReserveRoom.Price, Standard_currency, GetHotelRegionCurrencyISO(Country)));
                country_name = Country;
                Label_Barcode.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        string GetHotelRegionCurrencyISO(string Country)
        {
            var regions = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(x => new RegionInfo(x.LCID));
            var Region = regions.FirstOrDefault(region => region.EnglishName.Contains(Country));
            currency = Region.CurrencySymbol;

            return Region.ISOCurrencySymbol;
        }
        private const string urlPattern = "http://rate-exchange-1.appspot.com/currency?from={0}&to={1}";

        public string CurrencyConversion(decimal amount, string fromCurrency, string toCurrency)
        {
            string url = string.Format(urlPattern, fromCurrency, toCurrency);

            using (var wc = new WebClient())
            {
                var json = wc.DownloadString(url);

                Newtonsoft.Json.Linq.JToken token = Newtonsoft.Json.Linq.JObject.Parse(json);
                decimal exchangeRate = (decimal)token.SelectToken("rate");

                return (amount * exchangeRate).ToString();
            }
        }
        private void B_CommitReservation_Click(object sender, EventArgs e)
        {
            DateTime timeComming = dateComming_picker.Value;
            DateTime timeLeaving = dateLeaving_picker.Value;
            //if time coming> timeleaving => Error (you can't leave before you come
            if (tb_FamilyOriented.Text == "" || tb_Hotel.Text == "" || tb_RoomID.Text == "" || tb_RoomType.Text == "")
            {
                MessageBox.Show("ERROR!\nNo Room selected.");
                return;
            }
            if (timeLeaving.CompareTo(timeComming) < 0)
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
            if (Switch_CarRent.Value == true)
            {
                Car = string.Format("Car rented: {0}.", comboBox_selectCarType.Text);
            }
            else
            {
                Car = "No car selected";
            }
            richTextBox_ConfReservationOrShowError.ForeColor = Color.FromArgb(52, 106, 237);
            richTextBox_ConfReservationOrShowError.Text = String.Format("\t\t\t\t\tConfirm Reservation!\n" +
                                                  "User: UNDEFINED TODO :P\n\n" +
                                                  "Room ID: " + rented_Room.ROOM_ID + "\n" +
                                                  "Date Coming: " + rented_Room.START_DATE + "\n" +
                                                  "DateLeaving: " + rented_Room.END_DATE + "\n\n" +
                                                  Car + "\n\n" +
                                                  "Reservation Identifier:" + rented_Room.ReservationID + "\n\n" +
                                                  "\t\t\t\t\tTotal Cost: " + AddVAT(Form1.ReserveRoom.Price + GetCarPrice(), VAT) + " " + currency);
            //TODO: ADD Details of car to facture and e-mail and add to database tha fact that a car is rented.
        }
        double GetCarPrice()
        {
            if (rentedCar == null)
            {
                return 0;
            }
            else
            {
                return rentedCar.RENT_PRICE;
            }
        }
        private void MakeReservation()
        {
            switch (MessageBox.Show("Making reservation?", "Room available", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    {
                        try
                        {
                            Entities.Rent_Rooms rent = new Entities.Rent_Rooms(dateComming_picker.Value, dateLeaving_picker.Value, Int32.Parse(tb_RoomID.Text), tb_UniqueClientID.Text);
                            if (rentedCar != null)
                                DAL.Dal_Rent_Rooms.InsertRenter(rent, rentedCar);
                            else
                                DAL.Dal_Rent_Rooms.InsertRenter(rent, null);

                            AddConfirmationRichTextbox(rent);

                            //DONE: Send a confirmation email
                            SendEmail();
                            //Solved: Add all data to a CSV file

                            SaveToCSV(rent, Form1.ReserveRoom);

                            //MessageBox.Show("Room succesfully Rented in period " + dateComming_picker.Value.ToString() + "-" + dateLeaving_picker.Value.ToString());
                            //this.Close(); 

                            GenerateBarCodeinPictureBox(UniqueID, PB_Barcode);
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

            if (!alreadyGeneratedID)
            {
                UniqueID = GenerateUniqueID();
                tb_UniqueClientID.Text = UniqueID;
            }
            double price = AddVAT(Room.Price + GetCarPrice(), VAT);
            //TO DO: Add checker for switz pricing
            tb_Price.Text = (price).ToString() + " " + currency;

            tb_FullPrice.Text = string.Format("{0} {1}", GetFullPriceWithVAT(Form1.ReserveRoom.Price + GetCarPrice(), VAT), currency);
            tb_FullPriceNoVAT.Text = string.Format("{0} {1}", GetFullPrice(Form1.ReserveRoom.Price + GetCarPrice()), currency);



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
            alreadyGeneratedID = true;
            richTextBox_ConfReservationOrShowError.Text = "";
            dateComming_picker.CustomFormat = "dd MMM yyyy";
            dateLeaving_picker.CustomFormat = "dd MMM yyyy";
            Switch_CarRent.Value = false;
        }

        private void SendEmail()
        {
            var Room = Form1.ReserveRoom;

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

            mail.From = new MailAddress("hotelmanagement8.2019@gmail.com");
            mail.To.Add("mihai.stoica98@gmail.com");
            mail.Subject = "Confirm Reservation.";
            mail.Body = String.Format("\tWe happily confirm your reservation in room {0}, in the Hotel {1}," +
                                        "with is {2} that costs {3} {8} per day." +
                                        "\n\t Your reservation starts on {4} and ends on {5}." +
                                        "{9} per day" +
                                        "\n\n\t\t\tTotal Price:{7} {8}\n" +
                                        "\nFor any issues please use your order ID when contacting us: {6}" +
                                        "\n\n Have a nice day! :)",
                                        Room.Room_ID, DAL.GlobalDictionary.HotelsDictionary[Room.Hotel_ID], Room.FamilyType, AddVAT(Room.Price + GetCarPrice(), VAT), dateComming_picker.Value.ToString("dd MM yyyy"), dateLeaving_picker.Value.ToString("dd MM yyyy"),
                                        tb_UniqueClientID.Text, GetFullPriceWithVAT(Room.Price + GetCarPrice(), VAT), currency, Car);

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
        #region VAT Calculator region
        private double AddVAT(double costWithoutVAT, double VAT)
        {
            double costWithVAT;
            costWithVAT = costWithoutVAT * (1 + VAT / 100);
            return AproximatePrice(costWithVAT);

        }
        private double AproximatePrice(double price)
        {
            if (country_name == "Switzerland")
                if (price * 10 - (int)(price * 10) > 0.5)
                    return Convert.ToDouble((Convert.ToInt32(price * 10)) + 0.5) / 10;
                else
                    return Convert.ToDouble(Convert.ToInt32(price * 10)) / 10;
            else return Convert.ToDouble(Convert.ToInt32(price * 100)) / 100;
        }
        private double GetFullPrice(double price)
        {
            return AproximatePrice(price * (dateLeaving_picker.Value - dateComming_picker.Value).TotalDays);
        }
        private double GetFullPriceWithVAT(double price, double VAT)
        {
            return AddVAT(GetFullPrice(price), VAT);
        }
        private void DateLeaving_picker_ValueChanged(object sender, EventArgs e)
        {
            tb_FullPrice.Text = string.Format("{0} {1}", GetFullPriceWithVAT(Form1.ReserveRoom.Price + GetCarPrice(), VAT), currency);
            tb_FullPriceNoVAT.Text = string.Format("{0} {1}", GetFullPrice(Form1.ReserveRoom.Price + GetCarPrice()), currency);
        }

        private void DateComming_picker_ValueChanged(object sender, EventArgs e)
        {
            tb_FullPrice.Text = string.Format("{0} {1}", GetFullPriceWithVAT(Form1.ReserveRoom.Price + GetCarPrice(), VAT), currency);
            tb_FullPriceNoVAT.Text = string.Format("{0} {1}", GetFullPrice(Form1.ReserveRoom.Price + GetCarPrice()), currency);
        }

        #endregion
        private void GenerateBarCodeinPictureBox(string code, PictureBox box)
        {
            Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            box.Image = barcodeDraw.Draw(code, box.Height);
            Label_Barcode.Text = code;
        }
        #region Calculator Region 

        private double ManualCalculation = 0.0;
        private string operand = null;
        bool calculation_made = false;
        private void AddNumber(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(((Bunifu.UI.WinForms.BunifuButton.BunifuButton)sender).ButtonText);
                for (int i = 0; i <= 9; i++)
                {
                    if (calculation_made)
                        ClearScreen();
                    if (i == number)
                    {
                        string t = tb_Manually_CalculatedFullPrice.Text;
                        t += number;
                        tb_Manually_CalculatedFullPrice.Text = t;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured.");
                DAL.Log.LogMessage(ex);
            }

        }

        private void OperandClick(object sender, EventArgs e)
        {
            string[] operands = { "x", "--", "+", "/" };

            foreach (string s in operands)
            {
                if ((sender as Bunifu.UI.WinForms.BunifuButton.BunifuButton).ButtonText == s)
                    if (operand == null)
                    {
                        ManualCalculation = double.Parse(tb_Manually_CalculatedFullPrice.Text);
                        tb_Manually_CalculatedFullPrice.Text = null;
                        tb_Manually_CalculatedFullPrice.TextPlaceholder = ManualCalculation.ToString();
                        operand = s;
                    }
                    else
                    {
                        AddCalculation();
                        operand = s;
                    }
            }


        }
        private double Calculate(double n1, double n2, string operand)
        {
            switch (operand)
            {
                case "+":
                    return n1 + n2;
                case "--":
                    return n1 - n2;
                case "x":
                    return n1 * n2;
                case "/":
                    return n1 / n2;
                default:
                    {
                        MessageBox.Show("Error with operands");
                        return 0.0;
                    }
            }
        }
        private void AddCalculation()
        {
            ManualCalculation = Calculate(ManualCalculation, double.Parse(tb_Manually_CalculatedFullPrice.Text), operand);
            tb_Manually_CalculatedFullPrice.Text = ManualCalculation.ToString();
            calculation_made = true;
        }
        private void ClearScreen()
        {
            tb_Manually_CalculatedFullPrice.Text = null;
            calculation_made = false;

        }
        private void Operand_equal_Click(object sender, EventArgs e)
        {
            if ((sender as Bunifu.UI.WinForms.BunifuButton.BunifuButton).ButtonText == "=")
            {
                AddCalculation();
                operand = null;
            }
        }

        private void OperandPointClick(object sender, EventArgs e)
        {
            if ((sender as Bunifu.UI.WinForms.BunifuButton.BunifuButton).ButtonText == ".")
            {
                string t = tb_Manually_CalculatedFullPrice.Text;
                t += ".";
                tb_Manually_CalculatedFullPrice.Text = t;
            }
        }

        private void ClearScreenClick(object sender, EventArgs e)
        {
            tb_Manually_CalculatedFullPrice.TextPlaceholder = "";
            operand = null;
            ManualCalculation = 0.0;
            ClearScreen();
        }

        #endregion

        private void Switch_CarRent_OnValuechange(object sender, EventArgs e)
        {
            if (Switch_CarRent.Value == true)
            {
                comboBox_selectCarType.Enabled = true;
                //Call procedure to get all data for renting cars
                try
                {
                    DAL.Dal_RentCars.Get_Cars_Rent(Form1.ReserveRoom.Hotel_ID);

                }
                catch (OracleException ex)
                {
                    DAL.Log.LogMessage(ex);
                }
                comboBox_selectCarType.Sorted = true;
                foreach (Entities.RentCars cars in DAL.Dal_RentCars.Rents)
                {
                    comboBox_selectCarType.Items.Add(GetAproximatedPriceString(cars));
                }
            }
            else if (Switch_CarRent.Value == false)
            {
                comboBox_selectCarType.Enabled = false;
                comboBox_selectCarType.Text = null;
                rentedCar = null;
                comboBox_selectCarType.Items.Clear();
                AllTextboxReservation_Update();
            }
        }
        string GetAproximatedPriceString(Entities.RentCars cars)
        {
            return String.Format("{0} ({1} {2})", cars.CAR_NAME_TYPE,
                                                    AproximatePrice(Convert.ToDouble(CurrencyConversion(Convert.ToDecimal(cars.RENT_PRICE), Standard_currency, GetHotelRegionCurrencyISO(country_name)))),
                                                    currency);
        }
        private void ComboBox_selectCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get price of car from combobox

            foreach (var rent in DAL.Dal_RentCars.Rents)
            {
                if (comboBox_selectCarType.Text == GetAproximatedPriceString(rent))
                {
                    rentedCar = rent;
                    break;
                }
            }
            AllTextboxReservation_Update();
        }

        private void BunifuLabel13_Click(object sender, EventArgs e)
        {
            //TODO: Add Terms and Conditions
        }

        private void Check_TermsAndConditions_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (Check_TermsAndConditions.Checked == true)
                b_CommitReservation.Enabled = true;
            else b_CommitReservation.Enabled = false;
        }
    }
}
