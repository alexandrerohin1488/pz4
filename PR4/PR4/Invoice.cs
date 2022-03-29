using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR4
{
    interface Iinvoice : IDocument
    {

    }
     class Invoice: Iinvoice
    {
        protected string status;
        protected DateTime DateOfShipment;
        public string FullName;
        public string description;

        public virtual void Delete()
        {
            Console.WriteLine("Накладная удалена");
        }
        public virtual void Cancel()
        {
            Console.WriteLine("Накладная отменена");
        }
        public Invoice(string Status)
        {
            this.status = Status;
        }
        public Invoice(DateTime DateOfShipment)
        {
            this.DateOfShipment = DateOfShipment;
        }
        public Invoice(string description, string FullName)
        {
            this.description = description;
            this.FullName = FullName;
        }
    }
}
