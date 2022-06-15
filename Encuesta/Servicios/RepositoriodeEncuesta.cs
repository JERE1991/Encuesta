using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encuesta.Models;

namespace Encuesta.Servicios
{ 


    public interface IRepositoriodeEncuesta
{
        void FormularlaEncuesta(FormularioEncuesta formularioEncuesta);
}
    public class RepositoriodeEncuesta: IRepositoriodeEncuesta
    {
       private readonly string connectionString;

        public void FormularlaEncuesta(FormularioEncuesta formularioEncuesta) { 
        
        
        
        }





    }
}
