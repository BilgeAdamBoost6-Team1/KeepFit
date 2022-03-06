using KeepFit.Data;
using KeepFit.Model;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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
        private readonly Meal updateMeal;
        Food selectedMeal = new Food();
        Meal mealTotal = new Meal();
        Food foodTotal = new Food();
        bool update = false;
        ObservableCollection<MealsFoods> mealsList = new ObservableCollection<MealsFoods>();
        public MealForm(AppDbContext db, User logUser, Meal updateMeal)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;
            this.updateMeal = updateMeal;
            mealsList = updateMeal.Foods;
            btnAddMeal.Text = "Update";
            txtMealName.Text = updateMeal.MealName;
            cmbMealType.SelectedItem = updateMeal.MealType;
            foodList();
            totalValues();
            dtpMealDate.Visible = false;
            btnDelete.Visible = false;
            update = true;
        }
        public MealForm(AppDbContext db, User logUser)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;
            btnDeleteUpdate.Visible = false;
        }
        private void HandleChange(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (var x in e.NewItems)
                {
                    totalValues();
                }
            }
            if (e.OldItems != null)
            {
                foreach (var y in e.OldItems)
                {
                    totalValues();
                }
            }
            if (e.Action == NotifyCollectionChangedAction.Move)
            {
            }
        }
        private void totalValues()
        {
            decimal totalCalorie = 0;
            decimal totalProtein = 0;
            decimal totalCarbohydrate = 0;
            decimal totalFat = 0;
            decimal totalGram = 0;
            foreach (var item in mealsList)
            {
                totalCalorie += item.Calorie;
                totalProtein += item.Protein;
                totalCarbohydrate += item.Carbohydrate;
                totalFat += item.Fat;
                totalGram += item.Gram;
            }
            lblGelenCalorie.Text = totalCalorie.ToString();
            lblGelenProtein.Text = totalProtein.ToString();
            lblGelenCarbohydrate.Text = totalCarbohydrate.ToString();
            lblGelenFat.Text = totalFat.ToString();
            lblGelenGram.Text = totalGram.ToString();
        }
        void mealTypeComboBox()
        {
            cmbMealType.DataSource = Enum.GetValues(typeof(MealType));
            cmbUnit.DataSource = Enum.GetValues(typeof(Unit));
            cmbUnit.SelectedIndex = 0;
            cmbMealType.SelectedIndex = 0;
        }
        void foodList()
        {
            dgvEklenenOgun.Rows.Clear();
            foreach (var item in mealsList)
            {
                dgvEklenenOgun.Rows.Add(item.FoodId, item.FoodName, item.Picture, item.Calorie, item.Protein, item.Carbohydrate, item.Fat, item.Gram);
            }
        }
        void fillFoodList()
        {
            dgvOgunListele.Rows.Clear();
            foreach (var item in db.Food.ToList())
            {
                switch (logUser.LifeStyle)
                {
                    case LifeStyle.Vegetarian:
                        if (item.FoodType == foodType.Vegetables || item.FoodType == foodType.Fruits || item.FoodType == foodType.Grains || item.FoodType == foodType.Eggs || item.FoodType == foodType.DairyFoods || item.FoodType == foodType.Legumes)
                        {
                            dgvOgunListele.Rows.Add(item.FoodId, item.FoodName, item.Picture, item.Calorie, item.Protein, item.Carbohydrate, item.Fat, item.Gram);
                        }
                        break;
                    case LifeStyle.Vegan:
                        if (item.FoodType == foodType.Vegetables || item.FoodType == foodType.Fruits || item.FoodType == foodType.Grains || item.FoodType == foodType.Eggs || item.FoodType == foodType.DairyFoods || item.FoodType == foodType.Legumes)
                        {
                            dgvOgunListele.Rows.Add(item.FoodId, item.FoodName, item.Picture, item.Calorie, item.Protein, item.Carbohydrate, item.Fat, item.Gram);
                        }
                        break;
                    case LifeStyle.GlutenFree:
                        if (item.FoodType == foodType.Vegetables || item.FoodType == foodType.Fruits || item.FoodType == foodType.DairyFoods || item.FoodType == foodType.Legumes || item.FoodType == foodType.RedMeat || item.FoodType == foodType.WhiteMeat || item.FoodType == foodType.Eggs)
                        {
                            dgvOgunListele.Rows.Add(item.FoodId, item.FoodName, item.Picture, item.Calorie, item.Protein, item.Carbohydrate, item.Fat, item.Gram);
                        }
                        break;
                    case LifeStyle.Ketogenic:
                        if (item.FoodType == foodType.Vegetables || item.FoodType == foodType.DairyFoods || item.FoodType == foodType.RedMeat || item.FoodType == foodType.WhiteMeat || item.FoodType == foodType.Eggs)
                        {
                            dgvOgunListele.Rows.Add(item.FoodId, item.FoodName, item.Picture, item.Calorie, item.Protein, item.Carbohydrate, item.Fat, item.Gram);
                        }
                        break;
                    case LifeStyle.Normal:
                        dgvOgunListele.Rows.Add(item.FoodId, item.FoodName, item.Picture, item.Calorie, item.Protein, item.Carbohydrate, item.Fat, item.Gram);
                        break;
                    default:
                        break;
                }
            }
        }
        private void MealForm_Load(object sender, EventArgs e)
        {
            dtpMealDate.MaxDate = DateTime.Now;
            fillFoodList();
            mealTypeComboBox();
            mealsList.CollectionChanged += HandleChange;
        }
        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            fillFoodList();
        }
        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMealName.Text))
            {
                MessageBox.Show("Meal Name required ");
                return;
            }
            if (btnAddMeal.Text == "Add Meal")
            {
                Meal meal = new Meal();
                meal.MealName = txtMealName.Text;
                meal.MealType = (MealType)cmbMealType.SelectedValue;
                meal.Foods = mealsList;
                meal.CreateTime = dtpMealDate.Value;
                logUser.Meals.Add(meal);
                db.SaveChanges();
                MessageBox.Show("Meal added");
                this.Close();
            }
            else
            {
                updateMeal.MealName = txtMealName.Text;
                updateMeal.MealType = (MealType)cmbMealType.SelectedValue;
                db.SaveChanges();
                MessageBox.Show("Meal updated");
                this.Close();
            }
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            if (dgvOgunListele.SelectedRows.Count > 0)
            {
                int id = (int)dgvOgunListele.SelectedRows[0].Cells[0].Value;
                Food food = db.Food.FirstOrDefault(x => x.FoodId == id);
                MealsFoods mealsFoods = new MealsFoods();
                if ((Unit)cmbUnit.SelectedValue == Unit.Gram)
                {
                    mealsFoods.Gram = food.Gram;
                    mealsFoods.Protein = food.Protein;
                    mealsFoods.Calorie = food.Calorie;
                    mealsFoods.Carbohydrate = food.Carbohydrate;
                    mealsFoods.Fat = food.Fat;
                }
                else if ((Unit)cmbUnit.SelectedValue == Unit.Porsion)
                {
                    mealsFoods.Gram = food.Gram / 10 * 3;
                    mealsFoods.Protein = food.Protein / 10 * 3;
                    mealsFoods.Calorie = food.Calorie / 10 * 3;
                    mealsFoods.Carbohydrate = food.Carbohydrate / 10 * 3;
                    mealsFoods.Fat = food.Fat / 10 * 3;
                }
                else if ((Unit)cmbUnit.SelectedValue == Unit.Slice)
                {
                    mealsFoods.Gram = food.Gram / 10 * 2;
                    mealsFoods.Protein = food.Protein / 10 * 2;
                    mealsFoods.Calorie = food.Calorie / 10 * 2;
                    mealsFoods.Carbohydrate = food.Carbohydrate / 10 * 2;
                    mealsFoods.Fat = food.Fat / 10 * 2;
                }
                else if ((Unit)cmbUnit.SelectedValue == Unit.Spoon)
                {
                    mealsFoods.Gram = food.Gram / 10;
                    mealsFoods.Protein = food.Protein / 10;
                    mealsFoods.Calorie = food.Calorie / 10;
                    mealsFoods.Carbohydrate = food.Carbohydrate / 10;
                    mealsFoods.Fat = food.Fat / 10;
                }
                else if ((Unit)cmbUnit.SelectedValue == Unit.Cup)
                {
                    mealsFoods.Gram = food.Gram * 2;
                    mealsFoods.Protein = food.Protein * 2;
                    mealsFoods.Calorie = food.Calorie * 2;
                    mealsFoods.Carbohydrate = food.Carbohydrate * 2;
                    mealsFoods.Fat = food.Fat * 2;
                }
                mealsFoods.Picture = food.Picture;
                mealsFoods.FoodId = food.FoodId;
                mealsFoods.FoodName = food.FoodName;
                mealsFoods.FoodType = food.FoodType;
                if (update == false)
                {
                    mealsList.Add(mealsFoods);
                    foodList();
                }
                else
                {
                    mealsFoods.MealId = updateMeal.MealId;
                    updateMeal.Foods.Add(mealsFoods);
                    db.SaveChanges();
                    foodList();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvEklenenOgun.SelectedRows.Count > 0)
            {
                int deleteId = (int)dgvEklenenOgun.SelectedRows[0].Cells[0].Value;
                MealsFoods deleteFoods = new MealsFoods();
                if (mealsList != null)
                {
                    deleteFoods = mealsList.FirstOrDefault(x => x.FoodId == deleteId);
                    mealsList.Remove(deleteFoods);
                    foodList();
                }
            }
        }
        private void btnDeleteUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEklenenOgun.SelectedRows.Count > 0)
            {
                int deleteId = (int)dgvEklenenOgun.SelectedRows[0].Cells[0].Value;
                MealsFoods deleteFoods = new MealsFoods();
                deleteFoods = db.MealsFoods.FirstOrDefault(x => x.FoodId == deleteId);
                if (deleteFoods != null)
                {
                    db.MealsFoods.Remove(deleteFoods);
                    db.SaveChanges();
                    foodList();
                }
            }
        }
    }
}
