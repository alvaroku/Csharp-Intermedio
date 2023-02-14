using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CallBacks.Interfaces;

namespace CallBacks
{
    public class Moto
    {
        private List<IEventoMoto> CallBacks = new List<IEventoMoto>();

        public float Gas{ get; private set; }
        private float RendimientoPorLitro { get; set; }

        public Moto(float Gas,float RendimientoPorListro)
        {
            this.Gas = Gas;
            this.RendimientoPorLitro = RendimientoPorListro;
        }
        public void AgregarEvento(IEventoMoto evento)
        {
            if(evento != null)
            {
                CallBacks.Add(evento);
            }
        }
        public void EliminarEvento(IEventoMoto evento)
        {
            if (CallBacks.Contains(evento))
            {
                CallBacks.Remove(evento);
            }
        }
        public void Avanzar(float KmRecorridos)
        {
          
              Gas -= KmRecorridos / RendimientoPorLitro;
 

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Combustible {0}", Gas);

            //invocamos al callback
            if(Gas < 2)
            {
                foreach(IEventoMoto hanlder in CallBacks)
                {
                    hanlder.CombustibleBajo(Gas);
                }
            }
            if(Gas <= 0.5)
            {
                foreach (IEventoMoto hanlder in CallBacks)
                {
                    hanlder.Beep();
                }
            }
        }
    }
}
