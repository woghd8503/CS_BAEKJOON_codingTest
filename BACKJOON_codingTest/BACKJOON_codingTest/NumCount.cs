using System;

namespace BACKJOON_codingTest
{
    class NumCount
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int totalNum = num1 * num2 * num3;
            string total = totalNum.ToString();

            char[] charArray = total.ToCharArray();

            int[] answer = new int[10];

            for(int i = 0; i < charArray.Length; i++)
            {
                string num = charArray[i].ToString();
                switch(Int32.Parse(num))
                {
                    case 0:
                        answer[0]++;
                        break;
                    case 1:
                        answer[1]++;
                        break;
                    case 2:
                        answer[2]++;
                        break;
                    case 3:
                        answer[3]++;
                        break;
                    case 4:
                        answer[4]++;
                        break;
                    case 5:
                        answer[5]++;
                        break;
                    case 6:
                        answer[6]++;
                        break;
                    case 7:
                        answer[7]++;
                        break;
                    case 8:
                        answer[8]++;
                        break;
                    case 9:
                        answer[9]++;
                        break;
                }
            }

            for(int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }
    }

}
