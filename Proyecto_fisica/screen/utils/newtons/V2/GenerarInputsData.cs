using ControlComponents.Component.Inputs;
using Proyecto_fisica.screen.components.inputs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows.Foundation;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Proyecto_fisica.screen.utils.newtons.V2
{
    public class GenerarInputsData
    {

        public List<LeyesNewtonV2InputsModel> listValue { get; set; }

        List<PanelsModel> listPan;
        private Panel addItemPanel;

        public GenerarInputsData(Panel addItemPanel)
        {
            listValue = new List<LeyesNewtonV2InputsModel>();
            listPan = new List<PanelsModel>();

            this.addItemPanel = addItemPanel;
        }

        public void generateInputType(string name, int type, string cs)
        {
            int pos = 0;
            string nameS = fuerPesExistF(name);

            switch (type)
            {
                case 0:
                    listValue.Add(new LeyesNewtonV2InputsModel(name, name, "", "", cs, type));
                    listPan.Add(new PanelsModel(generatePanelInputsDef(name), 00));
                    break;
                case 1:
                    listValue.Add(new LeyesNewtonV2InputsModel(nameS, name, "", "", cs, type));
                    listPan.Add(new PanelsModel(generatePanelInputs(pos, nameS, "θ"), 01));
                    break;
                case 2:
                    listValue.Add(new LeyesNewtonV2InputsModel(name, name, "", "", cs, type));
                    listPan.Add(new PanelsModel(generatePanelInputs(pos, name, name.ToLower().Equals("Fk".ToLower()) ? "Uk" : "Us"), 01));
                    break;
                case 3:
                    listValue.Add(new LeyesNewtonV2InputsModel(nameS, name, "", "", cs, type));
                    listPan.Add(new PanelsModel(generatePanelInputsDef(nameS), 00));
                    break;

            }

        }

        public void getItemsAddControl()
        {
            addItemPanel.Visible = false;
            addItemPanel.Controls.Clear();

            listPan.ForEach(item =>
            {
                addItemPanel.Controls.Add(item.name);
            });

            addItemPanel.Visible = true;
        }

        public void updateItemsAddControl() {
   
            for (int i = 0; i < listValue.Count; i++)
            {
                if (listPan[i].type == 01 )
                {
                    InputAddSuma inp = (InputAddSuma)listPan[i].name;
                    listValue[i].value = inp.SetTextInputLeft;
                    listValue[i].valueGradoU = inp.SetTextInputRight;
                }
                else {
                    InputDefault inp = (InputDefault)listPan[i].name;
                    listValue[i].value = inp.SetTextInput;
                }
            }

        }

        public void deleteItemsControl(int index)
        {
            //index = 0;
            if (!index.ToString().Contains("-"))
            {
                listValue.RemoveAt((index));
                listPan.RemoveAt((index));
            }
            
        }

        private string fuerPesExistF(string name)
        {
            string value = name;
            if (!name.ToLower().Equals("w"))
            {
                if (isExistFuer())
                {
                    value = name.ToLower().Equals("f") ? "F" + numFuer().ToString() : name;
                }
                else
                {
                    value = name.ToLower().Equals("f") ? "F1" : "";
                }
            }
           

            return value;
        }

        private bool isExistFuer() {
            foreach (var item in listValue)
            {
                if (item.des.ToLower().Equals("f"))
                {
                    return true;
                }
            }

            return false;
        }

        private int numFuer() { 
            int num = 1;
            List<int> list = new List<int>();
            listValue.ForEach(item => {
                if (item.des.ToLower().Equals("f"))
                {
                    Match m = Regex.Match(item.name, "(\\d+)");
                    list.Add(Int32.Parse(m.Success ? m.Value : "0"));
                }
            });

            list.ForEach(item =>
            {
                num = item > num ? item : num;
            });

           
            return num + 1;
        }

        private InputAddSuma generatePanelInputs(int pos, string ti,string tg)
        {
            InputAddSuma inputAddSuma = new InputAddSuma();
            inputAddSuma.Dock = DockStyle.Top;
            inputAddSuma.Location = new Point(0, 0);
            inputAddSuma.Name = ti;
            inputAddSuma.SetAlignmentLabel = ContentAlignment.BottomLeft;
            inputAddSuma.SetColorText = Colors.colorBlack;
            inputAddSuma.SetEnable = true;
            inputAddSuma.SetSizeInput = 10F;
            inputAddSuma.SetSizeLabel = 10F;
            inputAddSuma.SetTextInputLeft = "";
            inputAddSuma.SetTextInputRight = "";
            inputAddSuma.SetTextlabel = ti;
            inputAddSuma.SetTextlabelGrado = tg;
            inputAddSuma.Size = new Size(0, 50);
            inputAddSuma.position = pos;
            //inputAddSuma.paintViewPanel(true);
            return inputAddSuma;
        }

        private InputDefault generatePanelInputsDef(string ti)
        {
            InputDefault inputAddSuma = new InputDefault();
;
            inputAddSuma.Dock = DockStyle.Top;
            inputAddSuma.Location = new System.Drawing.Point(0, 0);
            inputAddSuma.Name = ti;
            inputAddSuma.SetAlignmentLabel = ContentAlignment.BottomLeft;
            inputAddSuma.SetColorText = Colors.colorBlack;
            inputAddSuma.SetEnable = true;
            inputAddSuma.SetSizeInput = 10F;
            inputAddSuma.SetSizeLabel = 10F;
            inputAddSuma.SetTextlabel = ti;
            inputAddSuma.Size = new System.Drawing.Size(220, 58);

            return inputAddSuma;
        }


        public class PanelsModel {
            public Panel name { get; set; }
            public int type { get; set; }

            public PanelsModel(Panel name, int type)
            {
                this.name = name;
                this.type = type;
            }
        }
    }
}
