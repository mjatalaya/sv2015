/*  Name: Jose Vicente Leal
 *  Program: reto3
 *  13/10/2015



¿Sabrías decir cuantos días faltan para Nochevieja? Asumiremos que nos 
encontramos en un año no bisiesto.

Entrada La entrada comenzará con un entero para especificar el número de casos 
de prueba que vendrá a continuación. Para cada caso de prueba habrá dos 
enteros, el primero de ellos será correspondiente al día y el segundo 
correspondiente al mes de una fecha válida.

Salida
Para cada fecha de la entrada, se mostrarán el número de días completos que 
faltan hasta el día de Nochevieja.

Entrada de ejemplo
3
28
12
30
12
1
1
Salida de ejemplo
3
1
364
*/

using System;
public class daysyear
{
    public static void Main()
    {
        int n, day,month,days=0;
        int i, j;
        n = Convert.ToInt32(Console.ReadLine());
        
        for ( j = 1; j <= n ; j++)
        {
            day = Convert.ToInt32(Console.ReadLine());
            month = Convert.ToInt32(Console.ReadLine());
            
            for ( i = month ; i <= 12 ; i++)
            {
                switch(i)
                {
                    case 2:
                        days = days + 28;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        days = days + 30;
                        break;
                    default:
                        days = days + 31;
                        break;
                }
            }
            
            days = days - day;            
            Console.WriteLine(days);
            days = 0;
        }
    }
}
