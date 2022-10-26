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
    class DGClass
    {
        SqlConnection sqlConnection =
             new SqlConnection(@"Data Source=10.128.14.48\SQLEXPRESS;
                                Initial Catalog=user45;
                                Persist Security Info=True;
                                User ID=user45;
                                Password=wsruser45");
        SqlDataAdapter sqlDataAdapter;
        DataGrid dataGrid;
        DataTable dataTable;

        public DGClass(DataGrid dataGrid)
        {
            this.dataGrid=dataGrid;
        }

        public void LoadDG(string sqlCommand)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter=new SqlDataAdapter(sqlCommand,
                    sqlConnection);
                dataTable=new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGrid.ItemsSource=dataTable.DefaultView;
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
