// See https://aka.ms/new-console-template for more information
using CallBacks;
using CallBacks.Implementaciones;
using CallBacks.Interfaces;

Moto m = new Moto(20,13);

IEventoMoto ev = new EventoMoto();
IEventoMoto ev2 = new MensajeReserva();

Random rnd = new Random();

m.AgregarEvento(ev);
m.AgregarEvento(ev2);

while(m.Gas > 0)
{
    m.Avanzar(rnd.Next(1,5));
}