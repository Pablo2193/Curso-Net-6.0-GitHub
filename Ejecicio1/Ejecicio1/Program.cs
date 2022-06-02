
var contadorDeVueltas = 0;
var respuesta = "S";

while (respuesta.ToUpper()!= "N")
{
    contadorDeVueltas++;
    
    Console.Clear();
    Console.WriteLine("Vuelta numero " + contadorDeVueltas);
    Console.WriteLine("Ingrese su nombre por favor");
    var nombre = Console.ReadLine();
    Console.WriteLine($"Hola {nombre} eres bienvenido");
    Console.WriteLine("Quiere continuar S/N?");
    respuesta = Console.ReadLine();
    if (respuesta.ToUpper()=="N")
    {
        Console.WriteLine("Programa finalizado correctamente");
    }
    if (respuesta.ToUpper() != "N" && respuesta.ToUpper() != "S")
    {
        Console.WriteLine("Opción no valida");
        break;
    }
}

