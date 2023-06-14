using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils.newtons
{
    public class LeyesNewtonV2Model
    {
        public string name { get; set; }
        public string value { get; set; }
        public string valueGrado { get; set; }
        public bool grado { get; set; }
        public string typeGrado { get; set; }
        public string type { get; set; }

        public LeyesNewtonV2Model(string name, string value, bool grado, string type)
        {
            this.name = name;
            this.value = value;
            this.grado = grado;
            this.type = type;
        }

        public LeyesNewtonV2Model(string name, bool grado, string typeGrado, string type)
        {
            this.name = name;
            this.grado = grado;
            this.typeGrado = typeGrado;
            this.type = type;
        }
    }
}
