namespace Lotto_Runtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] draw = Lotto_Generator.Lotto.RunLottery();
            foreach (byte number in draw)
            {
                System.Console.WriteLine("Drawn: "+ number);
            }

            byte[] myTips = { 5, 9, 12, 31, 19, 20 };
            int hitAmount = Lotto_Generator.Lotto.RunLottery(myTips);
            if (hitAmount == 0) System.Console.WriteLine("No Hits you lost!");
        }
    }
}