using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Jose_Picado : Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "87654321";
            NombreCompleto = "Jose Picado";
            return "Ha asistido a clase";
        }
    }
}
