using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Subscription : Base
    {
        public Plan Plan { get; set; } // Assinatura para o usuário. Nesse caso plano de pagamento

        // Se EndDate estiver nulo, o usuário está ativo.   
        // Se EndDate estiver no futuro, o usuário cancelou o plano, mas consegue acessar o curso até o final da Data Final da Assinatura (EndDate)
        // Se o EndDate estiver no passado, o usuário não possui acesso.
        public DateTime? EndDate { get; set; }

        public bool IsInactive => EndDate <= DateTime.Now;
    }
}