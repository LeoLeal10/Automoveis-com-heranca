using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2B2_POO
{
    interface IPedagio
    {
        double PagarPedagio();

        double GastoTotalPedagios();

        double NumeroPedagiosPagos { get; set; }
 
    }
}
