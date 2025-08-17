namespace TaskApi.Core.Domain.Exception
{
    public class DutyNotFoundException : BusinessException
    {
        public Guid IdDuty { get; }
        public DutyNotFoundException(Guid idDuty) : base($"Usuário com ID {idDuty} Não Encontrado.")
        {
            IdDuty = idDuty;
        }
    }
}