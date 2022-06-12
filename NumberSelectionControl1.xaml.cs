using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VerySecretiveRandomMusicSearchApp.ViewModel;

namespace VerySecretiveRandomMusicSearchApp
{
    /// <summary>
    /// Interaction logic for NumberSelectionControl1.xaml
    /// </summary>
    public partial class NumberSelectionControl1 : Page
    {
        public string Text { get; set; } = "Number of words:";
        public int MinSelection { get; set; } = 5;
        public int MaxSelection { get; set; } = 20;

        public NumberSelectionControl1()
        {
            InitializeComponent();
            DataContext = new NumberSelectionViewModel();

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = Application.Current.MainWindow as MainWindow;
            mainWindow.MainWindowFrame.Content = new SongPage();

        }

        private void NumberSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Properties.Settings.Default.SliderNum = (int)NumberSlider.Value;
        }
    }

    public class ConvertToIntegerConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (double)value;
        }
    }
}
