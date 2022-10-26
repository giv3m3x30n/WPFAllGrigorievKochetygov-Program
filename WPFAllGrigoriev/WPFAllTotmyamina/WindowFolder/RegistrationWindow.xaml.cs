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
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        SqlConnection sqlConnection =
            new SqlConnection(@"Data Source=10.128.14.48\SQLEXPRESS;
                                Initial Catalog=user45;
                                Persist Security Info=True;
                                User ID=user45;
                                Password=wsruser45");
        SqlDataReader dataReader;
        SqlCommand sqlCommand;

        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            string zagl = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string mal = "qwertyuiopasdfghjklzxcvbnm";
            string cif = "1234567890";
            string znak = "!@#$%^&*()-_+=";
            string pwd = PasswordPb.Password;

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
            else if (pwd.Length < 6)
            {
                MBClass.ErrorMB("Пароль должен содержать" +
                    " минимум 6 символов");
                PasswordPb.Focus();
                PasswordPb.Clear();
                PasswordDoublePb.Clear();
            }
            else if (zagl.IndexOfAny(pwd.ToCharArray()) == -1)
            {
                MBClass.ErrorMB("Пароль должен содержать" +
                    " минимум одну прописную букву");
                PasswordPb.Focus();
                PasswordPb.Clear();
                PasswordDoublePb.Clear();
            }
            else if (mal.IndexOfAny(pwd.ToCharArray()) == -1)
            {
                MBClass.ErrorMB("Пароль должен содержать" +
                    " минимум одну строчную букву");
                PasswordPb.Focus();
                PasswordPb.Clear();
                PasswordDoublePb.Clear();
            }
            else if (cif.IndexOfAny(pwd.ToCharArray()) == -1)
            {
                MBClass.ErrorMB("Пароль должен содержать" +
                    " минимум одну цифру");
                PasswordPb.Focus();
                PasswordPb.Clear();
                PasswordDoublePb.Clear();
            }
            else if (znak.IndexOfAny(pwd.ToCharArray()) == -1)
            {
                MBClass.ErrorMB("Пароль должен содержать" +
                    $" минимум один символ из {znak}");
                PasswordPb.Focus();
                PasswordPb.Clear();
                PasswordDoublePb.Clear();
            }
            else if (pwd.Length > 30)
            {
                MBClass.ErrorMB("Пароль может содержать" +
                    " максимум 30 символов");
                PasswordPb.Focus();
                PasswordPb.Clear();
                PasswordDoublePb.Clear();
            }
            else if (PasswordPb.Password != PasswordDoublePb.Password)
            {
                MBClass.ErrorMB("Пароли не совпадают");
                PasswordDoublePb.Focus();
                PasswordDoublePb.Clear();
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand("Insert Into dbo.[User] " +
                        "(LoginUser, PasswordUser,IdRole) " +
                        $"Values ('{LoginTb.Text}', '{PasswordPb.Password}',4)",
                        sqlConnection);
                    //sqlCommand.Parameters.AddWithValue("LoginUser", LoginTb.Text);
                    //sqlCommand.Parameters.AddWithValue("PasswordUser", PasswordPb.Password);
                    //sqlCommand.Parameters.AddWithValue("IdRole", 4);
                    sqlCommand.ExecuteNonQuery();
                    MBClass.InfoMB("Вы успешно зарегистрировались");
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
    }
}
