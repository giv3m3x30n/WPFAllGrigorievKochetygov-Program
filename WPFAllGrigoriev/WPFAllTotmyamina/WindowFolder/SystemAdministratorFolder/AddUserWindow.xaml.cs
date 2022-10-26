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
using WPFAllTotmyamina.ClassFolder;

namespace WPFAllTotmyamina.WindowFolder.SystemAdministratorFolder
{
    /// <summary>
    /// Логика взаимодействия для AddUserWindow.xaml
    /// </summary>
    public partial class AddUserWindow : Window
    {
        CBClass cBClass;
        public AddUserWindow()
        {
            InitializeComponent();
            cBClass = new CBClass();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddUserBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new NUCLEAR_WEAPON().ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cBClass.LoadComboBoxRole(RoleCb);
        }
    }
}
