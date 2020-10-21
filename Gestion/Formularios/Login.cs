using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion.ViewModels;
using Negocio.Objetos;
using System.Data.SqlClient;
using System.Net.Configuration;
using Negocio.Modelo;
using Presentacion.Helpers;


namespace Gestion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            string nombreUsuario = txtUsuario.Text;
            string password = txtContrasena.Text;
            //Usuario usr = new Negocio.Modelo.Usuario();
            Usuario usr = new Usuario();
            usr.Ingresar(nombreUsuario, password, Variables.programa);
            bool ingreso = usr.Ingresar(nombreUsuario, password, Variables.programa);
            if (checkrecordar.Checked == true)
            {
                Properties.Settings.Default.UserName = txtUsuario.Text;
                Properties.Settings.Default.password = txtContrasena.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                /*Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();*/
            }
            Principal p = new Principal();
            p.Show();

            //guardo los datos


        }

        private void BtCerrar_Click(object sender, EventArgs e)
        {
            Close();         

        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
