using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Movimiento
    {
        public decimal Importe { get; set }
        public string Titulo { get; set }
        public Concepto Concepto { get; set }
        public string Descripcion { get; set }
        public bool Tipo { get; set }
        public DateTime Fecha { get; set }

    }
}
