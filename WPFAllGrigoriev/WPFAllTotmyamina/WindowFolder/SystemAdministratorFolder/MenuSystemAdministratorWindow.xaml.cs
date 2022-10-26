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
using WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder;

namespace WPFAllTotmyamina.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для MenuSystemAdministratorWindow.xaml
    /// </summary>
    public partial class MenuSystemAdministratorWindow : Window
    {
        public MenuSystemAdministratorWindow()
        {
            InitializeComponent();
        }

        private void ListUserBtn_Click(object sender, RoutedEventArgs e)
        {
            new ListUserWindow().ShowDialog();
        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddUserWindow().ShowDialog();
        }

        private void ListOfProductsBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListOfOrdersBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
