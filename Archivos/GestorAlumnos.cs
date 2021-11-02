using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Archivos
{
    class GestorAlumnos
    {
        string archivo = "alumnos.txt";

        public void Alta(Alumno unAlumno)
        {
            //Abrimos el archivo
            FileStream fs = new FileStream(archivo, FileMode.Append, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                //Obtengo el registro que guarde en el archiv a partir del objeto recibido
                writer.WriteLine(unAlumno.GenerarRegistro());
            }
            fs.Close();
        }

        public void Baja(long DNI)
        {
            //Para dar de baja es necesario crear un nuevo set de datos sin el dato quese desea borrar
            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();

                while(linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    if(unAlumno.DNI != DNI)//compara DNI de la linea(alumno) leida con el DNI recibido
                    {
                        output += linea + Environment.NewLine; //Environment.NewLine agrega un salto de linea
                    }
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();

        }
        public List<Alumno> Listar()
        {
            //Creamos una lista
            List<Alumno> lista = new List<Alumno>();

            //Abrimos el archivo
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);

            //Leemos linea por linea y por cada linea creamos un Objeto alumno que 
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                while (linea != null)
                {
                    Alumno unAlumno = new Alumno(linea);
                    lista.Add(unAlumno);
                    linea = reader.ReadLine();
                }
            }
            fs.Close();
            return lista;
        }

        public void EditarAlumno(long DNI, Alumno alumnoEditar)
        {
            string output = string.Empty;
            FileStream fs = new FileStream(archivo, FileMode.OpenOrCreate, FileAccess.Read);
            using (StreamReader reader = new StreamReader(fs))
            {
                string linea = reader.ReadLine();
                string lineaAux = alumnoEditar.GenerarRegistro();
                while (linea != null)
                {
                    Alumno alumno = new Alumno(linea);
                    if(alumno.DNI != DNI)
                    {
                        output += linea + Environment.NewLine;
                    }
                    if (alumno.DNI == DNI)
                    {
                        output += lineaAux + Environment.NewLine;
                    }
                    linea = reader.ReadLine();
                }
            }
            fs.Close();

            fs = new FileStream(archivo, FileMode.Truncate, FileAccess.Write);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(output);
            }
            fs.Close();
        }
    }
}
