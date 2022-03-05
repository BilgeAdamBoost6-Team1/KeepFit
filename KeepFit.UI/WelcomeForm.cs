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
    public partial class WelcomeForm : MetroSetForm
    {
        private readonly AppDbContext db;
        private readonly User logUser;

        public WelcomeForm(AppDbContext db, User logUser)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;
            lblHelloUser.Text = logUser.Name.ToString();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            lblHelloUser.Text = logUser.Name.ToString();
        }   

        private void btnStart_Click(object sender, EventArgs e)
        {
            MainForm frm = new MainForm(db,logUser);
            frm.Show();
            this.Hide();
        }
    }
}
