using System;
using System.Collections.Generic;
using System.Text;

namespace TypeConversion
{
    class Miles
    {
        public double Distance { get; }

        public Miles( double miles)
        {
            Distance = miles;
        }
        
        // what's implicit operator?
        public static implicit operator Kilometers(Miles miles)
        {
            return new Kilometers(miles.Distance * 1.6);
        }

        // what's implicit operator?
        public static explicit operator int(Miles miles)
        {
            return (int)(miles.Distance + 0.5);
        }
    }

}
