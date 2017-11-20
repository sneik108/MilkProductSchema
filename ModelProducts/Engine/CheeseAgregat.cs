using System;
using System.Collections.Generic;
using System.Text;

namespace ModelProducts
{
    public class CheeseAgregat : Agregat
    {
        public CheeseAgregat(double outputRate) : base(outputRate)
        {
        }

        public override (MilkProduct mainProduct, List<MilkProduct> sideProducts) Transform(MilkProduct ingredients)
        {
            double valueNewProd = ingredients.Value / OutputRate;
            double milkPercetageNewProd = ingredients.Value * ingredients.MilkPercentage / valueNewProd;
            string productName = typeof(Cheese).Name;

            var mainProduct = new Cheese
            {
                Name = typeof(Cheese).Name,
                Value = ingredients.Value / OutputRate,
                MilkPercentage = milkPercetageNewProd
            };

            var sideProduct = new FattySerum();
            var sideProducts = new List<MilkProduct> { sideProduct };

            var products = (mainProduct: mainProduct, sideProducts: sideProducts);
            return products;
        }
    }
}
