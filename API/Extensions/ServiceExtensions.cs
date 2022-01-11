using Services.SevicesInterfaces;

namespace API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureOpenWeather(this IServiceCollection service)
        {   
             return service.AddScoped<IOpenWeatherService, OpenWeatherService>();
        }
    }
}