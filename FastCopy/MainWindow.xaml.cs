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

namespace FastCopy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool enable = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Topmost = Convert.ToBoolean((sender as CheckBox).IsChecked);
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if (enable)
            {
                Clipboard.SetText(main_TextBox.Text);
            }
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            enable = Convert.ToBoolean((sender as CheckBox).IsChecked);
        }
    }
}
