using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ArrancarCocheService : IArrancarCocheService
    {
         private string codigoLlave;

        public string getCodigoLLave()
        {
            return codigoLlave;
        }

        public ArrancarCocheService(string codigoLlave)
        {
            this.codigoLlave = codigoLlave;
        }


        public string arrancarCoche(string codigo)
        {
            return "Arrancar coche";
        }

    }
}
