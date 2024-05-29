using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cafe
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

        public Good(int id, string name, int quantity, int price )
        {
            
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Price = price;


        }

    
    }
}
