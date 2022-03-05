using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Data
{
    public class Food
    {
        public Food()
        {
           
           this.Meals=new HashSet<MealsFoods>();
        }

        public int FoodId { get; set; }
        public string FoodName { get; set; }
        public string Picture { get; set; }
        public decimal Calorie { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbohydrate { get; set; }
        public decimal Fat { get; set; }
        public decimal Gram { get; set; }
        public foodType FoodType { get; set; }       
        public virtual ICollection<MealsFoods> Meals { get; set; }
    }
    public enum foodType
    {
        Vegetables, Fruits, DairyFoods, Grains, Legumes, RedMeat, WhiteMeat, Eggs, Dessert, Junkfood,Beverages
    }

}
