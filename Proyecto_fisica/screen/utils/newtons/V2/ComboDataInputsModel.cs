using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils.newtons.V2
{
    public class ComboDataInputsModel
    {
        public int posi { get; set; }
        public string indentity { get; set; }
        public string nombre { get; set; }

        public ComboDataInputsModel(string indentity, string nombre)
        {
            this.indentity = indentity;
            this.nombre = nombre;
        }

        public ComboDataInputsModel(int posi, string indentity, string nombre)
        {
            this.posi = posi;
            this.indentity = indentity;
            this.nombre = nombre;
        }

        public ComboDataInputsModel(string indentity)
        {
            this.indentity = indentity;
        }
    }
}
