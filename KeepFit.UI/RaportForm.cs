using KeepFit.Data;
using KeepFit.Model;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepFit.UI
{
    public partial class RaportForm : MetroSetForm
    {
        private readonly AppDbContext db;
        private readonly User logUser;
        MonthPicker monthPicker = new MonthPicker();

        public RaportForm(AppDbContext db, User logUser)
        {
            InitializeComponent();
            this.db = db;
            this.logUser = logUser;
            dtpWeekRaport.MaxDate = DateTime.Now;

            monthPicker.Width = 150;
            monthPicker.Location = new Point(groupBox4.Width - monthPicker.Width, 0);
            monthPicker.MaxDate = DateTime.Now;
            //monthPicker.MinDate = new DateTime((DateTime.Now.Year),01,01);
            monthPicker.ValueChanged += monthPicker_ValueChanged;
            groupBox4.Controls.Add(monthPicker);

        }

        private void RaportForm_Load(object sender, EventArgs e)
        {
            /*Gün sonunda kişisel olarak yediğimiz öğünlerde bulunan kaloriyi öğün bazlı ve toplam olarak görmek isteriz.-BİTTİ
              Yediğimiz öğünleri haftalık/aylık bazda tüm kişiler ile öğün bazlı ve yemek kategorisi bazlı kıyaslamasını raporlasın.
              Hangi yemeklerin hangi öğünlerde ne kadar yendiğini gösteren bir rapor hazırlansın.
              En çok yenen yemekler raporu çıksın.*/
            DailyChartRaport();
            WeeklyRaport();
            MontlyReport();

            dgvUserWeekFoods.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 177, 225);
            dgvUserWeekFoods.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUserWeekFoods.EnableHeadersVisualStyles = false;
            dgvUsersWeekFoods.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 177, 225);
            dgvUsersWeekFoods.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvUsersWeekFoods.EnableHeadersVisualStyles = false;
            dgvLogUserFoodMonth.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 177, 225);
            dgvLogUserFoodMonth.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvLogUserFoodMonth.EnableHeadersVisualStyles = false;
            dgvAllUserFoodMonth.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(65, 177, 225);
            dgvAllUserFoodMonth.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvAllUserFoodMonth.EnableHeadersVisualStyles = false;
        }
        //GÜNLÜK
        private void DailyChartRaport()
        {
            lbldailycal.Text = "";
            foreach (var series in chtDaily.Series)
            {
                series.Points.Clear();
            }
            decimal totalCalorie = 0;
            foreach (var item in logUser.Meals)
            {
                if (dtpMealDate.Value.Date == item.CreateTime.Date)
                {
                    totalCalorie += item.TotalCalorie;
                    chtDaily.Series["Calorie"].Points.AddXY(item.MealName, item.TotalCalorie);
                    lbldailycal.Text += " \r\n" + item.MealName + ": " + item.TotalCalorie + " kcal";

                }
            }
            chtDaily.Series["Calorie"].Points.AddXY("Total Calorie", totalCalorie);

            lblCalories.Text = "Total Calorie: " + totalCalorie;

        }

        private void dtpMealDate_ValueChanged(object sender, EventArgs e)
        {
            DailyChartRaport();
        }

        //HAFTALIK
        void WeeklyRaport()
        {
            if (logUser.Meals.Where(x => WeekOfYear(x.CreateTime) == WeekOfYear(dtpWeekRaport.Value)).Any())
                lblWeekAvg.Text = logUser.Meals
                    .Where(x => WeekOfYear(x.CreateTime) == WeekOfYear(dtpWeekRaport.Value))
                    .Average(x => x.TotalCalorie)
                    .ToString();
            else
                lblWeekAvg.Text = "0";

            lblBreakFastAvg.Text = WeeklyCaloriUser(MealType.Breakfast);
            lblBrunchAvg.Text = WeeklyCaloriUser(MealType.Brunch);
            lblLunchAvg.Text = WeeklyCaloriUser(MealType.Lunch);
            lblDinnerAvg.Text = WeeklyCaloriUser(MealType.Dinner);
            lblSnackAvg.Text = WeeklyCaloriUser(MealType.Snack);
            lblSupperAvg.Text = WeeklyCaloriUser(MealType.Supper);


            List<Meal> mealList = new List<Meal>();
            foreach (var item in db.Meal.ToList())
            {
                if (WeekOfYear(item.CreateTime) == WeekOfYear(dtpWeekRaport.Value))
                {
                    mealList.Add(item);
                }
            }

            if (mealList.Where(x => WeekOfYear(x.CreateTime) == WeekOfYear(dtpWeekRaport.Value)).Any())
                lblUsersAvg.Text = mealList.Average(x => x.TotalCalorie).ToString();
            else
                lblUsersAvg.Text = "0";

            lblUsersBreakFastAvg.Text = WeeklyCaloriAll(MealType.Breakfast, mealList);
            lblUsersBruncAvg.Text = WeeklyCaloriAll(MealType.Brunch, mealList);
            lblUsersLunchAvg.Text = WeeklyCaloriAll(MealType.Lunch, mealList);
            lblUsersDinnerAvg.Text = WeeklyCaloriAll(MealType.Dinner, mealList);
            lblUsersSnackAvg.Text = WeeklyCaloriAll(MealType.Snack, mealList);
            lblUsersSupperAvg.Text = WeeklyCaloriAll(MealType.Supper, mealList);

            lblBreakFastFood.Text = "-";
            lblBrunchFood.Text = "-";
            lblLunchFood.Text = "-";
            lblDinnerFood.Text = "-";
            lblSupperFood.Text = "-";
            lblSnachFood.Text = "-";

            List<MealsFoods> usersFoodsWeekly = new List<MealsFoods>();
            foreach (var meal in logUser.Meals.ToList())
            {
                if (WeekOfYear(meal.CreateTime) == WeekOfYear(dtpWeekRaport.Value))
                {
                    foreach (var food in meal.Foods.ToList())
                    {
                        usersFoodsWeekly.Add(food);
                    }
                }
            }

            lblBreakFastFood.Text = WeeklylogUserFoods(MealType.Breakfast, usersFoodsWeekly);
            lblBrunchFood.Text = WeeklylogUserFoods(MealType.Brunch, usersFoodsWeekly);
            lblLunchFood.Text = WeeklylogUserFoods(MealType.Lunch, usersFoodsWeekly);
            lblDinnerFood.Text = WeeklylogUserFoods(MealType.Dinner, usersFoodsWeekly);
            lblSupperFood.Text = WeeklylogUserFoods(MealType.Supper, usersFoodsWeekly);
            lblSnachFood.Text = WeeklylogUserFoods(MealType.Snack, usersFoodsWeekly);

            //En çok yenilen 10 yemek kullanıcının.//
            var userWeeklyMost10Food = (from foods in usersFoodsWeekly
                                        group foods.FoodId by foods.FoodId into g
                                        orderby g.Count() descending
                                        select new { Id = g.Key, Count = g.Count() }).Take(10).ToList();

            dgvUserWeekFoods.Rows.Clear();
            foreach (var food in userWeeklyMost10Food)
            {
                foreach (var item in db.Food)
                {
                    if (item.FoodId == food.Id)
                        dgvUserWeekFoods.Rows.Add(food.Count.ToString(), item.FoodName.ToString());
                }
            }

            lblUsersBreakFastFood.Text = "-";
            lblUsersBrunchFood.Text = "-";
            lblUsersLunchFood.Text = "-";
            lblUsersDinnerFood.Text = "-";
            lblUsersSupperFood.Text = "-";
            lblUsersSnachFood.Text = "-";

            List<MealsFoods> AllFoodsWeekly = new List<MealsFoods>();
            foreach (var meal in db.Meal.ToList())
            {
                if (WeekOfYear(meal.CreateTime) == WeekOfYear(dtpWeekRaport.Value))
                {
                    foreach (var food in meal.Foods.ToList())
                    {
                        AllFoodsWeekly.Add(food);
                    }
                }
            }

            lblUsersBreakFastFood.Text = WeeklyFoodsAll(MealType.Breakfast, AllFoodsWeekly);
            lblUsersBrunchFood.Text = WeeklyFoodsAll(MealType.Brunch, AllFoodsWeekly);
            lblUsersLunchFood.Text = WeeklyFoodsAll(MealType.Lunch, AllFoodsWeekly);
            lblUsersDinnerFood.Text = WeeklyFoodsAll(MealType.Dinner, AllFoodsWeekly);
            lblUsersSupperFood.Text = WeeklyFoodsAll(MealType.Supper, AllFoodsWeekly);
            lblUsersSnachFood.Text = WeeklyFoodsAll(MealType.Snack, AllFoodsWeekly);

            //En çok yenilen 10 yemek tüm kullanıcının.
            var AllWeeklyMost10Food = (from foods in AllFoodsWeekly
                                       group foods.FoodId by foods.FoodId into g
                                       orderby g.Count() descending
                                       select new { Id = g.Key, Count = g.Count() }).Take(10).ToList();

            dgvUsersWeekFoods.Rows.Clear();
            foreach (var food in AllWeeklyMost10Food)
            {
                foreach (var item in db.Food)
                {
                    if (item.FoodId == food.Id)
                        dgvUsersWeekFoods.Rows.Add(food.Count.ToString(), item.FoodName.ToString());
                }
            }

        }

        string WeeklyCaloriUser(MealType type)
        {
            if (logUser.Meals.Where(x => x.MealType == type & WeekOfYear(x.CreateTime) == WeekOfYear(dtpWeekRaport.Value)).Any(x => x.MealType == type))
                return logUser.Meals
                    .Where(x => x.MealType == type & WeekOfYear(x.CreateTime) == WeekOfYear(dtpWeekRaport.Value))
                    .Average(x => x.TotalCalorie)
                    .ToString();
            else
                return "0";
        }
        string WeeklyCaloriAll(MealType type, List<Meal> list)
        {
            if (list.Where(x => x.MealType == type & WeekOfYear(x.CreateTime) == WeekOfYear(dtpWeekRaport.Value)).Any(x => x.MealType == type))
                return list
                    .Where(x => x.MealType == type & WeekOfYear(x.CreateTime) == WeekOfYear(dtpWeekRaport.Value))
                    .Average(x => x.TotalCalorie)
                    .ToString();
            else
                return "0";
        }

        string WeeklylogUserFoods(MealType type, List<MealsFoods> list)
        {
            var foodss = (from foods in list
                          join meal in logUser.Meals
                          on foods.MealId equals meal.MealId
                          where meal.MealType == type
                          group foods.FoodId by foods.FoodId into g
                          orderby g.Count() descending
                          select new { Id = g.Key, Count = g.Count() }).Take(1).ToList();

            foreach (var food in foodss)
            {
                foreach (var item in db.Food)
                {
                    if (item.FoodId == food.Id)
                        return item.FoodName;
                }
            }
            return "-";
        }

        string WeeklyFoodsAll(MealType type, List<MealsFoods> list)
        {
            var foodss = (from foods in list
                          join meal in db.Meal
                          on foods.MealId equals meal.MealId
                          where meal.MealType == type
                          group foods.FoodId by foods.FoodId into g
                          orderby g.Count() descending
                          select new { Id = g.Key, Count = g.Count() }).Take(1).ToList();

            foreach (var food in foodss)
            {
                foreach (var item in db.Food)
                {
                    if (item.FoodId == food.Id)
                        return item.FoodName;

                }
            }

            return "-";
        }

        private static int WeekOfYear(DateTime date)
        {
            var day = (int)CultureInfo.CurrentCulture.Calendar.GetDayOfWeek(date);
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date.AddDays(4 - (day == 0 ? 7 : day)), CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private void dtpWeekRaport_ValueChanged(object sender, EventArgs e)
        {
            WeeklyRaport();
        }

        //AYLIK RAPORLAMA

        void MontlyReport()
        {
            if (logUser.Meals.Where(x => x.CreateTime.Month == monthPicker.Value.Month).Any())
                lblUserAvgMonth.Text = logUser.Meals
                    .Where(x => x.CreateTime.Month == monthPicker.Value.Month)
                    .Average(x => x.TotalCalorie)
                    .ToString();
            else
                lblWeekAvg.Text = "0";

            lblUserBreakFastMonthAvg.Text = MonthlyCaloriUser(MealType.Breakfast, logUser.Meals.ToList());
            lblUserBrunchMonthAvg.Text = MonthlyCaloriUser(MealType.Brunch, logUser.Meals.ToList());
            lblUserLunchMonthAvg.Text = MonthlyCaloriUser(MealType.Lunch, logUser.Meals.ToList());
            lblUserDinnerMonthAvg.Text = MonthlyCaloriUser(MealType.Dinner, logUser.Meals.ToList());
            lblUserSnackMonthAvg.Text = MonthlyCaloriUser(MealType.Snack, logUser.Meals.ToList());
            lblUserSupperMonthAvg.Text = MonthlyCaloriUser(MealType.Supper, logUser.Meals.ToList());

            List<Meal> mealList = new List<Meal>();
            foreach (var item in db.Meal.ToList())
            {
                if ((item.CreateTime.Month == monthPicker.Value.Month))
                {
                    mealList.Add(item);
                }
            }

            if (mealList.Where(x => (x.CreateTime.Month == monthPicker.Value.Month)).Any())
                lblAllAvgMonth.Text = mealList.Average(x => x.TotalCalorie).ToString();
            else
                lblAllAvgMonth.Text = "0";

            lblAllBreakFastMonthAvg.Text = MonthlyCaloriUser(MealType.Breakfast, db.Meal.ToList());
            lblAllBrunchMonthAvg.Text = MonthlyCaloriUser(MealType.Brunch, db.Meal.ToList());
            lblAllLunchMonthAvg.Text = MonthlyCaloriUser(MealType.Lunch, db.Meal.ToList());
            lblAllDinnerMonthAvg.Text = MonthlyCaloriUser(MealType.Dinner, db.Meal.ToList());
            lblAllSnackMonthAvg.Text = MonthlyCaloriUser(MealType.Snack, db.Meal.ToList());
            lblAllSupperMonthAvg.Text = MonthlyCaloriUser(MealType.Supper, db.Meal.ToList());

            lblUserBreakFastFoodMonth.Text = "-";
            lblUserBrunchFoodMonth.Text = "-";
            lblUserLunchFoodMonth.Text = "-";
            lblUserDinnerFoodMonth.Text = "-";
            lblUserSupperFoodMonth.Text = "-";
            lblUserSnackFoodMonth.Text = "-";

            List<MealsFoods> usersFoodsMontly = new List<MealsFoods>();
            foreach (var meal in logUser.Meals.ToList())
            {
                if (meal.CreateTime.Month == monthPicker.Value.Month)
                {
                    foreach (var food in meal.Foods.ToList())
                    {
                        usersFoodsMontly.Add(food);
                    }
                }
            }

            lblUserBreakFastFoodMonth.Text = WeeklyFoodsAll(MealType.Breakfast, usersFoodsMontly);
            lblUserBrunchFoodMonth.Text = WeeklyFoodsAll(MealType.Brunch, usersFoodsMontly);
            lblUserLunchFoodMonth.Text = WeeklyFoodsAll(MealType.Lunch, usersFoodsMontly);
            lblUserDinnerFoodMonth.Text = WeeklyFoodsAll(MealType.Dinner, usersFoodsMontly);
            lblUserSupperFoodMonth.Text = WeeklyFoodsAll(MealType.Supper, usersFoodsMontly);
            lblUserSnackFoodMonth.Text = WeeklyFoodsAll(MealType.Snack, usersFoodsMontly);

            //En çok yenilen 10 yemek kullanıcının.
            var userMost10Food = (from foods in usersFoodsMontly
                                  group foods.FoodId by foods.FoodId into g
                                  orderby g.Count() descending
                                  select new { Id = g.Key, Count = g.Count() }).Take(10).ToList();

            dgvLogUserFoodMonth.Rows.Clear();
            foreach (var food in userMost10Food)
            {
                foreach (var item in db.Food)
                {
                    if (item.FoodId == food.Id)
                        dgvLogUserFoodMonth.Rows.Add(food.Count.ToString(), item.FoodName.ToString());
                }
            }
            //
            lblAllBreakFastFoodMonth.Text = "-";
            lblAllBrunchFoodMonth.Text = "-";
            lblAllLunchFoodMonth.Text = "-";
            lblAllDinnerFoodMonth.Text = "-";
            lblAllSupperFoodMonth.Text = "-";
            lblAllSnackFoodMonth.Text = "-";

            List<MealsFoods> AllFoodsMontly = new List<MealsFoods>();
            foreach (var meal in db.Meal.ToList())
            {
                if (meal.CreateTime.Month == monthPicker.Value.Month)
                {
                    foreach (var food in meal.Foods.ToList())
                    {
                        AllFoodsMontly.Add(food);
                    }
                }
            }

            lblAllBreakFastFoodMonth.Text = WeeklyFoodsAll(MealType.Breakfast, AllFoodsMontly);
            lblAllBrunchFoodMonth.Text = WeeklyFoodsAll(MealType.Brunch, AllFoodsMontly);
            lblAllLunchFoodMonth.Text = WeeklyFoodsAll(MealType.Lunch, AllFoodsMontly);
            lblAllDinnerFoodMonth.Text = WeeklyFoodsAll(MealType.Dinner, AllFoodsMontly);
            lblAllSupperFoodMonth.Text = WeeklyFoodsAll(MealType.Supper, AllFoodsMontly);
            lblAllSnackFoodMonth.Text = WeeklyFoodsAll(MealType.Snack, AllFoodsMontly);

            //En çok yenilen 10 yemek tüm kullanıcının.
            var AllMost10Food = (from foods in AllFoodsMontly
                                 group foods.FoodId by foods.FoodId into g
                                 orderby g.Count() descending
                                 select new { Id = g.Key, Count = g.Count() }).Take(10).ToList();

            dgvAllUserFoodMonth.Rows.Clear();
            foreach (var food in AllMost10Food)
            {
                foreach (var item in db.Food)
                {
                    if (item.FoodId == food.Id)
                        dgvAllUserFoodMonth.Rows.Add(food.Count.ToString(), item.FoodName.ToString());
                }
            }

        }
        string MonthlyCaloriUser(MealType type, List<Meal> list)
        {
            if (list.Where(x => x.MealType == type && (x.CreateTime.Month == monthPicker.Value.Month)).Any(x => x.MealType == type))
                return list
                    .Where(x => x.MealType == type && (x.CreateTime.Month == monthPicker.Value.Month))
                    .Average(x => x.TotalCalorie)
                    .ToString();
            else
                return "0";
        }
        private void monthPicker_ValueChanged(object sender, EventArgs e)
        {
            MontlyReport();
        }

        private void RaportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MainForm mainForm = new MainForm(db, logUser);
            //mainForm.Show();
            //this.Close();                
        }

        private void RaportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm mainForm = new MainForm(db, logUser);
            mainForm.Show();
            this.Hide();
        }
    }
}
