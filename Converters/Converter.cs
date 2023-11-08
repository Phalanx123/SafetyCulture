using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Converters
{
    internal class Converter
    {
        public static string NullableBoolToStringConverter(bool? inputBool)
        {
            if (inputBool.HasValue)
            {
                return inputBool.Value ? "true" : "false";
            }
            else
            {
                return "both";
            }
        }
        public class EnumToStringConverter<TEnum> : JsonConverter<TEnum> where TEnum : Enum
        {
            public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return (TEnum)Enum.Parse(typeof(TEnum), reader.GetString());
            }

            public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(Enum.GetName(typeof(TEnum), value));
            }
        }
        
        public class EnumToStringConverterLower<TEnum> : JsonConverter<TEnum> where TEnum : Enum
        {
            public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return (TEnum)Enum.Parse(typeof(TEnum), reader.GetString().ToLower());
            }

            public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
            {
                writer.WriteStringValue(Enum.GetName(typeof(TEnum), value).ToLower());
            }
        }
    }
}
