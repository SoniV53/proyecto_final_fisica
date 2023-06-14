using Proyecto_fisica.screen.utils.medida;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_fisica.screen.utils
{
    public class ListUnidadMedidas
    {
        public List<UnidadMedidaModel> unidaLists()
        {
            List<UnidadMedidaModel> list = new List<UnidadMedidaModel>();
            //Masa
            list.Add(new UnidadMedidaModel("Masa","Gramo", 1));
            list.Add(new UnidadMedidaModel("Masa", "Libra", 453.592));
            list.Add(new UnidadMedidaModel("Masa","Kilogramo", 1000));
            list.Add(new UnidadMedidaModel("Masa", "Onzas", 28.3495));
            //Tiempo
            list.Add(new UnidadMedidaModel("Tiempo", "Segundo", 1));
            list.Add(new UnidadMedidaModel("Tiempo", "Minuto", 60));
            list.Add(new UnidadMedidaModel("Tiempo", "Hora", 3600));
            list.Add(new UnidadMedidaModel("Tiempo", "Días", 86400));
            list.Add(new UnidadMedidaModel("Tiempo", "Años", 31557600));
            //Longitud
            list.Add(new UnidadMedidaModel("Longitud", "Metros", 1));
            list.Add(new UnidadMedidaModel("Longitud", "Kilometros", 1000));
            list.Add(new UnidadMedidaModel("Longitud", "Millas", 1609.34));
            list.Add(new UnidadMedidaModel("Longitud", "Pies", 0.3048));
            list.Add(new UnidadMedidaModel("Longitud", "Centímetros", 0.01));
            list.Add(new UnidadMedidaModel("Longitud", "Pulgadas", 0.0254));
            
            return list;
        }

        public String[] getComboText(List<UnidadMedidaModel> medida, String type)
        {
            List<String> list = new List<String>();

            foreach (UnidadMedidaModel item in medida)
            {
                if (item.type.Trim().ToLower().Equals(type.Trim().ToLower()))
                    list.Add(item.name);
            }

            return isReturnString(list);
        }

        public String[] medidaRepetida(String[] medida,String name) {
            List<String> list = new List<String>();

            foreach (String item in medida) {
                if (!item.Trim().ToLower().Equals(name.Trim().ToLower()))
                    list.Add(item);
            }
            return isReturnString(list);
        }

        private String[] isReturnString(List<String> list) {
            String[] stringList = new String[list.Count];
            for (int i = 0; i < stringList.Length; i++)
            {
                stringList[i] = list[i];
            }
            return stringList;
        }
    }
}
