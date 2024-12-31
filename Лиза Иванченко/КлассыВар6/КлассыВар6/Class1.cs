using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КлассыВар6
{
    
        public class Dish
        {
            private double weightIngredient1;
            private double weightIngredient2;
            private double weightIngredient3;
            private double caloriesPer100g;

            
            public double WeightIngredient1
            {
                get { return weightIngredient1; }
                set { weightIngredient1 = value; }
            }

            public double WeightIngredient2
            {
                get { return weightIngredient2; }
                set { weightIngredient2 = value; }
            }

            public double WeightIngredient3
            {
                get { return weightIngredient3; }
                set { weightIngredient3 = value; }
            }

            public double CaloriesPer100g
            {
                get { return caloriesPer100g; }
                set { caloriesPer100g = value; }
            }

            // Конструктор

            public Dish(double weight1, double weight2, double weight3, double calories)
            {
                weightIngredient1 = weight1;
                weightIngredient2 = weight2;
                weightIngredient3 = weight3;
                caloriesPer100g = calories;
            }

            // Метод для подсчета общего веса

            public double CalculateTotalWeight()
            {
                return weightIngredient1 + weightIngredient2 + weightIngredient3;
            }

            // Метод для подсчета калорийности

            public double CalculateCalories()
            {
                double totalWeight = CalculateTotalWeight();
                return (totalWeight / 100) * caloriesPer100g;
            }

            // Метод для пересчета рецепта

            public void RecalculateRecipe(double newWeightIngredient1)
            {
                weightIngredient1 = newWeightIngredient1;
            }

            // Метод для получения информации об объекте

            public string GetInfo()
            {
                return $"Ингредиенты: {weightIngredient1}g, {weightIngredient2}g, {weightIngredient3}g; " +
                       $"Калорийность на 100g: {caloriesPer100g} kcal; " +
                       $"Общий вес: {CalculateTotalWeight()}g; " +
                       $"Общая калорийность: {CalculateCalories()} kcal.";
            }
        }
}
