using Domain.DTO;
using Newtonsoft.Json;

namespace Services.SevicesInterfaces
{
    public class OpenWeatherService
    {
        private readonly IHttpClienteFactory _clientFactory;
        private readonly IConfiguration _configuration;
        private string _ApiUrl;
        private string _ApiKey;

        public OpenWeatherService(IHttpClienteFactory clientFactory, IConfiguration configuration)
        {
            _clientFactory = clientFactory;
            _configuration = configuration;
            _ApiUrl = _configuration["ApiOpenWeather:ApiUrl"];
            _ApiKey = _configuration["ApiOpenWeather:ApiKey"];
        }

        public DTOOpenWeatherResult GetCurrentTemperature(double latitude, double longitude)
        {

            Dictionary<string, string> urlParameters = new Dictionary<string, string>()
            {
                {"lat", latitude.ToString()},
                {"lon", longitude.ToString()},
                {"appid", _ApiKey}
            };

            HttpResponseMessage response = SendRequest("/weather", urlParameters);
            return HandleCurrentTemperatureResponse(response);
        }

        public DTOOpenWeatherReport GetCurrentTemperature(string city)
        {
            Dictionary<string, string> urlParameters = new Dictionary<string, string>()
            {
                {"q", city},
                {"appid", _ApiKey}
            };

            HttpResponseMessage response = SendRequest("/weather", urlParameters);
            return HandleCurrentTemperatureResponse(response);
        }

        private HttpResponseMessage SendRequest(string urlPath, Dictionary<string, string> urlParameters)
        {
            string openWeatherEndpoint = _ApiUrl + urlPath;
            HttpClient client = _clientFactory.CreateClient();

            return client.GetAsync(QueryHelpers.AddQueryString(ultParameters, urlParameters));
        }

        private DTOOpenWeatherReport HandleCurrentTemperatureResponse(HttpResponseMessage response)
        {
            return JsonConvert.DeserializeObject<DTOOpenWeatherReport>(
                response.Content.ToString()
            );
        }
    }
}