using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            Dictionary<string, int> nsync = new Dictionary<string, int>
            {
                {"Bye Bye Bye", 12},
                {"Space Cowboy", 10},
                {"It's Gonna Be Me", 17}
            };
            CD NoStringsAttached = new CD("No Strings Attached", nsync);

            Dictionary<string, int> shrekMOV = new Dictionary<string, int> {
                { "Shrek.mov", 4400 }
            };
            DVD Shrek = new DVD("Shrek", shrekMOV);

            // TODO: Call each CD and DVD method to verify that they work as expected.

            NoStringsAttached.SpinDisk();
            Shrek.SpinDisk();

        }
    }
}
