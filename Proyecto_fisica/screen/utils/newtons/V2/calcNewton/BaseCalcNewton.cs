using ControlComponents.Component.Inputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fisica.screen.utils.newtons.V2.calcNewton
{
    public class BaseCalcNewton
    {
        private String MessageNot = "NO se pudo calcular";
        public bool isEmptyDouble(List<LeyesNewtonV2InputsModel> newt)
        {
            foreach (var item in newt)
            {
                if (isEmpty(item.value)
                    && isEmpty(item.valueGradoU))
                {
                    return true;
                }
            }
            return false;
        }

        public double addCalcSenCos(LeyesNewtonV2InputsModel item)
        {
            double result = 0;
            string form = "";
            if (!isEmpty(item.valueGradoU))
            {
                double num = parDouble(item.valueGradoU) * Math.PI / 180.0;
                result = isEquals(item.cosSen, "sen") ?
                    (Math.Sin(num) * parDouble(item.value)) :
                    (Math.Cos(num) * parDouble(item.value));
                form += getConcat(new string[] {
                    item.value,"*",item.cosSen,"(",item.valueGradoU,")"
                 });
            }
            else
            {
                result = parDouble(item.value);
                form += " " + item.value;
            }
            return result;
        }

        public double addCalcFriccion(LeyesNewtonV2InputsModel item, string normal)
        {
            double result = 0;
            if (isNumSelect(item, 2))
            {
                if (isEmpty(item.value))
                {
                    if (isEmpty(item.valueGradoU))
                    {
                        result += parDouble(item.valueGradoU) * parDouble(normal);
                    }
                }
                else
                {
                    result += parDouble(item.value);
                }

            }
            return result;
        }

        public bool isEmpty(String value)
        {
            if (value == null) value = "";
            return  value.ToLower().Trim().Equals("");
        }

        public string getValueEmpty(String value, String value2)
        {
            return isEmpty(value) && !isEmpty(value2) ? value2 : value;
        }

        public bool isEquals(String value, String value2)
        {
            if (value == null) value = "";
            if (value2 == null) value2 = "";
            return value.Trim().ToLower().Equals(value2.Trim().ToLower());
        }
        public bool isContains(String value, String value2)
        {
            return value.Trim().ToLower().Contains(value2.Trim().ToLower());
        }

        public string getConcat(String[] value)
        {
            String result = "";
            foreach (var item in value)
            {
                result += item;
            }
            return result;
        }

        public bool isNumSelect(LeyesNewtonV2InputsModel item, int num)
        {
            return item.type == num;
        }
        public double poten2(String v)
        {
            return parDouble(v) * parDouble(v);
        }
        public double parDouble(String v)
        {
            return v != null && !isEmpty(v) ? Double.Parse(v) : 0;
        }

        public bool isValidNumberString(string inpAltura)
        {
            String convPun = inpAltura.Replace(",", ".");
            String res = convPun.Trim();
            Regex regex = new Regex("^[0-9]+([.][0-9]+)?$");
            Regex regexNe = new Regex("^([-][0-9]+)+([.][0-9]+)?$");
            if (regex.IsMatch(res) ||
                regexNe.IsMatch(res) || res.Equals(""))
            {
                return true;
            }
            else return false;
        }

        public string format2Digit(decimal value) {
           return decimal.Round(value, 2).ToString();
        }

        public string format2Digit(string value)
        {
            return decimal.Round(Decimal.Parse(value), 2).ToString();
        }
    }
}
