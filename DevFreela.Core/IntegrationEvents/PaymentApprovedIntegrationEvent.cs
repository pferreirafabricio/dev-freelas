namespace DevFreela.Core.IntegrationEvents
{
    public class PaymentApprovedIntegrationEvent
    {
        public PaymentApprovedIntegrationEvent(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
