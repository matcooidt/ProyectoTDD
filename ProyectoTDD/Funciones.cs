using System;
namespace ProyectoTDD
{
    public static class Funciones
    {
        private const long ErrorFactorial = -1;

        /// <summary>
        /// Calcula el factorial de n.
        /// Devuelve -1 si n es negativo; el factorial de 0 es 1.
        /// </summary>
        public static long CalcularFactorial(int n)
        {
            if (n < 0)
            {
                return ErrorFactorial;
            }

            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }

            return resultado;
        }

        public static bool EsContrasenyaValida(string contrasenya)
        {
            if (contrasenya == null)
            {
                return false;
            }

            if (contrasenya == "")
            {
                return false;
            }

            if (contrasenya.Length < 8)
            {
                return false;
            }

            if (!contrasenya.Contains("#"))
            {
                return false;
            }

            return true;
        }
    }
}