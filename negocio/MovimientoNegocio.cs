using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MovimientoNegocio
    {
        public List<Movimiento> listar()
        {
            List<Movimiento> lista = new List<Movimiento>();
            AccesoDatos datos = new AccesoDatos();
            try {
                datos.setearConsulta("");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) {
                    Movimiento aux = new Movimiento();
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Importe = (decimal)datos.Lector["Importe"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex) {
                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }
        }
    }
}
