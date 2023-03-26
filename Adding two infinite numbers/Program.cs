using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adding_two_infinite_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numStr1 = Console.ReadLine();
            string numStr2 = Console.ReadLine();

            int a = numStr1.Length;
            int b = numStr2.Length;

            int x = Math.Max(a, b);
            int y = Math.Min(a, b);

            string[] numStrArr1 = new string[a];
            string[] numStrArr2 = new string[b];

            string[] nullArr = new string[x - y];

            Console.WriteLine();
            for (int i = 0; i < x - y; i++)
            {
                nullArr[i] = 0.ToString();
            }

            for (int i = 0; i < a; i++)
            {
                numStrArr1[i] = numStr1.Substring(i, 1);
            }

            for (int i = 0; i < b; i++)
            {
                numStrArr2[i] = numStr2.Substring(i, 1);
            }

            string[] numStrArrNew1 = new string[] { };
            string[] numStrArrNew2 = new string[] { };

            if (a > b)
            {
                numStrArrNew1 = numStrArr1;
                numStrArrNew2 = nullArr.Concat(numStrArr2).ToArray();
            }
            else if (a < b)
            {
                numStrArrNew1 = nullArr.Concat(numStrArr1).ToArray();
                numStrArrNew2 = numStrArr2;
            }
            else
            {
                numStrArrNew1 = numStrArr1;
                numStrArrNew2 = numStrArr2;
            }

            Array.Reverse(numStrArrNew1);
            Array.Reverse(numStrArrNew2);

            int d = 0;
            int q = 0;

            List<string> list = new List<string>();

            for (int i = 0; i < x; i++)
            {
                d = int.Parse(numStrArrNew1[i]) + int.Parse(numStrArrNew2[i]) + (d / 10);
                q = d % 10;
                list.Add(q.ToString());
                if (i == x - 1)
                {
                    list.Add((d / 10).ToString());
                }
            }

            list.Reverse();
            if (list[0] == "0")
            {
                list.RemoveAt(0);
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i]);
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write(list[i]);
                }
            }
            Console.ReadKey();
        }
    }
}
