﻿using System;
using System.Windows.Data;

namespace Microsoft.FamilyShow
{
    public class NotConverter : IValueConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException(Properties.Resources.NotImplemented);
        }

        #endregion
    }
}
