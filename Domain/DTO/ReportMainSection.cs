using Newtonsoft.Json;

namespace Domain.DTO
{
    [Serializable]
    public class ReportMainSection
    {
        [JsonProperty("temp")]
        public double Temp { get; set; }
    }
}