using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_ColeCannon
{
    class DeskQuote
    {
       public static string displayQuote(string[] quoteProperties)
        {
            return  "Height: " + quoteProperties[0] + " Width: " + quoteProperties[1] + " Material: " + quoteProperties[2] + " Rush: " + quoteProperties[3] + " Drawers: " + quoteProperties[4] + " Price: $" + quoteProperties[5] + "\n";
        }
    }
}
