using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КлассВар9 
{
    public class Attraction
        
    {
        public class TouristAttraction
        {
            private string name;
            private double entryFee;
            private double discount;
            private int optimalTime;
            private double rating;
            private List<double> ratings;

            public string Name 
            {
                get { return name; }
                set { name = value; }
            
            
            }

            public double EntryFee 
            { 
                get { return entryFee; }
                set { entryFee = value; }

            }

            public double Discount
            {
                get { return discount; }
                set { discount = value; }

            }

            public int OptimalTime
            {
                get { return optimalTime; }
                set { optimalTime = value; }
            }
            
            public double Rating
            {
                get { return rating; }
                set { rating = value; }

            }

            // Конструктор

            public TouristAttraction(string name,double entryFee,double discount,int optimalTime)
            {
                this.name = name;
                this.entryFee = entryFee;
                this.discount = discount;
                this.optimalTime = optimalTime;
                this.rating = 0; 
                this.ratings = new List<double>();
            }

            // Метод для оценки

            public void SetRating(double newRating)
            {
                if (newRating >= 0 && newRating <= 5)
                {
                    ratings.Add(newRating); // Новая оценка в список
                    Rating = CalculateAverageRating();
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Рейтинг от 0 до 5");
                }
            }
          
            
            // Средняя оценка
             
            public double CalculateAverageRating()
            {
                if (ratings.Count == 0)
                    return 0;

                double total = 0;
                foreach (var r in ratings)
                {
                    total += r;

                }
                return total / ratings.Count; // Среднее значение

            }

            // Метод для расчета стоимости с учетом скидки

            public double CalculateDiscountPrice()
            {
                return EntryFee - (EntryFee * (Discount / 100));
            }

            // Метод для  подсчета суммы на посещение компанией

            public double CalculateTotalCost(int regularVisit,int discountVisit)
            {
                double totalCost = (regularVisit * EntryFee)+(discountVisit * CalculateDiscountPrice());
                return totalCost;
            }

            // Информация об обьекте 

            public string info()
            {
                return $"Название: {Name}, Стоимость: {EntryFee:C},Скидка: {Discount}%, Время : {optimalTime}, Рейтинг : {Rating}";
            }
       
        
        
        }



    }
}
 