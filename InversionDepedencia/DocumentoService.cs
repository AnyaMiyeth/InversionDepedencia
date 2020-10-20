using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDepedencia
{
    public class DocumentoService:IDocumento
    {
        public DocumentoService()
        {
        }

        public string CrearDocumento()
        {
            return "Yo Genero Docuemento1 ";
        }
    }
}
