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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepFit.UI
{
    public partial class LoginForm : MetroSetForm
    {
        AppDbContext db = new AppDbContext();
        bool passwordStatus = true;

        public LoginForm(string status)
        {
            InitializeComponent();
            this.status = status;
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        User logUser;
        private readonly string status;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroSetMessageBox.Show(this, "Email or password cannot be empty.");
                return;
            }
            else
            {
                logUser = db.User.FirstOrDefault(x => x.Email == txtEmail.Text);
                if (logUser == null || logUser.Password != txtPassword.Text)
                {
                    MetroSetMessageBox.Show(this, "Wrong email or password.", "Wrong!");
                }
                else
                {
                    if (status == "new")
                    {
                        WelcomeForm frm = new WelcomeForm(db, logUser);
                        frm.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MainForm mainForm = new MainForm(db, logUser);
                        mainForm.ShowDialog();
                        this.Hide();
                    }
                }
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void pbPasswordSee_Click(object sender, EventArgs e)
        {
            if (passwordStatus == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                passwordStatus = false;
            }
            else if (passwordStatus == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                passwordStatus = true;
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
