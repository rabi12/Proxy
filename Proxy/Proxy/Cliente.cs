using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class Cliente
    {
        public void Main()
        {
            string llave1 = "QWERT";
            string llave2 = "12345";

            ArrancarCocheService servicio = new ArrancarCocheService(llave1);
            ProxyArrancarCoche proxy = new ProxyArrancarCoche(servicio);

            string resultado1=proxy.arrancarCoche(llave2);
            Console.WriteLine(resultado1);

            string resultado2=proxy.arrancarCoche(llave1);
            Console.WriteLine(resultado2);
        }
    }
}
