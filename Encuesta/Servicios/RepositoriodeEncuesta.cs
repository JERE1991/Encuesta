using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Encuesta.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace Encuesta.Servicios
{ 


    public interface IRepositoriodeEncuesta
{
        void FormularlaEncuesta(FormularioEncuesta formularioEncuesta);
       
    }
    public class RepositoriodeEncuesta: IRepositoriodeEncuesta
    {
       private readonly string connectionString;
        public RepositoriodeEncuesta(IConfiguration configuracion) {

            connectionString = configuracion.GetConnectionString("DefaulConnection");

        }

        public void FormularlaEncuesta(FormularioEncuesta formularioEncuesta) {

            using (var conexion = new SqlConnection(connectionString)) {


                conexion.Query($@"insert into Encuesta " + "(primerNombre_usuario, segundoNombre_usuario, primerApellido_usuario" +
                    "segundoApellido_usuario, fechaNacimiento_usuario, correo_usuario, pais_usuario, location_usuario, sexo_usuario, tipo_sangre" +
                    "cantidadHHijos_usuario, estadoCivil_usuario, nivelAcademico_usuario, edad_usuario)" + "values" +
                    "(@)primerNombre_usuario, @segundoNombre_usuario, @primerApellido_usuario, " +
                    "@segundoApellido_usuario, @fechaNacimiento_usuario, @correo_usuario" +
                    "@pais_usuario, @location_usuario, @sexo_usuario, @tipo_sangre, @cantidadHijos_usuario, @estadoCivil_usuario, @nivelAcademico_usuario, @edad) ");








            
            }


        }





    }
}
