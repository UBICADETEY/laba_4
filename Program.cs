using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input2.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for(int i= 0;i <N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }

            int max = -1001, min = 1001;
            float sum = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] % 5 == 0 || mas[i] > max)
                    max = mas[i];
                if (mas[i] % 3 == 0 || mas[i] < min)
                    min = mas[i];
                if (mas[i] % 10 == 0)
                    sum += mas[i];
            
            }
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sum);

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();

        }
    }
}
