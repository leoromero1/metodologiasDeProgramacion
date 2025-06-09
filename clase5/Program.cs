using clase5;
using clase5.comand;
using clase5.factoryMethod;
using clase5.interfaces;
using clase5.models;
using clase5.proxy;
using MetodologíasDeProgramaciónI;

class Program
{
    static void Main(string[] args)
    {
          //        Practica 5 - Ejercicio 2
        Teacher teacher = new Teacher();
        for (int i = 0; i < 10; i++)
        {
            AlumnoProxy alumno1 = (AlumnoProxy)FabricaDeComparables.CrearAleatorio(4);
            AlumnoAdapter adaptado = new AlumnoAdapter(alumno1);
            teacher.goToClass(adaptado);
        }
        teacher.teachingAClass();
        Console.WriteLine("---------------------------");
        //        Practica 5 - Ejercicio 10
        Aula aula = new Aula();
        OrdenEnAula1 inicio = new OrdenInicio(aula);
        OrdenEnAula1 fin = new OrdenAulaLlena(aula);
        OrdenEnAula2 alumno = new OrdenLlegaAlumno(aula);
        Pila pila = new Pila();
        pila.SetOrdenInicio(inicio);
        pila.SetOrdenLlegaAlumno(alumno);
        pila.setOrdenAulaLlena(fin);
        Helpers.Llenar(pila, 2);
        for (int i = 0; i < 20; i++)
        {
            AlumnoProxy alumnos = (AlumnoProxy)FabricaDeComparables.CrearAleatorio(4);
            pila.Apilar(alumnos);
        }
    }
}
