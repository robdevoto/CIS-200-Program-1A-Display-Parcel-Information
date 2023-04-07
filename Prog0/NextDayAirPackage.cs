// Program 1A
// CIS 200-75
// Fall 2022
// Due: 9/26/2022
// By: 1001001

// File: NextDayAirPackage.cs
// This concrete class is derived from the AirPackage class.
// Next Day Air Packages have an Express Fee.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class NextDayAirPackage : AirPackage
    {
        // backing field
        private decimal _expressFee;    // Additional fee for next day air service
        
        // constructor

        // Precondition:  length, width, height, and weight are all > 0 and express fee >= 0
        // Postcondition: The package is created with the specified values for
        //                origin address, destination address, length, width, height, weight, and express fee.
        public NextDayAirPackage(Address originAddress, Address destAddress, double pLength,
            double pWidth, double pHeight, double pWeight, decimal expressFee)
            : base(originAddress, destAddress, pLength, pWidth, pHeight, pWeight)
        {
            ExpressFee = expressFee;
        }

        // property

        public decimal ExpressFee
        {
            // Precondition:  None
            // Postcondition: The express fee of the package is returned
            get
            { 
                return _expressFee;
            }

            // Precondition:  value >= 0
            // Postcondition: The express fee of the package is set to the specified value
            private set
            {
                if (value >= 0)
                    _expressFee = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(ExpressFee), value,
                        $"{nameof(ExpressFee)} must be >= 0");
            }
        }

        // methods

        // Precondition: None
        // Postcondition: The next day air package's cost is returned
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = 0.35;         // Dimension coefficient in the cost equation
            const double WEIGHT_FACTOR = 0.25;      // Weight coefficient in the cost equation
            const double HEAVY_FACTOR = 0.2;        // Heavy coefficient in the cost equation
            const double LARGE_FACTOR = 0.22;       // Large coefficient in the cost equation
            
            decimal cost;

            cost = (decimal)(DIM_FACTOR * TotalDimension + WEIGHT_FACTOR * Weight) + ExpressFee;

            if (IsHeavy())
            {
                cost += (decimal)(HEAVY_FACTOR * Weight);
            }

            if (IsLarge())
            {
                cost += (decimal)(LARGE_FACTOR * TotalDimension);
            }

            return cost;
        }

        // Precondition: None
        // Postcondition: A string with the package's data is returned
        public override string ToString()
        {
            string NL = Environment.NewLine;    // Newline shortcut

            return $"Next Day {base.ToString()}{NL}Express Fee: {ExpressFee:C}";
        }
    }
}
