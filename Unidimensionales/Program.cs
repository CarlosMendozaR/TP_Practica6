using System;

namespace ArreglosUnidimensionales
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("    ~CALCULADORA DE VECTORES~\n\nIngresa un vector de tres componentes.\nSepara cada uno con una coma sin espacio.");
            Console.WriteLine("*****************\n**  EJEMPLOS   **\n**    1,3,5    **\n**   50,21,0   **\n*****************");
            string[] v1 = new string[3];
            string entrada = Console.ReadLine();
            try
            {
                if (entrada.Contains(";"))
                {
                    v1 = Unidimensional.Leer(entrada);
                    Console.WriteLine(v1.ToString());
                }
                else
                {
                    throw new ApplicationException("Has ingresado de forma incorrecta los componentes de tu vector.");
                }
            }
            catch(FormatException error)
            {
                Console.WriteLine("Error: "+error.Message);
            }
            catch(ApplicationException error)
            {
                Console.WriteLine("Error: " +error.Message);
            }
        }
    }
}
