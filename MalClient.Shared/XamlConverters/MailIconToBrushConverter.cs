﻿using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using MalClient.Shared.Utils;

namespace MalClient.Shared.XamlConverters
{
    public class MailIconToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if ((Symbol) value == Symbol.Mail)
                return Application.Current.Resources["SystemControlBackgroundAccentBrush"];
            return Settings.SelectedTheme == ApplicationTheme.Dark
                ? new SolidColorBrush(Colors.White)
                : new SolidColorBrush(Colors.Black);
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}