namespace Domain.DTO
{
    [Serializable]
    public class DTOOpenWeatherReport
    {
        [JsonProperty("main")]
        public ReportMainSection Main { get; set; }

        public bool IsValid() 
        {
            return (Main != null);
        }
    }
}