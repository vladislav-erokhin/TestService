using NUnit.Framework;

namespace Service.IntegrationTests
{
    using System.Threading.Tasks;

    using Grpc.Health.V1;
    using Grpc.Net.Client;

    using Test.V1;

    public class Tests
    {
        private GrpcChannel channel;

        [SetUp]
        public void Setup()
        {
            this.channel = GrpcChannel.ForAddress(AppSettings.ServiceUrl);
        }

        [Test]
        public async Task Sum()
        {
            var client = new TestService.TestServiceClient(this.channel);
            var request = new SumNumbersRequest { X = 4, Y = 9, };
            var response = await client.SumNumbersAsync(request);

            Assert.AreEqual(13, response.Result);
        }

        [Test]
        public async Task Health()
        {
            var client = new Health.HealthClient(this.channel);
            var request = new HealthCheckRequest();
            var response = await client.CheckAsync(request);

            Assert.AreEqual(HealthCheckResponse.Types.ServingStatus.Serving, response.Status);
        }
    }
}