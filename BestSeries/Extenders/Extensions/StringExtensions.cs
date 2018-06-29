using System;
using BestSeries.Infrastructure.Helpers;

namespace BestSeries.Extenders.Extensions
{
    public static class StringExtensions
    {
        public static string ToImagePath(this string value)
        => $"{ConstantHelper.ImageUrlPref}{value}";
    }
}
