using Grpc.Net.Client;
using GrpcGestaoClient.Protos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GrpcChamadaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{mensagem}/{testado}/{status}")]
        public async Task<IActionResult> Get(string mensagem, bool testado, int status)
        {
            var httpHandler = new HttpClientHandler
            {
                // Return `true` to allow certificates that are untrusted/invalid
                ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
            };

            using var channel = GrpcChannel.ForAddress("https://host.docker.internal:32788", new GrpcChannelOptions { HttpHandler = httpHandler });
            var client = new Gestao.GestaoClient(channel);
            var reply = await client.ChamadaTesteServiceAsync(new ExampleRequest { Mensagem = mensagem, Testado = testado, Status = status });

            return new ObjectResult(reply) { StatusCode = StatusCodes.Status200OK };
        }
    }
}
