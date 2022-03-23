using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_PR3
{
    public class Back : Chair
    {
        protected int Height_Back;

        public void SetHeight_Back(int Height_Back)
        {
            if (Height_Back >= Height * 0.5 && Height_Back <= Height)
            {
                this.Height_Back = Height_Back;

            }
            else
            {
                Console.WriteLine("Не входит в диапазон");
            }
        }

        public override void PrintObject()
        {
            Console.WriteLine("Высота седушки: " + Height + "| Кол-во ножек: " + Leg + "| Материал изделия: " + Material + "| Высота спинки: " + Height_Back);
        }
    }
}
