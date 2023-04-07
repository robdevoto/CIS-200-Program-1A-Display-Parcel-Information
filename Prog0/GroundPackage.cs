// Program 1A
// CIS 200-75
// Fall 2022
// Due: 9/26/2022
// By: 1001001

// File: GroundPackage.cs
// This concrete class is derived from the Package class.
// Ground packages have a zone distance.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class GroundPackage : Package
    {
        // constructor

        // Precondition:  length, width, height, and weight are all > 0
        // Postcondition: The package is created with the specified values for
        //                origin address, destination address, length, width, height, and weight
        public GroundPackage(Address originAddress, Address destAddress, 
            double plength, double pwidth, double pheight, double pweight) 
            : base(originAddress, destAddress, plength, pwidth, pheight, pweight)
        {
            // All work done in the base constructor
        }

        // property

        public int ZoneDistance
        {
            // Precondition:  None
            // Postcondition: The ground package's zone distance is returned.
            //                The zone distance is the positive difference between the
            //                first digit of the origin zip code and the first
            //                digit of the destination zip code.
            get
            {
                const int FIRST_DIGIT_FACTOR = 10000; // Denominator to extract 1st digit
                int diff;                             // Calculated zone difference

                diff = (OriginAddress.Zip / FIRST_DIGIT_FACTOR) - (DestinationAddress.Zip / FIRST_DIGIT_FACTOR);

                return Math.Abs(diff); // Absolute value in case negative
            }
        }

        // methods

        // Precondition: None
        // Postcondition: The package's cost is returned
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = 0.15;        // Dimension coefficient in the cost equation
            const double WEIGHT_FACTOR = 0.07;     // Weight coefficient in the cost equation

            return (decimal)(DIM_FACTOR * TotalDimension + WEIGHT_FACTOR * (ZoneDistance + 1) * Weight);
        }

        // Precondition: None
        // Postcondition: A string with the package's data is returned
        public override string ToString()
        {
            string NL = Environment.NewLine;    // Newline shortcut

            return $"Ground {base.ToString()}{NL}Zone Distance: {ZoneDistance}";
        }


    }
}
