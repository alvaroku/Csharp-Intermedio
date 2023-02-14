using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallBacks.Interfaces;

namespace CallBacks.Implementaciones
{
    public class EventoMoto : IEventoMoto
    {

        public void CombustibleBajo(float Gas)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Combustible bajo");
            Console.WriteLine("Quedan {0} litros", Gas);
        }
        public void Beep()
        {
            Console.Beep(600, 1000);
        }
    }
}
