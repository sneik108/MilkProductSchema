using System;
using System.Collections.Generic;
using System.Text;

namespace ModelProducts.Factory
{
    public class CheeseFactory : Factory
    {
        public CheeseFactory(Agregat agregat) : base(agregat)
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
