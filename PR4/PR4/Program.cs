using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order first = new Order("FPO235633532");
            first.Create();
            first.Payment();
            Console.ReadLine();
        }
    }
}
