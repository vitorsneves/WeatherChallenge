namespace API.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection ConfigureOpenWeather(this IServiceCollection service)
        {   
            service.Singleton<IOpenWeatherService, OpenWeatherService>();
        }
    }
}