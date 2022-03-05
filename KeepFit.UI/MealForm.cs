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
    public partial class MealForm : MetroSetForm
    {
        private readonly AppDbContext db;
        private readonly User logUser;

        public MealForm(AppDbContext db, User logUser)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;
            //FoodForm foodForm = new FoodForm(db, logUser);
            //if (cmbOgunleriListele.SelectedIndex == 0)
            //{
            //    foreach (var item in logUser.Food)
            //    {

            //    }
            //}
        }

        private void MealForm_Load(object sender, EventArgs e)
        {
            dtpMeal.MaxDate = DateTime.Now;
            cmbOgunleriListele.DataSource = Enum.GetValues(typeof(MealType));
        }
        private void btnOgunDuzenle_Click(object sender, EventArgs e)
        {
            MealCRUDForm mealCRUDForm = new MealCRUDForm(db, logUser);
            mealCRUDForm.Show();
            this.Hide();
        }

        private void cmbOgunleriListele_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOgunleriListele.SelectedIndex ==0)
            {
                //Food selectedMeal = (Food)cmbOgunleriListele.SelectedItem;
                //Food selectedMeal=(Food)flpOgunListele.
            }
        }
    }
}
