using System;

namespace ArreglosUnidimensionales
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("    ~CALCULADORA DE VECTORES~\n\nIngresa un vector de tres componentes.\nSepara cada uno con una coma sin espacio.");
            Console.WriteLine("*****************\n**  EJEMPLOS   **\n**    1,3,5    **\n**   50,21,0   **\n*****************");
            string dato = "";

            Unidimensional v1;
            v1 = Unidimensional.Leer(dato);
            Console.WriteLine("Tu vector es: "+ v1.ToString()+"\n");

            Console.WriteLine("Selecciona la opción que desees.\n0) Suma con otro vector\n1) Multiplicación por un escalar\n2) Multiplicación por otro vector");
            byte caso = byte.Parse(Console.ReadLine());

            switch (caso)
            {
                case 0:
                    Console.WriteLine("Ingresa otro vector que quieres sumar.");
                    Unidimensional v2 = Unidimensional.Leer(dato);
                    Console.WriteLine("Tu otro vector es: "+v2.ToString()+"\n");
                    Unidimensional v3 = v1 + v2;
                    Console.WriteLine("RESULTADO");
                    Console.WriteLine(v3.ToString());
                    break;

                case 1:
                    Console.WriteLine("Ingresa el escalar por el que quieres multiplicar tu vector.");
                    int escalar = int.Parse(Console.ReadLine());
                    Unidimensional res1 = new Unidimensional();
                    Console.WriteLine("RESULTADO");
                    res1.M_Escalar(v1, escalar);
                    break;

                case 2:
                    Console.WriteLine("Ingresa otro vector por el que quieres multiplicar.");
                    Unidimensional v4 = Unidimensional.Leer(dato);
                    Console.WriteLine("Tu otro vector es: "+v4.ToString()+"\n");
                    Unidimensional res2 = new Unidimensional();
                    Console.WriteLine("RESULTADO");
                    res2.M_Vector(v1, v4);
                    break;
            }
        }
    }
}
