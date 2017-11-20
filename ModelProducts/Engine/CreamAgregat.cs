using System.Collections.Generic;

namespace ModelProducts
{
    public class CreamAgregat : Agregat
    {
        public CreamAgregat(double outputRate) :base(outputRate)
        {
        }
        public override (MilkProduct mainProduct, List<MilkProduct> sideProducts) Transform(MilkProduct ingredients)
        {
            double valueNewProd = ingredients.Value / OutputRate;
            double milkPercetageNewProd = ingredients.Value * ingredients.MilkPercentage / valueNewProd;
            string productName = typeof(Cream).Name;

                var mainProduct = new Cream
                {
                    Name = typeof(Cream).Name,
                    Value = ingredients.Value / OutputRate,
                    MilkPercentage = milkPercetageNewProd
                };

            var sideProduct = new Obrat();
            var sideProducts = new List<MilkProduct> { sideProduct };

            var products = (mainProduct: mainProduct, sideProducts: sideProducts);
            return products;
        }
    }
}
