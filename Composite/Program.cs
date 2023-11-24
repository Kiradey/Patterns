using System;
using System.Net.Http.Headers;

namespace Composite
{
    class Program
    {
        static void Main()
        {
            var dishOfbird = new Dish("Блюдо из птицы");
            var dishOfVegetables = new Dish("Блюдо из овощей");
            var dishOfFish = new Dish("Блюдо из рыбы");
            var dishOfMeat = new Dish("Блюдо из мяса");
            var pancake = new Dish("Блины");

            var sectionOfMeat = new Section("Мясное");
            sectionOfMeat.Add(dishOfbird);
            sectionOfMeat.Add(dishOfMeat);

            var sectionOfFish = new Section("Рыбное");
            sectionOfFish.Add(dishOfFish);

            var sectionOfVegetables = new Section("Овощное");
            sectionOfVegetables.Add(dishOfVegetables);

            var sectionOfBakery = new Section("Выпечка");
            sectionOfBakery.Add(pancake);

            var menu = new Menu("заведения");
            menu.Add(sectionOfBakery);
            menu.Add(sectionOfFish);
            menu.Add(sectionOfMeat);
            menu.Add(sectionOfVegetables);

            menu.Print();
            Console.ReadLine();
        }
    }
}