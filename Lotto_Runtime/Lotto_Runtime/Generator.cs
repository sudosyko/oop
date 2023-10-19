using System;

namespace Lotto_Generator
{
    public static class Lotto
    {
        /// <summary>
        /// Runs a Draw of 6 numbers out of 1-42.
        /// </summary>
        /// <returns>Bytearray with the 6 drawn numbers</returns>
        public static byte[] RunLottery()
        {
            return DrawNumbers();
        }

        /// <summary>
        /// Runs a Poll of 6 random numbers out of 1-42.
        /// </summary>
        /// <param name="tips">Bytearray with the 6 drawn numbers (1-42)</param>
        /// <returns>Amount of hits</returns>
        public static int RunLottery(byte[] tips)
        {
            byte[] drawnNumbers = DrawNumbers();
            int hits = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (tips[i] == drawnNumbers[j])
                    {
                        hits++;
                        Console.WriteLine("Hit! : " + tips[i]);
                        break;
                    }
                }
            }
            return hits;
        }

        private static byte[] DrawNumbers()
        {
            byte[] drawnNumbers = new byte[6];
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                byte hits = (byte)random.Next(1, 46);
                drawnNumbers[i] = hits;
            }
            return drawnNumbers;
        }

    }
}