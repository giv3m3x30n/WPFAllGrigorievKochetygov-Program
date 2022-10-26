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
    /// Логика взаимодействия для ListUserWindow.xaml
    /// </summary>
    public partial class ListUserWindow : Window
    {
        DGClass dGClass;
        public ListUserWindow()
        {
            InitializeComponent();
            dGClass=new DGClass(UserDG);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            dGClass.LoadDG("SELECT * FROM dbo.UserView");
        }

        private void SearchTb_TextChanged(object sender, RoutedEventArgs e)
        {
            dGClass.LoadDG("SELECT * FROM dbo.UserView " +
                $"Where LastName LIKE '%(SearchTb.Text)%'");
        }
    }
}
