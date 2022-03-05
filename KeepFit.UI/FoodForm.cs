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
    public partial class FoodForm : MetroSetForm
    {
        private readonly AppDbContext db;
        public FoodForm(AppDbContext db)
        {
            InitializeComponent();
            this.db = db;
            FoodList();   
            
        }
        private void FoodList()
        {
            dgvFoods.DataSource = db.Food.ToList();
        }
        private void dgvFoods_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = dgvFoods.HitTest(e.X, e.Y);
            if (e.Button == MouseButtons.Right && hti.RowIndex >= 0)
            {
                dgvFoods.ClearSelection();
                dgvFoods.Rows[hti.RowIndex].Selected = true;
                metroSetContextMenuStrip1.Show(dgvFoods, new Point(e.X, e.Y));
            } 
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                MessageBox.Show("Food Name sections cannot be left blank ");
                return;
            }
            if (btnAddFood.Text == "Add Food")
            {
                Food newfood = new Food();
                newfood.FoodType = (foodType)cmbFoodType.SelectedItem;
                newfood.FoodName = txtFoodName.Text;
                newfood.Picture = txtPicture.Text;
                newfood.Gram = 100;
                newfood.Calorie = nudCalorie.Value;
                newfood.Fat = nudFat.Value;
                newfood.Carbohydrate = nudCarbonhydrate.Value;
                newfood.Protein = nudProtein.Value;
                db.Food.Add(newfood);
                if (db.SaveChanges() > 0)
                {
                    MessageBox.Show("New Food Added");
                    cmbFoodType.SelectedIndex = 0;
                    txtFoodName.Text = "";
                    txtPicture.Text = "";
                    nudCalorie.Value = nudCarbonhydrate.Value = nudFat.Value = nudProtein.Value = 0;
                }
                else
                {
                    MessageBox.Show("There was a problem adding food");
                }
            }
            else
            {
                int id = (int)dgvFoods.SelectedRows[0].Cells[0].Value;
                var updateFood = db.Food.Where(x => x.FoodId == id).FirstOrDefault();
                updateFood.FoodName = txtFoodName.Text;
                updateFood.FoodType =(foodType)cmbFoodType.SelectedItem;
                updateFood.Picture = txtPicture.Text;
                updateFood.Gram = 100;
                updateFood.Calorie = nudCalorie.Value;
                updateFood.Fat = nudFat.Value;
                updateFood.Carbohydrate = nudCarbonhydrate.Value;
                updateFood.Protein = nudProtein.Value;
                if (db.SaveChanges()>0)
                {
                    MessageBox.Show("Food İnformation Updated");
                    txtFoodName.Text="";
                    txtPicture.Text = "";
                    cmbFoodType.SelectedIndex = 0;
                    cmbFoodType.SelectedIndex = 0;
                    nudCalorie.Value = nudCarbonhydrate.Value = nudFat.Value = nudProtein.Value = 0 ;
                    btnAddFood.Text = "Add Food";
                }
            }
            FoodList();
        }

        private void FoodForm_Load(object sender, EventArgs e)
        {
            cmbFoodType.DataSource = Enum.GetValues(typeof(foodType));
        }
        
        private void deleteFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count>0)
            {
                DialogResult result = MessageBox.Show("Are you sure the food you selected?","Deletion process",MessageBoxButtons.YesNo);
                if (result==DialogResult.Yes)
                {
                    Food deleteFood = new Food();
                    int id = (int)dgvFoods.SelectedRows[0].Cells[0].Value;
                    deleteFood = db.Food.FirstOrDefault(x => x.FoodId == id);
                    db.Food.Remove(deleteFood);
                    if (db.SaveChanges()>0)
                    {
                        MessageBox.Show("selected food deleted");
                    }
                    FoodList();
                }
            }
        }

        private void updateFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddFood.Text = "Update Food";
            if (dgvFoods.SelectedRows.Count>0)
            {
                Food updateFood = new Food();
                int id = (int)dgvFoods.SelectedRows[0].Cells[0].Value;
                updateFood = db.Food.FirstOrDefault(x => x.FoodId == id);
                cmbFoodType.SelectedItem = updateFood.FoodType;
                txtFoodName.Text = updateFood.FoodName;
                txtPicture.Text = updateFood.Picture;
                nudCalorie.Value = updateFood.Calorie;
                nudFat.Value = updateFood.Fat;
                nudCarbonhydrate.Value = updateFood.Carbohydrate;
                nudProtein.Value = updateFood.Protein;            
            }
        }

        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFoods.SelectedRows.Count>0)
            {
                string imageurl = (string)dgvFoods.SelectedRows[0].Cells[2].Value;
                pboFood.ImageLocation = imageurl;
                pboFood.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
