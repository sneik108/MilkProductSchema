using System.Collections.Generic;

namespace ModelProducts
{
    public abstract class Agregat
    {
        protected double OutputRate { get; set; }
        public Agregat(double outputRate)
        {
            OutputRate = outputRate;
        }
        public abstract (MilkProduct mainProduct, List<MilkProduct> sideProducts) Transform(MilkProduct ingredients);
    }
}
