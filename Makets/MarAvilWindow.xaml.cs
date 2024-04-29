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
using System.Windows.Shapes;

namespace Makets
{
    /// <summary>
    /// Логика взаимодействия для MarAvilWindow.xaml
    /// </summary>
    public partial class MarAvilWindow : Window
    {
        public MarAvilWindow()
        {
            InitializeComponent();
            FrameObj.frameObj = FrmMain;
            FrmMain.Navigate(new AbonentPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new BillyPage());
        }

        private void PodderzhkaPolzButton_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new PodderzhkaPolzPage());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new AbonentPage());
        }

        private void UrpOborudBut_Click(object sender, RoutedEventArgs e)
        {
            FrmMain.Navigate(new UpravlenieOborudPage());
        }
    }
}
