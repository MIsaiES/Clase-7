int opc = 0;


static void calificaciones()
{
    int suma = 0, divisor = 0;
    int[] calificaciones = { 72, 43, 99, 55, 65, 91, 64, 45, 79, 81 };
    foreach (int i in calificaciones)
    {
        divisor++;
        Console.WriteLine($"Calificacion {divisor}: {i}");
        suma += i;
       
    }
    Console.WriteLine("Promedio: " + (suma / divisor));
}

static void calificacionesfor()
{
    int suma = 0, divisor = 0;
    int[] calificaciones = { 72, 43, 99, 55, 65, 91, 64, 45, 79, 81 };
    
    for (int i = 1; i < calificaciones.Length+1; i+=2)
    {
        divisor++;
        Console.WriteLine($"Calificacion {i+1}: {calificaciones[i]}");
        suma += i;
    }
    Console.WriteLine("Promedio: " + (suma / divisor));
}

static void ciclo(int[] arreglo)
{
    foreach (int i in arreglo)
    {
        Console.WriteLine(i);
    }
}
static void notas()
{
    int[] notas = { 50, 20, 10, 30, 40};
    Console.WriteLine("Original: ");
    ciclo(notas);
    

    Array.Sort(notas);
    Console.WriteLine("Ordenado: ");
    ciclo(notas);

    Array.Reverse(notas);
    Console.WriteLine("Al Reves");
    ciclo(notas);
}

static void busqueda()
{
    int[] calificaciones = { 72, 43, 99, 55, 65, 91, 64, 45, 79, 81 };
    int n;

    Console.WriteLine("Ingrese la Nota que desee buscar");
    int.TryParse(Console.ReadLine(), out n);
    if (Array.Exists(calificaciones, numero=> numero == n)){
    Console.WriteLine($"La primera Instancia se encuentra en la Posicion: {Array.IndexOf(calificaciones, n)+1}" );
    }
    else
    {
        Console.WriteLine("No Esxiste la calificaciion ingresada");
    }
    
}

do
{
    Console.WriteLine("¿Que Ejemplo desea ver?");
    Console.WriteLine("1.Calificaciones\n2.Calificaciones Pares con ciclo for\n3.Notas Ordenadas\n4.Busqueda de Notas\n5.Salir");
    int.TryParse(Console.ReadLine(), out opc);

    switch (opc)
    {
        case 0:
            Console.WriteLine("Opcion Invalida");
            break;
        case 1:
            calificaciones();
            break;
        case 2:
            calificacionesfor();
            break;
        case 3:
            notas(); 
            break;
        case 4:
            busqueda();
            break;
        case 5:
            Console.WriteLine("Cerrando el Programa");
            break;
        default:
            Console.WriteLine("Opcion Invalida");
            break;
    }
    Console.ReadLine();
    Console.Clear();
} while (opc != 5);