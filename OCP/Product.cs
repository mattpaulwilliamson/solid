using System;

namespace BreakingOpenClosedPrinciple
{
    public interface IProduct
    {
        /// <summary>
        /// Render has one behaviour for Standard Products Types, and a different behaviour for Featured Products types. 
        /// </summary>
        void Render();
    }

    public class Product : IProduct
    {
        private readonly ProductType _type;
        private readonly decimal _price;

        public Product(decimal price, ProductType type)
        {
            _price = price;
            _type = type;
        }

        /// <summary>
        /// Render has one behaviour for Standard Products Types, and a different behaviour for Featured Products types. 
        /// </summary>
        public void Render()
        {
        }

        public string[] GetImageFileNames()
        {
            return new[] { "image1.jpg", "image2.jpg" };
        }
    }

    public class StandardProduct : IProduct
    {
        private readonly decimal _price;

        public StandardProduct(decimal _price)
        {
            this._price = _price;
        }

        public void Render()
        {
            Console.WriteLine("Hi, I am a standard product that costs £{0}", _price);
        }
    }

    public class FeaturedProduct : IProduct
    {
        private readonly decimal _price;

        public FeaturedProduct(decimal _price)
        {
            this._price = _price;
        }

        public void Render()
        {
            Console.WriteLine("WOO HOOO *******");
            Console.WriteLine("FEATURED PRODUCT HERE **********");
            Console.WriteLine("******* I COST £{0} **********", _price);
        }
    }

    public class BonusProduct : IProduct
    {
        private readonly decimal _price;

        public BonusProduct(decimal _price)
        {
            this._price = _price;
        }

        public void Render()
        {
            Console.WriteLine("Bonus Product *******");
            Console.WriteLine("******* FEATURED PRODUCT HERE **********");
            Console.WriteLine("******* I COST £{0} **********", _price);
        }
    }

    #region What's wrong with the above?
    // if we add a new ProductType, then we need to modify how this existing code works in order 
    // to include the new ProductType.
    // What if we add lots more ProductTypes? – We need more and more If statements.
    // What if this is not the only thing that varies by ProductType? - We start to duplicate this If block all over our code base.
    //
    // NB: Don’t fool yourself into thinking that a switch statement is any better – it’s just as bad!
    #endregion
}
