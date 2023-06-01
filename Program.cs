using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timgiatrilonnhat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size;
            int[] bang;
            do
            {
                Console.WriteLine("nhap kich thuoc cua bang: ");
                size = Int32.Parse(Console.ReadLine());
                if (size > 20)
                {
                    Console.WriteLine("kich thuoc bang qua lon ");
                }

            } while (size > 20);
            bang = new int[size];
            int i = 0;
            while (i < size) 
            {
                Console.WriteLine("nhap gia tri cho bang ");
                bang[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Console.WriteLine("gia tri ban da nhap ");
            for (int j =0; j < bang.Length; j++)
            {
                Console.WriteLine(bang[j]);
            }
            int max = bang[0];
            int index = 1;
            for (int j = 0; j < bang.Length; ++j)
            {
                if (bang[j] > max)
                {
                    max = bang[j];
                    index = j + 1; 
                }
            }
            Console.WriteLine("gia tri lon nhat la " + max);
            Console.ReadKey();

        }
    }
}
