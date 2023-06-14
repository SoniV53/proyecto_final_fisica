using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils.newtons.V2
{
    public class ResultValuesNewtonModel
    {
        public string status {get;set;}
        public double result {get;set;}
        public string[] extraValues {get;set;}
        public LeyesNewtonV2InputsModel itemSelect { get;set;}

        public ResultValuesNewtonModel(double result, LeyesNewtonV2InputsModel itemSelect)
        {
            this.result = result;
            this.itemSelect = itemSelect;
        }

        public ResultValuesNewtonModel(string status, LeyesNewtonV2InputsModel itemSelect)
        {
            this.status = status;
            this.itemSelect = itemSelect;
        }

        public ResultValuesNewtonModel(double result, LeyesNewtonV2InputsModel itemSelect ,string[] extraValues )
        {
            this.result = result;
            this.extraValues = extraValues;
            this.itemSelect = itemSelect;
        }
    }
}
