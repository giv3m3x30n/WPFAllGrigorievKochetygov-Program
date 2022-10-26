using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WPFAllTotmyamina.WindowFolder
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        SqlConnection sqlConnection =
            new SqlConnection(@"Data Source=10.128.14.48\SQLEXPRESS;
                                Initial Catalog=user45;
                                Persist Security Info=True;
                                User ID=user45;
                                Password=wsruser45");
        SqlDataReader dataReader;
        SqlCommand sqlCommand;

        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                MBClass.ErrorMB("Введите логин");
                LoginTb.Focus();
            }
            else if (string.IsNullOrWhiteSpace(PasswordPb.Password))
            {
                MBClass.ErrorMB("Введите пароль");
                PasswordPb.Focus();
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("" +
                        "Select PasswordUser, IdRole From " +
                        $"dbo.[User] Where " +
                        $"LoginUser='{LoginTb.Text}'",
                        sqlConnection);

                    dataReader = sqlCommand.ExecuteReader();
                    dataReader.Read();

                    if (dataReader[0].ToString() != PasswordPb.Password)
                    {
                        MBClass.ErrorMB("Не верный пароль");
                        PasswordPb.Focus();
                    }
                    else
                    {
                        switch (dataReader[1].ToString())
                        {
                            case "1":
                                MBClass.InfoMB("Администратор системы");
                                new MenuSystemAdministratorWindow().ShowDialog();
                                break;
                            case "2":
                                MBClass.InfoMB("Менеджер");
                                break;
                            case "3":
                                MBClass.InfoMB("Директор");
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MBClass.ErrorMB(ex);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            MBClass.ExitMB();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            new RegistrationWindow().ShowDialog();
        }
    }
}
