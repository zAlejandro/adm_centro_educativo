using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace adm_centro_educativo
{
    class Alumnos : ICloneable
    {
        public String nombre { get; set; }
        public String apellidos { get; set; }
        public int edad { get; set; }
        public String email { get; set; }
        public Padres padres { get; set; }

        public object Clone()
        {
            Alumnos clon = (Alumnos)MemberwiseClone();
            clon.padres = new Padres();
            clon.padres.nombres = padres.nombres;
            clon.padres.telefono = padres.telefono;
            return clon;
        }

        public override string ToString()
        {
            return $"nombre: {nombre}" +
                $", apellido: {apellidos}" +
                $", edad: {edad}" +
                $", email: {email}" +
                $", Nombre del padre: {padres.nombres}" +
                $", telefono del padre: {padres.telefono}";
        }

        public void metodo1()
        {
            
        }
        public void metodo2()
        {

        }
        public void metodo3()
        {

        }
    }
}
