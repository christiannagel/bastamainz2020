using CoronaLight.Models;
using Microsoft.UI;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media;
using System;

namespace CoronaLight.Converters
{
#nullable enable

    public class CoronaLightToBrushConverter : IValueConverter
    {
        private static readonly Brush _redBrush = new SolidColorBrush(Colors.Red);
        private static readonly Brush _yellowBrush = new SolidColorBrush(Colors.Yellow);
        private static readonly Brush _orangeBursh = new SolidColorBrush(Colors.Orange);
        private static readonly Brush _greenBrush = new SolidColorBrush(Colors.Green);
        private static readonly Brush _blackBrush = new SolidColorBrush(Colors.Black);

        public object? Convert(object value, Type targetType, object parameter, string language)
        {
            if (value is LightState lightState)
            {
                return parameter switch
                {
                    "Red" => lightState == LightState.Red ? _redBrush : _blackBrush,
                    "Orange" => lightState == LightState.Orange ? _orangeBursh : _blackBrush,
                    "Yellow" => lightState == LightState.Yellow ? _yellowBrush : _blackBrush,
                    "Green" => lightState == LightState.Green ? _greenBrush : _blackBrush,
                    _ => throw new ArgumentException($"{parameter} is an invalid value for {nameof(parameter)}")
                };
            }
            return null;
        }

        public object? ConvertBack(object value, Type targetType, object parameter, string language) => throw new InvalidOperationException();
    }

#nullable restore
}
