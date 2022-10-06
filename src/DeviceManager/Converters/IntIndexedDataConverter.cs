namespace DeviceManager.Converters
{
    public class IntIndexedDataConverter : DataConverterBase<int>
    {
        public override int CastToKeyType(string propertyValue)
        {
            int indexValue = int.Parse(propertyValue);
            return indexValue;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert == typeof(Dictionary<int, object>);
        }
    }
}