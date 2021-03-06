﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdmonChecadas.Datos
{
    public interface IConsultasMySQLDatos
    {
        bool pruebaConn();

        List<Modelos.Empleados> getEmpleados();

        List<Modelos.Departamentos> getDeptos();

        List<Modelos.Checadas> getChecadas(string fechaIni, string fechaFin, bool cbNombre, bool cbDepto, int nombre, int depto, int numChec);

        List<int> getNumChec();

        List<Modelos.Empleados> cargaEmpleados();

        bool actEmpleados(int idInterno, string empleado, int depto);
    }
}
