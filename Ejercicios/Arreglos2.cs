using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Arreglos2
    {
        public void Ejercicio1(){
            int edad=50;
            string nombre;
            char letra;
            bool murio;

            int[] numeros = {4,3,6};
            int[] otroarreglo = new int[5];

            int[,] matriz = { {4,2,6} ,
                              {5,1,0} , 
                              {7,2,3} 
                            };

            System.Console.WriteLine(matriz[1,1]);                            

            int[,] otramatriz = new int[3,3];
        
            int[,,] cubo = new int[3,3,3];
                                  //75--->[2,2,1]
            
            cubo[2,2,1] = 75;

            // int[,,] = new int [2,3,3]
            int[,,] cubo2 = {
                                { 
                                    {4,2,6},
                                    {5,1,0} , 
                                    {7,2,3} 
                                },
                               { 
                                    {10,11,12},
                                    {13,14,15} , 
                                    {16,17,18} 
                                },

                            };

        System.Console.WriteLine(cubo2[1,1,0]);                            

        System.Console.WriteLine(numeros[0]);
        System.Console.WriteLine(numeros[1]);
        System.Console.WriteLine(numeros[2]);


        }
        
    }
}
/*
 gato[3,3]

   x |    |
 ____|____|____
     |  x |
 ____|____|____
     |    | x
     |    |


gato[0,0]='x';
gato[1,1]='x';
gato[2,2]='x';

*/

// 

//
// numeros --->  [4][2][6]
//                0  1  2 

// otroarreglo   --->  [][][][][]
//                      0 1 2 3 4

// matriz ---->  [ [4] [2] [6] ]
//               [ [5] [1] [0] ]
//               [ [7] [2] [3] ]

// otramatriz ---->  [ [] [] [] ]  0,0   0,1   0,2
//                   [ [] [] [] ]  1,0   1,1   1,2
//                   [ [] [] [] ]  2,0   2,1   2,2

//
// cubo ---->        [ [] [] [] ]  0,0,0   0,0,1   0,0,2
//                   [ [] [] [] ]  0,1,0   0,1,1   0,1,2
//                   [ [] [] [] ]  0,2,0   0,2,1   0,2,2

//                   [ [] [] [] ]  1,0,0   1,0,1   1,0,2
//                   [ [] [] [] ]  1,1,0   1,1,1   1,1,2
//                   [ [] [] [] ]  1,2,0   1,2,1   1,2,2

//                   [ [] [] [] ]  2,0,0   2,0,1   2,0,2
//                   [ [] [] [] ]  2,1,0   2,1,1   2,1,2
//                   [ [] [] [] ]  2,2,0   2,2,1   2,2,2

// gato       ---->  [ [] [] [] ]  0,0   0,1   0,2
//                   [ [] [O] [] ]  1,0   1,1   1,2
//                   [ [] [X] [] ]  2,0   2,1   2,2

//   inserta coordenadas x (0-2): 2 
//   inserta coordenadas y (0-2):1
// 
//  gato[2,1]='X'

//    O
//   inserta coordenadas x (0-2): 1 
//   inserta coordenadas y (0-2):1
//  gato[1,1]='O'