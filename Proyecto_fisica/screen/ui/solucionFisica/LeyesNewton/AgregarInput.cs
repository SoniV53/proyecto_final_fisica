using ControlComponents.Component.Inputs;
using Proyecto_fisica.screen.utils.newtons;
using Proyecto_fisica.screen.utils.newtons.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton
{
    public partial class AgregarInput : Form
    {
        public LeyesNewtonV2Model leyes;
        public int position = -1;
        public bool selecSum = true;
        public bool addW = false;
        private GenerarInputsData ge;
        private GenerarInputsData geExtra;
        private List<ComboDataInputsModel> itemsComboNameLocal;
        private List<ComboDataInputsModel> itemsComboNameGlobal;

        public AgregarInput(bool selecSum, GenerarInputsData ge, GenerarInputsData geExtra, List<ComboDataInputsModel> itemsComboNameGlobal)
        {
            InitializeComponent();
            this.ge = ge;
            this.geExtra = geExtra;
            this.selecSum = selecSum;
            itemsComboNameLocal = new List<ComboDataInputsModel>();
            this.itemsComboNameGlobal = itemsComboNameGlobal;
            getDataItems();
        }

        private void AgregarInput_Load(object sender, EventArgs e)
        {

            inputList1.SetItems = parseStringArr(itemsComboNameLocal);
            inputList1.SeleccIndex = itemsComboNameLocal.Count == 1 ? 0 : -1;
            raSen.Checked = selecSum;
            raCos.Checked = !selecSum;

            pnSenCos.Visible = false;
            btnAdd.Visible = false; 

            btnAdd.SetOnClick = () => {
                aciontionClick();
            };

            inputList1.SetEventActionPos = (val,po) => {
                btnAdd.Visible = inputList1.SetTextInput.Length > 0;

                int index = itemsComboNameLocal[po].posi;
                checkGrado.Checked = false;
                checkGrado.Visible = index == 0 || index == 1 || index == 2 ? false : true;

                pnSenCos.Visible = checkGrado.Checked;
                position = po;
            };

            
        }

        public void aciontionClick() {
            String[] listFu = parseStringArr(itemsComboNameLocal,true);
            int pos = itemsComboNameLocal[position].posi;
            int type = !checkGrado.Checked ? 0 : 1;
            type = pos == 1 || pos == 2 ? 2 : type;
            type = pos == 3 && !checkGrado.Checked ? 3 : type;

            string typeValue = raCos.Checked ? "cos" : "sen";
            typeValue = checkGrado.Checked ? typeValue : "";

            ge.generateInputType(listFu[position], type, typeValue);

            if (listFu[position].Equals("w") && type == 1)
            {
                string newTypeValue = typeValue.Equals("cos") ? "sen" : "cos";
                geExtra.generateInputType(listFu[position], type, newTypeValue);
                addW = true;
            }
            

            string addItemExist = listFu[position].Equals("F") ? "" : listFu[position];
            if (addItemExist.Length > 0)
            {
                itemsComboNameGlobal.Add(new ComboDataInputsModel(listFu[position]));
            }
            
            Close();
        }

        private void checkGrado_Click(object sender, EventArgs e)
        {
            pnSenCos.Visible = checkGrado.Checked;
        }

        private void getDataItems()
        {
            addExistItem("N", "N = Normal", 0);
            addExistItem("Fk", "Fk = Fricción Cinética", 1);
            addExistItem("Fs", "Fs = Fricción Estatica", 2);
            itemsComboNameLocal.Add(new ComboDataInputsModel(3,"F", "F = Fuerza"));
            addExistItem("w", "w = Peso", 4);
            
        }


        private string[] parseStringArr(List<ComboDataInputsModel> items,bool isName = false) {
            String[] listFu = new string[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                listFu[i] = isName ? items[i].indentity : items[i].nombre;
            }
            return listFu;
        }


        private void addExistItem(string ide, string name, int id) {

            if (!isValidExis(ide))
            {
                itemsComboNameLocal.Add(new ComboDataInputsModel(id, ide, name));
            }

        }

        private bool isValidExis(string id) {

            foreach (var item in itemsComboNameGlobal)
            {
                if (item.indentity.ToLower().Equals(id.ToLower()))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
