using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SpinningDiscs
{
    public class CD : baseDisk, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. this.
        
        public CD()
        {
            DiskType = "CD";
            Capacity = 700;
        }
        
        public CD(string name, Dictionary<string, int> contents) : base(name, contents)
        {
            Name = name;
            Contents = contents;

        }




    }
}
