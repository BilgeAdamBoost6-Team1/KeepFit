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
        private decimal _calorie;
        public decimal Calorie
        {
            get
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //         return _calorie;                       
                //    case Unit.Porsion:
                //        return _calorie * (decimal)0.3;

                //    case Unit.Slice:
                //        return _calorie * (decimal)0.2;

                //    case Unit.Spoon:
                //        return _calorie * (decimal)0.1;

                //    case Unit.Cup:
                //        return _calorie * 2;                       
                //    default:
                //        return _calorie;                      
                //}
                return _calorie;
            }
            set
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        _calorie = value;
                //        break;
                //    case Unit.Porsion:
                //        _calorie = value * (decimal)0.3;
                //        break;
                //    case Unit.Slice:
                //        _calorie = value * (decimal)0.2;
                //        break;
                //    case Unit.Spoon:
                //        _calorie = value * (decimal)0.1;
                //        break;
                //    case Unit.Cup:
                //        _calorie = value * 2;
                //        break;
                //    default:
                //        break;
                //}
                _calorie = value;
            }
        }
        private decimal _protein;
        public decimal Protein
        {
            get
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        return _protein;
                //    case Unit.Porsion:
                //        return _protein * (decimal)0.3;

                //    case Unit.Slice:
                //        return _protein * (decimal)0.2;

                //    case Unit.Spoon:
                //        return _protein * (decimal)0.1;

                //    case Unit.Cup:
                //        return _protein * 2;
                //    default:
                //        return _protein;
                //}
                return _protein;
            }

            set
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        _protein = value;
                //        break;
                //    case Unit.Porsion:
                //        _protein = value * (decimal)0.3;
                //        break;
                //    case Unit.Slice:
                //        _protein = value * (decimal)0.2;
                //        break;
                //    case Unit.Spoon:
                //        _protein = value * (decimal)0.1;
                //        break;
                //    case Unit.Cup:
                //        _protein = value * 2;
                //        break;
                //    default:
                //        break;
                //}
                _protein = value;
            }

        }

        private decimal _carbohydrate;
        public decimal Carbohydrate
        {
            get
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        return _carbohydrate;
                //    case Unit.Porsion:
                //        return _carbohydrate * (decimal)0.3;

                //    case Unit.Slice:
                //        return _carbohydrate * (decimal)0.2;

                //    case Unit.Spoon:
                //        return _carbohydrate * (decimal)0.1;

                //    case Unit.Cup:
                //        return _carbohydrate * 2;
                //    default:
                //        return _carbohydrate;
                //}
                return _carbohydrate;

            }
            set
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        _carbohydrate = value;
                //        break;
                //    case Unit.Porsion:
                //        _carbohydrate = value * (decimal)0.3;
                //        break;
                //    case Unit.Slice:
                //        _carbohydrate = value * (decimal)0.2;
                //        break;
                //    case Unit.Spoon:
                //        _carbohydrate = value * (decimal)0.1;
                //        break;
                //    case Unit.Cup:
                //        _carbohydrate = value * 2;
                //        break;
                //    default:
                //        break;
                //}
                _carbohydrate = value;
            }
        }
        private decimal _fat;
        public decimal Fat
        {
            get
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        return _fat;
                //    case Unit.Porsion:
                //        return _fat * (decimal)0.3;

                //    case Unit.Slice:
                //        return _fat * (decimal)0.2;

                //    case Unit.Spoon:
                //        return _fat * (decimal)0.1;

                //    case Unit.Cup:
                //        return _fat * 2;
                //    default:
                //        return _fat;
                //}
                return _fat;
            }
            set
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        _fat = value;
                //        break;
                //    case Unit.Porsion:
                //        _fat = value * (decimal)0.3;
                //        break;
                //    case Unit.Slice:
                //        _fat = value * (decimal)0.2;
                //        break;
                //    case Unit.Spoon:
                //        _fat = value * (decimal)0.1;
                //        break;
                //    case Unit.Cup:
                //        _fat = value * 2;
                //        break;
                //    default:
                //        break;
                //}
                _fat = value;
            }
        }
        private decimal _gram;
        public decimal Gram
        {
            get
            {

                return _gram;
            }
            set
            {
                //switch (Unit)
                //{
                //    case Unit.Gram:
                //        _gram = value;
                //        break;
                //    case Unit.Porsion:
                //        _gram = value * (decimal)0.3;
                //        break;
                //    case Unit.Slice:
                //        _gram = value * (decimal)0.2;
                //        break;
                //    case Unit.Spoon:
                //        _gram = value * (decimal)0.1;
                //        break;
                //    case Unit.Cup:
                //        _gram = value * 2;
                //        break;
                //    default:
                //        break;
                //}
                _gram = value;
            }
        }
        public foodType FoodType { get; set; }

    }
    public enum Unit
    {
        Gram, Porsion, Slice, Spoon, Cup
        //100gr,30gr,20gr,10gr,200gr
    }
}
