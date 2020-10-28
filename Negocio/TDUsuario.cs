using System;
using System.Collections.Generic;
using System.Text;

namespace 04_TipoDeDatos
{
    public class TDUsuario
    {
        private string Nombre;
        private string Password;

        public TDUsuario(string nombre, string password)
        {
            Nombre = nombre;
            Password = password;
        }
}
