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
        protected decimal sal = 10000;
        public List<Movimiento> lista;
        public List<Movimiento> listaMovimientos;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CuentaNegocio cuenta = new CuentaNegocio();
            MovimientoNegocio movimiento = new MovimientoNegocio();
            
            try {
                //BUSCAR EL ID DE USUARIO (O EMAIL EN SU DEFECTO) EN EL SESSION, SE TIENE QUE GUARDAR EN EL LOGIN ESTO
                sal = cuenta.buscarSaldo(1);
                lista = movimiento.listar();
                Session.Add("listaMovimientos", lista);
                listaMovimientos = (List<Movimiento>Session["listaMovimientos"]);
                repetidor.DataSource = listaMovimientos;
                repetidor.DataBind();

            }
            catch(Exception ex) {
                throw ex;
            }
        }

        
    }
}