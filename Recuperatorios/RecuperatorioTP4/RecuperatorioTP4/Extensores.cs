using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensores
    {
        public static void GuardarInformes(this Proyecto p)
        {
            Texto t = new Texto();
            Informes i = new Informes();
            string ruta = "Informe.txt";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fecha y hora del informe:");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine("---------------------------------------------------------------------------------------------------------");
            sb.AppendLine($"Programadores femeninos {i.ProgramadoresFemeninos(p).ToString()}");
            sb.AppendLine($"Programadores masculinos {i.ProgramadoresMasculinos(p).ToString()}");
            sb.AppendLine($"Programadores no binario {i.ProgramadoresNoBinario(p).ToString()}");
            sb.AppendLine("---------------------------------------------------------------------------------------------------------");
            sb.AppendLine(i.ProgramadoresPorPuesto(p));
            sb.AppendLine("---------------------------------------------------------------------------------------------------------");
            sb.AppendLine(i.RangosEtarios(p));
            t.Escribir(sb.ToString(),ruta);
            
        }
    }
}
