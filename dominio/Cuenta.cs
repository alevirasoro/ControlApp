using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Cuenta
    {
        public int ID { get; set; }
        public int IDUsuario { get; set; }
        public decimal Saldo { get; set; }
        public int Usuario { get; set; }
        public Movimiento Movimiento { get; set; }

    }
}
