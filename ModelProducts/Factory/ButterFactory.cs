using System;
using System.Collections.Generic;

namespace ModelProducts.Factory
{
    public class ButterFactory : Factory
    {
        public ButterFactory(Agregat agregat) : base(agregat)
        {

        }

        public override (MilkProduct, List<MilkProduct>) ProduceProducts(MilkProduct ingredients)
        {
            if (ingredients == null)
            {
                throw new ArgumentNullException("Нет инградиентов");
            }

            var (mainProduct, sideProducts) = Agregat.Transform(ingredients);

            return (mainProduct, sideProducts);
        }
    }
}
