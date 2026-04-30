using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Ulises_Castellon : Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "55416541";
            NombreCompleto = "Ulises Mauricion Castellon Mercado";
            return "Ha asistido a la clase";
        }
    }
}
