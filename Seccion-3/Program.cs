int[] calificaciones = new int[10];
int contador = 0;


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

Console.WriteLine("\n\n=== PRIMERA CALIFICACIÓN REPROBATORIA ===");
for(int i = 0; i < 10; i++)
{
     
    if(calificaciones[i] < 60 )
    {
        Console.WriteLine($"Encontrada en posición {i+1}: {calificaciones[i]}");
        break;
    }
}

Console.WriteLine("\n\n=== ESTUDIANTES APROBADOS ===");
foreach(int aprobado in calificaciones)
{
    if(aprobado <= 60)
    {
        continue;
    }

    contador += 1;
    Console.WriteLine($"aprobado: {aprobado}");
}
Console.WriteLine($"Total aprobados: {contador}");

Console.WriteLine("\n\n=== FILTRO COMBINADO ===");
for(int i = 0; i < 10; i++)
{
    if(calificaciones[i] < 70)
    {
        continue;
    
    }
    
    if(calificaciones[i] >= 90)
    {
        Console.WriteLine($"busqueda detenida al encontrar: {calificaciones[i]}");
        break;
    }
    else
    {
        Console.WriteLine($"calificacion procesada: {calificaciones[i]}");
    }
}
