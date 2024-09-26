using System.Diagnostics;
using System.Drawing;

namespace TelCo.ColorCoder
{

    class TestCode : PairColor
    {
        static void Main(string[] args)
        {
            var ColorCode = new ColorCode();
            int PairNumber = 4;
            PairColor TestPair1 = ColorCode.GetColorFromPairNumber(PairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", PairNumber, TestPair1);
            Debug.Assert(TestPair1.MajorColor == Color.White);
            Debug.Assert(TestPair1.MinorColor == Color.Brown);

            PairNumber = 5;
            TestPair1 = ColorCode.GetColorFromPairNumber(PairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", PairNumber, TestPair1);
            Debug.Assert(TestPair1.MajorColor == Color.White);
            Debug.Assert(TestPair1.MinorColor == Color.Slate);

            PairNumber = 23;
            TestPair1 = ColorCode.GetColorFromPairNumber(PairNumber);
            Console.WriteLine("[In]Pair Number: {0},[Out] Colors: {1}\n", PairNumber, TestPair1);
            Debug.Assert(TestPair1.MajorColor == Color.Violet);
            Debug.Assert(TestPair1.MinorColor == Color.Green);

            PairColor TestPair2 = new PairColor() { MajorColor = Color.Yellow, MinorColor = Color.Green };
            PairNumber = ColorCode.GetPairNumberFromColor(TestPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}\n", TestPair2, PairNumber);
            Debug.Assert(PairNumber == 18);

            TestPair2 = new PairColor() { MajorColor = Color.Red, MinorColor = Color.Blue };
            PairNumber = ColorCode.GetPairNumberFromColor(TestPair2);
            Console.WriteLine("[In]Colors: {0}, [Out] PairNumber: {1}", TestPair2, PairNumber);
            Debug.Assert(PairNumber == 6);
        }
    }
}
