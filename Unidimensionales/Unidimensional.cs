using System;

namespace ArreglosUnidimensionales
{
    class Unidimensional
    {
        double[] matriz = new double[3];

        public static Unidimensional Leer(string entrada)
        {
            Unidimensional vector = new Unidimensional();
            entrada = Console.ReadLine();

            try
            {
                if (entrada.Contains(","))
                {
                    for (int i = 0; i < vector.matriz.Length; i++)
                    {
                        vector.matriz[i] = Convert.ToDouble(Convert.ToString(entrada[i * 2]));
                        //entrada[i*2] es un char[], entonces convierto primero a string y después a int
                    }
                }
                else
                {
                    throw new ApplicationException("Has ingresado de forma incorrecta los componentes de tu vector.");
                }
            }
            catch (FormatException error)
            {
                Console.WriteLine("Error: " + error.Message);

            }
            catch (ApplicationException error)
            {
                Console.WriteLine("Error: " + error.Message);
            }

            return vector;


        }

        public override string ToString()
        {
            string aux = "(";
            for (int i = 0; i < 3; i++)
            {
                aux = aux + " " + matriz[i];
            }
            aux = aux + " )";
            return aux;
        }


        public static Unidimensional operator +(Unidimensional v1, Unidimensional v2)
        {
            Unidimensional v3 = new Unidimensional();
            for (int i = 0; i < v1.matriz.Length; i++)
            {
                v3.matriz[i] = v1.matriz[i] + v2.matriz[i];
            }
            return v3;
        }

        public void M_Escalar(Unidimensional x, int cte)
        {
            Unidimensional z = new Unidimensional();
            for (int c = 0; c < x.matriz.Length; c++)
            {
                z.matriz[c] = cte*x.matriz[c];
            }
            Console.WriteLine(z.ToString());
        }

        public void M_Vector(Unidimensional x, Unidimensional y)
        {
            Unidimensional z = new Unidimensional();
            z.matriz[0] =(x.matriz[1]*y.matriz[2])-(y.matriz[1]*x.matriz[2]);
            z.matriz[1] =(y.matriz[0]*x.matriz[2])-(x.matriz[0]*y.matriz[2]);
            z.matriz[2] =(x.matriz[0]*y.matriz[1])-(y.matriz[0]*x.matriz[1]);

            Console.WriteLine(z.ToString());
        }
    }
}
