using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            UsuarioBLL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);

        }
    }
}
