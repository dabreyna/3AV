using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Cadenas2
    {
        public async void Ejercicio2(){
            // string cadena1="Demonios";
            // string cadena2="Teclado";
            // string cadena3;


            // System.Console.WriteLine(cadena1.ToUpper());
            // System.Console.WriteLine(cadena2.ToLower());
            // cadena1=cadena1.ToUpper();
            // System.Console.WriteLine(cadena1);

            // System.Console.WriteLine("Introduce una frase");
            // cadena3=Console.ReadLine();
            // System.Console.WriteLine(cadena3.Trim());

            // System.Console.WriteLine(cadena1 + cadena2);
            // System.Console.WriteLine("hola"+" a todos");

            // if(cadena3.Contains("alumnos")){ // Para buscar una cadena o subcadena dentro de otra cadena
            //     System.Console.WriteLine("Si se encuentra la palabra");
            // }else{
            //     System.Console.WriteLine("No se encontro la palabra");
            // }

            // if(cadena3.StartsWith("Hol")){
            //     System.Console.WriteLine("Si empieza la frase con H");
            // }else{
            //     System.Console.WriteLine("No empieza la frase con H");
            // }

            // if(cadena3.EndsWith("todos")){
            //     System.Console.WriteLine("Si termina la frase con .");
            // }else{
            //     System.Console.WriteLine("No termina la frase con .");
            // }

                // reconocer
                // oso
                // ana
                // somos

            string palabra;
            string invertida="";

            System.Console.WriteLine("Introduce una palabra"); //  h  o  l  a 

            //Paso 1 introducir una palabra
            palabra=Console.ReadLine();
            int numeroCaracteres = palabra.Length;//4

            // 2 invertir mi palabra (
            //     leer caracter x caracter de la palabra original pero de forma inversa
            //     y guardarlo en una nueva variable "invertida"
            // )
            for(int indice=palabra.Length;indice>0;indice--){
               //invertida+=palabra[indice-1];
               invertida=invertida+palabra[indice-1];
            }

        // 3 comparar si palabra original es = a la palabra invertida

            if(palabra==invertida){
                System.Console.WriteLine("Es un palindromo");
            }else{
                System.Console.WriteLine("No es un palindromo");
            }

        }

    }
}