using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace классы30
{
    public class Distance
    {
        private double meters;

        public double Meters
        {
            get { return meters; }
            set { meters = value; }
        }

        // Конструктор

        public Distance(double meters)
        {
            this.meters = meters;
        }

        // Метод для определения времени, необходимого для преодоления расстояния с заданной скоростью

        public double CalculateTime(double speed)
        {
            if (speed <= 0)
                throw new ArgumentException("Скорость должна быть положительной.");
            return meters / speed;
        }

        // Метод для перевода расстояния в километры, мили и версты
        public (double kilometers, double miles, double versts) Convert()
        {
            double kilometers = meters / 1000;
            double miles = meters / 1609.34; // 1 миля = 1609.34 метра
            double versts = meters / 1066.8; // 1 верста = 1066.8 метра
            return (kilometers, miles, versts);
        }

        // Метод для получения информации об объекте
        public override string ToString()
        {
            return $"Расстояние: {meters} метров";
        }
    }
}
