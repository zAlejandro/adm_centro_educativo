using System;
using System.IO;

namespace adm_centro_educativo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("archivo.txt");
            Padres p1 = new Padres();

            p1.nombres = "Luis";
            p1.apellidos = "Rodrigez";
            p1.edad = 31;
            p1.estado = "Casado";
            p1.telefono = "829-529-5578";
            p1.email = "LuisitoR01@hotmail.com";

            Alumnos a1 = new Alumnos();

            a1.nombre = "Rodrigo";
            a1.apellidos = "Rodrigez";
            a1.edad = 14;
            a1.email = "RGarcia@gmail.com";
            a1.padres = new Padres();
            a1.padres.nombres = p1.nombres;
            a1.padres.telefono = p1.telefono;
            sw.WriteLine("");
            sw.WriteLine(a1.ToString());

            //clones(padres)

             Padres p2 = (Padres)p1.Clone();
             p2.nombres = "Maria";
             p2.apellidos = "Soto";
             p2.edad = 31;
             p2.estado = "Soltero";
             p2.telefono = "829-421-8978";
             p2.email = "Maria@gmail.com";

             Padres p3 = (Padres)p1.Clone();
             p3.nombres = "Joe";
             p3.apellidos = "Duke";
             p3.edad = 31;
             p3.estado = "Soltero";
             p3.telefono = "829-554-6214";
             p3.email = "Joe@hotmail.com";

             Padres p4 = (Padres)p1.Clone();
             p4.nombres = "Sabrina";
             p4.apellidos = "Caliente";
             p4.edad = 31;
             p4.estado = "Casada";
             p4.telefono = "829-789-5467";
             p4.email = "SC12@gmail.com";

            //clones alumnos

            Alumnos a2 = (Alumnos)a1.Clone();
            a2.nombre = "Angela";
            a2.apellidos = "Garcia";
            a2.edad = 13;
            a2.email = "angela@gmail.com";
            a2.padres = new Padres();
            a2.padres.nombres = p2.nombres;
            a2.padres.telefono = p2.telefono;
            sw.WriteLine("");
            sw.WriteLine(a2.ToString());
            

             Alumnos a3 = (Alumnos)a1.Clone();
             a3.nombre = "Nina";
             a3.apellidos = "Duke";
             a3.edad = 14;
             a3.email = "ninasG@live.com";
            a3.padres = new Padres();
            a3.padres.nombres = p3.nombres;
            a3.padres.telefono = p3.telefono;
            sw.WriteLine("");
            sw.WriteLine(a3.ToString());

            Alumnos a4 = (Alumnos)a1.Clone();
            a4.nombre = "Alonso";
            a4.apellidos = "German";
            a4.edad = 15;
            a4.email = "Alonsogerman435@hotmail.com";
            a4.padres = new Padres();
            a4.padres.nombres = p4.nombres;
            a4.padres.telefono = p4.telefono;
            sw.WriteLine("");
            sw.WriteLine(a4.ToString());

            sw.Close();

            Console.WriteLine("----------------");
            Console.WriteLine("     Padres     ");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine(p1.ToString());
            Console.WriteLine();
            Console.WriteLine(p2);
            Console.WriteLine();
            Console.WriteLine(p3);
            Console.WriteLine();
            Console.WriteLine(p4);
            Console.WriteLine();

            Console.WriteLine("----------------");
            Console.WriteLine("     Alumnos    ");
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine(a1.ToString());
            Console.WriteLine();
            Console.WriteLine(a2);
            Console.WriteLine();
            Console.WriteLine(a3);
            Console.WriteLine();
            Console.WriteLine(a4);


            Console.ReadKey();
        }
    }
}
