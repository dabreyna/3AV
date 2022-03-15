using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Cadenas
    {
        public void Ejercicio1(){
            // string cadena1="carne";
            // string cadena2="frutas";

            //cadena3=Console.ReadLine();
        

            //cadena4 = cadena1;

            //cadena5=String.Copy(cadena2);

            //cadena6= String.

            // System.Console.WriteLine(cadena1);
            // System.Console.WriteLine(cadena2);
            //System.Console.WriteLine(cadena3);
            // System.Console.WriteLine(cadena4);
            // System.Console.WriteLine(cadena5);

            // if(cadena1 == cadena3){
            //     System.Console.WriteLine("Las 2 cadenas tienen el mismo contenido");
            // }else{
            //     System.Console.WriteLine("Las 2 cadenas son diferentes");
            // }
            
            // if(cadena3 == "jugo"){
            //     System.Console.WriteLine("Tienes sed");
            // }else{
            //     System.Console.WriteLine("Tienes hambre");
            // }
 

            // if("jugo" == Console.ReadLine()){
            //     System.Console.WriteLine("Tienes sed");
            // }else{
            //     System.Console.WriteLine("Tienes hambre");
            // }


            // if(cadena1.Equals(cadena3)){
            //     System.Console.WriteLine("Las 2 cadenas tienen el mismo contenido");
            // }else{
            //     System.Console.WriteLine("Las 2 cadenas son diferentes");
            // }

            // if(cadena1.Equals("adios")){
            //     System.Console.WriteLine("Te estas despidiendo");
            // }else{
            //     System.Console.WriteLine("No es una despedida");
            // }
            string cadena1="abcdefghijklmnopqrstuv";
          //string cadena1=" a  b  c  d  e  f  g  h  i  j  k      lmnopqrstuv";
            //              [0][1][2][3][4][5][6][7][8][9][10]
            string cadena2;
            // Subcadena

            string cadena3 = cadena1.Substring(4);
            cadena2= cadena1.Substring(4,7);
            System.Console.WriteLine(cadena2);
          




        }



    }
}