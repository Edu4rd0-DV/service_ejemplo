using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;
namespace DataAccesLogic
{
    public class usuarioDAL
    {
        public int agregar(usuario pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("ingesar_usuario", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@nick", pn.nickmane));
            comando.Parameters.Add(new SqlParameter("@pass", pn.pass));
            comando.Parameters.Add(new SqlParameter("@empleado", pn.fk_empleado));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public int actualizar(usuario pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("actualizar_usuario", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            comando.Parameters.Add(new SqlParameter("@nick", pn.nickmane));
            comando.Parameters.Add(new SqlParameter("@pass", pn.pass));
            comando.Parameters.Add(new SqlParameter("@empleado", pn.fk_empleado));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public int eliminar(usuario pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("eliminar_usuario", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public List<usuario> mostrar()
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("mostrar_usuario", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            IDataReader lector = comando.ExecuteReader();
            List<usuario> lista = new List<usuario>();
            while (lector.Read())
            {
                usuario c = new usuario();
                c.id = lector.GetInt32(0);
                c.nickmane = lector.GetString(1);
                c.pass = lector.GetString(2);
                c.dui = lector.GetInt32(4);
                lista.Add(c);

            }
            _con.Close();
            return lista;

        }
    }
}
