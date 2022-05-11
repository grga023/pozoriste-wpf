using PozoristeSeminarski.Models;
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
    /// Interaction logic for KorisnikPregled.xaml
    /// </summary>
    public partial class KorisnikPregled : Window
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9MTV34K\SQLExpress;Initial Catalog=Pozoriste;Integrated Security=True");

        private int UsrId;

        private List<int> getID()
        {
            List<int> results = new List<int>();
            DataSet IDs = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("SELECT ID FROM IzvodjenjePredstave", sqlCon);
                adapter.Fill(IDs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            foreach (DataRow row in IDs.Tables[0].Rows)
            {
                results.Add((int)row["ID"]);
            }
            return results;
        }

        private void LoadDataGrid()
        {
            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT IzvodjenjePredstave.*,Predstave.Naziv as NazivPredstave,Sala.Ime as NazivSale FROM " +
                "IzvodjenjePredstave,Sala, predstave WHERE IzvodjenjePredstave.ID_P = Sala.ID AND IzvodjenjePredstave.ID_P = Predstave.ID";
            cmd.Connection = sqlCon;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable("IzvodjenjePredstave");
            dataAdapter.Fill(dataTable);
            IzvodjenjeDataGrid.ItemsSource = new DataView(dataTable);
            sqlCon.Close();
        }

        public KorisnikPregled(int UrID)
        {
            this.UsrId = UrID;
            InitializeComponent();
            Predstava.ItemsSource = getID();
            LoadDataGrid();
        }

        private void btnRezervisi_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "INSERT INTO Rezervacije(ID_I, ID_K) VALUES(@ID_I, @ID_K)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_I", Predstava.SelectedItem);
                sqlCmd.Parameters.AddWithValue("@ID_K", UsrId);
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
        }
    }
}
