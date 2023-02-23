usando  DAL ;
usando  Modelos ;
espaço de nomes  BLL
{
     classe  pública UsuárioBLL
    {
        public  void  Inserir ( Usuario  _usuario )
        {
            if ( _usuario . NomeUsuario . Comprimento  <=  3  ||  _usuario . NomeUsuario . Comprimento  >=  50 )
                throw  new  Exception ( " O nome do usuário deve ter mais de três caracteres. " );
            if ( _usuario . NomeUsuario . Contém ( "  " ))
                throw  new  Exception ( " O nome do usuário não pode conter espaço em branco. " );
            if ( _usuário . Senha . Contém ( " 1234567 " ))
                throw  new  Exception ( " Não é permitido um número sequencial. " );
            if ( _usuario . Senha . Comprimento  <  7  ||  _usuario . Senha . Comprimento  >  11 )
                lançar  nova  exceção ( " A senha deve ter entre 7 e 11 caracteres. " );
            // TODO: Validar se já existe um usuário com nome existente.
            UsuarioDAL  usuarioDAL  =  new  UsuarioDAL ();
            usuarioDAL . Inserir ( _usuário );
        }
         public  Usuário  Buscar ( string  _nomeUsuario )
        {
            retornar  novo  usuário ();
        }
        public  void  Change ( Usuario  _usuario )
        {
            if ( _usuario . NomeUsuario . Comprimento  <=  3  ||  _usuario . NomeUsuario . Comprimento  >=  100 )
                throw  new  Exception ( " O nome do usuário deve conter de 3 a 100 caracteres. " );
            if ( _usuario . NomeUsuario . Contém ( "  " ))
                throw  new  Exception ( " O nome do usuário não pode conter espaço em branco. " );
            if ( _usuário . Senha . Contém ( " 1234567 " ))
                throw  new  Exception ( " Não é permitido número sequencial. " );
            if ( _usuario . Senha . Comprimento  <  7  ||  _usuario . Senha . Comprimento  >  11 )
                lançar  nova  exceção ( " A senha deve ter entre 7 e 11 caracteres. " );
            UsuarioDAL  usuarioDAL  =  new  UsuarioDAL ();
            usuarioDAL . Mudar ( _usuário );
        }
        public  void  Excluir ( int  _id )
        {
             }
    }
}