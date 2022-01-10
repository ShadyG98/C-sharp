using ObjetosDeNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ComaEnJoeBll
    {
        //Listar la lista de Cheffs de la pagina indicada con items x pagina.
        public static List<Cheffs> ListChefs(int pagina, int cantItemsXPagina)
        {
            var res = new List<Cheffs>();

            //Aqui vendria cualquier logica adicional que quisieramos agregar
            res = DAL.ComaEnJoeDAL.ListChefs(pagina, cantItemsXPagina);
         
            return res;
        }

        //Obtener un cheff por ID
        public static Cheffs GetCheff(int cheffId)
        {
            Cheffs res = null;

            //Aqui vendria cualquier logica adicional que quisieramos agregar
            res = DAL.ComaEnJoeDAL.GetCheff(cheffId);
          
            return res;
        }

        //Eliminar un cheff con solo el ID
        public static int DeleteCheff(int cheffId)
        {
            var res = 0;
            //Aqui vendria cualquier logica adicional que quisieramos agregar
            res = DAL.ComaEnJoeDAL.DeleteCheff(cheffId);
            return res;
        }

        //Actualizar cheff existente
        public static int UpdateCheff(Cheffs cheffAActualizar)
        {
            var res = 0;
            //Aqui vendria cualquier logica adicional que quisieramos agregar
            res = DAL.ComaEnJoeDAL.UpdateCheff(cheffAActualizar);
            return res;
        }

        //Agregar nuevo Cheff
        public static int InsertCheff(Cheffs cheffAInsertar)
        {
            var res = 0;
            //Aqui vendria cualquier logica adicional que quisieramos agregar
            res = DAL.ComaEnJoeDAL.InsertCheff(cheffAInsertar);
            return res;
        }

    }
}
