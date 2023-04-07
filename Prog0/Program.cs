// Program 1A
// CIS 200-75
// Fall 2022
// Due: 9/26/2022
// By: 1001001

// File: Program.cs
// Simple test program for Parcel classes

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Prog0
{
    class Program
    {
        // Precondition:  None
        // Postcondition: Small list of Parcels is created and displayed
        static void Main(string[] args)
        {
            Address a1 = new Address("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ", 
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", 
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321", 
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4

            Letter l1 = new Letter(a1, a3, 0.50M); // Test Letter 1
            Letter l2 = new Letter(a2, a4, 1.20M); // Test Letter 2
            Letter l3 = new Letter(a4, a1, 1.70M); // Test Letter 3

            GroundPackage g1 = new GroundPackage(a1, a2, 10, 5, 2, 60); // Test Ground Package 1

            NextDayAirPackage n1 = new NextDayAirPackage(a1, a2, 10, 5, 2, 60, 10); // Test Next Day Air Package 1
            NextDayAirPackage n2 = new NextDayAirPackage(a1, a2, 100, 5, 2, 60, 10); // Test Next Day Air Package 2
            NextDayAirPackage n3 = new NextDayAirPackage(a1, a2, 10, 5, 2, 75, 10); // Test Next Day Air Package 3
            NextDayAirPackage n4 = new NextDayAirPackage(a1, a2, 100, 5, 2, 75, 10); // Test Next Day Air Package 4

            TwoDayAirPackage t1 = new TwoDayAirPackage(a1, a2, 100, 5, 2, 75, TwoDayAirPackage.Delivery.Early); // Test Two Day Air Package 1
            TwoDayAirPackage t2 = new TwoDayAirPackage(a1, a2, 100, 5, 2, 75, TwoDayAirPackage.Delivery.Saver); // Test Two Day Air Package 2

            List<Parcel> parcels = new List<Parcel> {l1, l2, l3, g1, n1, n2, n3, n4, t1, t2}; // Test list of parcels

            // Display data
            WriteLine("Program 1A - List of Parcels\n");

            foreach (Parcel p in parcels)
            {
                WriteLine(p);
                WriteLine("--------------------");
            }
        }
    }
}
