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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private string role = "Admin";
        public int UrID;

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9MTV34K\SQLExpress;Initial Catalog=Pozoriste;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }
        public void btnLogovanje_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string queryAdmin = "SELECT COUNT(*) FROM Korisnik WHERE username = @USERNAME AND password = @PASSWORD AND role = '"+role+"'";
                string queryUsr = "SELECT COUNT(*),ID FROM Korisnik WHERE username = @USERNAME AND password = @PASSWORD GROUP BY ID";
                string queryID = "SELECT ID FROM Korisnik WHERE username = @USERNAME AND password = @PASSWORD ";

                SqlCommand sqlCmdAdmin = new SqlCommand(queryAdmin, sqlCon);
                sqlCmdAdmin.CommandType = CommandType.Text;
                sqlCmdAdmin.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                sqlCmdAdmin.Parameters.AddWithValue("@PASSWORD", txtPassword.Password);
                int count = Convert.ToInt32(sqlCmdAdmin.ExecuteScalar());
                if(count == 1)
                {
                    Pozorista dashboard = new Pozorista();
                    dashboard.Show();
                    this.Close();
                }
                else
                {
                    SqlCommand sqlCmdUsr = new SqlCommand(queryUsr, sqlCon);
                    sqlCmdUsr.CommandType = CommandType.Text;
                    sqlCmdUsr.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                    sqlCmdUsr.Parameters.AddWithValue("@PASSWORD", txtPassword.Password);
                    int countUsr = Convert.ToInt32(sqlCmdUsr.ExecuteScalar());
                    if (countUsr == 1)
                    {
                        SqlCommand sqlCmdID = new SqlCommand(queryID, sqlCon);
                        sqlCmdID.CommandType = CommandType.Text;
                        sqlCmdID.Parameters.AddWithValue("@USERNAME", txtUsername.Text);
                        sqlCmdID.Parameters.AddWithValue("@PASSWORD", txtPassword.Password);
                        UrID = Convert.ToInt32(sqlCmdID.ExecuteScalar());

                        KorisnikPregled dashboard = new KorisnikPregled(UrID);
                        dashboard.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("User name ili password nisu dobro uneti. Pokusajte ponovo.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close(); 
            }
        }

        public void btnRegistracija_Click(object sender, RoutedEventArgs e)
        {
            Register dashboard = new Register();
            dashboard.Show();
            this.Close();
        }

    }
}
