using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Gato
    {
        public bool fin;
        int turno;
        int ubicacion;
        // creamos una matriz de 3x3 que va almacenar los datos del tablero del juego
        char[,] tablero = {
                    {' ',' ',' '},
                    {' ',' ',' '},
                    {' ',' ',' '}
                    };
        public void jugar(){
            fin=false;
            turno=1;
            dibujaTablero();

            do{
                Console.SetCursorPosition(0,12);
                System.Console.WriteLine("Elige una posicion disponible (1-9):");
                ubicacion=int.Parse(Console.ReadLine());
                switch(ubicacion){
                    case 1:
                            if(tablero[0,0]==' '){
                                if(turno==1){ tablero[0,0]='O';turno=2;}
                                else{tablero[0,0]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                            }
                            break;
                    case 2:
                            if(tablero[0,1]==' '){
                                if(turno==1){ tablero[0,1]='O';turno=2;}
                                else{tablero[0,1]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                            }
                            break;
                    case 3:
                            if(tablero[0,2]==' '){
                                if(turno==1){ tablero[0,2]='O';turno=2;}
                                else{tablero[0,2]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                            }
                            break;
                    case 4:
                            if(tablero[1,0]==' '){
                                if(turno==1){ tablero[1,0]='O';turno=2;}
                                else{tablero[1,0]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                                break;
                            }
                    case 5:
                            if(tablero[1,1]==' '){
                                if(turno==1){ tablero[1,1]='O';turno=2;}
                                else{tablero[1,1]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                                break;
                            }
                    case 6:
                            if(tablero[1,2]==' '){
                                if(turno==1){ tablero[1,2]='O';turno=2;}
                                else{tablero[1,2]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                                break;
                            }
                    case 7:
                            if(tablero[2,0]==' '){
                                if(turno==1){ tablero[2,0]='O';turno=2;}
                                else{tablero[2,0]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                                break;
                            }
                    case 8:
                            if(tablero[2,1]==' '){
                                if(turno==1){ tablero[2,1]='O';turno=2;}
                                else{tablero[2,1]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                                break;
                            }
                    case 9:
                            if(tablero[2,2]==' '){
                                if(turno==1){ tablero[2,2]='O';turno=2;}
                                else{tablero[2,2]='X';turno=1;}
                                break;
                            }else{
                                System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                                Console.ReadKey();
                                break;
                            }
                    default:
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra");
                            Console.ReadKey();
                            break;
                }
                //fin=hayGanador(turno);
                //dibujaTablero();
            }
            while(!hayGanador(turno));
            Console.SetCursorPosition(40,5);
            System.Console.Write($"El jugador #{turno} ha ganado el juego");
        }

        public void dibujaTablero(){
            // Limpiamos pantalla
            Console.Clear();
            Console.SetCursorPosition(0,0);
            // dibujamos el tablero en la pantalla
            System.Console.WriteLine(" 1 | 2 | 3 "); // 1,0   5,0    9,0
            System.Console.WriteLine("___|___|___");
            System.Console.WriteLine(" 4 | 5 | 6 "); // 1,2
            System.Console.WriteLine("___|___|___");
            System.Console.WriteLine(" 7 | 8 | 9 "); // 1,4
            System.Console.WriteLine("   |   |   ");

            int y=0;
            for (int i = 0; i < 3; i++)
            {
                int x=1;
                for (int j = 0; j < 3; j++)
                {
                    if(tablero[i,j]!=' '){
                        Console.SetCursorPosition(x , y);
                        System.Console.WriteLine(tablero[i,j]);
                    }
                    x+=4;
                }
                y+=2;
            }
        }

        //Funcion para verificar si hay un ganador
        public bool hayGanador(int turno){
            /*
            Primero debemos definir las jugadas que pueden ganar el juego
            independientemente de la marca del jugador

            jugadaHorizontal1 {1,2,3}
            jugadaHorizontal2 {4,5,6}
            jugadaHorizontal3 {7,8,9}

            jugadaVertical1 {1,4,7}
            jugadaVertical2 {2,5,6}
            jugadaVertical3 {3,6,9}

            jugadaDiagonal1 {1,5,9}
            jugadaDiagonal2 {1,5,9}

            */

            
            char marca;
            if (turno==1){marca='O';}else{marca='X';}
            dibujaTablero();

            //jugadaHorizontal1 {1,2,3}
            if( tablero[0,0]==marca && tablero[0,1]==marca && tablero[0,2]==marca)
            {
                return true;
            }
            return false;
        }
    }
}