using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils.newtons.V2.calcNewton
{
    public class ListaCalcultNewtonModel
    {
        public List<LeyesNewtonV2InputsModel> newtonX { get; set; }
        public List<LeyesNewtonV2InputsModel> newtonY { get; set; }

        public ListaCalcultNewtonModel(List<LeyesNewtonV2InputsModel> newtonX, List<LeyesNewtonV2InputsModel> newtonY)
        {
            this.newtonX = newtonX;
            this.newtonY = newtonY;
        }
    }
}
