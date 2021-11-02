using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class Alumno
    {
        public Alumno()
        {
        }

        public Alumno(long dni)
        {
            //Creo un alumno con el DNI obligatoriamente
            this.DNI = dni;
        }

        public Alumno(string linea)
        {
            //Recontruyo el objeto a partir de los datos levantados del registro
            string[] datos = linea.Split(',');

            this.DNI = long.Parse(datos[0]);
            this.Apellido= datos[1];
            this.Nombre = datos[2];
            this.Email = datos[3];
            this.Telefono = datos[4];
        }

        public long DNI { get;  set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


        public string GenerarRegistro()
        {
            return $"{DNI},{Apellido},{Nombre},{Email},{Telefono}";
        }

    }
}
