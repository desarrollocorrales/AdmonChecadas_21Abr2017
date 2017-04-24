using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using AdmonChecadas.Modelos;

namespace AdmonChecadas.Datos
{
    public class ConsultasMySQLDatos : IConsultasMySQLDatos
    {
        // Variable que almacena el estado de la conexión a la base de datos
        IConexion _conexionMySQL;

        public ConsultasMySQLDatos()
        {
            this._conexionMySQL = new Conexion(Modelos.ConectionString.conn);
        }

        // realiza una prueba de conexion
        public bool pruebaConn()
        {
            using (var conn = this._conexionMySQL.getConexionMySQL())
            {
                try
                {
                    conn.Open();
                    return true;
                }
                catch (MySqlException)
                {
                    return false;
                }
            }
        }

        // obtiene todos los empleados
        public List<Empleados> getEmpleados()
        {
            List<Empleados> result = new List<Empleados>();
            Empleados ent;

            // string sql = "select idusuario, usuario from activos_usuarios where usuario = @usuario and clave = @clave";

            string sql = "select id_interno, nombre from empleados order by id_interno";

            // define conexion con la cadena de conexion
            using (var conn = this._conexionMySQL.getConexionMySQL())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Modelos.Empleados();

                            ent.idInterno = Convert.ToInt32(res.reader["id_interno"]);
                            ent.nombreEmpleado = ent.idInterno.ToString().PadLeft(6, ' ') + " | " + Convert.ToString(res.reader["nombre"]);
                           
                            result.Add(ent);
                        }
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }

        // obtiene los departamentos
        public List<Departamentos> getDeptos()
        {
            List<Departamentos> result = new List<Departamentos>();
            Departamentos ent;

            // string sql = "select idusuario, usuario from activos_usuarios where usuario = @usuario and clave = @clave";

            string sql = "select id, nombre from departamentos where status = 1 order by nombre";

            // define conexion con la cadena de conexion
            using (var conn = this._conexionMySQL.getConexionMySQL())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Modelos.Departamentos();

                            ent.idDepto = Convert.ToInt16(res.reader["id"]);
                            ent.departamento = Convert.ToString(res.reader["nombre"]);

                            result.Add(ent);
                        }
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }

        // obtiene las checadas
        public List<Checadas> getChecadas(string fechaIni, string fechaFin, bool cbNombre, bool cbDepto, int nombre, int depto, int numChec)
        {
            List<Checadas> result = new List<Checadas>();
            Checadas ent;

            string sql =
                "select c.id_interno, c.fecha_hora, c.no_checador, " +
                       "e.nombre as empleado, " +
                       "e.id_depto, d.nombre as departamento " +

                "from checadas c " +

                "left join empleados e on (c.id_interno = e.id_interno) " +
                "left join departamentos d on (e.id_depto = d.id) " +

                "where c.fecha_hora between @fechaIn and @fechaFi and no_checador = @noChec";

            // define conexion con la cadena de conexion
            using (var conn = this._conexionMySQL.getConexionMySQL())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // faltantes
                    if(cbNombre)
                    {
                        sql += " and c.id_interno = @nombre ";
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                    }

                    if (cbDepto)
                    {
                        sql += " and e.id_depto = @depto ";
                        cmd.Parameters.AddWithValue("@depto", depto);
                    }

                    sql += " order by e.id_depto, c.id_interno, c.fecha_hora desc";

                    cmd.Parameters.AddWithValue("@fechaIn", fechaIni);
                    cmd.Parameters.AddWithValue("@fechaFi", fechaFin);
                    cmd.Parameters.AddWithValue("@noChec", numChec);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Modelos.Checadas();

                            ent.idInterno = Convert.ToInt32(res.reader["id_interno"]);
                            ent.fechaHora = Convert.ToDateTime(res.reader["fecha_hora"]).ToString("yyyy/MM/dd HH:mm:ss");
                            ent.empleado = Convert.ToString(res.reader["empleado"]);
                            ent.idDepto = Convert.ToInt16(res.reader["id_depto"]);
                            ent.departamento = Convert.ToString(res.reader["departamento"]);

                            result.Add(ent);
                        }
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }

        // obtiene los numeros de checador disponibles
        public List<int> getNumChec()
        {
            List<int> result = new List<int>();

            string sql = "select no_checador from checadas group by no_checador";

            // define conexion con la cadena de conexion
            using (var conn = this._conexionMySQL.getConexionMySQL())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                        while (res.reader.Read())
                            result.Add(Convert.ToInt16(res.reader["no_checador"]));
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();
                }
            }

            return result;
        }

        // obtiene todos los empleados con sus datos
        public List<Empleados> cargaEmpleados()
        {
            List<Empleados> result = new List<Empleados>();
            Empleados ent;

            // string sql = "select idusuario, usuario from activos_usuarios where usuario = @usuario and clave = @clave";

            string sql =
                "select e.id_interno, e.nombre as empleado, e.id_depto, d.nombre as departamento " +
                "from empleados e " +
                "left join departamentos d on (e.id_depto = d.id) order by e.nombre asc";

            // define conexion con la cadena de conexion
            using (var conn = this._conexionMySQL.getConexionMySQL())
            {
                // abre la conexion
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    ManejoSql res = Utilerias.EjecutaSQL(sql, cmd);

                    if (res.ok)
                    {
                        while (res.reader.Read())
                        {
                            ent = new Modelos.Empleados();

                            ent.idInterno = Convert.ToInt32(res.reader["id_interno"]);
                            ent.nombreEmpleado = Convert.ToString(res.reader["empleado"]);

                            ent.idDepto = Convert.ToInt16(res.reader["id_depto"]);
                            ent.departamento = Convert.ToString(res.reader["departamento"]);

                            result.Add(ent);
                        }
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                    // cerrar el reader
                    res.reader.Close();

                }
            }

            return result;
        }

        // actualiza informacion del empleado
        public bool actEmpleados(int idInterno, string empleado, int depto)
        {
            string sql = "update empleados set id_depto = @idDepto, nombre = @nombre where id_interno = @idInterno";

            bool result = true;

            int rows = 0;

            using (var conn = this._conexionMySQL.getConexionMySQL())
            {
                conn.Open();

                using (var cmd = new MySqlCommand())
                {
                    cmd.Connection = conn;

                    // define parametros
                    cmd.Parameters.AddWithValue("@idDepto", depto);
                    cmd.Parameters.AddWithValue("@nombre", empleado);
                    cmd.Parameters.AddWithValue("@idInterno", idInterno);

                    ManejoSql res = Utilerias.EjecutaSQL(sql, ref rows, cmd);

                    if (res.ok)
                    {
                        if (rows == 0) result = false;
                    }
                    else
                        throw new Exception(res.numErr + ": " + res.descErr);

                }
            }

            return result;
        }
    }
}
