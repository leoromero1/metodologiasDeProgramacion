using clase4.decorator;
using clase4.factoryMethod;
using clase4.interfaces;
using clase4.models;
using MetodologíasDeProgramaciónI;
class Program
{
    static void Main(string[] args)
    {
        //Practica 4 - ejercicio 4
        /*
        Teacher teacher = new Teacher();
        FabricaDeAlumnos fabrica = new FabricaDeAlumnos();
        for (int i = 0; i < 10; i++)
        {
            Alumno alumno = (Alumno)fabrica.CrearAleatorio();
            AlumnoAdapter adaptado = new AlumnoAdapter(alumno);
            teacher.goToClass(adaptado);
        }

        for (int i = 0; i < 10; i++)
        {
            Alumno alumno = (Alumno)fabrica.CrearAleatorio();
            AlumnoMuyEstudioso alumnoEstudioso = new AlumnoMuyEstudioso(
                alumno.GetNombre(),
                alumno.GetDni(),
                alumno.GetLegajo(),
                alumno.GetPromedio(),
                alumno.GetCalificacion()
            );
            AlumnoAdapter adaptado = new AlumnoAdapter(alumnoEstudioso);
            teacher.goToClass(adaptado);
        }
        teacher.teachingAClass();
        */

        // Practica 4 - ejercicio 6
        Teacher teacher = new Teacher();
        for (int i = 0; i < 10; i++)
        {
            IAlumno alumno = (Alumno)FabricaDeComparables.CrearAleatorio(2);
            IAlumno decorador = new DecoradorPorLegajo(alumno);
            IAlumno decorador2 = new DecoradorConLetras(decorador);
            IAlumno decorador3 = new DecoradoPorPromocion(decorador2);
            IAlumno decorador4 = new DecoradoConAsteriscos(decorador3);

            Student student = new AlumnoAdapter(decorador4);


            teacher.goToClass(student);
        }

        teacher.teachingAClass();
    }
}
