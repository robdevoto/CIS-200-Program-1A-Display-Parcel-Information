// Program 1A
// CIS 200-75
// Fall 2022
// Due: 9/26/2022
// By: 1001001

// File: Package.cs
// This class is an abstract class derived from the Parcel class.
// Packages have a size, consisting of length, width, and height, as well as a weight.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public abstract class Package : Parcel
    {
        // backing fields
        private double _length; // length of the package
        private double _width;  // width of the package
        private double _height; // height of the package
        private double _weight; // weight of the package

        // constructor

        // Precondition:  length, width, height, and weight are all > 0
        // Postcondition: The package is created with the specified values for
        //                origin address, destination address, length, width, height, and weight
        public Package(Address originAddress, Address destAddress, double pLength, 
            double pWidth, double pHeight, double pWeight) : base(originAddress, destAddress)
        {
            Length = pLength;
            Width = pWidth;
            Height = pHeight;
            Weight = pWeight;
        }

        // properties
        public double Length
        {
            // Precondition:  None
            // Postcondition: The length of the package is returned
            get
            {
                return _length;
            }

            // Precondition:  value > 0
            // Postcondition: The length of the package is set to the specified value
            set
            {
                if (value > 0)
                    _length = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Length)}", value,
                        $"{nameof(Length)} must be > 0");
            }
        }

        public double Width
        {
            // Precondition: None
            // Postcondition: The width of the package is returned
            get
            {
                return _width;
            }

            // Precondition: value > 0
            // Postcondition: The width of the package is set to the specified value
            set
            {
                if (value > 0)
                    _width = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Width)}", value,
                        $"{nameof(Width)} must be > 0");
            }
        }

        public double Height
        {
            // Precondition: None
            // Postcondition: The height of the package is returned
            get
            {
                return _height;
            }

            // Precondition: value > 0
            // Postcondition: The height of the package is set to the specified value
            set
            {
                if (value > 0)
                    _height = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Height)}", value,
                        $"{nameof(Height)} must be > 0");
            }
        }

        public double Weight
        {
            // Precondition: None
            // Postcondition: The weight of the package is returned
            get
            {
                return _weight;
            }

            // Precondition: value > 0
            // Postcondition: The weight of the package is set to the specified value
            set
            {
                if (value > 0)
                    _weight = value;
                else
                    throw new ArgumentOutOfRangeException($"{nameof(Weight)}", value,
                        $"{nameof(Weight)} must be > 0");
            }
        }

        protected double TotalDimension    // Read-only helper property
        {
            // Precondition: None
            // Postcondition: The total dimension of the package is returned
            get
            {
                return (Length + Width + Height);
            }
        }


        // methods

        // Precondition: None
        // Postcondition: A string with the package's data is returned
        public override string ToString()
        {
            string NL = Environment.NewLine; // Newline shortcut
            
            return $"Package{NL}{base.ToString()}{NL}Length: {Length}{NL}Width: " +
                $"{Width}{NL}Height: {Height}{NL}Weight: {Weight}"; 

        }

    }
}
