using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace AdmonChecadas.Modelos
{
    public class Conexion : IConexion
    {
        private string _cadenaConexion;

        public Conexion(string cadenaConexionMySQL)
        {
            this._cadenaConexion = cadenaConexionMySQL;
        }

        public string getCadenaMySQL()
        {
            return this._cadenaConexion;
        }

        public MySqlConnection getConexionMySQL()
        {
            return new MySqlConnection(this._cadenaConexion);
        }
    }
}
