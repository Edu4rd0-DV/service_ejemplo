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
     public class sexoDAL
    {
        public int agregar(sexo pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("ingresar_sexo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@nombre", pn.nombre));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public int actualizar (sexo pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("actualizar_sexo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            comando.Parameters.Add(new SqlParameter("@nombre", pn.nombre));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public int eliminar (sexo pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("eliminar_sexo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.nombre));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public List<sexo> mostrar()
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("mostrar_sexo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            IDataReader lector = comando.ExecuteReader();
            List<sexo> lista = new List<sexo>();
            while (lector.Read())
            {
                sexo c = new sexo();
                c.id = lector.GetInt32(0);
                c.nombre = lector.GetString(1);
                lista.Add(c);

            }
            _con.Close();
            return lista;

        }
    }
}
