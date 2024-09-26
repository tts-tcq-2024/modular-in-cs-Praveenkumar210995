using ColorCoding;
namespace TelCo.ColorCoder
{
    public class ColorCode : ColorMapping
    {
        public ColorPair GetColorFromPairNumber(int PairNumber)
        {
            int MajorColorsCount = MajorColorMapping.Length;
            int MinorColorsCount = MinorColorMapping.Length;
            if (PairNumber < 1 || PairNumber > MinorColorsCount * MajorColorsCount)
            {
                throw new ArgumentOutOfRangeException(
                    string.Format("Argument PairNumber:{0} is outside the allowed range", PairNumber));
            }
            int ZeroBasedPairNumber = PairNumber - 1;
            int MajorColorIndex = ZeroBasedPairNumber / MinorColorsCount;
            int MinorColorIndex = ZeroBasedPairNumber % MinorColorsCount;
            ColorPair Pair = new ColorPair() { MajorColor = MajorColorMapping[MajorColorIndex], MinorColor = MinorColorMapping[MinorColorIndex] };
            return Pair;
        }

        public int GetPairNumberFromColor(ColorPair Pair)
        {
            var GetColorIndex = new GetColorIndex();
            int MajorColorIndex = GetColorIndex.Major(Pair);
            int MinorColorIndex = GetColorIndex.Minor(Pair);
            if (MajorColorIndex == -1 || MinorColorIndex == -1)
            {
                throw new ArgumentException(
                    string.Format("Unknown Colors: {0}", Pair.ToString()));
            }
            return (MajorColorIndex * MinorColorMapping.Length) + (MinorColorIndex + 1);
        }
    }
}
