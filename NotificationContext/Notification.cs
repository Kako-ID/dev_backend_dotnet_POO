namespace Balta.NotificationContext
{
    // Classe para notificações de Erro
    public sealed class Notification
    {

        public Notification()
        {

        }

        public Notification(string property, string message)
        {
            Property = property;
            Message = message;
        }

        public string Property { get; set; } // Propriedade que está com erro
        public string Message { get; set; } // Mensagem de erro
    }
}