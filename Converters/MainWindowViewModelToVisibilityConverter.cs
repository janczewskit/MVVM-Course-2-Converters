using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using MVVM_2_Converters.ViewModels;

namespace MVVM_2_Converters.Converters
{
    public class MainWindowViewModelToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is MainWindowViewModel)
            {
                var mainWindowViewModel = value as MainWindowViewModel;
                bool result = !string.IsNullOrEmpty(mainWindowViewModel.Login) 
                    && !string.IsNullOrEmpty(mainWindowViewModel.Password);
                return result ? Visibility.Visible : Visibility.Hidden;
            }
            return Visibility.Hidden;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
