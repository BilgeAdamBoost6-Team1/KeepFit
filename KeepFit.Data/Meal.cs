using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepFit.Data
{
    public class Meal
    {
        public Meal()
        {
            this.Foods = new ObservableCollection<MealsFoods>();
            Foods.CollectionChanged += HandleChange;
        }
        private void HandleChange(object sender,NotifyCollectionChangedEventArgs e)
        {
            if(e.NewItems!=null)
            {
                foreach (var x in e.NewItems)
                {                    
                    FillPropp();
                }

            }
            if(e.OldItems!=null)
            {
                foreach (var y in e.OldItems)
                {                    
                    //FillPropp();
                }
            }
            if (e.Action == NotifyCollectionChangedAction.Move)
            {
               
            }
        }
        public int MealId { get; set; }
        public string MealName { get; set; }

        public virtual ObservableCollection<MealsFoods> Foods  {  get;  set;  }

        public decimal TotalCalorie { get; set; }

        public decimal TotalProtein { get; set; }

        public decimal TotalFat { get; set; }

        public decimal TotalCarbohydrate { get; set; }

        public decimal TotalGram { get; set; }

        public MealType MealType { get; set; }
        public DateTime CreateTime { get; set; } = DateTime.Now;
        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        private void FillPropp()
        {
            TotalCalorie = 0;
            TotalFat = 0;
            TotalProtein = 0;
            TotalGram = 0;
            TotalCarbohydrate = 0;
            foreach (var item in Foods)
            {
                TotalCalorie += item.Calorie;
                TotalFat += item.Fat;
                TotalGram += item.Gram;
                TotalCarbohydrate += item.Carbohydrate;
                TotalProtein += item.Protein;
            }
        }
    }
    public enum MealType
    {
        //öğünler
        Breakfast, Brunch, Lunch, Dinner, Supper, Snack
    }
}
