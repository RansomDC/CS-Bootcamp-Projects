using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    // This creates an interface that can be inherited by other classes
    interface IWalkAway
    {
        // This defines that any class that inherits this interface must implement this method
        void WalkAway(Player player); 
    }
}
