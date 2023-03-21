using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    internal class Alumno
    {
        public int legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DNI { get; set; }
        public List<int> Calificacion { get; set; }
        public void CargarCalificacion(int Nota, DateTime Fecha)
        {
            Calificacion.Add(Nota);
            Console.WriteLine(Fecha.ToString("yyyy") + $" se asigno la calificacion {Nota} al legajo {legajo}");
        }

        // lo que logra es obtener el promedio de las calificaciones
        public decimal ObtenerPromedio()
        {  
        int acumulador = 0; 
        foreach (int nota in Calificacion)
	    {
            acumulador += nota;
        }
            var promedio = acumulador / Calificacion.Count;
            return promedio;
	    }
    }
    }

