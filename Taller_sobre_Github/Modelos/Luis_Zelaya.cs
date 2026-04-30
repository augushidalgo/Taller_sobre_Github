using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    internal class Luis_Zelaya : Estudiante
    {
        public override string ComprobarAsistencia()
        {
            Carnet = "45445";
            NombreCompleto = "LUIS ISAAC ZELAYA CRUZ";
            return "ha asistido a clase ";

            
        }

    }
}
