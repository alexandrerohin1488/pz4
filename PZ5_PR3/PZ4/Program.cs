using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_PR3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Back first = new Back();
            first.SetHeight(30);
            first.SetLeg(4);
            first.SetMaterial("Дерево");
            first.SetHeight_Back(15);
            first.PrintObject();

        }
    }
}
