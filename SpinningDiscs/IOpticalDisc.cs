using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        public const bool canSpin = true;
        public const bool storesData = true;
        public const bool degradesOverTime = true;

        void SpinDisk();


        //public void Compare
    }
}
