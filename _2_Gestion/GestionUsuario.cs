using System;
using _4_TipoDeDato;
using _3_Persistencia;

namespace _2_Gestion
{
    public class GestionUsuario
    {
        public Int32  RegsitrarUsuario(DTUsuario usu)
        {
            PersistenciaUsuario p = new PersistenciaUsuario();

            Int32 idUsuGen = p.RegistrarUsuario(usu);
            return idUsuGen;
        }

        public DTUsuario ObtenerUsuario(DTUsuario usu)
        {
            PersistenciaUsuario p = new PersistenciaUsuario();

            return p.ObtenerUsuario(usu);

        }
    }
}
