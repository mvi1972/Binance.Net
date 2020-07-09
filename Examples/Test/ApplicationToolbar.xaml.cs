using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для ApplicationToolbar.xaml
    /// </summary>
    public partial class ApplicationToolbar : UserControl
    {
        public ApplicationToolbar()
        {
            InitializeComponent();
        }

        private void NavigationCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            NavigationService service = NavigationService.GetNavigationService(this);
            service.Navigate(new Uri(e.Parameter.ToString(), UriKind.Relative));
        }
    }
}
