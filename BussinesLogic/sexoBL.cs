using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccesLogic;
using Entities;
namespace BussinesLogic
{
     public  class sexoBL
    {
        sexoDAL dal = new sexoDAL();
        public int agregar(sexo pn)
        {
            return dal.agregar(pn);
        }
        public int actualizar(sexo pn)
        {
            return dal.actualizar(pn);

        }
        public int eliminar(sexo pn)
        {
            return dal.eliminar(pn);
        }
        public List<sexo> mostrar()
        {
            return dal.mostrar();
        }
    }
}
