using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Price { get; set; }

        public override bool Equals(object obj)
        {
            Product product = obj as Product;
            return this.ID == product.ID;
        }

    }
}
