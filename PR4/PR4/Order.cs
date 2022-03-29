using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
     interface IOrder:IDocument
    {
        void Payment();
    }
      class Order: IOrder
    {
        protected string Status;
        protected DateTime DateOfShipment;
        protected DateTime DateOfPayment;
        protected int Price;
        public virtual void Create()
        {
            Console.WriteLine("Заказ создан");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Заказ удален");
        }
        public virtual void Payment()
        {
            Console.WriteLine("Заказ оплачен");
        }
        public virtual void Cancel()
        {
            Console.WriteLine("Заказ отменён");
        }
        public Order(string Status)
        {
            this.Status = Status;
        }
        public Order(DateTime DateOfPayment, int Price)
        {
            this.DateOfPayment = DateOfPayment;
            this.Price = Price;
        }
        public Order(DateTime DateOfShipment)
        {
            this.DateOfShipment = DateOfShipment;
        }
 
    }
}
