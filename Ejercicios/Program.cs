using System;

namespace Ejercicios{

    class Ejercicios{

        public static void Main(string[] args){

            Ejercicio1 saludar = new Ejercicio1();
            Console.WriteLine("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            saludar.saludo(nombre);
        
        }
    }
}
