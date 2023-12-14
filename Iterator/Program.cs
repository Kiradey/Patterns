using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iterator;
class Program
{
    static void Main()
    {
        MenuItem[] menuItemsArray = {
            new MenuItem("Каша", true),
            new MenuItem("Мясо", false),
            new MenuItem("Веганский борщ", true),
            new MenuItem("Торт", false)
        };

        List<MenuItem> menuItemsList = new List<MenuItem>(menuItemsArray);
        IIterator<MenuItem> arrayIterator = new MenuArrayIterator(menuItemsArray);
        IIterator<MenuItem> reverseListIterator = new MenuReverseListIterator(menuItemsList);
        IIterator<MenuItem> veganIterator = new MenuVeganIterator(menuItemsList);

        Console.WriteLine("Меню :");
        Print(arrayIterator);

        Console.WriteLine("\nОбратное меню:");
        Print(reverseListIterator);

        Console.WriteLine("\nВеганское меню :");
        Print(veganIterator);
        Console.ReadLine();
    }
    static void Print(IIterator<MenuItem> iterator)
    {
        while (iterator.HasNext())
        {
            MenuItem menuItem = iterator.Next();
            //Console.WriteLine($"{menuItem.name} (Веганское: {menuItem.isVegan})");
            Console.WriteLine("{0} (Веганское: {1})",menuItem.name, menuItem.isVegan?"Да":"Нет");
        }
    }
}
