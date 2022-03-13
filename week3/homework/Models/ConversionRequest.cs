namespace homework.Models;

public class ConversionRequest
{
    public enum RequestValueType
    {
        Miles,
        Gallons,
        Pounds,
        Yards,
        Feets

    }
    public double Value { get; set; }
    public RequestValueType TypeToConvert { get; set; }
}