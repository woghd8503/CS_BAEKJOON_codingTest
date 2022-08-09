using System;
using System.Text;

namespace BACKJOON_codingTest
{
    class SelfNumber
    {
        static int Method(int input)
        {
            int result;

            if (input < 10)
            {
                result = input + input;
            }
            else if (input >= 10 && input < 100)
            {
                result = input + (input / 10) + (input % 10);
            }
            else if (input >= 100 && input < 1000)
            {
                result = input + (input / 100) + ((input % 100) / 10) + ((input % 100) % 10);
            }
            else if (input >= 1000 && input < 10000)
            {
                result = input + (input / 1000) + ((input % 1000) / 100) + ((((input % 1000) % 100)) / 10) + ((((input % 1000) % 100)) % 10);
            }
            else
            {
                result = input + 1;
            }

            return result;
        }

        static void Main()
        {
            StringBuilder answer = new StringBuilder();
            bool isCheck = true;

            int[] arrayResult = new int[10000];

            for(int i = 1; i < 10000; i++)
            {
                arrayResult[i] = Method(i);
            }

            for (int i = 0; i < 10001; i++)
            {
                for(int j = 0; j < arrayResult.Length; j++)
                {
                    if(arrayResult[j] == i)
                    {
                        isCheck = false;
                        break;
                    }
                    else
                    {
                        isCheck = true;
                    }
                }
                if (isCheck) answer.AppendLine(i.ToString());
            }
            Console.WriteLine(answer);
        }
    }

}
