﻿using System;

namespace NewFetures.Class01
{
    internal class ParameterIn : MenuItem
    {
        public override void Main()
        {
            var ponto1 = new Ponto3D(7, 4, 3);
            var ponto2 = new Ponto3D(17, 6, 2);
            var distancia = CalcularDistancia(ponto1, ponto2);
            Console.WriteLine($"Distância entre {ponto1} e {ponto2}: {distancia}");
        }

        private static double CalcularDistancia(in Ponto3D ponto1, Ponto3D ponto2 = default)
        {
            //OPS! PARÂMETRO DO MÉTODO ESTÁ SENDO MODIFICADO!
            //ponto1 = new Ponto3D(1, 2, 3);

            double diferencaX = ponto1.X - ponto2.X;
            double diferencaY = ponto1.Y - ponto2.Y;
            double diferencaZ = ponto1.Z - ponto2.Z;

            return Math.Sqrt(diferencaX * diferencaX
                            + diferencaY * diferencaY
                            + diferencaZ * diferencaZ);
        }

        private struct Ponto3D
        {
            public readonly double X;
            public readonly double Y;
            public readonly double Z;

            public Ponto3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public override string ToString()
            {
                return $"({X}, {Y}, {Z})";
            }
        }
    }
}