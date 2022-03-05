using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Data
{
    public class MealsFoods
    {
        public MealsFoods()
        {

        }
        public int MealsFoodsId { get; set; }
        public int FoodId { get; set; }
        public int MealId { get; set; }
        public Food Food { get; set; }
        public Meal Meal { get; set; }
        public Unit Unit { get; set; }
        public string FoodName { get; set; }
        public string Picture { get; set; }
        public decimal Calorie { get; set; }
        public decimal Protein { get; set; }
        public decimal Carbohydrate { get; set; }
        public decimal Fat { get; set; }
        public decimal Gram { get; set; }
        public foodType FoodType { get; set; }

    }
    public enum Unit
    {
        Gram, Porsion, Slice, Spoon, Cup
        //100gr,30gr,20gr,10gr,200gr
    }
}
