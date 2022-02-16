using System;
namespace Ejercicios{

    class Ejercicios{

        public static void Main(string[] args){

            /*

                    MENU

                    1. EJERCICIO1
                    2 
                    ..

                    55 EJERCICIO 55

                    SELECCIONA UNA OPCION: 1


            */


            Ejercicio2 operaciones = new Ejercicio2();
            int valor,num1,num2;

            System.Console.WriteLine("Ingresa un numero: ");
            num1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Ingresa otro numero: ");
            num2=int.Parse(Console.ReadLine());

            System.Console.WriteLine("\n\t SUMA");
            valor=operaciones.sumar(num1,num2);
            System.Console.WriteLine(valor);
            
            System.Console.WriteLine("\n\t RESTA");
            valor = operaciones.restar(num1,num2);
            System.Console.WriteLine(valor);

            System.Console.WriteLine("\n\t MULTIPLICACION");
            valor = operaciones.multiplicar(num1,num2);
            System.Console.WriteLine(valor);

            System.Console.WriteLine("\n\t DIVISION");
            valor = operaciones.dividir(num1,num2);
            System.Console.WriteLine(valor);
        }
    }
}
