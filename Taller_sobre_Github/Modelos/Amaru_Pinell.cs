using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Amaru_Pinell:Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "12345678";
            NombreCompleto = "Adriana Meza";
            return "Ha asistido a clase";
        }
    }
}
