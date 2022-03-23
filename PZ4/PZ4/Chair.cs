using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ4
{
    internal class Chair
    {
        public Chair()
        {

        }
        private int Height;
        private int Leg;
        private string Material;

        public Chair(int Height, int Leg, string Material)
        {
            if (Height >= 20 && Height <= 60)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Не входит в диапазон");
            }

            if (Leg == 1 || Leg == 2 || Leg == 4)
            {
                this.Leg = Leg;
            }
            else
            {
                Console.WriteLine("Не входит в диапазон");
            }

            if (Material == "Девево" || Material == "Пластик" || Material == "Металл")
            {
                this.Material = Material;
            }
            else
            {
                Console.WriteLine("Материал отсутствует либо не существует");
            }
        }



        public void SetHeight(int Height)
        {
            if (Height >= 20 && Height <= 60)
            {
                this.Height = Height;
            }
            else
            {
                Console.WriteLine("Не входит в диапазон");
            }
        }
        public void PrintHeight()
        {
            Console.WriteLine("Высота сидушки = " + Height + " см");
        }


        public void SetLeg(int Leg)
        {
            if (Leg == 1 || Leg == 2 || Leg == 3)
            {
                this.Leg = Leg;
            }
            else
            {
                Console.WriteLine("Не входит в диапазон");
            }
        }
        public void PrintLeg()
        {
            Console.WriteLine("Количество ножек = " + Leg);
        }


        public void GetMaterial(string Material)
        {
            if (Material == "Дерево" || Material == "Пластик" || Material == "Металл")
            {
                this.Material = Material;
            }
            else
            {
                Console.WriteLine("Материал отсутствует либо не существует");
            }
        }
        public void PrintMaterial()
        {
            Console.WriteLine("Материал изделия = " + Material);
        }





    }
}
