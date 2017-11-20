using System;
using System.Collections.Generic;
using System.Text;

namespace ModelProducts
{
    public class ButterAgregat : Agregat
    {
        public ButterAgregat(double outputRate) : base(outputRate)
        {
        }

        public override (MilkProduct mainProduct, List<MilkProduct> sideProducts) Transform(MilkProduct ingredients)
        {
            double valueNewProd = ingredients.Value / OutputRate;
            double milkPercetageNewProd = ingredients.Value * ingredients.MilkPercentage / valueNewProd;
            string productName = typeof(Butter).Name;

            var mainProduct = new Butter
            {
                Name = typeof(Butter).Name,
                Value = ingredients.Value / OutputRate,
                MilkPercentage = milkPercetageNewProd
            };

            var sideProduct = new ButterMilk();
            var sideProducts = new List<MilkProduct> { sideProduct };

            var products = (mainProduct: mainProduct, sideProducts: sideProducts);
            return products;
        }
    }
}
