using Microsoft.UI.Xaml.Data;
using System;
using System.Globalization;
namespace Leagueoflegends.Support.Local.Converters;

public class BooleanToInverseConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is bool boolValue)
        {
            return !boolValue;
        }
        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
