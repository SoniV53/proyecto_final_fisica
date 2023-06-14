using Proyecto_fisica.screen.utils.newtons.V2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Foundation.Collections;

namespace Proyecto_fisica.screen.ui.solucionFisica.LeyesNewton
{
    public partial class DeleteInputsSelect : Form
    {
        private int position = -1;
        private string name = "";
        private GenerarInputsData ge;
        private List<ComboDataInputsModel> globalList;
        public DeleteInputsSelect(GenerarInputsData ge, List<ComboDataInputsModel> globalList)
        {
            InitializeComponent();
            this.ge = ge;
            this.globalList = globalList;
        }

        private void DeleteInputsSelect_Load(object sender, EventArgs e)
        {
            btnAdd.Visible = inputList1.SetTextInput.Length > 0;
            inputList1.SetItems = parseStringArr(ge.listValue);
            inputList1.SetEventActionPos = (val, po) => {
                btnAdd.Visible = inputList1.SetTextInput.Length > 0;
                position = po;
                name = val;
            };

            btnAdd.SetOnClick = () => {
                ge.deleteItemsControl(position);
                deleteDataExist(name);
                Close();
            };
        }

        private void deleteDataExist(string name) {
            for (int i = 0; i < globalList.Count; i++)
            {
                if (globalList[i].indentity.ToLower().Equals(name.ToLower()))
                {
                    globalList.RemoveAt(i);
                }
            }
          
        }

        private string[] parseStringArr(List<LeyesNewtonV2InputsModel> items)
        {
            String[] listFu = new string[items.Count];
            for (int i = 0; i < items.Count; i++)
            {
                listFu[i] = items[i].name;
            }
            return listFu;
        }
    }
}
