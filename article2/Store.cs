using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Article2
{
    class Store
    {
        private Article[] article = new Article[5];

        public string GetString(Article art)
        {
            //string[] art = { Name, Brand, Price };
            return "Product name: " + art.Name + "; " + "Product brand: " + art.Brand + "; " + "Product price: " + art.Price + ";";
        }
        public Store()
        {
            Article g = new Article("ps4", "Sony", "399.99 UAH");
            Article b = new Article("controller", "SIXAXIS", "59.99 UAH");
            Article c = new Article("Game F.E.A.R.", "Monolith", "19.99 UAH");
            Article d = new Article("Game MGS5", "KONAMI", "39.99 UAH");
            Article f = new Article("Game MotorStorm", "HAVOK", "9.99 UAH");

            article[0] = g;
            article[1] = b;
            article[2] = c;
            article[3] = d;
            article[4] = f;

        }

        public string this[string index]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                    if (article[i].Name == index)
                        return "Product name: " + article[i].Name + "; " + "Product brand: " + article[i].Brand + "; " + "Product price: " + article[i].Price + ";";

                return string.Format("{0} - Thre's no product with such name.", index);
            }
        }

        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < article.Length)
                    return GetString(article[index]);
                else
                    return "An attempt to access index out of array scope.";
            }
        } 
        
    }
}
