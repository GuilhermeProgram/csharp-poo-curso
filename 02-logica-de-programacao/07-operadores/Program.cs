// Operadores aritméticos e de atribuição (+=, ++), precedência e raízes de uma equação do 2º grau.
using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            double n4 = 10.0 / 8.0;

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            Console.WriteLine("------------");

            int v = 10;
            v += 2;
            Console.WriteLine(v);
            v *= 3;
            Console.WriteLine(v);

            string s = "ABC";
            s += "DEF";
            Console.WriteLine(s);

            Console.WriteLine("------------");

            int p = 10;
            int q = p++;   // q recebe 10, depois p vira 11
            Console.WriteLine(p);
            Console.WriteLine(q);

            int r = 10;
            int t = ++r;   // r vira 11, depois t recebe 11
            Console.WriteLine(r);
            Console.WriteLine(t);
        }
    }
}
