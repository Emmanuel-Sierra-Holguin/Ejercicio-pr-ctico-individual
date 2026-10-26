int[] calificaciones = new int[10];
int suma = 0;


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




Console.WriteLine("\n\n=== REGISTRO DE CALIFICACIONES ===");

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"estudiante {i+1}: {calificaciones[i]}");
}
Console.WriteLine("\n\n=== ORDEN DESCENDENTE ===");
for (int i = 10; i > 0; i--)
{
    Console.WriteLine($"estudiante {i}: {calificaciones[i-1]}");
}
Console.WriteLine("\n\n=== PROMEDIO DEL GRUPO ===");
foreach (int calificacion in calificaciones)
{
    suma += calificacion;
}

 double promedio = (double)suma / calificaciones.Length;
Console.WriteLine($"suma total: {suma}");
Console.WriteLine($"promedio: {promedio}");

Console.WriteLine("\n\n=== POSICIONES PARES ===");
for (int i = 0; i < 10; i += 2)
{
    Console.WriteLine($"posicion par: {calificaciones[i]}");
}
