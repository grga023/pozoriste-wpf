using System;
using System.Collections.Generic;
using System.Data;
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

namespace PozoristeSeminarski
{
    /// <summary>
    /// Interaction logic for Mesto.xaml
    /// </summary>
    public partial class Mesto : Window
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9MTV34K\SQLExpress;Initial Catalog=Pozoriste;Integrated Security=True");

        public Mesto()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open(); string query = "INSERT INTO Mesto (ptt, Naziv)VALUES(@PTT, @Naziv)"
                 ;
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Naziv", txtNaziv.Text);
                sqlCmd.Parameters.AddWithValue("@PTT", txtPTT.Text);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            Register dashboard = new Register();
            dashboard.Show();
            this.Close();
        }
    }
    
}
