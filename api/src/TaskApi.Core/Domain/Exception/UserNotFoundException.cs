namespace TaskApi.Core.Domain.Exception
{
    public class UserNotFoundException : BusinessException
    {
        public Guid IdUser { get; }
        public UserNotFoundException(Guid idUser) : base($"Usuário com ID {idUser} Não Encontrado.")
        {
            IdUser = idUser;
        }
    }
}