using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio.Objetos; 


namespace Gestion.ViewModels
{
    public class UsuarioView
    {
        //listar clientes
        public List<DataUsuario> ListarDoctores()
        {
            List<DataUsuario> listaUsuarios = new List<DataUsuario>();

            List<DataUsuario> listaUsuarios = servicio.obtenerClientes();
        } 

        

    }
}
