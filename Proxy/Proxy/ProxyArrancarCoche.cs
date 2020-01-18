using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    class ProxyArrancarCoche : IArrancarCocheService
    {
        ArrancarCocheService servicio;

        public ProxyArrancarCoche(ArrancarCocheService servicio) {
            this.servicio = servicio;
        }

        public string arrancarCoche(string codigo)
        {
            if (checkAccess(codigo)) {
                return servicio.arrancarCoche(codigo);
            }
            else
            {
                return "Llave no valida";
            }
        }

        private bool checkAccess(string codigo)
        {
            if(servicio.getCodigoLLave().Equals(codigo))
                return true;
            return false;
        }
    }
}
