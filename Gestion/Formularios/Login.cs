using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.ViewModels;
using Negocio.Objetos;

namespace Gestion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UsuarioView usrview = new UsuarioView();
            List<DataUsuario> lista =  usrview.ListarDoctores();
            dgvDoctores.DataSource = lista;
                //llamo a conexion.        
                
           



        }
    }
}
