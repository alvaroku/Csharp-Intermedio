using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallBacks.Interfaces;

namespace CallBacks.Implementaciones
{
    public class MensajeReserva : IEventoMoto
    {
        public void CombustibleBajo(float Gas)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Abre reserva");
        }
        public void Beep()
        {
             
        }

        
    }
}
