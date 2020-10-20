using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDepedencia
{
   public class FormatoPDFService:IFormato
    {
        public IDocumento Documento;

        public FormatoPDFService(IDocumento documento)
        {
            Documento = documento;
        }
        public string Generar()
        {
            return "Yo Genero PDF" + Documento.CrearDocumento();
        }

    }
}
