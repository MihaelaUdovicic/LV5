using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class ShippingService
    {
        private double cijenaMase=1.99;

        public double CijenaDostavePaketa(IShipable item){
            double cijena;

            cijena = cijenaMase + item.Weight;

            return cijena;
        }

    }
}
