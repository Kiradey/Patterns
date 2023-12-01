using System;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main()
        {
            IFile file = new FileProxy("./../../../ExampleKiradey.txt");

            var size = file.GetSize();
            var path = file.GetPath();
            var content = file.Show();

            Console.WriteLine($"File size: {size}");
            Console.WriteLine($"File path: {path}");
            Console.WriteLine($"File content length: {Encoding.UTF8.GetString(content)}");

            Console.ReadLine();
        }
    }
}