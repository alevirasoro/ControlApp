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
        public Cuenta buscarCuenta(int idUsuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try {
                //BUSCA EL NRO DE USUARIO EN LA TABLA DE CUENTAS HASTA QUE ENCUENTRA LA CUENTA CON ESE ID
                datos.setearConsulta("select A.IDUsuario, A.Saldo, A.ID from CUENTAS A WHERE A.IDUsuario = " +idUsuario);
                datos.ejecutarLectura();

                if (datos.Lector.Read()) {
                    Cuenta aux = new Cuenta();
                    aux.Saldo = (decimal)datos.Lector["Saldo"];
                    aux.ID = (int)datos.Lector["ID"];
                    aux.IDUsuario = (int)datos.Lector["IDUsuario"];
                    return aux;
                }
                else {
                    Cuenta aux = new Cuenta();
                    aux.ID = 0;
                    return aux;
                }
            }
            catch(Exception ex) {
                throw ex;
            }
        }
        
    }
}
