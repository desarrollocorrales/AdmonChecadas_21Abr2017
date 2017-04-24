using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdmonChecadas.Modelos
{
    public class Checadas
    {
        public int idInterno { get; set; }
        public string empleado { get; set; }

        public int idDepto { get; set; }
        public string departamento { get; set; }

        public string fechaHora { get; set; }
    }
}
