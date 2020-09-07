using System;

namespace TelCo.ColorCoder
{
    class NumToColor
    {
        /// <summary>
        /// Given a pair number function returns the major and minor colors in that order
        /// </summary>
        /// <param name="pairNumber">Pair number of the color to be fetched</param>
        /// <returns></returns>
        internal static ColorMap.ColorPair GetColorFromPairNumber(int pairNumber)
        {
            ColorMap obj = new ColorMap();

            // The function supports only 1 based index. Pair numbers valid are from 1 to 25
            int minorSize = obj.ColorMapMinor.Length;
            int majorSize = obj.ColorMapMajor.Length;
            if (pairNumber < 1 || pairNumber > minorSize * majorSize)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", pairNumber));
            }
            
            // Find index of major and minor color from pair number
            int zeroBasedPairNumber = pairNumber - 1;
            int majorIndex = zeroBasedPairNumber / minorSize;
            int minorIndex = zeroBasedPairNumber % minorSize;

            // Construct the return val from the arrays
            ColorMap.ColorPair pair = new ColorMap.ColorPair() { majorColor = obj.ColorMapMajor[majorIndex],
                minorColor = obj.ColorMapMinor[minorIndex] };
            
            // return the value
            return pair;
        }
    }
}