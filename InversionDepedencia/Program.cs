using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDepedencia
{
    class Program
    {
        static void Main(string[] args)
        {

            //IFormato formato = new FormatoPDFService();
            IDocumento documento = new DocumentoService();
            IDocumento documento2 = new ReporteVentasc();
            IFormato formatoExcel = new FormatoExcelService(documento2);
            ImpresionService service = new ImpresionService(formatoExcel);
            Console.WriteLine(service.Imprimir());
            Console.ReadKey();
        }
    }
}
