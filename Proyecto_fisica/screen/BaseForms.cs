using ControlComponents.Component.Inputs;
using Proyecto_fisica.screen.components;
using Proyecto_fisica.screen.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_fisica.screen
{
    public partial class BaseForms : Form
    {
       
        public Label getNameCards(string name)
        {
            return UtilsComponent.setCreateLabel("\n" + name,
                    Colors.colorWhite, 10, DockStyle.Fill, ContentAlignment.TopCenter, 12, FontStyle.Bold);
        }
        public double parseDouble(InputDefault inpAltura)
        {
            String res = inpAltura.SetTextInput.ToString().Trim();
            Regex regex = new Regex("^[0-9]+([.][0-9]+)?$");
            Regex regexNe = new Regex("^([-][0-9]+)+([.][0-9]+)?$");
            if (regex.IsMatch(res) ||
                regexNe.IsMatch(res))
            {
                return double.Parse(res);
            }
            else return 0;
        }

        public double parDouble(String v)
        {
            return v != null && !isEmpty(v) ? Double.Parse(v) : 0;
        }
        public decimal parDecimal(String v)
        {
            return v != null && !isEmpty(v) ? Decimal.Parse(v) : 0;
        }

        public string parseString(InputDefault inpAltura)
        {
            String res = inpAltura.SetTextInput.ToString().Trim();
            Regex regex = new Regex("^[0-9]+([.][0-9]+)?$");
            Regex regexNe = new Regex("^([-][0-9]+)+([.][0-9]+)?$");
            if (regex.IsMatch(res) ||
                regexNe.IsMatch(res))
            {
                return res;
            }
            else return "";
        }

        public bool isValidNumberString(InputDefault inpAltura)
        {
            String res = inpAltura.SetTextInput.ToString().Trim();
            Regex regex = new Regex("^[0-9]+([.][0-9]+)?$");
            Regex regexNe = new Regex("^([-][0-9]+)+([.][0-9]+)?$");
            if (regex.IsMatch(res) ||
                regexNe.IsMatch(res) || res.Equals(""))
            {
                return true;
            }
            else return false;
        }

        public bool isEquals(String value, String value2)
        {
            return value.Trim().ToLower().Equals(value2.Trim().ToLower());
        }
        public bool isValidNumberString(string inpAltura)
        {
            String res = inpAltura.Trim();
            Regex regex = new Regex("^[0-9]+([.][0-9]+)?$");
            Regex regexNe = new Regex("^([-][0-9]+)+([.][0-9]+)?$");
            if (regex.IsMatch(res) ||
                regexNe.IsMatch(res) || res.Equals(""))
            {
                return true;
            }
            else return false;
        }

        public string saltoLinea() {
            return String.Format(Environment.NewLine);
        }

        public string formatString(string valu)
        {
            return valu.Trim().ToLower();
        }

        public bool isEmpty(string valu)
        {
            if (formatString(valu).Equals("")) return true;
            else return false;
        }

        public int parseInt(InputDefault inpAltura)
        {
            return int.Parse(inpAltura.SetTextInput.Trim());
        }
    }
}
