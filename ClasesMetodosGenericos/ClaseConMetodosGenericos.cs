using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMetodosGenericos
{
    public static class ClaseConMetodosGenericos
    {
        public static void WriteType<T>()
        {
            var a = typeof(T);
            Console.WriteLine(a.Name);
        }

        public static void Swap<T>(T a, T b)
        {
            Console.WriteLine("valor a " + a);
            Console.WriteLine("valor b " + b);
            T t = a;
            a = b;
            b = t;
            Console.WriteLine("nuevo valor a " + a);
            Console.WriteLine("nuevo valor b " + b);
        }
    }
}
