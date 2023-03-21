using Alumnos;

var alumno1 = new Alumno();
alumno1.Apellido = "Mateo";
alumno1.Nombre = "Joaquin";
alumno1.legajo = 1;
alumno1.DNI = "30560420";
alumno1.FechaNacimiento = new DateTime(1986, 11, 4);
alumno1.Calificacion = new List<int>();
var alumno2 = new Alumno();
{
   alumno2.Apellido = "Lobo";
    alumno2.Nombre = "Melu";
    alumno2.legajo = 2;
    alumno2.DNI = "30562563";
    alumno2.FechaNacimiento = new DateTime(1988, 11, 4);


}

alumno1.CargarCalificacion(6,DateTime.Now);
alumno1.CargarCalificacion(7, DateTime.Now);
alumno1.CargarCalificacion(8, DateTime.Now);


Console.WriteLine(alumno1.ObtenerPromedio);
