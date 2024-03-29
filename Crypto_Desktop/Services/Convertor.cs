﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using Crypto_Desktop.MVVM.Coin;

namespace Crypto_Desktop.Services
{
    public class SparklineToSvg : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            culture = CultureInfo.InvariantCulture;

            int index = 0;
            var SparklineIn7D = value as SparklineIn7D;
            var max = SparklineIn7D.Price.Max();
            var avg = SparklineIn7D.Price.Average();
            var coef = max - avg;
            var scale = 14 / (coef == 0 ? 14 : coef);

            string path = SparklineIn7D.Price.Aggregate("", (path, price) =>
            {
                char instruction = index == 0 ? 'M' : 'L';
                path = string.Format(
                    culture,
                    "{0} {1}{2} {3:0.###}",
                    path,
                    instruction,
                    index,
                    (max - price) * scale
                );
                index++;
                return path;
            });
            return path;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class StringToUp : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value == null ? string.Empty : value.ToString().ToUpper();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class PercentageToText : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null) return string.Empty;
            double percentage = (double)value;
            return (percentage >= 0 ? "⏶" : "⏷") + Math.Abs(percentage / 100).ToString("P");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class PercentageToBrush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value >= 0 ? "#16c784" : "#ea3943";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class DecimalToVariableCurrency : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null) return string.Empty;

            var price = (decimal)value;

            int precision;
            if (price >= 1 || price < 0) precision = 2;
            else if (price > 0.099M) precision = 4;
            else precision = (int)Math.Log10((double)(1M / price)) * 2;
            return string.Format(CultureInfo.CurrentCulture, "{0:C" + precision + "}", price);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    public class DecimalToShortCurrency : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            decimal v = (decimal)value;
            culture = CultureInfo.CurrentCulture;
            string symbol = culture.NumberFormat.CurrencySymbol;
            return v switch
            {
                > 999_999_999 => v.ToString(symbol + "0,,,.##B", culture),
                > 999_999 => v.ToString(symbol + "0,,.##M", culture),
                > 9_999 => v.ToString(symbol + "0,.##K", culture),
                _ => v.ToString("C", culture)
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
