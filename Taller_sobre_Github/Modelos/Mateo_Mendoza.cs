using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_sobre_Github.Modelos
{
    public class Mateo_Mendoza:Estudiante
    {
		public override string ComprobarAsistencia()
		{
			Carnet = "123456789";
			NombreCompleto = "Mateo Mendoza";
			return "Ha asistido a clase";
		}
    }
}
