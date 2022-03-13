namespace homework.Models;

public class ConversionRequest
{
    public enum RequestValueType
    {
        Miles,
        Kilometers,
        Gallons,
        Liters
    }
    public double Value { get; set; }
    public RequestValueType TypeToConvert { get; set; }
}