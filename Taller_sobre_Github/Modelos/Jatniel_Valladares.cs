using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Jatniel_Valladares : Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "25505890";
            NombreCompleto = "Jatniel Valladares";
            return "Ha asistido a clase";
        }
    }
}
