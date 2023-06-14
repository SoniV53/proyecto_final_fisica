using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils.medida
{
    public class UnidadMedidaModel
    {
        public string type { set; get; }
        public string name { set; get; }
        public double value{ set; get; }

        public UnidadMedidaModel(string type,string name, double value)
        {
            this.name = name;
            this.value = value;
            this.type = type;
        }

        public UnidadMedidaModel(string name, double value)
        {
            this.name = name;
            this.value = value;
        }

        public UnidadMedidaModel()
        {
        }
    }
}
