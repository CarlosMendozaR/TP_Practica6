using System;

namespace ArreglosUnidimensionales
{
    class Program
    {
        static void Main()
        {
            bool excep = false; 
            do
            {
                Console.WriteLine("    ~CALCULADORA DE VECTORES~\n\nIngresa un vector de tres componentes.\nSepara cada uno con una coma sin espacio.");
                Console.WriteLine("*****************\n**  EJEMPLOS   **\n**    1,3,5    **\n**   50,21,0   **\n*****************");
                string entrada = Console.ReadLine();
                try
                {
                    if (entrada.Contains(","))
                    {
                        Unidimensional v1 = Unidimensional.Leer(entrada);
                        Console.WriteLine(v1.ToString());
                    }
                    else
                    {
                        throw new ApplicationException("Has ingresado de forma incorrecta los componentes de tu vector.");
                    }
                }

                catch (ApplicationException error)
                {
                    Console.WriteLine("Error: " + error.Message);
                    excep = true;
                }

                catch (FormatException error)
                {
                    Console.WriteLine("Error: " + error.Message);
                    excep = true;
                }

            } while (excep);

            Console.ReadLine();
        }
    }
}
