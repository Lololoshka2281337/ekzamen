using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ekzamen
{
    class Class1
    {
        public void zadanie3()
        {
            
            double max;
            Console.WriteLine("Введите N: ");
            int N = Int32.Parse(Console.ReadLine());
            double[] a = new double[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = Double.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Максимальный элемент последовательности: {0}", a.Max());
        }
    }
}
