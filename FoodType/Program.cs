using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodType
{
    class FoodType
    {
        private string name;
        private int protein, carbs, fat;
        static int counter = 0;


        public string Name { get => name; }
        public int Protein { get => protein; }
        public int Carbs { get => carbs; }
        public int Fat { get => fat;}
        public int Counter { get => counter;}

        public FoodType(string name,int protein, int carbs, int fat)
        {
            this.name = name;
            this.protein = protein;
            this.carbs = carbs;
            this.fat = fat;
            counter++;
        }

        static int getNumberOfCreatedInstances()
        {
            return counter;
        }

        public override string ToString()
        {
            return "{0}: p - {1}%, c - {2}%, f - {3}%" + name + protein + carbs + fat;
        }
    }

    class Food
    {
        FoodType type;
        int weight;

        public FoodType Type { get => type; }
        public int Weight { get => weight; }
        
        public double Protein1 { get => type.Protein/100; }
        public double Carbs1 { get => type.Carbs/100; }
        public double Fat1 { get => type.Fat/100; }

        public Food (FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public override string ToString()
        {
            return ", w - {0}g" + weight;
        }
        
    }
    class Program
    {
        static void Main()
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);
            Console.WriteLine("protein: " + food.Protein1 +"\ncarbs: " +food.Weight/food.Carbs1 + "\nFat: "+food.Fat1);

            Console.ReadKey();
        }
    }
}