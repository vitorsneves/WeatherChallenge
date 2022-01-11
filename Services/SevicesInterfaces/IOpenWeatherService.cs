using Domain.DTO;

namespace Services.SevicesInterfaces
{
    public interface IOpenWeatherService
    {
        public DTOOpenWeatherReport GetCurrentTemperature(double latitude, double longitude);
        public DTOOpenWeatherReport GetCurrentTemperature(string city);
        public DTOOpenWeatherReport GetTemperatureHistory(double latitude, double longitude);
        public DTOOpenWeatherReport GetTemperatureHistory(string city);
    }
}