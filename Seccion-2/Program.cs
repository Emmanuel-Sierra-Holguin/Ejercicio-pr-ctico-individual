int[] calificaciones = new int[10];
int suma = 0;
int numeroMayor = 0;


calificaciones[0] = 72;  
calificaciones[1] = 85;
calificaciones[2] = 91;
calificaciones[3] = 60;
calificaciones[4] = 43;
calificaciones[5] = 78;
calificaciones[6] = 95;
calificaciones[7] = 55;
calificaciones[8] = 88;
calificaciones[9] = 67;


foreach (int calificacion in calificaciones)
{
    suma += calificacion;
}

 double promedio = (double)suma / calificaciones.Length;

 foreach(int numero in calificaciones)
{
    if(numero > numeroMayor)
    {
        numeroMayor = numero;
    }
}



Console.WriteLine("\n\n=== CONTROL DE ACCESO ===");
const string clave = "sena2025";
int intentos = 0;
int opcion;

while (true)
{
    Console.Write("ingresa la clave: ");
    string usuario = Console.ReadLine() ?? "";

    if(usuario != clave )
    {
        
        Console.WriteLine($"Clave incorrecta. Intentos restantes: {intentos += 1}");
    }
     if(intentos >=  3)
    {
        Console.WriteLine( "Acceso bloqueado.");
        break;
    }

    if(usuario == clave)
    {
        Console.WriteLine("Acceso concedido.");
        do
        {
            Console.WriteLine("\n\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Ver promedio del grupo");
            Console.WriteLine("2. Ver calificación más alta");
            Console.WriteLine("3. Salir");



            
            Console.Write("Elige una opción:");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                Console.WriteLine($"promedio del grupo: {promedio}");
                break;
                case 2:
                Console.WriteLine($"el numero mayor es: {numeroMayor}");
                break;
                case 3:
                Console.WriteLine("saliendo...");
                break;
                default:
                Console.WriteLine("opcion no valida.");
                continue;
            }  
        }
        while(opcion != 3);
        break;
    }
}

