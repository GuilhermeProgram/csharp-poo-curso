// Classe Triangulo: três atributos (A, B, C) e o método Area() (reaproveitamento + delegação).
using System;

namespace Course {
    class Triangulo {
        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
