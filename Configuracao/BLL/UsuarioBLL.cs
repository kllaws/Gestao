using DAL;
using Models;

namespace BLL
{
    public class UsuarioBLL
    {
        public void Inserir(Usuario _usuario)
        {
            if (_usuario.NomeUsuario.Length <= 3 || _usuario.NomeUsuario.Length >= 50)
                throw new Exception("O nome do usuario deve ter mais de tres caracteres.");

            if( _usuario.NomeUsuario.Contains("..."))
                throw new Exception("O nome de usuario nao pode conter espaço ");
  
            if (_usuario.Senha ==("123567"))
                   throw new Exception("Nao e permitido um numero sequencial. ");

            if (_usuario.Senha.Length <= 7 || _usuario.Senha.Length > 11)
                    throw new Exception("A senha deve ter entre 7 e 11 caracteres. ");

            // TODO: Validar se ja existe um usuario com esse nome.
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            usuarioDAL.Inserir(_usuario);
            
        }
        public Usuario Buscar(string _nomeUsuario)
        Console.write("Digite o nome que deseja pesquisar: ");
        nome.Console.ReadLine();
        string nomes = {};

        bool achou = false;
        for (int i=; i< nomes.length; i++)
        {
            if(nomes[i]== nome)
            {
                achou = true;
                break;
            }
        }
        if(achou)
        {
            Console.WriteLine("O nome "nome"esta cadastrado")
            console.ReadLine.nome();
        }
        else
        {
          Console.WriteLine("O nome nao esta na lista");  
        }
        
        {
            return new Usuario();
        }
        public void Alterar (Usuario _usuario)
        {

        }
        public void Excluir (int _id)
        {

        }

    }
}