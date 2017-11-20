using System;

namespace ModelProducts
{
    public abstract class MilkProduct
    {
        private double _milkPercentage;

        public string Name { get; set; }
        public double MilkPercentage
        {
            get
            {
                return _milkPercentage;
            }
            set
            {
                if (value > 100)
                {
                    throw new Exception("Value is not valid");
                }
                _milkPercentage = value;
            }
        }
        public double Value { get; set; }
        public double FatUnits
        {
            get
            {
                return Value * MilkPercentage / 100;
            }
        }

        public MilkProduct(double value, double milkPercentage)
        {
            Value = value;
            MilkPercentage = milkPercentage;
        }

        public MilkProduct()
        {

        }
    }


    public class Milk : MilkProduct
    {
        public Milk(double value, double milkPercentage) : base(value, milkPercentage)
        {

        }
    }

    public class Cream : MilkProduct
    {

    }

    public class Obrat : MilkProduct
    {

    }

    public class Butter : Cream
    {

    }

    public class ButterMilk : Cream
    {

    }

    public class MilkSerum : MilkProduct
    {

    }


    public class Cheese : MilkSerum
    {

    }


    public class FattySerum : MilkProduct
    {

    }
}
