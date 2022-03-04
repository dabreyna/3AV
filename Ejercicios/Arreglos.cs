using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Arreglos
    {
        
        /*
            DECLARACION

            int[] numeros;
            string[] nombres;
            double[] promedios;
            char[] vocales;

            DECLARACION Y ASIGNACION DE TAMAÑO DEL ARREGLO

            int[] numeros = new int[5];  // Tenemos un arreglo de 5 elementos de tipo int
            string[] nombres= new string[3];
            double[] promedios = new double[4];
            char[] vocales = new char[5];


            DECLARACION Y ASIGNACION DE TAMAÑO DEL ARREGLO MEDIANTE LA INICIALIZACION DE VALORES

            int[] numeros = {1, 2, 3, 4, 5};
            string[] nombres= {"Juan", "Luis", "Pedro"};
            double[] promedios = {9.9, 7.3, 8.85, 9.21};
            char[] vocales = {'a', 'e', 'i' ,'o' ,'u'};
        
            NOTA: Todos los arreglos se manejan mediante un indice para identificar a todos los elementos del arreglo,
            el primer elemento de los arreglos esta etiquetado con el indice 0, el segundo elemento con el 1, el tercero con el 2,
            el ultimo elemento contiene la posicion o indice n-1, donde n-1 corresponde a la cantidad de elementos totales 
            dentro del arreglo menos 1 posicion.
        */

        public void ejercicio1(){
            int[] numeros = new int[5];

            // Vamos a recorrer el arreglo elemento por elemento desde el indice 0 hasta n-1
            // para pedir 5 valores enteros y almacenarlos dentro del arreglo.
            for(int indice=0;indice<5;indice++){
                Console.WriteLine("Ingrese un numero: ");
                numeros[indice]= int.Parse(Console.ReadLine());
            }

            // Ahora recorremos el arreglo y vamos a imprimir en pantalla el valor de cada elemento multiplicado por dos
            // sin modificar el valor original de los elementos del arreglo.
            for(int indice=0;indice<5;indice++){
                Console.WriteLine(numeros[indice]*2);
            }

            // NOTA: En este ejercicio los 2 recorridos del arreglo se realizaron iniciando desde el primer elemento(indice 0)
            //       hasta el ultimo.

        }

        public void ejercicio2(){
            int[] numeros = {2,6,1,7,8,0};
           
            // Todos los arreglos tienen la propiedad Length, la cual nos devuelve el numero de elementos que conforman el arreglo
            // La forma de utilizarlo es Arreglo.Length

            // En el siguiente ejemplo vamos a recorrer el arreglo inciando en el indice 0 pero avanzaremos de 2 en 2 posiciones
            // en lugar de ir de uno por uno.
            Console.WriteLine("Salida en utilizando for");
            for(int indice=0;indice<numeros.Length;){
                    Console.WriteLine(numeros[indice]);
                    indice+=2;
            }

            // Otra forma de recorrer un arreglo es mediante la estructura repetitiva foreach
            Console.WriteLine("Salida en foreach");          
                foreach(int numero in numeros){
                    Console.WriteLine(numero);
                }
            // NOTA: La variable numero almacena la primera vez el primer elemento del arreglo numeros, seguidamente 
            //       se ejecuta el bloque del foreach (en este caso imprimimos el contenido de la variable numero).
            //       Es decir que numero almacena en cada vuelta del foreach un elemento del arreglo en cuestion.
            //       Con la estructura foreach recorremos en forma completa el vector y en cada iteración tenemos 
            //       acceso a un elemento del arreglo que se copia en una variable auxiliar en nuestro ejemplo la
            //       variable auxiliar es numero.
        }

        public void ejercicio3(){
            int[] numeros = {2,6,1,7,8,0};

            // En c# tenemos una clase llamada Array, la cual nos ofrece diferentes metodos que podemos usar
            // al trabajar con arreglos, algunas de estas funciones o metodos nos facilitan el realizar acciones
            // como por ejemplo ordenar los elementos de un arreglo o invertir el contenidod el arreglo.

            Console.WriteLine("Arreglo Original:");          
                foreach(int numero in numeros){
                    Console.Write(numero + " ");
                }
            
            // El metodo Sort nos permite ordenar los elementos de un arreglo
            Array.Sort(numeros);

            //Ahora mostramos el contenido del arreglo despues de aplicarle el metodo Sort
            Console.WriteLine("\n\nArreglo Ordenado con Sort:");          
                foreach(int numero in numeros){
                    Console.Write(numero + " ");
                }

            // El metodo Reverse invierte todo el contenido del arreglo cambiando a los elementos de posicion
            Array.Reverse(numeros);

            //Ahora mostramos el contenido del arreglo despues de aplicarle el metodo Reverse
            Console.WriteLine("\n\nArreglo invertido:");          
                foreach(int numero in numeros){
                    Console.Write(numero + " ");
                }
            
            // NOTA: Aplicar este tipo de metodos modifica el contenido de nuestro arreglo

        }

        public void invertirDatos(){
            int[] numeros = {2,6,1,7,8,0};

            // Mostramos el arreglo original
            Console.WriteLine("Arreglo Original:");          
                foreach(int numero in numeros){
                    Console.Write(numero + " ");
                }

            // Algoritmo para invertir los datos de un arreglo de n elementos
            for(int indice=1;indice<=numeros.Length/2;indice++){
                int aux= numeros[indice-1];
                numeros[indice-1]= numeros[numeros.Length-indice];
                numeros[numeros.Length-indice]=aux;
            }

            // Ahora mostramos el contenido del arreglo despues de aplicarle nuestro algoritmo para invertir los datos
            // el cual funciona como el metodo Reverse de la clase Array
            Console.WriteLine("\n\nArreglo invertido:");          
                foreach(int numero in numeros){
                    Console.Write(numero + " ");
                }
        }

    }
}