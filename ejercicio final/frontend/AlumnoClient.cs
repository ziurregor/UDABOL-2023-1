using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace frontend
{
    public class AlumnoClient
    {
        private readonly JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };

        private readonly HttpClient client;
        private readonly ILogger<AlumnoClient> _logger;

        public AlumnoClient(HttpClient client, ILogger<AlumnoClient> logger)
        {
            this.client = client;
            this._logger = logger;
        }

        public async Task<Alumno[]> GetAlumnosAsync()
        {
            try
            {
                var responseMessage = await this.client.GetAsync("/api/Alumnos");

                if (responseMessage != null)
                {
                    var stream = await responseMessage.Content.ReadAsStreamAsync();
                    return await JsonSerializer.DeserializeAsync<Alumno[]>(stream, options);
                }
            }
            catch (HttpRequestException ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
            return new Alumno[] { };

        }



    }
}