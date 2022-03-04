using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicios
{
    public class TiposDeDatos
    {
        public void tiposNumericos(){
            Console.Clear();

            System.Console.WriteLine("Tipo\t\t\tDescripcion\t\t\t\tValores/Rango");
            System.Console.WriteLine("");
            System.Console.WriteLine("byte\t\t8-bit unsigned integer\t\t\t0 to 255");
            System.Console.WriteLine("sbyte\t\t8-bit signed integer\t\t\t-128 to 127");
            System.Console.WriteLine("short\t\t16-bit signed integer\t\t\t-32,768 to 32,767");
            System.Console.WriteLine("ushort\t\t16-bit unsigned integer\t\t\t0 to 65,535");
            System.Console.WriteLine("int\t\t32-bit signed integer\t\t\t-2,147,483,648 to 2,147,483,647");
            System.Console.WriteLine("uint\t\t32-bit unsigned integer\t\t\t0 to 4,294,967,295");
            System.Console.WriteLine("long\t\t64-bit signed integer\t\t\t–9,223,372,036,854,775,808 to 9,223,372,036,854,775,807");
            System.Console.WriteLine("ulong\t\t64-bit unsigned integer\t\t\t0 to 18,446,744,073,709,551,615");
            System.Console.WriteLine("float\t\t32-bit floating point\t\t\t±1.5 x 10−45 to ±3.4 x 1038");
            System.Console.WriteLine("double\t\t64-bit floating point\t\t\t±5.0 × 10−324 to ±1.7 × 10308");
            System.Console.WriteLine("decimal\t\t128-bit floating point\t\t\t±1.0 x 10-28 to ±7.9228 x 1028");

        }

        public void tiposLogicos(){
            Console.Clear();
            System.Console.WriteLine("Tipo\t\t\tDescripcion\t\t\t\tValores/Rango");
            System.Console.WriteLine("");
            System.Console.WriteLine("bool\t\tBoolean\t\t\ttrue or false");
        }

        public void tiposAlfanumericos(){
            Console.Clear();
            System.Console.WriteLine("Tipo\t\t\tDescripcion\t\t\t\tValores/Rango");
            System.Console.WriteLine("");
            System.Console.WriteLine("char\t\t16-bit Unicode character\t\t\tU+0000 to U+FFFF");
            System.Console.WriteLine("string\t\tSequence of Unicode characters\t\t\t\"abcde...\"");

        }

    }
}