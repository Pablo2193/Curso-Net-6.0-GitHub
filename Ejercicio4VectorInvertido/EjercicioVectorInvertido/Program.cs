/*
1)      Pedir al usuario la longitud de un vector
2)      Crear el vector del tamaño ingresado.
3)      Llenar el mismo con datos aleatorios
4)      Mostrar el vector por pantalla
5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo, el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido, el vector debe quedar así: 50, 40, 30, 20, 10.  
Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones. Tampoco se debe crear un vector nuevo o auxiliar para realizar el ejercicio. 
6)      Mostrar el vector nuevamente.
*/

Console.WriteLine(" Ingrese la longitud de un vector por favor!");
int tamanioVector = int.Parse(Console.ReadLine());
Console.WriteLine(" La computadora genera numero aleatoreos en el vector!");
int[] vectorInvetido = new int[tamanioVector];

Random datosAleatoreos = new Random();
Console.WriteLine(" Los numeros generados son:");
Console.WriteLine("<-------------------------------------------------------->");
for (int i = 0; i < vectorInvetido.Length; i++)
{
    vectorInvetido[i] = datosAleatoreos.Next(100);
    //Console.WriteLine($" El numero {i + 1} es: {vectorInvetido[i]}");
}
var contador = 0; 
foreach (var p in vectorInvetido)
{
    contador++;
    Console.WriteLine($"El numero {contador} es :  {p}"  );
}
int  auxiliar;
for (int i=0; i<vectorInvetido.Length/2;i++)
{
auxiliar = vectorInvetido[i];
vectorInvetido[i] = vectorInvetido[vectorInvetido.Length-1-i];
vectorInvetido[vectorInvetido.Length-1-i] = auxiliar;
}
Console.WriteLine("");
Console.WriteLine("==========================================================");
Console.WriteLine(" Invertimos los numeros del vector :");
Console.WriteLine("<-------------------------------------------------------->");
contador = 0; 
foreach (var p in vectorInvetido)
{
    contador++;
    Console.WriteLine($"El numero {contador} es :  {p}"  );
}
