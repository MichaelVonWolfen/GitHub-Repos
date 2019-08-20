using Bunifu.Framework.UI;
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
    public partial class LogInForm : Bunifu.Framework.UI.BunifuForm
    {
        private List<BunifuGradientPanel> Panels;
        public LogInForm()
        {
            InitializeComponent();
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            Panels = new List<BunifuGradientPanel>();
            Panels.Add(registerPanel);
            Panels.Add(bunifuGradientPanel1);

            Panels[0].Hide();

            drop_month.Items.Add("Month");
            drop_month.SelectedItem("Month");
            Drop_year.Items.Add("Year");
            Drop_year.SelectedItem("Year");

            int year = DateTime.Now.Year;

            for (int i = 0; i <= 10; i++)
            {
                Drop_year.Items.Add(year + i);
            }
            for (int i = 1; i <= 12; i++)
            {
                drop_month.Items.Add(i);
            }
        }

        private void BunifuTextBox1_TextChange(object sender, EventArgs e)
        {
            Tb_password.UseSystemPasswordChar = true;
        }

        private void B_CommitReservation_Click(object sender, EventArgs e)
        {
            try
            {
                Entities.User user = new Entities.User(tb_Username.Text, Tb_password.Text);

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Panels[0].Show();
            Panels[1].Hide();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Panels[1].Show();
            Panels[0].Hide();
        }

        private void Registration_btn_Click(object sender, EventArgs e)
        {
            //Registration area
            try
            {
                Entities.User user = new Entities.User(reg_username.Text, reg_password.Text, reg_email.Text,reg_cardNumber.Text, reg_cvv.Text, drop_month.selectedValue, Drop_year.selectedValue);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
