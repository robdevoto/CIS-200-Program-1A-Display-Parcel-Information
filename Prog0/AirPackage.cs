// Program 1A
// CIS 200-75
// Fall 2022
// Due: 9/26/2022
// By: 1001001

// File: AirPackage.cs
// This abstract class is derived from the Package class.
// Air packages declare whether a package is heavy or large.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class AirPackage : Package
    {
        // constants
        public const double HEAVY_THRESHOLD = 75;   // Minimum weight for a package to be declared heavy
        public const double LARGE_THRESHOLD = 100;  // Minumum total dimension for a package to be declared large

        // constructor

        // Precondition:  length, width, height, and weight are all > 0
        // Postcondition: The package is created with the specified values for
        //                origin address, destination address, length, width, height, and weight
        public AirPackage(Address originAddress, Address destAddress, double pLength, 
            double pWidth, double pHeight, double pWeight)
            : base(originAddress, destAddress, pLength, pWidth, pHeight, pWeight)
        {
            // All work done in the base constructor
        }

        // methods

        // Precondition:  Air package is considered heavy if weight >= HEAVY_THRESHOLD
        // Postcondition: Return boolean based on the weight
        public bool IsHeavy()
        {
            return (Weight >= HEAVY_THRESHOLD);
        }

        // Precondition:  Air package is considered large if total dimension >= LARGE_THRESHOLD
        // Postcondition: Return boolean based on the total dimension
        public bool IsLarge()
        {
            return (TotalDimension >= LARGE_THRESHOLD);
        }

        // Precondition: None
        // Postcondition: A string with the package's data is returned
        public override string ToString()
        {
            string NL = Environment.NewLine;    // Newline shortcut

            return $"Air {base.ToString()}{NL}Heavy: {IsHeavy()}{NL}Large: {IsLarge()}";
        }



    }
}
