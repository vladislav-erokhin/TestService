namespace Service
{
    using System.Threading.Tasks;

    using Grpc.Core;

    using Service.Services;

    using Test.V1;

    public class TestServiceImplV1 : TestService.TestServiceBase
    {
        private readonly MathService service;

        public TestServiceImplV1(MathService service)
        {
            this.service = service;
        }

        public override async Task<SumNumbersResponse> SumNumbers(SumNumbersRequest request, ServerCallContext context)
        {
            var result = this.service.Sum(request.X, request.Y);
            var response = new SumNumbersResponse { Result = result };

            return await Task.FromResult(response);
        }

        public override async Task<MultiplyNumbersResponse> MultiplyNumbers(MultiplyNumbersRequest request, ServerCallContext context)
        {
            var result = this.service.Multiply(request.X, request.Y);
            var response = new MultiplyNumbersResponse { Result = result };

            return await Task.FromResult(response);
        }
    }
}
