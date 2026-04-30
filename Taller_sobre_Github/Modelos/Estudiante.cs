using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Estudiante
    {
        public string Carnet { get; set; }
        public string NombreCompleto { get; set; }

        public virtual string ComprobarAsistencia()
        {
            Carnet = string.Empty;
            NombreCompleto = string.Empty;
            return "No ha asistido a clase.";
        }
    }
}
