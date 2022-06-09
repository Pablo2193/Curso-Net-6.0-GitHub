/*
1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores ingresados por pantalla
3) Declarar un vector de tipo double llamado promedios
4) Recorrer la matriz para su carga con elementos de tipo int
5) Recorrer la matriz para mostrar cada valor de la matriz
6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
7) Mostrar los promedios recorriendo el vector promedios
 */

Console.WriteLine(" Ingrese la cantidad Celdas que necesita¡ ");
int cantidadDeCeldas = int.Parse(Console.ReadLine());
Console.WriteLine("  ");
Console.WriteLine(" Ingrese la cantidad Filas que necesita¡ ");
int cantidadDeFilas = int.Parse(Console.ReadLine());
Console.WriteLine("  ");
int[,] numeros = new int [ cantidadDeFilas , cantidadDeCeldas] ;



int leghtfilas = numeros.GetUpperBound(0) + 1 ;
int leghtcolumnas = numeros.GetUpperBound(1) + 1 ;
double[] promedio = new double[leghtcolumnas];


for (int columnas  = 0; columnas < leghtcolumnas; columnas ++)
{
    double acomulador = 0;
    Console.WriteLine("-----------------------------------------------");
    Console.WriteLine($" Columna numero {columnas + 1 } : ");
    Console.WriteLine("-----------------------------------------------");
    for (int filas = 0; filas < leghtfilas; filas++)
    {
        Console.WriteLine("  ");
        Console.WriteLine($" Cargue valor Fila numero {filas + 1}  : ");
        numeros[filas, columnas] = int.Parse(Console.ReadLine());
        acomulador = acomulador + numeros[filas, columnas];
        

    }
    promedio[columnas] = (acomulador / (numeros.GetUpperBound(0)+1));

}

for (int columnas = 0; columnas < leghtcolumnas; columnas++)
{
    Console.WriteLine("===============================================");
    Console.WriteLine($" Columna numero {columnas + 1} : ");
    Console.WriteLine("===============================================");
    for (int filas = 0; filas < leghtfilas; filas++)
    {
        Console.WriteLine("  ");
        Console.WriteLine($"El valor de la Fila numero  {filas +1} ");
        Console.WriteLine(numeros[filas, columnas] );
        
    }
    Console.WriteLine($"El  promedio es : ");
    Console.WriteLine(promedio[columnas]);
}