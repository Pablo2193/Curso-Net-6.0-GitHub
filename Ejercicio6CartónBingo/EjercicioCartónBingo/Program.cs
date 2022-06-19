/*
1)    Cartón de 3 filas por 9 columnas
2)    El cartón debe tener 15 números y 12 espacios en blanco
3)    Cada fila debe tener 5 números
4)    Cada columna debe tener 1 o 2 números
5)    Ningún número puede repetirse
6)    La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29, así sucesivamente hasta la última columna la cual contiene del 80 al 90
7)    Mostrar el carton por pantalla
 */
Console.WriteLine(" Bienvenido al cartón magico!!!");
int[,] carton = new int[3,9];
Random numerosAleatorios = new Random();


int leghtfilas = carton.GetUpperBound(0) + 1;
int leghtcolumnas = carton.GetUpperBound(1) + 1;



Console.WriteLine("===================================================");
for (int columnas = 0; columnas < leghtcolumnas; columnas++)
{
   
    for (int filas = 0; filas < leghtfilas; filas++)
    {

        switch (columnas )
        {
            case 0: carton[filas, columnas] = numerosAleatorios.Next(1 , 9); break;
            case 1: carton[filas, columnas] = numerosAleatorios.Next(10,19); break;
            case 2: carton[filas, columnas] = numerosAleatorios.Next(20,29); break;
            case 3: carton[filas, columnas] = numerosAleatorios.Next(30,39); break;
            case 4: carton[filas, columnas] = numerosAleatorios.Next(40,49); break;
            case 5: carton[filas, columnas] = numerosAleatorios.Next(50,59); break;
            case 6: carton[filas, columnas] = numerosAleatorios.Next(60,69); break;
            case 7: carton[filas, columnas] = numerosAleatorios.Next(70,79); break;
            case 8: carton[filas, columnas] = numerosAleatorios.Next(80,90); break;
            default:
                break;
            
        }
        
    }
    
    
}
var contador = 0;
int num = 00;

for (int columnas = 0; columnas < leghtcolumnas; columnas++)
{
    
    for (int filas = 0; filas < leghtfilas; filas++)
    {
        contador++;
        if (contador == 3 || contador == 5 || contador == 8 || contador == 10 || contador == 11|| contador == 13 || contador == 16 || contador == 18 || contador == 21 || contador == 22 || contador == 25 || contador == 27 )
        {
            carton[filas, columnas] = num;   
        }  
    }
}


for (int filas = 0; filas < leghtfilas; filas++)
{

    for (int columna = 0; columna < leghtcolumnas; columna++)
    {
        if (carton[filas, columna] < 10)
        {
            Console.Write(" "  + carton[filas, columna] + " " + " ");
        }
        else
        {
            Console.Write(" " + carton[filas, columna] + " ");
        }
        
        

    }
    Console.WriteLine("");

}
Console.WriteLine("===================================================");


//int[,] posiciones = new int[3,9];
//int leghtPfilas = posiciones.GetUpperBound(0) + 1;
//int leghtpcolumnas =posiciones.GetUpperBound(1) + 1;
//for (int columnas = 0; columnas < leghtpcolumnas; columnas++)
//{

//    for (int filas = 0; filas < leghtPfilas; filas++)
//    {

//        switch (columnas)
//        {
//            case 0: posiciones[filas, columnas] = 00; break;
//            case 1: posiciones[filas, columnas] = 00; break;
//            case 2: posiciones[filas, columnas] = 00; break;
//            case 3: posiciones[filas, columnas] = 00; break;
//            case 4: posiciones[filas, columnas] = 00; break;
//            case 5: posiciones[filas, columnas] = 00; break;
//            case 6: posiciones[filas, columnas] = 00; break;
//            case 7: posiciones[filas, columnas] = 00; break;
//            case 8: posiciones[filas, columnas] = 00; break;
//            default:
//                break;
//        }
//    }
//}
