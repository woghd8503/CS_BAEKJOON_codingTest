using System;

namespace BACKJOON_codingTest
{
    class Average
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            string[] inputNums = Console.ReadLine().Split();
            float[] scores = Array.ConvertAll(inputNums, float.Parse);
            float sum = 0.0f;

            float maxScore = float.MinValue;

            for(int i = 0; i < count; i++)
            {
                if (maxScore < scores[i])
                    maxScore = scores[i];
            }

            for(int i = 0; i < count; i++)
            {
                scores[i] = (scores[i] / maxScore) * 100;

                sum += scores[i];
            }

            double averageScore = sum / count;
            Console.WriteLine("{0:#0.00####}", averageScore);
        }
    }

}
