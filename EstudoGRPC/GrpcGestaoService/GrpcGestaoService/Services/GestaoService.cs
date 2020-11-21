using Grpc.Core;
using GrpcGestaoService.Protos;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace GrpcGestaoService.Services
{
    public class GestaoService : Gestao.GestaoBase
    {
        private readonly ILogger<GestaoService> _logger;

        public GestaoService(ILogger<GestaoService> logger)
        {
            _logger = logger;
        }

        public override Task<ExampleResponse> ChamadaTesteService(ExampleRequest exampleRequest, ServerCallContext serverCallContext)
        {
            var response = new ExampleResponse { Id = exampleRequest.Status, Nome = $"{exampleRequest.Mensagem} Testado: {exampleRequest.Testado}" };
            return Task.FromResult(response);
        }
    }
}
