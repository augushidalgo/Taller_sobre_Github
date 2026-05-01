using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Jose_Benavides : Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "25502051";
            NombreCompleto = "José Antonio Benavides Meléndez";
            return "Ha asistido a clase";
        }
    }
}
