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
     public class bitacoraDAL
    {
        public int agregar(bitacora pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("ingresar_bitacora", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@actividad", pn.actividad));
            comando.Parameters.Add(new SqlParameter("@fecha", pn.fecha_hora));
            comando.Parameters.Add(new SqlParameter("@usuario", pn.fk_usuario));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }
        public int eliminar(bitacora pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("eliminar_bitacora", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public List<bitacora> mostrar()
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("mostrar_bitacora", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            IDataReader lector = comando.ExecuteReader();
            List<bitacora> lista = new List<bitacora>();
            while (lector.Read())
            {
                bitacora c = new bitacora();
                c.id = lector.GetInt32(0);
                c.actividad = lector.GetString(1);
                c.fecha_hora = lector.GetString(2);
                c.nickname = lector.GetString(3);
                lista.Add(c);

            }
            _con.Close();
            return lista;

        }


    }
}
