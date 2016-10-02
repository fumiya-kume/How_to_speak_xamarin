using System;
using System.Collections.Generic;
using static HowToSpeak.Util.Country;

namespace HowToSpeak.Util
{
    public static class CountryUtil
    {
        public static string GetCountryCode(Country country)
        {
            switch (country)
            {
                case Japan:
                    return "ja-JP";
                case US:
                    return "us-US";
                case Chin:
                    return "cn-ZN";
                default:
                    throw new ArgumentOutOfRangeException(nameof(country), country, null);
            }
        }

        public static List<string> GetCountryList()
        {
            return new List<string> {GetCountryCode(Japan),GetCountryCode(US),GetCountryCode(Chin)};
        }
    }

    public enum Country
    {
        Japan,
        US,
        Chin
    }
}