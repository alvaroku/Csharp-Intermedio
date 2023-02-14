using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesMetodosGenericos
{
    public class ClaseGenerica<T>
    {
        public T X { get; private set; }
        public T Y { get; private set; }
        public ClaseGenerica(T x, T y) { 
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"X = {X} Y = {Y}";
        }
        public void Reset()
        {
            //colocal el valor por defecto del tipo T
            //Numérico = 0
            //Referencias = null
            X = default(T);
            Y = default(T);
        }
    }
}
