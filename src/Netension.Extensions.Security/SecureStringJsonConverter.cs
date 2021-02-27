using System;
using System.Security;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Netension.Extensions.Security
{
    public class SecureStringJsonConverter : JsonConverter<SecureString>
    {
        public override SecureString Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = reader.GetString();
            if (string.IsNullOrEmpty(value)) return null;

            return value.Encrypt();
        }

        public override void Write(Utf8JsonWriter writer, SecureString value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.Decrypt());
        }
    }
}
