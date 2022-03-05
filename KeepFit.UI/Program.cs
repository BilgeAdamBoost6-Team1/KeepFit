using KeepFit.Data;
using KeepFit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeepFit.UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppDbContext db = new AppDbContext();
            if (!db.User.Any())
            {
                User admin = new User()
                {
                    Email = "admin",
                    Password = "admin",
                    Gender = Gender.Male,
                    BirthDate = DateTime.Now,
                    Height = 181,
                    Weight = 74,
                    LifeStyle = LifeStyle.Normal,
                    Goal = Goal.GainWeight,
                    Name = "admin",
                    Surname = "admin"
                };
                db.User.Add(admin);
                db.SaveChanges();
            }
            if (!db.Food.Any())
            {
                Food food = new Food()
                {
                    FoodName = "Egg",
                    FoodType = foodType.Eggs,
                    Calorie = 100,
                    Carbohydrate = 100,
                    Protein = 100,
                    Fat = (decimal)(100),
                    Gram = 100,
                    Picture = "https://w7.pngwing.com/pngs/499/766/png-transparent-egg-android-apk-egg.png"

                };
                db.Food.Add(food);
                Meal meal = new Meal()
                {
                    MealName = "My BreakFast",                
                    MealType = MealType.Breakfast,                                       
                };
                
                MealsFoods foods = new MealsFoods()
                {
                    FoodName = food.FoodName,
                    Unit = Unit.Slice,
                    Calorie = food.Calorie,
                    Carbohydrate = food.Carbohydrate,
                    Fat = food.Fat,
                    Gram = food.Gram,
                    Picture = food.Picture,
                    FoodId = food.FoodId,
                    FoodType = food.FoodType,
                    MealId = meal.MealId,
                    Protein = food.Protein,                    
                };
                MealsFoods foods1 = new MealsFoods()
                {
                    FoodName = food.FoodName,
                    Unit = Unit.Spoon,
                    Calorie = food.Calorie,
                    Carbohydrate = food.Carbohydrate,
                    Fat = food.Fat,
                    Gram = food.Gram,
                    Picture = food.Picture,
                    FoodId = food.FoodId,
                    FoodType = food.FoodType,
                    MealId = meal.MealId,
                    Protein = food.Protein,
                };
                MealsFoods foods2 = new MealsFoods()
                {
                   FoodName = food.FoodName,
                    Unit = Unit.Cup,
                    Calorie = food.Calorie,
                   Carbohydrate = food.Carbohydrate,
                    Fat = food.Fat,
                    Gram = food.Gram,
                    Picture = food.Picture,
                    FoodId = food.FoodId,
                    FoodType = food.FoodType,
                    MealId = meal.MealId,
                    Protein = food.Protein,
                };
                meal.Foods.Add(foods2);
                meal.Foods.Add(foods1);
                meal.Foods.Add(foods);
                User user = new User();
                user = db.User.FirstOrDefault(x => x.UserId == 1);
                user.Meals.Add(meal);             
                
                db.SaveChanges();
            }
            Application.Run(new LoginForm());

        }
    }
}
