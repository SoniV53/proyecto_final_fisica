using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils.newtons.V2
{
    public class LeyesNewtonV2InputsModel
    {
        public string name { get; set; }
        public string des { get; set; }
        public string value { get; set; }
        public string valueGradoU { get; set; }
        public string cosSen { get; set; }
        public int type { get; set; }

        public LeyesNewtonV2InputsModel(string name, string value, string valueGradoU, int type, string des)
        {
            this.name = name;
            this.value = value;
            this.valueGradoU = valueGradoU;
            this.type = type;
            this.des = des;
        }

        public LeyesNewtonV2InputsModel(string name, string des, string value, string valueGradoU, string cosSen, int type)
        {
            this.name = name;
            this.des = des;
            this.value = value;
            this.valueGradoU = valueGradoU;
            this.cosSen = cosSen;
            this.type = type;
        }
    }
}
