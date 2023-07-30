using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace Katte20230729.Logic
{
    public class HealthCheck : IHealthCheck
    {
        private readonly OpenAILogic _openAILogic;
        public HealthCheck(OpenAILogic openAILogic)
        {
            _openAILogic = openAILogic;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            try
            {
                _openAILogic.StreamRun("").GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                return Task.FromResult(
            new HealthCheckResult(
                context.Registration.FailureStatus, ex.Message));
            }
            return Task.FromResult(
                HealthCheckResult.Healthy("A healthy result."));
        }
    }
}
