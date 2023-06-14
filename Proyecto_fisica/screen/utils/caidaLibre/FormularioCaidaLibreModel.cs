using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils.caidaLibre
{
    public class FormularioCaidaLibreModel
    {
        public string identificador { get; set; }
        public string formula { get; set; }
        public string valor { get; set; }
        public string unidad { get; set; }

        public FormularioCaidaLibreModel(string identificador, string valor, string unidad, string formula)
        {
            this.identificador = identificador;
            this.valor = valor;
            this.unidad = unidad;
            this.formula = formula;
        }

    }
}
