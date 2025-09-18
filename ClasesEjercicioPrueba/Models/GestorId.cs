using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEjercicioPrueba.Models
{
    public static class GestorId
    {
        private static int actual = 0;

        public static int ObtenerSiguiente()
        {
            return ++actual;
        }
    }
}


    

