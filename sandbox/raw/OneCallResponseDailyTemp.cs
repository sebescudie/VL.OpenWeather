// Code generated by jtd-codegen for C# + System.Text.Json v0.2.1

using System.Text.Json.Serialization;

namespace VL.OpenWeather
{
    public class OneCallResponseDailyTemp
    {
        [JsonPropertyName("day")]
        public double Day { get; set; }

        [JsonPropertyName("eve")]
        public double Eve { get; set; }

        [JsonPropertyName("max")]
        public double Max { get; set; }

        [JsonPropertyName("min")]
        public double Min { get; set; }

        [JsonPropertyName("morn")]
        public double Morn { get; set; }

        [JsonPropertyName("night")]
        public double Night { get; set; }
    }
}