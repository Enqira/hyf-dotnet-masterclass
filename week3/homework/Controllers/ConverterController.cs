using Microsoft.AspNetCore.Mvc;
using homework.Models;

namespace homework.Controllers;

[ApiController]
[Route("[controller]")]
public class ConverterController : ControllerBase
{


    [HttpGet("GallonsToLiters")]
    public double GallonsToLiters(int gallons)
    {
        return gallons * 3.785;
    }

    [HttpGet("ConvertMiles")]
    public Distance ConvertMiles(int miles)
    {
        double km = miles * 1.609;
        return new Distance() { Miles = miles, Kilometers = km };
    }

    [HttpPost("ConvertValues")]
    public Object[] ConvertValues([FromBody] ConversionRequest Request)
    {
        //save request on variables for ease of use
        string valueType = Request.TypeToConvert.ToString();
        double requestValue = Request.Value;

        //The new created variable will be saved here
        string responseValueType = "";
        double responseValue = 0;

        if (valueType == "Miles")
        {
            responseValueType = "Kilometers";
            responseValue = requestValue * 1.609;
        }
        else if (valueType == "Kilometers")
        {
            responseValueType = "Miles";
            responseValue = requestValue / 1.609;
        }
        else if (valueType == "Gallons")
        {
            responseValueType = "Liters";
            responseValue = requestValue * 3.785;
        }
        else if (valueType == "Liters")
        {
            responseValueType = "Gallons";
            responseValue = requestValue / 3.785;
        }

        // Create an array of objects
        Object[] obj = new Object[2];
        obj[0] = new ConversionResponse() { ExternalValueType = valueType, Value = requestValue };
        obj[1] = new ConversionResponse() { ExternalValueType = responseValueType, Value = responseValue };


        return obj;
    }


}



