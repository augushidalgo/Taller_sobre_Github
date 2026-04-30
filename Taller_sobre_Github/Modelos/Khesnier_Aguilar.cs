using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Khesnier_Aguilar:Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "20221020009";
            NombreCompleto = "Khesnier Aguilar";
            return "Ha asistido a clase";
        }
    }
}
