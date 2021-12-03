using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JuegoDelAhorcado
{
    class JuegoDelAhorcado
    {
        static void Main(string[] args)
        {
            // Declaracion de variables
            string palabra;
            string letra;
            string palabraOculta;
            int intentos = 0;
            int aciertos = 0;
            int fallos = 0;
            int contador = 0;
            int contador2 = 0;
            int contador3 = 0;
            int contador4 = 0;
            int contador5 = 0;
            int contador6 = 0;
            int contador7 = 0;
            int contador8 = 0;
            int contador9 = 0;
            int contador10 = 0;
            int contador11 = 0;
            int contador12 = 0;
            int contador13 = 0;
            int contador14 = 0;
            int contador15 = 0;
            int contador16 = 0;
            int contador17 = 0;
            int contador18 = 0;
            int contador19 = 0;
            int contador20 = 0;
            int contador21 = 0;
            int contador22 = 0;
            int contador23 = 0;
            int contador24 = 0;
            int contador25 = 0;
            int contador26 = 0;
            int contador27 = 0;
            int contador28 = 0;
            int contador29 = 0;
            int contador30 = 0;
            int contador31 = 0;
            int contador32 = 0;
            int contador33 = 0;
            int contador34 = 0;
            int contador35 = 0;
            int contador36 = 0;
            int contador37 = 0;
            int contador38 = 0;
            int contador39 = 0;
            int contador40 = 0;
            int contador41 = 0;
            int contador42 = 0;
            int contador43 = 0;
            int contador44 = 0;
            int contador45 = 0;
            int contador46 = 0;
            int contador47 = 0;
            int contador48 = 0;
            int contador49 = 0;
            int contador50 = 0;

            // Inicio del programa
            Console.WriteLine("Bienvenido al juego del ahorcado");
            Console.WriteLine("Para empezar, introduce una palabra");
            palabra = Console.ReadLine();
            palabraOculta = palabra;
            for (int i = 0; i < palabra.Length; i++)
            {
                palabraOculta = palabraOculta.Replace(palabra[i], '*');
            }
            Console.WriteLine("La palabra oculta es: " + palabraOculta);
            Console.WriteLine("Para empezar, introduce una letra");
            letra = Console.ReadLine();
            while (palabra.Contains(letra) == false);
            {
                intentos++;
                Console.WriteLine("La letra introducida no esta en la palabra");
                Console.WriteLine("Para empezar, introduce una letra");
                letra = Console.ReadLine();
            }
            while (palabra.Contains(letra) == true)
            {
                aciertos++;
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (letra == palabra[i])
                    {
                        palabraOculta = palabraOculta.Replace(palabra[i], palabra[i]);
                    }
                }
                Console.WriteLine("La letra introducida esta en la palabra");
                Console.WriteLine("La palabra oculta es: " + palabraOculta);
                Console.WriteLine("Para empezar, introduce una letra");
                letra = Console.ReadLine();
            }
            if (aciertos == palabra.Length)
            {
                Console.WriteLine("Has ganado");
            }
            else
            {
                Console.WriteLine("Has perdido");
            }
            Console.WriteLine("La palabra era: " + palabra);
            Console.WriteLine("Has usado " + intentos + " intentos");
            Console.WriteLine("Has acertado " + aciertos + " letras");
            Console.WriteLine("Has fallado " + fallos + " letras");
            Console.WriteLine("Pulsa una tecla para continuar");
        }  
    }
}

// Fin del programa	