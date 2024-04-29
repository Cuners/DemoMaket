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

namespace Makets
{
    /// <summary>
    /// Логика взаимодействия для RasschetColvoStanstPage.xaml
    /// </summary>
    public partial class RasschetColvoStanstPage : Page
    {
        public RasschetColvoStanstPage()
        {
            InitializeComponent();
        }

        private void Raschet(double S, double s, double K)
        {
            double R0 = Math.Sqrt(s / Math.PI);
            double R = Math.Sqrt(S / Math.PI);
            double L = K * Math.Pow((R0*R),2);
            double D = 2 * R;
            double C = Math.Pow(D, 5 / 2) + Math.Pow(D, 3 / 2) + Math.Pow(D, 1 / 2);
            double n = L / C;

        }
    }
}
