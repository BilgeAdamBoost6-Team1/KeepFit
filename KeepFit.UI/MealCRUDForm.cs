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
    public partial class MealCRUDForm : MetroSetForm
    {
        private readonly AppDbContext db;
        private readonly User logUser;
        public MealCRUDForm(AppDbContext db, User logUser)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;
        }

        private void MealCRUDForm_FormClosing(object sender, FormClosingEventArgs e)
        {           
            MealForm mealForm = new MealForm(db,logUser);
            mealForm.Show();
        }

        private void MealCRUDForm_Load(object sender, EventArgs e)
        {
            //flowLayoutPanel1.DataBindings
            cmbOgunleriListele.DataSource = Enum.GetValues(typeof(MealType));
            cmbLifeStyle.DataSource = Enum.GetValues(typeof(LifeStyle));

        }
    }
}
