using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encuesta.Models
{
    public class FormularioEncuesta
    {
        public string primerNombre_usuario { get; set; }
        public string segundoNombre_usuario { get; set; }
        public string primerApellido_usuario { get; set; }
        public string segundoApellido_usuario { get; set; }
        public string fechaNacimiento_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string pais_usuario { get; set; }
        public string location_usuario { get; set; }
        public string sexo_usuario { get; set;}
        public string tipo_sangre { get; set; }
        public int cantidadHijos_usuario { get; set; }
        public string estadoCivil_usuario { get; set; }
        public string nivelAcademico_usuario { get; set; }
        public int  edad { get; set; }


          
    }
}