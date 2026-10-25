using System;
namespace ProyectoTDD
{
    public static class Funciones
    {
        public static long CalcularFactorial(int n)
        {
            if (n < 0)
            {
                return -1;
            }

            if (n == 0)
            {
                return 1;
            }

            long resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
        public static bool EsContrasenyaValida(string contrasenya)
        {
            throw new NotImplementedException();
        }
    }
}