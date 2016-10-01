using System;

namespace HowToSpeak.Util
{
    public static class CountryUtil
    {
        public static string GetCountryCode(Country country)
        {
            switch (country)
            {
                case Country.Japan:
                    return "ja-JP";
                case Country.US:
                    return "us-US";
                case Country.Chin:
                    return "cn-ZN";
                default:
                    throw new ArgumentOutOfRangeException(nameof(country), country, null);
            }
        }
    }

    public enum Country
    {
        Japan,
        US,
        Chin
    }
}