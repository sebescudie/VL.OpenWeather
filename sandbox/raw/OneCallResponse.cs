// Code generated by jtd-codegen for C# + System.Text.Json v0.2.1

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VL.OpenWeather
{
    public class OneCallResponse
    {
        [JsonPropertyName("alerts")]
        public IList<OneCallResponseAlert> Alerts { get; set; }

        [JsonPropertyName("current")]
        public OneCallResponseCurrent Current { get; set; }

        [JsonPropertyName("daily")]
        public IList<OneCallResponseDaily> Daily { get; set; }

        [JsonPropertyName("hourly")]
        public IList<OneCallResponseHourly> Hourly { get; set; }

        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }

        [JsonPropertyName("minutely")]
        public IList<OneCallResponseMinutely> Minutely { get; set; }

        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        [JsonPropertyName("timezone_offset")]
        public short TimezoneOffset { get; set; }
    }
}
