using System.Text.Json.Serialization;
using System;
using System.Text.Json;


namespace ComplianceApp.Models
{
    public class TimeSpanToStringConverter : JsonConverter<TimeSpan>
    {
        public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Parse the incoming JSON string value to TimeSpan
            return TimeSpan.ParseExact(reader.GetString(), @"hh\:mm\:ss", null);
        }

        public override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
        {
            // Convert the TimeSpan value to a string in "hh:mm:ss" format
            writer.WriteStringValue(value.ToString(@"hh\:mm\:ss"));
        }

    }
}
