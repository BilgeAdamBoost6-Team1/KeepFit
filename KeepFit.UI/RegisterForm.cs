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

namespace KeepFit.UI
{
    public partial class RegisterForm : MetroSetForm
    {
        AppDbContext db = new AppDbContext();
        bool status = true;
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = Enum.GetValues(typeof(Gender));
            cmbLifeStyle.DataSource = Enum.GetValues(typeof(LifeStyle));
            cmbGoal.DataSource = Enum.GetValues(typeof(Goal));
            btnRegister.Enabled = false;
            cmbGoal.SelectedIndex = 2;
            cmbLifeStyle.SelectedIndex = 4;
            cmbGender.SelectedIndex = -1;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserRegister();
        }
        public void UserRegister()
        {
            if (!string.IsNullOrEmpty(txtEmail.Text) && db.User.Any(a => a.Email == txtEmail.Text))
            {
                MessageBox.Show("This email adress has been used.");
                return;
            }
            else if (txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("Passwords not match!");
                return;
            }
            else
            {
                if (!string.IsNullOrEmpty(txtName.ToString()) && !string.IsNullOrEmpty(txtSurName.ToString()) && !string.IsNullOrEmpty(txtPassword.ToString()) && !string.IsNullOrEmpty(txtPasswordAgain.ToString()) && cmbHeight.SelectedIndex != -1 && cmbWeight.SelectedIndex != -1)
                {

                    User newUser = new User();
                    newUser.Name = txtName.Text;
                    newUser.Surname = txtSurName.Text;
                    newUser.Email = txtEmail.Text;
                    newUser.BirthDate = dtpBirthdate.Value;
                    newUser.Height = Convert.ToInt32(cmbHeight.SelectedItem);
                    newUser.Weight = Convert.ToInt32(cmbWeight.SelectedItem);
                    newUser.Gender = (Gender)cmbGender.SelectedItem;
                    newUser.Goal = (Goal)cmbGoal.SelectedItem;
                    newUser.LifeStyle = (LifeStyle)cmbLifeStyle.SelectedItem;
                    newUser.Password = txtPassword.Text;
                    db.User.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Successfull registery.");

                    LoginForm frm = new LoginForm("new");
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please fill the required fields.");
                }
            }
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
        private void txtPasswordAgain_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtPasswordAgain.Text)
            {
                lblPasswordControl.Text = "Passwords did not match.";
            }
            else
            {
                lblPasswordControl.Text = "";
                btnRegister.Enabled = true;
            }
        }
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"
                    + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                    + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                    + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                    + @"[a-zA-Z]{2,}))$";
            Regex reStrict = new Regex(patternStrict);
            if (!reStrict.IsMatch(txtEmail.Text))
            {
                lblEmailControl.Text = "Please enter a valid email adress.";
            }
            else
            {
                lblEmailControl.Text = "";
                btnRegister.Enabled = true;
            }
        }                
        private void pbEye_Click(object sender, EventArgs e)
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
        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }
    }
}
