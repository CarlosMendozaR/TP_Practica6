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
            byte caso;

            try
            {
                Console.WriteLine("Selecciona la opción que desees.\n  0) Suma con otro vector\n  1) Multiplicación por un escalar\n  2) Multiplicación por otro vector\n");
                caso = byte.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Formato incorrecto, se asigno suma automaticamente");
                caso = 0;
            }

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
                    int escalar;
                    try
                    {
                        Console.WriteLine("Ingresa el escalar por el que quieres multiplicar tu vector.");
                        escalar = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Formato incorrecto, se asigno 1 como tu escalar");
                        escalar = 1;
                    }
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
                default:
                    Console.WriteLine("Formato incorrecto");
                    break;
            }

            Console.ReadLine();
        }
    }
}
