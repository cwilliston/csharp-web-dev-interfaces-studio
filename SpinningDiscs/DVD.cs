using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public class DVD : baseDisk, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        public DVD()
        {
            DiskType = "DVD";
            Capacity = 4700;
        }
        public DVD(string name, Dictionary<string, int> contents) : base(name, contents)
        {
            Name = name;
            Contents = contents;

        }

    }
}
