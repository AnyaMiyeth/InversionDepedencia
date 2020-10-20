using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDepedencia
{
   public class FormatoExcelService:IFormato
    {

        public IDocumento Documento;

        public FormatoExcelService(IDocumento documento)
        {
            Documento = documento;
        }
        public string Generar()
        {
            return "Yo Genero Excel" + Documento.CrearDocumento();
        }

       
    }
}
