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
            MainForm mainForm = new MainForm(db, logUser);
            mainForm.Show();
            this.Hide();
        }
        private void deleteMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Selected meal deleting, Are you sure ?", "Deleting", MessageBoxButtons.YesNo);
            if (dgvOgunlerim.SelectedRows.Count > 0)
            {
                if (result == DialogResult.Yes)
                {
                    int id = (int)dgvOgunlerim.SelectedRows[0].Cells[0].Value;
                    Meal silinecekMeal = db.Meal.FirstOrDefault(x => x.MealId == id);
                    db.Meal.Remove(silinecekMeal);
                    db.SaveChanges();
                    mealListele();
                }
            }
        }
        private void updateMealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvOgunlerim.SelectedRows.Count > 0)
            {
                int id = (int)dgvOgunlerim.SelectedRows[0].Cells[0].Value;
                Meal updateMeal = db.Meal.FirstOrDefault(x => x.MealId == id);
                MealForm updateForm = new MealForm(db, logUser, updateMeal);
                updateForm.ShowDialog();
                mealListele();
            }
        }
        Food selectedMeal = new Food();
        void mealListele()
        {
            dgvOgunlerim.Rows.Clear();
            foreach (var item in logUser.Meals.ToList())
            {
                if (item.CreateTime.Date == dtpMealDate.Value.Date)
                {
                    dgvOgunlerim.Rows.Add(item.MealId, item.MealName, item.MealType);
                }
            }
        }
        private void dgvOgunlerim_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvOgunlerim.HitTest(e.X, e.Y);
                if (hti.RowIndex < 0)
                {
                    contextMenuStrip1.Visible = false;
                    return;
                }
                dgvOgunlerim.Rows[hti.RowIndex].Selected = true;
            }
        }
        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            mealListele();
        }
        private void dgvOgunlerim_SelectionChanged(object sender, EventArgs e)
        {
            dgvListelenecekYemek.Rows.Clear();
            if (dgvOgunlerim.SelectedRows.Count > 0)
            {
                try
                {
                    int id = (int)dgvOgunlerim.SelectedRows[0].Cells[0].Value;
                    Meal meal = db.Meal.FirstOrDefault(x => x.MealId == id);
                    if (meal != null)
                    {
                        foreach (var item in meal.Foods.ToList())
                        {
                            dgvListelenecekYemek.Rows.Add(item.FoodName);
                        }
                    }
                }
                catch
                {

                    MessageBox.Show("vutututut");
                }

            }
        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            MealForm mealForm = new MealForm(db, logUser);
            mealForm.ShowDialog();
            mealListele();
        }

        private void MealCRUDForm_Load(object sender, EventArgs e)
        {
            mealListele();
        }

        private void MealCRUDForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
