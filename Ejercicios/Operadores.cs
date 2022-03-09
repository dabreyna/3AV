using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class Operadores
    {
        public void operadores(){
            Console.Clear();
            System.Console.WriteLine("Lista de Operadores ordenados por nivel de precedencia");
            System.Console.WriteLine("Categoria\t\t\tDescripcion");
            System.Console.WriteLine("");
            System.Console.WriteLine("Primary\t\tx.y, f(x), a[i], x?.y, x?[y], x++, x--, x!, new, typeof, checked, unchecked,\n\t\tdefault, nameof, delegate, sizeof, stackalloc, x->y\n");
            System.Console.WriteLine("Unary\t\t+x, -x, !x, ~x, ++x, --x, ^x, (T)x, await, &x, *x, true and false\n");
            System.Console.WriteLine("Range\t\tx..y\n");
            System.Console.WriteLine("switch,with\nexpressions\tswitch, with\n");
            System.Console.WriteLine("Multiplicative\tx * y, x / y, x % y\n");
            System.Console.WriteLine("Additive\tx + y, x – y\n");
            System.Console.WriteLine("Shift\t\tx << y, x >> y\n");
            System.Console.WriteLine("Relational and\ntype-testing\tx < y, x > y, x <= y, x >= y, is, as\n");
            System.Console.WriteLine("Equality\tx == y, x != y\n");
            System.Console.WriteLine("Logical AND\tx & y\n");
            System.Console.WriteLine("Logical XOR\tx ^ y\n");
            System.Console.WriteLine("Logical OR\tx | y\n");
            System.Console.WriteLine("Conditional AND\tx && y\n");
            System.Console.WriteLine("Conditional OR\tx || y\n");
            System.Console.WriteLine("Conditional\noperator\tc ? t : f\n");
            System.Console.WriteLine("Assignment\nand lambda\ndeclaration\nAND\t\tx = y, x += y, x -= y, x *= y, x /= y, x %= y, x &= y, x |= y, x ^= y, x <<= y,\n\t\tx >>= y, x ??= y, =>");
            System.Console.WriteLine("\n\nPresiona cualquier tecla para regresar al inicio");
            Console.ReadKey();
        }

        public async void operadoresAritmeticos(){

            // Operador ++

            Console.Clear();
            System.Console.WriteLine("Operador de incremento ++ tiene 2 formas de usarse (Pofijo y Prefijo)");
            System.Console.WriteLine("\nUtilizado como Posfijo");
            System.Console.WriteLine("\nConsiderando la variable \"A\" con un valor inicial de 3");
            System.Console.WriteLine("int A=3;");
            System.Console.WriteLine("Paso 1: Console.WriteLine(A); Da la siguiente salida: 3");
            System.Console.WriteLine("Paso 2: Console.WriteLine(A++); Da la siguiente salida: 3");
            System.Console.WriteLine("Paso 3: Console.WriteLine(A); Da la siguiente salida: 4");
            System.Console.WriteLine("\nAl usar el operador ++ en el paso 2, primero se evalua el valor de A");
            System.Console.WriteLine("imprimiendo el valor 3 y posteriormente se aplica un incremento a A en 1");
            System.Console.WriteLine("por eso en el paso 3, el valor impreso de A pasa a ser 4.");

            System.Console.WriteLine("\nUtilizado como Prefijo");
            System.Console.WriteLine("\nConsiderando la variable \"B\" con un valor inicial de 5");
            System.Console.WriteLine("double B=5.5;");
            System.Console.WriteLine("Paso 1: Console.WriteLine(B); Da la siguiente salida: 5.5");
            System.Console.WriteLine("Paso 2: Console.WriteLine(++B); Da la siguiente salida: 6.5");
            System.Console.WriteLine("Paso 3: Console.WriteLine(B); Da la siguiente salida: 6.5");
            System.Console.WriteLine("\nAl usar el operador ++ en el paso 2, primero se incrementa el valor de B");
            System.Console.WriteLine("y posteriormente se evalua para ser impreso.");

            System.Console.WriteLine("\n\nPresiona cualquier tecla para continuar");
            Console.ReadKey();

            // Operador --

            Console.Clear();
            System.Console.WriteLine("Operador de incremento -- tiene 2 formas de usarse (Pofijo y Prefijo)");
            System.Console.WriteLine("\nUtilizado como Posfijo");
            System.Console.WriteLine("\nConsiderando la variable \"A\" con un valor inicial de 3");
            System.Console.WriteLine("int A=3;");
            System.Console.WriteLine("Paso 1: Console.WriteLine(A); Da la siguiente salida: 3");
            System.Console.WriteLine("Paso 2: Console.WriteLine(A--); Da la siguiente salida: 3");
            System.Console.WriteLine("Paso 3: Console.WriteLine(A); Da la siguiente salida: 2");
            System.Console.WriteLine("\nAl usar el operador -- en el paso 2, primero se evalua el valor de A");
            System.Console.WriteLine("imprimiendo el valor 3 y posteriormente se aplica un decremento a A en 1");
            System.Console.WriteLine("por eso en el paso 3, el valor impreso de A pasa a ser 2.");

            System.Console.WriteLine("\nUtilizado como Prefijo");
            System.Console.WriteLine("\nConsiderando la variable \"B\" con un valor inicial de 5");
            System.Console.WriteLine("double B=5.5;");
            System.Console.WriteLine("Paso 1: Console.WriteLine(B); Da la siguiente salida: 5.5");
            System.Console.WriteLine("Paso 2: Console.WriteLine(--B); Da la siguiente salida: 4.5");
            System.Console.WriteLine("Paso 3: Console.WriteLine(B); Da la siguiente salida: 4.5");
            System.Console.WriteLine("\nAl usar el operador -- en el paso 2, primero se decrementa el valor de B");
            System.Console.WriteLine("y posteriormente se evalua para ser impreso.");

            System.Console.WriteLine("\n\nPresiona cualquier tecla para continuar");
            Console.ReadKey();

            // Operador unario + y -

            Console.Clear();
            System.Console.WriteLine("Dentro de los operadores tenemos el + y - unario");
            System.Console.WriteLine("\nEl operador unario + regresa el valor del operando, mientras");
            System.Console.WriteLine("que el operador unario - calcula la negacion del operando.");
            System.Console.WriteLine("\nEjemplo #1:");
            System.Console.WriteLine("Console.WriteLine(+4); Da la siguiente salida: 4");
            System.Console.WriteLine("Console.WriteLine(-4); Da la siguiente salida: -4");
            System.Console.WriteLine("Console.WriteLine(-(-4)); Da la siguiente salida: 4");

            System.Console.WriteLine("\nEjemplo #2:");
            System.Console.WriteLine("\nint a=5;\nint b= -a;");
            System.Console.WriteLine("Console.WriteLine(b); Da la siguiente salida: -5");


            System.Console.WriteLine("\n\nPresiona cualquier tecla para continuar");
            Console.ReadKey();

            // Asignacion compuesta

            Console.Clear();
            System.Console.WriteLine("Dentro de los operadores aritmeticos podemos realizar la asignacion compuesta");
            System.Console.WriteLine("\nEsta asignacion tiene el siguiente formato: x op= y");
            System.Console.WriteLine("\nEjemplos:");
            System.Console.WriteLine("int a=5;");
            System.Console.WriteLine("\na += 9;\nConsole.WriteLine(a); Da la siguiente salida: 14");
            System.Console.WriteLine("\na -= 4;\nConsole.WriteLine(a); Da la siguiente salida: 10");
            System.Console.WriteLine("\na *= 2;\nConsole.WriteLine(a); Da la siguiente salida: 20");
            System.Console.WriteLine("\na /= 4;\nConsole.WriteLine(a); Da la siguiente salida: 5");


            System.Console.WriteLine("\nEjemplo #2:");
            System.Console.WriteLine("\nint a=5;\nint b= -a;");
            System.Console.WriteLine("Console.WriteLine(b); Da la siguiente salida: -5");

            byte a = 200;
            byte b = 100;
            //byte d=0;
            var c=a+b;
            //d=a+b;
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
            System.Console.WriteLine(a+b);
            a+=b;
            System.Console.WriteLine(a);

            System.Console.WriteLine("\n\nPresiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}