using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace negocio
{
    public class CuentaNegocio
    {
        public decimal buscarSaldo(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try {
                //BUSCA EL NRO DE USUARIO EN LA TABLA DE CUENTAS HASTA QUE ENCUENTRA LA CUENTA CON ESE ID
                datos.setearConsulta("select A.IDUsuario, A.Saldo from CUENTAS A WHERE A.IDUsuario = " +idUsuario);
                datos.ejecutarLectura();

                if (datos.Lector.Read()) {
                    Cuenta aux = new Cuenta();
                    aux.Saldo = (decimal)datos.Lector["Saldo"];

                    return aux.Saldo;
                }
                else {
                    return 0;
                }
            }
            catch(Exception ex) {
                throw ex;
            }
        }
        
    }
}
