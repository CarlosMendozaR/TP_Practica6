using System;

namespace Unidimensionales
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("    ~CALCULADORA DE VECTORES~\n\nIngresa un vector de tres componentes.\nSepara cada uno con una coma sin espacio.");
            Console.WriteLine("*****************\n**  EJEMPLOS   **\n**    1,3,5    **\n**   50,21,0   **\n*****************");
            float[] v1 = new float[3];
            string entrada = Console.ReadLine();
            try
            {
                if (entrada.Contains(";"))
                {
                    /*mu1 = Multidimensional.Leer(txtbEntrada.Text);
                    lbMatriz1.Text = mu1.ToString();*/
                    v1 =
                    m1 = (txtbEntrada.Text);
                    lbMatriz1.Text = m1.ToString();
                }
                else
                {
                    m1 = Unidimensional.Leer(txtbEntrada.Text);
                    lbMatriz1.Text = m1.ToString();
                }
                errorProv.Clear();
            }
            catch (FormatException error)
            {
                errorProv.SetError(txtbEntrada, error.Message);
            }
        }
    }
}
