using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using negocio;

namespace ControldeGastos
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected decimal sal = -1;
        public int idCuenta = 0;
        public List<Movimiento> lista;
        public List<Movimiento> listaMovimientos;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Cuenta cuenta = new Cuenta();
            CuentaNegocio negocio = new CuentaNegocio();
            MovimientoNegocio movimiento = new MovimientoNegocio();
            

            try {
                //BUSCAR EL ID DE USUARIO (O EMAIL EN SU DEFECTO) EN EL SESSION, SE TIENE QUE GUARDAR EN EL LOGIN ESTO
                cuenta = negocio.buscarCuenta(1);
                if(cuenta.ID != 0) {
                    idCuenta = cuenta.ID;
                    lista = movimiento.listar(idCuenta);
                    Session.Add("listaMovimientos", lista);
                    listaMovimientos = (List<Movimiento>)Session["listaMovimientos"];
                    repetidor.DataSource = listaMovimientos;
                    repetidor.DataBind();       
                }
            }
            catch(Exception ex) {
                throw ex;
            }
        }

        
    }
}