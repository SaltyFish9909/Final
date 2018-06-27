using System;
using System.Collections.Generic;
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

namespace 期末
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(MonthSlider.Value, 1);
            MonthNumber.Text = value.ToString();

            double v = value;
            Canvas.SetLeft(Month, v);

            double h = double.Parse(MonthNumber.Text);
            double w = double.Parse(DateNumber.Text);

            string[] parts = Math.Round(h, 1).ToString().Split('/');

            BigNumber.Text = parts[0];
            if (parts.Length > 1)
                SmallNumber.Text = "/" + parts[1];
            else
                SmallNumber.Text = "/0";


        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(DateSlider.Value, 1);
            DateNumber.Text = value.ToString();
      
            double v = value;
            Canvas.SetLeft(Date, v);

            double h = double.Parse(MonthNumber.Text);
            double w = double.Parse(DateNumber.Text);

            string[] parts = Math.Round(h, 1).ToString().Split('/');

            BigNumber.Text = parts[0];
            if (parts.Length > 1)
                SmallNumber.Text = "/" + parts[1];
            else
                SmallNumber.Text = "/0";

        }
    }
}
