using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02
{
    class Invoice
    {
        //properties

        //read only
        public int PartNumber { get; }
        public string PartDescription { get; }
        public int Quantity { get; }
        public decimal price;

        //constructor initialize 
        public Invoice(int partNumber, string partDescription,
            int quantity, decimal price)
        {
            PartNumber = partNumber;
            PartDescription = partDescription;
            Quantity = quantity;
            Price = price;
        }

        //
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 0M)
                {
                    price = value;
                }
            }
        }

        //return a string containing the information of invoice 
        // 10 for spaces || 'C' for curreny 
        public override string ToString() => $"{PartNumber,-10} {PartDescription,-20} {Quantity,-10} {Price,10:C}{"l",12}";
    }

}