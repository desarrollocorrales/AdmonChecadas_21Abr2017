using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdmonChecadas.Datos;

namespace AdmonChecadas.Negocio
{
    public class ConsultasMySQLNegocio : IConsultasMySQLNegocio
    {
        private IConsultasMySQLDatos _consultasMySQLDatos;

        public ConsultasMySQLNegocio()
        {
            this._consultasMySQLDatos = new ConsultasMySQLDatos();
        }

        public bool pruebaConn()
        {
            return this._consultasMySQLDatos.pruebaConn();
        }

        public List<Modelos.Empleados> getEmpleados()
        {
            return this._consultasMySQLDatos.getEmpleados();
        }

        public List<Modelos.Departamentos> getDeptos()
        {
            return this._consultasMySQLDatos.getDeptos();
        }

        public List<Modelos.Checadas> getChecadas(string fechaIni, string fechaFin, bool cbNombre, bool cbDepto, int nombre, int depto, int numChec)
        {
            return this._consultasMySQLDatos.getChecadas(fechaIni, fechaFin, cbNombre, cbDepto, nombre, depto, numChec);
        }

        public List<int> getNumChec()
        {
            return this._consultasMySQLDatos.getNumChec();
        }

        public List<Modelos.Empleados> cargaEmpleados()
        {
            return this._consultasMySQLDatos.cargaEmpleados();
        }

        public bool actEmpleado(int idInterno, string empleado, int depto)
        {
            return this._consultasMySQLDatos.actEmpleados(idInterno, empleado, depto);
        }
    }
}
