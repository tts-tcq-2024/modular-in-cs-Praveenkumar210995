using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelCo.ColorCoder;

namespace ColorCoding
{
    internal class GetColorIndex : ColorMapping
    {
        public int Major(PairColor Pair)
        {
            int ColorIndex = -1;
            for (int i = 0; i < MajorColorMapping.Length; i++)
            {
                if (MajorColorMapping[i] == Pair.MajorColor)
                {
                    ColorIndex = i;
                    break;
                }
            }
            return ColorIndex;
        }

        public int Minor(PairColor Pair)
        {
            int ColorIndex = -1;
            for (int i = 0; i < MinorColorMapping.Length; i++)
            {
                if (MinorColorMapping[i] == Pair.MinorColor)
                {
                    ColorIndex = i;
                    break;
                }
            }
            return ColorIndex;
        }
    }
}
