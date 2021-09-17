using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formulario_solicitud_tramite
{
    class Solicitud_tramite
    {
        public persona propietario = new persona()
        {
            comprador = false
        };
        public persona comprador = new persona()
        {
            comprador = true
        };
        public vehiculo vehiculonuevo = new vehiculo();

        public string nombre_organismo;

        public string ciudad_organismo;

        public int codigo_orgnismo;

        public string fecha_tramite;

        public int tipo_tramite;

    }
}
