using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair first = new Chair();
            first.SetHeight(20);
            first.PrintHeight();
            first.SetLeg(2);
            first.PrintLeg();
            first.GetMaterial("Дерево");
            first.PrintMaterial();
            Console.ReadLine();
        }
    }
}
