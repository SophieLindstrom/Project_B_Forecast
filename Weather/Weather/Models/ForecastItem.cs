using System;

namespace Weather.Models
{
    public class ForecastItem
    {
        public DateTime DateTime { get; set; }
        public double Temperature { get; set; }
        public double WindSpeed { get; set; }

        private string _Description;
        public string Description
        {
            get { return StringExtensions.FirstCharToUpper(_Description); }
            set { _Description = value; }
        }
        public string Icon { get; set; }

        public override string ToString() => $"{Description}, temperature: {Temperature} degC, wind: {WindSpeed} m/s";
    }
}

public static class StringExtensions
{
    public static string FirstCharToUpper(this string input)
    {
        switch (input)
        {
            case null:
                {
                    return null;
                }
            case "":
                {
                    return "";
                }
            default:
                {
                    return input[0].ToString().ToUpper() + input.Substring(1);
                }
        }
    }
}