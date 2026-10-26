# Portada

- nombre: Emmanuel Sierra
- Ficha: 3412768
- Curso: Desarrollo c#
- Fecha: 26/10/2026

# evidencias

## Sección 1 — For y Foreach: Registro y análisis de calificaciones

### Pasos a seguir

1. Declara un array de enteros llamado `calificaciones` con los siguientes valores: `72, 85, 91, 60, 43, 78, 95, 55, 88, 67`.
2. Usando un **bucle `for`**, recorre el array y muestra cada calificación con su número de posición (iniciando en 1). Formato esperado: `Estudiante 1: 72`.
3. Usando el **mismo bucle `for`** pero de forma **descendente**, muestra las calificaciones desde la última hasta la primera.
4. Usando un **bucle `foreach`**, calcula la **suma total** de todas las calificaciones y luego calcula e imprime el **promedio** del grupo.
5. Usando un **bucle `for`** con incremento de `2`, recorre únicamente los índices pares del array e imprime esas calificaciones con la etiqueta `"Posición par:"`.

### Salida esperada (fragmento)

```
=== REGISTRO DE CALIFICACIONES ===
Estudiante 1: 72
Estudiante 2: 85
...
Estudiante 10: 67

=== ORDEN DESCENDENTE ===
Estudiante 10: 67
...
Estudiante 1: 72

=== PROMEDIO DEL GRUPO ===
Suma total: 734
Promedio: 73.4

=== POSICIONES PARES ===
Posición par: 72
Posición par: 91
...
```

- Evidencia 
![evidencia](/Evidencias/evidencia1.png)

## Sección 2 — While y Do-While: Validación y juego interactivo

### Pasos a seguir

1. Usando un **bucle `while`**, simula un sistema de acceso: declara una variable `intentos` en `0` y una variable `clave` con el valor `"sena2025"`. El bucle debe pedir al usuario que ingrese la clave y repetirse **mientras la clave sea incorrecta y los intentos sean menores a 3**. Si el usuario agota los intentos, muestra `"Acceso bloqueado."`. Si adivina, muestra `"Acceso concedido."`.
2. Usando un **bucle `do-while`**, implementa un **menú de opciones** que se repita hasta que el usuario elija salir. El menú debe mostrar:
    - `1. Ver promedio del grupo`
    - `2. Ver calificación más alta`
    - `3. Salir`
    
    El bucle debe continuar mientras la opción ingresada sea diferente de `3`. Si el usuario ingresa una opción inválida, muestra `"Opción no válida. Intenta de nuevo."`.
    

### Salida esperada (fragmento)

```
=== CONTROL DE ACCESO ===
Ingresa la clave: abc
Clave incorrecta. Intentos restantes: 2
Ingresa la clave: sena2025
Acceso concedido.

=== MENÚ PRINCIPAL ===
1. Ver promedio del grupo
2. Ver calificación más alta
3. Salir
Elige una opción: 1
Promedio del grupo: 73.4
...
Elige una opción: 3
Hasta luego.
```
- evidencia
![evidencia](/Evidencias/evidencia2.png)
![evidencia](/Evidencias/evidencia2-1.png)

## Sección 3 — Break y Continue: Filtrado y búsqueda eficiente

### Pasos a seguir

1. Usando un **bucle `for`** con `break`, recorre el array `calificaciones` y detén la búsqueda en cuanto encuentres la **primera calificación reprobatoria** (menor a 60). Muestra en qué posición se encontró y cuál es su valor.
2. Usando un **bucle `foreach`** con `continue`, recorre el array y muestra **únicamente las calificaciones aprobatorias** (mayores o iguales a 60). Lleva un contador de cuántos estudiantes aprobaron e imprímelo al final.
3. Usando un **bucle `for`** que combine `break` y `continue`, recorre el array y:
    - Salta (`continue`) las calificaciones menores a 70.
    - Detén (`break`) el recorrido en cuanto encuentres una calificación de 95 o más.
    - Imprime todas las calificaciones que no fueron saltadas ni causaron el break, con la etiqueta `"Calificación procesada:"`.

### Salida esperada (fragmento)

```
=== PRIMERA CALIFICACIÓN REPROBATORIA ===
Encontrada en posición 5: 43

=== ESTUDIANTES APROBADOS ===
Aprobado: 72
Aprobado: 85
Aprobado: 91
Aprobado: 78
Aprobado: 95
Aprobado: 88
Aprobado: 67
Total aprobados: 7

=== FILTRO COMBINADO ===
Calificación procesada: 72
Calificación procesada: 85
Búsqueda detenida al encontrar: 91
```

- Evidencia
![evidencia](/Evidencias/evidencia3.png)



