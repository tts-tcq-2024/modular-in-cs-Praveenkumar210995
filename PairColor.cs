using System.Drawing;

namespace TelCo.ColorCoder
{
    public class PairColor
    {
        public Color MajorColor;
        public Color MinorColor;
        public override string ToString()
        {
            return string.Format("MajorColor:{0}, MinorColor:{1}", MajorColor.Name, MinorColor.Name);
        }
    }
}
