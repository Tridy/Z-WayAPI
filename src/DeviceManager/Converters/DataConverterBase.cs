using System.Text.Json;
using System.Text.Json.Serialization;

namespace DeviceManager.Converters
{
    public abstract class DataConverterBase<T> : JsonConverter<Dictionary<T, object>>
    {
        public override Dictionary<T, object> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new JsonException();
            }

            Dictionary<T, object> results = new();

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return results;
                }

                if (reader.TokenType != JsonTokenType.PropertyName)
                {
                    throw new JsonException();
                }

                string? propertyName = reader.GetString();
                T property = CastToKeyType(propertyName);

                reader.Read();

                if (reader.TokenType == JsonTokenType.StartObject)
                {
                    var dataItems = Read(ref reader, typeToConvert, options);
                    results.Add(property, dataItems);
                }
                else if (reader.TokenType == JsonTokenType.String)
                {
                    var value = reader.GetString();
                    results.Add(property, value);
                }
                else if (reader.TokenType == JsonTokenType.Number)
                {
                    if (reader.TryGetInt32(out int value))
                    {
                        results.Add(property, value);
                    }
                    else
                    {
                        var decimalValue = reader.GetDecimal();
                        results.Add(property, decimalValue);
                    }
                }
                else if (reader.TokenType == JsonTokenType.Null)
                {
                    results.Add(property, null);
                }
                else if (reader.TokenType == JsonTokenType.True || reader.TokenType == JsonTokenType.False)
                {
                    var value = reader.GetBoolean();
                    results.Add(property, value);
                }
                else if (reader.TokenType == JsonTokenType.StartArray)
                {
                    var arrayItems = new List<byte>();
                    reader.Read();

                    while (reader.TokenType != JsonTokenType.EndArray)
                    {
                        var arrayElement = reader.GetByte();
                        arrayItems.Add(arrayElement);
                        reader.Read();
                    }

                    results.Add(property, arrayItems);
                }
                else
                {
                    throw new NotImplementedException(); 
                }
            }

            return results;
        }

        public abstract T CastToKeyType(string propertyValue);

        public override void Write(Utf8JsonWriter writer, Dictionary<T, object> source, JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}