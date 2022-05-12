using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using DevFreela.Core.DTOs;
using DevFreela.Core.Services;
using Microsoft.Extensions.Configuration;

namespace DevFreela.Infrastructure.Payments
{
    public class PaymentService : IPaymentService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMessageBusService _messageBusService;
        private const string QUEUE_NAME = "Payments";
        private readonly string _paymentsBaseUrl;

        public PaymentService(IMessageBusService messageBusService)
        {
            _messageBusService = messageBusService;
        }

        public PaymentService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _paymentsBaseUrl = configuration.GetSection("Services:Payments").Value;
        }

        public void Process(PaymentInfoDTO paymentInfoDTO)
        {
            var paymentInfoJson = JsonSerializer.Serialize(paymentInfoDTO);
            var paymentInfoBytes = Encoding.UTF8.GetBytes(paymentInfoJson);

            _messageBusService.Publish(QUEUE_NAME, paymentInfoBytes);
        }

        public async Task<bool> ProcessWithHttp(PaymentInfoDTO paymentInfoDTO)
        {
            var url = $"{_paymentsBaseUrl}/api/payments";
            var paymentInfoJson = JsonSerializer.Serialize(paymentInfoDTO);
            var paymentInfoContext =  new StringContent(
                paymentInfoJson,
                Encoding.UTF8,
                "application/json"
            );

            var httpClient = _httpClientFactory.CreateClient("Payments");

            var response = await httpClient.PostAsync(url, paymentInfoContext);

            return response.IsSuccessStatusCode;
        }
    }
}
