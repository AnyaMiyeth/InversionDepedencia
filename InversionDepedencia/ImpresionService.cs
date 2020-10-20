using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDepedencia
{
    public class ImpresionService
    {
        public IFormato Formato;
        

        public ImpresionService(IFormato formato)
        {
            Formato = formato;
            
        }
     
        public string Imprimir()
        {
            return "Yo imprimo " + Formato.Generar()+"\t";


        }
        
    }
}
