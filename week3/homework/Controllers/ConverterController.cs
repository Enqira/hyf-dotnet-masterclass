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

        //From Miles to Kilometers
        if (valueType == "Miles")
        {
            responseValueType = "Kilometers";
            responseValue = requestValue * 1.609;
        }
        // From Gallons to Liters
        else if (valueType == "Gallons")
        {
            responseValueType = "Liters";
            responseValue = requestValue * 3.785;
        }
        // From Pounds to Kilograms 
        else if (valueType == "Pounds")
        {
            responseValueType = "Kilograms";
            responseValue = requestValue / 2.205;
        }
        // From Yards to Meters
        else if (valueType == "Yards")
        {
            responseValueType = "Meters";
            responseValue = requestValue / 1.094;
        }
        // From Feets to Centimeters
        else if (valueType == "Feets")
        {
            responseValueType = "Centimeters";
            responseValue = requestValue / 30.48;
        }


        // Create an array of objects
        Object[] obj = new Object[2];
        obj[0] = new ConversionResponse() { ExternalValueType = valueType, Value = requestValue };
        obj[1] = new ConversionResponse() { ExternalValueType = responseValueType, Value = responseValue };


        return obj;
    }


}



