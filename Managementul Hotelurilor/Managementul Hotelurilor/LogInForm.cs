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
        private string CardNumber;
        private string CVV;
        private DateTime ExpirationDate;
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
            catch (Exception ex)
            {
                DAL.Log.LogMessage(ex);
                MessageBox.Show(ex.Message);
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
                Entities.User user = new Entities.User(reg_username.Text, reg_password.Text, reg_email.Text);
                DAL.DalUsers.AddNewUser(user);
            }
            catch (Exception ex)
            {

                DAL.Log.LogMessage(ex);
                MessageBox.Show("Error while adding user! Try again later.");
                Application.Exit();
            }
        }

        private void RegisterPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
