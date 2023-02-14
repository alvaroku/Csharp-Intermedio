// See https://aka.ms/new-console-template for more information
using Interfaces.Implementaciones;
using Interfaces.Interfaces;

IOperacion Operacion = new Suma();

string op = "";
while (true)
{
    Console.WriteLine("0.Salir, 1.Suma, 2.Resta, 3.Multiplicación, 4.División");
    Console.WriteLine("Escoge una opción");

    op = Console.ReadLine();

    if(op == "0")
    {
        break;
    }
 

    Console.WriteLine("Ingrese el primer valor");
    double valor1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo valor");
    double valor2 = double.Parse(Console.ReadLine());

    int opcion = int.Parse(op);
    switch (opcion)
    {
        case 1:
            Operacion = new Suma();
            break;
        case 2:
            Operacion = new Resta();
            break;
        case 3:
            Operacion = new Multiplicacion();
            break;
        case 4:
            Operacion = new Division();
            break;
    }
    Operacion.Calcular(valor1, valor2);
    Operacion.Mostrar();
}