using KeepFit.Data;
using KeepFit.Model;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace KeepFit.UI
{
    public partial class ProfileForm : MetroSetForm
    {
        private readonly AppDbContext db;
        private readonly User logUser;
        bool status = true;
       


        public ProfileForm(AppDbContext db, User logUser)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;


            cmbLifeStyle.DataSource = Enum.GetValues(typeof(LifeStyle));
            cmbGoal.DataSource = Enum.GetValues(typeof(Goal));
            btnUpdate.Enabled = false;

            cmbHeight.SelectedIndex = (logUser.Height) - 100;
            cmbWeight.SelectedIndex = (logUser.Weight) - 40;
            cmbGoal.SelectedItem = logUser.Goal;
            cmbLifeStyle.SelectedItem = logUser.LifeStyle;

            lblName1.Text = logUser.Name;
            lblSurName1.Text = logUser.Surname;
            lblEmail1.Text = logUser.Email;
            lblBirthdate1.Text = logUser.BirthDate.ToShortDateString();
            var gender = logUser.Gender.ToString();
            lblGender1.Text = gender;
           
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[$@!%*?+#&'()[=\"€])[A-Za-z\\d$@!%*?+#&'()[=\"€']{8,16}");
            if (!regex.IsMatch(txtPassword.Text))
            {
                lblPassword.Text = "Weak password.";
            }
            else
            {
                lblPassword.Text = "";
            }
        }

        private void txtPasswordAgain_TextChanged_1(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                lblPasswordControl.Text = "Passwords did not match.";
            }
            else
            {
                lblPasswordControl.Text = "";
                btnUpdate.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPasswordAgain.UseSystemPasswordChar = false;
                status = false;
            }
            else if (status == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPasswordAgain.UseSystemPasswordChar = true;
                status = true;
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UserUpdate();
        }

        private void UserUpdate()
        {
            if (!string.IsNullOrEmpty(txtPassword.Text)&&!string.IsNullOrEmpty(txtPasswordAgain.Text))
            {
                int oldPassword =Convert.ToInt32( logUser.Password);
                int newPassword = Convert.ToInt32(txtPassword.Text);
                if (oldPassword==newPassword)
                {
                    MessageBox.Show("Old password and new password shouldn't be same.");
                }
                if (txtPassword.Text != txtPasswordAgain.Text)
                {
                    MessageBox.Show("Passwords not match!");
                    return;
                }
                else
                {
                    logUser.Height= Convert.ToInt32(cmbHeight.SelectedItem);
                    logUser.Weight= Convert.ToInt32(cmbWeight.SelectedItem);
                    logUser.Goal= (Goal)cmbGoal.SelectedItem;
                    logUser.LifeStyle= (LifeStyle)cmbLifeStyle.SelectedItem;
                    logUser.Password= txtPassword.Text;

                    db.SaveChanges();
                    MessageBox.Show("Successfull update.");
                    txtPassword.Text = "";
                    txtPasswordAgain.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please fill all the areas.");
            }
        }

        public bool Gonder(string konu, string icerik)
        {
            MailMessage ePosta = new MailMessage();
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("keepfitTeam1@outlook.com", "111KeepFitTeam%");
            smtp.Port = 587;
            smtp.Host = "smtp-mail.outlook.com";
            smtp.EnableSsl = true;
            ePosta.To.Add("keepfitTeam1@outlook.com");
            ePosta.From = new MailAddress("keepfitTeam1@outlook.com");           
            
            ePosta.Subject = konu;
            
            ePosta.Body = icerik;      

            object userState = ePosta;
            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
                MessageBox.Show("Thank you for your sharing with us!");
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Fail");
            }
            return kontrol;
        }

        private void btnSendExperience_Click(object sender, EventArgs e)
        {
            Gonder("user experience", rtbExperience.Text);
        }
        
        private void rtbExperience_TextChanged(object sender)
        {
            
            int character = Convert.ToInt32(lblCharacter.Text);
            if (character<=0)
            {
                btnSend.Enabled = false;
            }
            else
            {
                character = character - 1;
                lblCharacter.Text = Convert.ToString(character);
            }
            
        }
    }
}
