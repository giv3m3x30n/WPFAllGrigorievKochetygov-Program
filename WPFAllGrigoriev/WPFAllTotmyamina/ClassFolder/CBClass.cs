using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFAllTotmyamina.ClassFolder
{
    class CBClass
    {
        SqlConnection sqlConnection =
            new SqlConnection(@"Data Source=10.128.14.48\SQLEXPRESS;
                                Initial Catalog=user45;
                                Persist Security Info=True;
                                User ID=user45;
                                Password=wsruser45");
        SqlDataReader dataReader;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataSet dataSet;

        public void LoadComboBoxRole(ComboBox comboBox)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("Select IdRole, NameRole " +
                    "From dbo.Role Order By IdRole ASC", sqlConnection);
                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Role");
                comboBox.ItemsSource = dataSet.Tables["Role"].DefaultView;
                comboBox.DisplayMemberPath = dataSet.Tables["Role"].Columns["NameRole"].ToString();
                comboBox.SelectedValuePath = dataSet.Tables["Role"].Columns["IdRole"].ToString();
            }
            catch(Exception ex)
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
