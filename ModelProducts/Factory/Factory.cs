using System.Collections.Generic;

namespace ModelProducts.Factory
{
    public abstract class Factory
    {
        protected Agregat Agregat;
        public Factory(Agregat agregat)
        {
            Agregat = agregat;
        }
        public abstract (MilkProduct, List<MilkProduct>) ProduceProducts(MilkProduct ingredients);
    }
}
