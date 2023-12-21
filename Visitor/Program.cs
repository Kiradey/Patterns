using System;

namespace Visitor
{
    class Program
    {
        static void Main()
        {
            var spaghettiBolognese = new MenuItem("\t Спагетти по-болоньски", false);
            var caesarSalad = new MenuItem("\t Салат Цезарь", false);
            var grilledSalmon = new MenuItem("\t Гриль-лосось", false);
            var vegetableSoup = new MenuItem("\t Овощной суп", true);
            var fruitPlatter = new MenuItem("\t Фруктовое ассорти", true);
            var chocolateCake = new MenuItem("\t Шоколадный торт", false);

            var pastaSection = new Section("Паста и рыба:");
            pastaSection.Add(spaghettiBolognese);
            pastaSection.Add(grilledSalmon);

            var healthyEatingSection = new Section("Здоровое питание:");
            healthyEatingSection.Add(caesarSalad);
            healthyEatingSection.Add(vegetableSoup);
            healthyEatingSection.Add(fruitPlatter);

            var dessertsSection = new Section("Десерты:");
            dessertsSection.Add(chocolateCake);

            var myMenu = new Menu("\t Мое меню");
            myMenu.Add(pastaSection);
            myMenu.Add(healthyEatingSection);
            myMenu.Add(dessertsSection);

            myMenu.Print();

            CountVeganVisitor countVeganVisitor = new CountVeganVisitor();

            var objectStructure = new ObjectStruct(myMenu);
            objectStructure.Accept(countVeganVisitor);

            Console.WriteLine($"Число блюд для веганов: {countVeganVisitor.GetResult()}");
            Console.ReadLine();
        }
    }
}
