using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Fernando_Duarte:Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "161070503";
            NombreCompleto = "Fernando Moises Duarte Osorio";
            return "Ha asistido a clase.";
        }
    }
}
