using System;
using System.Collections.Generic;
using System.Text;
using Negocio.Objetos;

namespace Negocio.Modelo
{
    public class Doctor
    {
        public List<DataUsuario> ObtenerDoctores()
        {
            List<DataUsuario> list= new List<DataUsuario>();
            DataUsuario doc1 = new DataUsuario("Pedro", "apellido");
            list.Add(doc1);
            DataUsuario doc2 = new DataUsuario("Pedro", "apellido");
            list.Add(doc2);
            return list;
        }
    }
}
