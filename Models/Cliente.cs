using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTienda.Models
{
    class Cliente
    {
        public int id_persona { get; set; }
        public int id_cliente { get; set; }
public

        string nombre { get; set; }
        public string apellidos { get; set; }

        public string ci_nit { get; set; }

        public DateTime fecha_nac { get; set; }


        public Cliente(int idpersona, int idcliente, string nombre, string apellidos, string cinit,DateTime fechanac)
        {
            id_persona = idpersona;
            id_cliente = idcliente;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.ci_nit = cinit;
            fecha_nac = fechanac;
        }

        public Cliente() { }


    }
}
