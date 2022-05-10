using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejer8
{
    static class Extensiones
    {
        public static string PrimerMitad(this string palabra)
        {
            string aux = palabra.Substring(0, palabra.Length / 2);
            return aux;
        }

        public static string SegundaMitad(this string palabra)
        {
            string aux = palabra.Substring(palabra.Length / 2, palabra.Length - (palabra.Length / 2));
            return aux;
        }
    }
}
