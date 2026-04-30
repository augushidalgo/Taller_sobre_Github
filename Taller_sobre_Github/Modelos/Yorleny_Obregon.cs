using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Yorleny_Obregon : Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "25501204";
            NombreCompleto = "Yorleny Obregón";
                return "Ha asistido a clase";
        }
    }
}
