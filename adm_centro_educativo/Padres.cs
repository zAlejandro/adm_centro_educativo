using System;
using System.Collections.Generic;
using System.Text;

namespace adm_centro_educativo
{
    class Padres : ICloneable
    {
        public String nombres { get; set; }
        public String apellidos { get; set; }
        public int edad { get; set; }
        public String estado { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public Alumnos alumno { get; set; }

        public object Clone()
        {
            Padres clon = (Padres)MemberwiseClone();
            return clon;
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

        public override string ToString()
        {
            return $"nombre: {nombres}," +
                $" apellido: {apellidos}," +
                $" edad: {edad}," +
                $" estado civil: {estado}," +
                $" telefono: {telefono}," +
                $" email: {email}";
        }

    }
}
