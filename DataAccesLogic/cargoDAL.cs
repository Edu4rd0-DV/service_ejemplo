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
     public class cargoDAL
    {
        public int  agregar (cargo pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("agregar_cargo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@nombre", pn.nombre));
            comando.Parameters.Add(new SqlParameter("@descripcion", pn.descripcion));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;
           
        }
        public int actulalizar(cargo pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("actualizar_cargo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            comando.Parameters.Add(new SqlParameter("@nombre", pn.nombre));
            comando.Parameters.Add(new SqlParameter("@descripcion", pn.descripcion));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public int eliminar(cargo pn)
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("eliminar_cargo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@id", pn.id));
            int resultado = comando.ExecuteNonQuery();
            _con.Close();
            return resultado;

        }

        public List<cargo> mostrar()
        {
            IDbConnection _con = conexion.cnbd();
            _con.Open();
            SqlCommand comando = new SqlCommand("mostrar_cargo", _con as SqlConnection);
            comando.CommandType = CommandType.StoredProcedure;
            IDataReader lector = comando.ExecuteReader();
            List<cargo> lista = new List<cargo>();
            while (lector.Read())
            {
                cargo c = new cargo();
                c.id = lector.GetInt32(0);
                c.nombre = lector.GetString(1);
                c.descripcion = lector.GetString(2);
                lista.Add(c);

            }
            _con.Close();
            return lista;

        }

    }
}
