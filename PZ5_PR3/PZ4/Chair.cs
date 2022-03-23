using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5_PR3
{
    public class Chair
    {


        protected int Height;
        protected int Leg;
        protected string Material;


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
                Console.WriteLine("Материал отсутствует или не существует");
            }
        }

        //Высота седушки
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

        //Количество ножек
        public void SetLeg(int Leg)
        {
            if (Leg == 1 || Leg == 3 || Leg == 4)
            {
                this.Leg = Leg;
            }
            else
            {
                Console.WriteLine("Не входит в диапазон");
            }
        }

        //Вид материала 
        public void SetMaterial(string Material)
        {
            if (Material == "Дерево" || Material == "Пластик" || Material == "Металл")
            {
                this.Material = Material;
            }
            else
            {
                Console.WriteLine("Материал отсутствует или не существует");
            }
        }

        //Вывод данных
        public virtual void PrintObject()
        {
            Console.WriteLine("Высота седушки: " + Height + "| Кол-во ножек: " + Leg + "| Материал изделия: " + Material);
        }



        public Chair()
        {

        }
    }
}
