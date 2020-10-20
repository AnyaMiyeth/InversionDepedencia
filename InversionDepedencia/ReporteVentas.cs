using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDepedencia
{
    public class ReporteVentasc : IDocumento
    {
        public string CrearDocumento()
        {
            return " Yo soy el Reporte de Ventas";
        }
    }
}
