using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingOpenClosedPrinciple
{
    class ProductConsole
    {
        public static void Main()
        {
            var standard = new StandardProduct(4.52m);
            var featured = new FeaturedProduct(3.99m);
            var bonus = new BonusProduct(3.99m);

            var products = new List<IProduct>();

            products.Add(standard);
            products.Add(featured);
            products.Add(bonus);

            foreach (IProduct product in products)
            {
                product.Render();
            }


            Console.WriteLine("FINISHED......press any key");
            Console.ReadKey();
        
        }
    }
}
