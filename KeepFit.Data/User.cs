using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Data
{
    public class User
    {
        public User()
        {

            Meals = new List<Meal>();

        }
        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public Gender Gender { get; set; }
        public LifeStyle LifeStyle { get; set; }
        public Goal Goal { get; set; }

        private decimal recomendedCalorie;

        public decimal RecomendedCalorie
        {
            get
            {
                switch (Gender)
                {
                    case Gender.NotSpecified:
                        return recomendedCalorie = 0;


                    case Gender.Female:
                        return recomendedCalorie = (decimal)(10 * Weight + (6.25 * Height) - (5 * (DateTime.Now.Year - BirthDate.Year)) - 161);

                    case Gender.Male:
                        return recomendedCalorie = (decimal)(10 * Weight + (6.25 * Height) - (5 * (DateTime.Now.Year - BirthDate.Year)) + 5);

                    default:
                        return recomendedCalorie = 0;

                }
            }
            set
            {
                switch (Gender)
                {
                    case Gender.NotSpecified:
                        recomendedCalorie = 0;
                        break;

                    case Gender.Female:
                        recomendedCalorie = (decimal)(10 * Weight + (6.25 * Height) - (5 * (DateTime.Now.Year - BirthDate.Year)) - 161);
                        break;
                    case Gender.Male:
                        recomendedCalorie = (decimal)(10 * Weight + (6.25 * Height) - (5 * (DateTime.Now.Year - BirthDate.Year)) + 5);
                        break;
                    default:
                        recomendedCalorie = 0;
                        break;
                }
            }
        }

        public virtual List<Meal> Meals { get; set; }

    }

    public enum Gender
    {
        Male, Female, NotSpecified
    }

    public enum LifeStyle
    {
        Vegetarian, Vegan, GlutenFree, Ketogenic, Normal
    }

    public enum Goal
    {
        LoseWeight, GainWeight, KeepFit, BuildMuscle
    }
}

