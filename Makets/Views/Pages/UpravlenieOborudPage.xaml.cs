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
    /// Логика взаимодействия для UpravlenieOborudPage.xaml
    /// </summary>
    public partial class UpravlenieOborudPage : Page
    {
        public UpravlenieOborudPage()
        {
            InitializeComponent();
        }

        private void ContBut_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.frameObj.Navigate(new ControlSostPage());
        }
    }
}
