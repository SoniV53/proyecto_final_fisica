using System;
using System.Collections.Generic;

namespace Proyecto_fisica.screen.utils.medida
{
    public class ConvertidorMedida
    {

        private ListUnidadMedidas listUni;
        private List<UnidadMedidaModel> itemsListUnid;
     
        public ConvertidorMedida()
        {
            listUni = new ListUnidadMedidas();
            itemsListUnid = listUni.unidaLists();
        }

        /**
         * METODO VERIFICA QUE TIPO DE UNIDAD DE MEDIDA ES
         */

        public String selectTypeUnidad(string unidSelect, double num, string uniDef, string uniCon) {
            string med = unidSelect.Trim().ToLower();

            foreach (var itemMed in itemsListUnid) {
                if (med.Equals(isValid(itemMed.type)))
                    return getSelectUnidad(num, uniDef, uniCon);
            }
                

            return "";
        }

        /**
         * METODO QUE VERIFICA QUE TIPO DE MEDIDA VA A COMVERTIR
         */
        private String getSelectUnidad(double num,string uniDef,string uniCon)
        {
            string def = uniDef.Trim().ToLower();
            string cov = uniCon.Trim().ToLower();

            foreach (var itemDef in itemsListUnid)
            {
                if (def.Equals(isValid(itemDef.name))) {
                    foreach (var item in itemsListUnid) {
                        if (cov.Equals(isValid(item.name)))
                            return setCalculadorUnidad(num, itemDef.value, item.name).ToString();
                    }
                        
                }
                    
            }


            return "";
        }

        /**
         * METODO QUE CONVIERTE EL A LA UNIDAD DE MEDIDA SELECCIONADA
         */
        private double setCalculadorUnidad(double num, double numDiv, string type)
        {
            foreach (var item in itemsListUnid) {
                if (isValid(type).Equals(isValid(item.name))) 
                    return setReturnResult(item.value, num, numDiv);
            }
            return 0;
        }

        /**
         * METODO QUE VALIDA EL TIPO DE OPERACION QUE SE NECESITA
         */
        private double setReturnResult(double med, double num, double numDiv) 
        {
            if (numDiv > med) { return ((num * numDiv) / med); }
            else if (numDiv < med) return (num / med) * numDiv;
            else return 0;
           
        }

        private String isValid(String text) { 
            return text.Trim().ToLower();
        }
    }
}
