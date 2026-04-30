using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    internal class Hamleth_Galeano : Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "25511632";
            NombreCompleto = "Hamleth Galeano";
            return "Ha asistido a clase";
        }
    }
}
