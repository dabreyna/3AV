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
        int ganador;
        // creamos una matriz de 3x3 que va almacenar los datos del tablero del juego
        char[,] tablero = {
                    {' ',' ',' '},
                    {' ',' ',' '},
                    {' ',' ',' '}
                    };

        public void jugar(){
            fin=false;
            turno=1;
            ganador=0;
            dibujaTablero();

            while(fin==false){
            Console.SetCursorPosition(30,22);
            System.Console.WriteLine("Jugador: {0}",turno);
            Console.SetCursorPosition(0,12);
            System.Console.WriteLine("Elige una posicion disponible (1-9)");
            ubicacion = int.Parse(Console.ReadLine());

            /*  fin = true
                turno = 1
                ganador=0
                ubicacion= 3
            //
            */
            switch (ubicacion)
            {
                case 1:
                        if(tablero[0,0]==' '){
                           if(turno==1){
                               tablero[0,0]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[0,0]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 2:
                        if(tablero[0,1]==' '){
                           if(turno==1){
                               tablero[0,1]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[0,1]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 3:
                        if(tablero[0,2]==' '){
                           if(turno==1){
                               tablero[0,2]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[0,2]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 4:
                        if(tablero[1,0]==' '){
                           if(turno==1){
                               tablero[1,0]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[1,0]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 5:
                        if(tablero[1,1]==' '){
                           if(turno==1){
                               tablero[1,1]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[1,1]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 6:
                        if(tablero[1,2]==' '){
                           if(turno==1){
                               tablero[1,2]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[1,2]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 7:
                        if(tablero[2,0]==' '){
                           if(turno==1){
                               tablero[2,0]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[2,0]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 8:
                        if(tablero[2,1]==' '){
                           if(turno==1){
                               tablero[2,1]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[2,1]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                case 9:
                        if(tablero[2,2]==' '){
                           if(turno==1){
                               tablero[2,2]='O';
                               fin=hayGanador(turno);
                               turno=2;
                           }else{
                               tablero[2,2]='X';
                               fin=hayGanador(turno);
                               turno=1;
                           }                             
                        }else{
                            System.Console.WriteLine("Ubicacion no disponible, intenta otra\n presiona una tecla para continuar..");
                            Console.ReadKey();
                        }
                        break;
                default:{ 
                    System.Console.WriteLine("Error, valor de posicion no valido");
                    System.Console.ReadKey();
                    break;
                    }
            }
            dibujaTablero();
            }


            // dibujaTablero();
            //if(){
            System.Console.WriteLine("El ganador es el Jugador {0}",ganador);
            System.Console.WriteLine("\n\n\n\n");
            //}
            //else
            // {
            //      System.Console.WriteLine("No hay ganador");
            // }
        }
// jugador1 = O
// jugador2 = X
        public void dibujaTablero(){
            // Limpiamos pantalla
            Console.Clear();
            Console.SetCursorPosition(0,0);
            // dibujamos el tablero en la pantalla
            System.Console.WriteLine(" 1 | 2 | 3 "); // 1,0   5,0    9,0
            System.Console.WriteLine("___|___|___");
            System.Console.WriteLine(" 4 | 5 | 6 "); // 1,2   5,2    9,2
            System.Console.WriteLine("___|___|___");
            System.Console.WriteLine(" 7 | 8 | 9 "); // 1,4   5,4    9,4
            System.Console.WriteLine("   |   |   ");

            int y=0;
            /*
              x= 1
              y= 2
              i= 1
              j= 0
                tablero[0,1]
            */
            for(int i=0;i<3;i++){ // recorrer por linea
                int x=1;
                for(int j=0;j<3;j++){ // recorrer por columna
                    if(tablero[i,j]!=' '){
                        Console.SetCursorPosition(x,y);
                        System.Console.WriteLine(tablero[i,j]);
                    }
                    x=x+4;
                }
                y=y+2;
            }
        }

        //Funcion para verificar si hay un ganador
        public bool hayGanador(int turno){
            /*
            Primero debemos definir las jugadas que pueden ganar el juego
            independientemente de la marca del jugador
            jugadaHorizontal1 {1,2,3} ganador = turno; return true;
            jugadaHorizontal2 {4,5,6}
            jugadaHorizontal3 {7,8,9}
            jugadaVertical1 {1,4,7}
            jugadaVertical2 {2,5,6}
            jugadaVertical3 {3,6,9}
            jugadaDiagonal1 {1,5,9}
            jugadaDiagonal2 {3,5,7}
        char[,] tablero = {
                    {'O','O','O'}, // [0,0]  [0,1]  [0,2]
                    {' ',' ',' '}, // [1,0]  [1,1]  [1,2]
                    {' ',' ',' '}  // [2,0]  [2,1]  [2,2]
                    };
            */
            char marca; //'X' 'O'
            if(turno==1){marca='O';}else{marca='X';}
            //marca= 'O'
            // AND o el Y logico     expresion A Y expresion B 

            //JUGADAS HORIZONTALES
            if(tablero[0,0]==marca && tablero[0,1]==marca && tablero[0,2]==marca){
                ganador=turno;
                return true;
            }

            if(tablero[1,0]==marca && tablero[1,1]==marca && tablero[1,2]==marca){
                ganador=turno;
                return true;
            }
            if(tablero[2,0]==marca && tablero[2,1]==marca && tablero[2,2]==marca){
                ganador=turno;
                return true;
            }            

            //JUGADAS VERTICALES
            if(tablero[0,0]==marca && tablero[1,0]==marca && tablero[2,0]==marca){
                ganador=turno;
                return true;
            }

            if(tablero[0,1]==marca && tablero[1,1]==marca && tablero[2,1]==marca){
                ganador=turno;
                return true;
            }
            if(tablero[0,2]==marca && tablero[1,2]==marca && tablero[2,2]==marca){
                ganador=turno;
                return true;
            }            

            //JUGADAS DIAGONALES
            if(tablero[0,0]==marca && tablero[1,1]==marca && tablero[2,2]==marca){
                ganador=turno;
                return true;
            }

            if(tablero[0,2]==marca && tablero[1,1]==marca && tablero[2,0]==marca){
                ganador=turno;
                return true;
            }
            return false;
        }
    }
}
