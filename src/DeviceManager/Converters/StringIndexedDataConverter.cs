using System;
using System.Collections.Generic;

namespace DeviceManager.Converters
{
    public class StringIndexedDataConverter : DataConverterBase<string>
    {
        public override string CastToKeyType(string propertyValue)
        {
            return propertyValue;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(Dictionary<string, object>);
        }
    }
}