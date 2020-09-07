using System;
using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{
    class print
    {
        public override string ToString()
        {
            string manual = "";
            for(int i=1; i<26; i++)
            {
                ColorMap.ColorPair pair = NumToColor.GetColorFromPairNumber(i);
                manual += String.Format("Pair Number - {0}: Colors - {1} \n", i,  pair.ToString()) ;
            }

            return manual;
        }
    }
}

