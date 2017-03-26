using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article2
{
    public class Article
    {
        private string name;
        private string brand;
        private string price;

        public string Name
        {
            get
            {
            return name;
            }
            set
            {
                name=value;
            }
            
        }

        public string Brand
        {
            get
            {
                return brand;
            }
            set
            {
                brand = value;
            }

        }

        public string Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }
        public string GetName()
        {
            return name;
        }

        public Article(string Name, string Brand, string Price)
        {
            this.Name = Name;
            this.Brand = Brand;
            this.Price = Price;
            
        }
    }
}
