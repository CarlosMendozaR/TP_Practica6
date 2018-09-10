﻿using System;

namespace ArreglosUnidimensionales
{
    class Unidimensional
    {
        float[] matriz = new float[3];

        public static Unidimensional Leer(string elementos)
        {
            string[] columnas = elementos.Split(','); //columnas es una matriz auxiliar
            Unidimensional vector = new Unidimensional();
            for (int i = 0; i < 3; i++)
            {
                vector.matriz[i] = float.Parse(columnas[i]);
            }
            return vector;
        }

    }
}