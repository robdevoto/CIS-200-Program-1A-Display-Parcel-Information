// Program 1A
// CIS 200-75
// Fall 2022
// Due: 9/26/2022
// By: 1001001

// File: TwoDayAirPackage.cs
// This concrete class is derived from the AirPackage class.
// Two Day Air Packages have a Saver cost reduction.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog0
{
    public class TwoDayAirPackage : AirPackage
    {
        // enumeration
        public enum Delivery { Early, Saver};   // Defines 2 choice enumeration for Delivery

        // backing field
        private Delivery _deliveryType;     // The delivery type of the two day air package

        // constructor

        // Precondition:  length, width, height, and weight are all > 0 and delivery type is valid
        // Postcondition: The package is created with the specified values for
        //                origin address, destination address, length, width, height, weight and delivery type
        public TwoDayAirPackage(Address originAddress, Address destAddress, double pLength,
            double pWidth, double pHeight, double pWeight, Delivery deliverytype)
            : base(originAddress, destAddress, pLength, pWidth, pHeight, pWeight)
        {
            DeliveryType = deliverytype;
        }

        // property

        public Delivery DeliveryType
        {
            // Precondition:  None
            // Postcondition: The two day air packages's delivery type is been returned
            get
            {
                return _deliveryType;
            }

            // Precondition:  value is defined in the enumeration
            // Postcondition: The two day air packages's delivery type is set to the
            //                specified value
            set
            {
                if (Enum.IsDefined(typeof(Delivery), value))
                    _deliveryType = value;
                else
                    throw new ArgumentOutOfRangeException(nameof(DeliveryType), value,
                        $"{nameof(DeliveryType)} must be {nameof(Delivery.Early)} " +
                        $"or {nameof(Delivery.Saver)}");
            }
        }

        // methods

        // Precondition: None
        // Postcondition: The package's cost is returned
        public override decimal CalcCost()
        {
            const double DIM_FACTOR = 0.18;         // Dimension coefficient in the cost equation
            const double WEIGHT_FACTOR = 0.2;      // Weight coefficient in the cost equation
            const decimal DISCOUNT_FACTOR = 0.15M;     // Discount coefficient in the cost equation
            decimal cost;

            cost = (decimal)(DIM_FACTOR * TotalDimension + WEIGHT_FACTOR * Weight);

            if (DeliveryType == Delivery.Saver)
                cost *= (1-DISCOUNT_FACTOR);

            return cost;
        }

        // Precondition: None
        // Postcondition: A string with the package's data is returned
        public override string ToString()
        {
            string NL = Environment.NewLine;    // Newline shortcut

            return $"Two Day {base.ToString()}{NL}Delivery Type: {DeliveryType}";
        }


    }
}
