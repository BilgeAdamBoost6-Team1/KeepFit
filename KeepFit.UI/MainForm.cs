using KeepFit.Data;
using KeepFit.Model;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KeepFit.UI
{
    public partial class MainForm : MetroSetForm
    {
        AppDbContext db;
        private readonly User logUser;

        public MainForm(AppDbContext db, User logUser)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;

        }
    

        private void MainForm_Load(object sender, EventArgs e)
        {

            dtpMealDate.MaxDate = DateTime.Now;
          
            ListMeals();
            FillCharts();
        }

        private void ListMeals()
        {
            flpMeals.Controls.Clear();
            foreach (var item in db.Meal.ToList())
            {
                if (item.CreateTime.Date == dtpMealDate.Value.Date && item.UserId == logUser.UserId)
                {

                    ObservableCollection<MealsFoods> foods = item.Foods;
                    //TODO
                    //Meal kısmının ana paneli.
                    Panel panel = new Panel()
                    {
                        Width = flpMeals.Width - 20,
                        Height = 200,
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.FromArgb(65, 177, 225),
                    };
                    Label label = new Label()
                    {
                        Text = item.MealName,
                        Location = new Point(0, 0),

                        Height = 35,
                        Left = 10,
                        AutoSize = true
                    };
                    Label label2 = new Label()
                    {
                        Text = item.MealType.ToString(),
                        Location = new Point(0, label.Bottom),
                        Height = 35,
                        Left = 10,
                        BorderStyle = BorderStyle.FixedSingle,
                        AutoSize = true

                    };
                    FlowLayoutPanel foodList = new FlowLayoutPanel()
                    {
                        Height = 120,
                        Width = panel.Width - 20,
                        BackColor = Color.FromArgb(30, 30, 30),
                        Location = new Point(0, label2.Bottom),
                        Left = 10,
                        FlowDirection = FlowDirection.TopDown,

                    };
                    Label totalCalori = new Label()
                    {
                        Text = "Meal Total Calorie :" + item.TotalCalorie,
                        Height = 10,
                        AutoSize = true,
                        Location = new Point(panel.Width - 230, label2.Top),

                    };
                    Button deleteButton = new Button()
                    {
                        Image = Properties.Resources.deleteButton,
                        Width = 36,
                        Height = 36,
                        Location = new Point(panel.Width - 36, 0),
                        Tag = item.MealId,
                    };
                    foreach (var food in foods)
                    {                      
        
                            PictureBox foodPicture = new PictureBox()
                            {
                                Height = 70,
                                Width = 60,
                                Left = 10,
                                ImageLocation = food.Picture,
                                Location = new Point(0, 0),

                            };
                            foodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                            foodList.Controls.Add(foodPicture);
                            Label foodName = new Label()
                            {
                                Text = food.FoodName.ToString(),
                                Location = new Point(0, foodPicture.Bottom),
                                Width = (foodPicture.Width),
                                Font = new Font("Arial", 8),
                                AutoSize = true,

                            };
                            foodList.Controls.Add(foodName);                      


                    }

                    deleteButton.Click += paneldelete_Click;
                    panel.Controls.Add(deleteButton);
                    panel.Controls.Add(totalCalori);
                    panel.Controls.Add(label);
                    panel.Controls.Add(label2);
                    panel.Controls.Add(foodList);
                    flpMeals.Controls.Add(panel);

                }
            }

        }
        private void paneldelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MetroSetMessageBox.Show(this, "This meal will be deleted.Are you sure ?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Button deleteMealId = (Button)sender;
                Meal deleteMeal = new Meal();
                deleteMeal = db.Meal.FirstOrDefault(x => x.MealId == (int)deleteMealId.Tag);
                db.Meal.Remove(deleteMeal);

                db.SaveChanges();
            }
            FillCharts();
            ListMeals();
        }

        private void FillCharts()
        {
            //Calorie
            foreach (var series in chCalorie.Series)
            {
                series.Points.Clear();
            }
            decimal recomendedCalorie = logUser.RecomendedCalorie;
            decimal totalCalorie = 0;
            foreach (var meal in logUser.Meals.ToList())
            {
                if (dtpMealDate.Value.Date == meal.CreateTime.Date)
                {
                    totalCalorie += meal.TotalCalorie;
                }
            }
            decimal showingCalorie = recomendedCalorie - totalCalorie;
            if (showingCalorie < 0)
            {
                showingCalorie = 0;
                chCalorie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            }
            else
            {
                chCalorie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            }
            chCalorie.Series["Calorie"].Points.AddXY("Remaining", showingCalorie);
            chCalorie.Series["Calorie"].Points.AddXY("Intake", totalCalorie);

            //Protein

            foreach (var series in chProtein.Series)
            {
                series.Points.Clear();
            }
            double recomendedProtein = 0;

            if (logUser.Goal == Goal.KeepFit)
            {
                recomendedProtein = logUser.Weight * 0.8;
            }
            else if (logUser.Goal == Goal.BuildMuscle)
            {
                recomendedProtein = logUser.Weight * 1.7;
            }
            else if (logUser.Goal == Goal.LoseWeight)
            {
                recomendedProtein = logUser.Weight * 1.3;
            }
            else
            {
                recomendedProtein = logUser.Weight * 1.5;
            }

            double totalProtein = 0; //Aşağıdaki foreachden dolduruluyor.
            //Fat

            double totalFat = 0;
            foreach (var item in logUser.Meals.ToList())
            {
                if (dtpMealDate.Value.Date == item.CreateTime.Date)
                {


                    totalProtein += (double)item.TotalProtein;
                    totalFat += (double)item.TotalFat;

                }
            }

            double showingProtein = recomendedProtein - totalProtein;
            if (showingProtein < 0)
            {
                showingProtein = 0;
                chProtein.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            }
            else
            {
                chProtein.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            }
            chProtein.Series["Protein"].Points.AddXY("Remaining", showingProtein);
            chProtein.Series["Protein"].Points.AddXY("Intake", totalProtein);


            foreach (var series in chFat.Series)
            {
                series.Points.Clear();
            }
            double recomendedFat = 0;

            if (logUser.RecomendedCalorie >= 1500 & logUser.RecomendedCalorie <= 2000)
            {
                recomendedFat = 70;
            }
            else if (logUser.RecomendedCalorie > 2000 & logUser.RecomendedCalorie <= 2500)
            {
                recomendedFat = 90;
            }
            else if (logUser.RecomendedCalorie > 2500)
            {
                recomendedFat = 100;
            }
            double showingFat = recomendedFat - totalProtein;
            if (showingFat < 0)
            {
                showingFat = 0;
                chFat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;

            }
            else
            {
                chFat.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            }
            chFat.Series["Fat"].Points.AddXY("Remaining", showingFat);
            chFat.Series["Fat"].Points.AddXY("Intake", totalFat);


        }
        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            FillCharts();
            ListMeals();
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            FoodForm foodForm = new FoodForm(db, logUser);
            foodForm.Show();
            this.Hide();
        }

        private void btnAddMeal_Click(object sender, EventArgs e)
        {
            MealCRUDForm mealForm = new MealCRUDForm(db, logUser);
            mealForm.Show();
            this.Hide();
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            RaportForm raportForm = new RaportForm(db, logUser);
            raportForm.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(db, logUser);
            profileForm.Show();
            this.Hide();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
