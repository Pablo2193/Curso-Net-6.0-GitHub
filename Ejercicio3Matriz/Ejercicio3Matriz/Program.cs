/*
1) Pida 10 números al usuario.
2) Obtener la suma de todos los números ingresados.
3) Obtener cual es el mayor de todos los números.
4) Obtener cual es el menor de todos los números.
5) Obtener el promedio de todos los números.
6) Mostrar todos los números ingresados por pantalla.
7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5. 
 */
int[]   numeros = new int[10];
int     acumulador  = 0;
int     numeroMayor = 0;
int     numeroMenor = 10000;
double  promedio = 0;

Console.WriteLine($"Ingrese {numeros.Length} por favor!");

for (int i = 0; i < numeros.Length; i++)
{   
    Console.WriteLine($"Ingrese el numero {i+1} por favor!");
    numeros[i] = int.Parse(Console.ReadLine());
    acumulador += numeros[i];
    if (numeroMayor < numeros[i])
    {
        numeroMayor = numeros[i];
    }
    if (numeroMenor > numeros[i])
    {
        numeroMenor = numeros[i];
    }

}
Console.WriteLine("---------------------------------------------------- ");
Console.WriteLine("Estos son los numero cargados!");
for (int i = 0; i < numeros.Length ; i++)
{
    Console.WriteLine($"En la posicion {i + 1} es el numero :{numeros[i]}");

}
Console.WriteLine("---------------------------------------------------- ");
Console.WriteLine($"El numero más grande es :{numeroMayor} ");
Console.WriteLine("---------------------------------------------------- ");
Console.WriteLine($"El numero más chico es : {numeroMenor} ");
Console.WriteLine("---------------------------------------------------- ");
promedio = acumulador * numeros.Length / 100;
Console.WriteLine($"El promedio de los 10 numeros es :{promedio}");


