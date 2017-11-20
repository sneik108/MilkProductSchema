using System;
using System.Collections.Generic;

namespace ModelProducts.Factory
{
    public class CreamFactory : Factory
    {
        public CreamFactory(Agregat agregat) : base(agregat)
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
