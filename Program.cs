using System;
using System.Collections.Generic;

namespace KR2
{
    class Program
    {
        static void Main()
        {
            List<Wine> bigObj = new List<Wine>();
            Wine w = new Wine();

            Console.WriteLine(" Кількість вина, яку потрібно внести в накладну? ");
            Console.Write("  >>  ");
            int bufer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < bufer; i++)
            {
                w.GetInformation();
                bigObj.Add(w);
            }

            for (int i = 0; i < bufer; i++)
            {
                Console.WriteLine(bigObj[i].ToString());
            }
        }

    }
}
