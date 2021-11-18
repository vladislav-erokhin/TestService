namespace Service.Services
{
    using System.Threading.Tasks;

    using Grpc.Core;
    using Grpc.Health.V1;

    public class HealthServiceImpl : Health.HealthBase
    {
        public override async Task<HealthCheckResponse> Check(HealthCheckRequest request, ServerCallContext context)
        {
            var response = new HealthCheckResponse { Status = HealthCheckResponse.Types.ServingStatus.Serving };

            return await Task.FromResult(response);
        }
    }
}
