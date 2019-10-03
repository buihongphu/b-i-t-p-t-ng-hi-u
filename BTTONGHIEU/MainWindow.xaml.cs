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

namespace BTTONGHIEU
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btntong_Click(object sender, RoutedEventArgs e)
        {
             {
            Double a = double.Parse(btntong.Text);
            Double b = double.Parse(btntong.Text);
            btntong.Text = Tong(a, b).ToString();
              }
            public double Tong(Double a, Double b)
            {
                return a + b;
            }

        }
    }
}
