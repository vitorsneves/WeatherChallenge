namespace Services.SevicesInterfaces
{
    public interface IOpenWeatherService
    {
        public DTOOpenWeatherResult GetCurrentTemperature(double latitude, double longitude);
        public DTOOpenWeatherResult GetCurrentTemperature(string city);
        public DTOOpenWeatherResult GetTemperatureHistory(double latitude, double longitude);
        public DTOOpenWeatherResult GetTemperatureHistory(string city);
    }
}