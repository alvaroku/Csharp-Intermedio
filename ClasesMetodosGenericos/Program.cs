using ClasesMetodosGenericos;

Console.WriteLine("------------------------------\nMetodos Genericos\n------------------------------");
ClaseConMetodosGenericos.WriteType<int>();

int a = 2, b = 3;
ClaseConMetodosGenericos.Swap<int>(a, b);

string c = "mundo", d = "hola";
ClaseConMetodosGenericos.Swap<string>(c, d);

Console.WriteLine("------------------------------\nClases Genericas\n------------------------------");
ClaseGenerica<float> ClaseGenerica = new ClaseGenerica<float>(4, 2);
Console.WriteLine(ClaseGenerica.ToString());
ClaseGenerica.Reset();
Console.WriteLine(ClaseGenerica.ToString());