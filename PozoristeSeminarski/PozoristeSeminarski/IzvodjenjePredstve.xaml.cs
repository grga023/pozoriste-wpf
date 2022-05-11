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
    /// Interaction logic for IzvodjenjePredstve.xaml
    /// </summary>
    public partial class IzvodjenjePredstve : Window
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-9MTV34K\SQLExpress;Initial Catalog=Pozoriste;Integrated Security=True");


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

        private List<PredstavaModel> GetPredstave()
        {
            List<PredstavaModel> results = new List<PredstavaModel>();
            DataSet predstave = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("SELECT * FROM Predstave", sqlCon);
                adapter.Fill(predstave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            foreach (DataRow row in predstave.Tables[0].Rows)
            {
                results.Add(new PredstavaModel
                {
                    ID = (int)row["ID"],
                    Naziv = (string)row["Naziv"]
                });
            }
            return results;
        }

        private List<SalaModel> GetSale()
        {
            List<SalaModel> results = new List<SalaModel>();
            DataSet Sale = new DataSet();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand("SELECT * FROM Sala", sqlCon);
                adapter.Fill(Sale);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            foreach (DataRow row in Sale.Tables[0].Rows)
            {
                results.Add(
                    new SalaModel
                    {
                        ID = (int)row["ID"],
                        Ime = (string)row["Ime"]
                    }
                );
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


        public IzvodjenjePredstve()
        {
            InitializeComponent();
            ID.ItemsSource = getID();
            NazivPredstave.ItemsSource = GetPredstave();
            NazivPredstave.DisplayMemberPath = "Naziv";
            NazivSale.ItemsSource = GetSale();
            NazivSale.DisplayMemberPath = "Ime";
            LoadDataGrid();
        }

        private void btnPozorista_Click(object sender, RoutedEventArgs e)
        {
            Pozorista dashboard = new Pozorista();
            dashboard.Show();
            this.Close();
        }

        private void btnPredstave_Click(object sender, RoutedEventArgs e)
        {
            Predstava dashboard = new Predstava();
            dashboard.Show();
            this.Close();
        }

        private void btnSale_Click(object sender, RoutedEventArgs e)
        {
            Sale dashboard = new Sale();
            dashboard.Show();
            this.Close();
        }

        private void btnSedista_Click(object sender, RoutedEventArgs e)
        {
            Sedista dashboard = new Sedista();
            dashboard.Show();
            this.Close();
        }

        private void txtLogout_Click(object sender, RoutedEventArgs e)
        {
            Login dashboard = new Login();
            dashboard.Show();
            this.Close();
        }

        private void BtnDodaj_Click(object sender, RoutedEventArgs e)
        {
            PredstavaModel selectedPredstava = (PredstavaModel)NazivPredstave.SelectedItem;
            SalaModel selectedSala = (SalaModel)NazivSale.SelectedItem;
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "INSERT INTO IzvodjenjePredstave(ID_P, ID_S, VremeIzvodjenja) VALUES(@ID_P, @ID_S, @Vreme)";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_S", selectedSala.ID);
                sqlCmd.Parameters.AddWithValue("@ID_P", selectedPredstava.ID);
                sqlCmd.Parameters.AddWithValue("@Vreme", Vreme.SelectedDate);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                LoadDataGrid();
            }

            IzvodjenjePredstve dashboard = new IzvodjenjePredstve();
            dashboard.Show();
            this.Close();

        }

        private void BtnIzmeni_Click(object sender, RoutedEventArgs e)
        {
            PredstavaModel selectedPredstava = (PredstavaModel)NazivPredstave.SelectedItem;
            SalaModel selectedSala = (SalaModel)NazivSale.SelectedItem;

            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "UPDATE IzvodjenjePredstave SET ID_P=@ID_P, ID_S=@ID_S, VremeIzvodjenja=@Vreme WHERE ID = " + ID.SelectedItem + "";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@ID_S", selectedSala.ID);
                sqlCmd.Parameters.AddWithValue("@ID_P", selectedPredstava.ID);
                sqlCmd.Parameters.AddWithValue("@Vreme", Vreme.SelectedDate); ;
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    MessageBox.Show("Podatci su uspesno promenjeni");
                    LoadDataGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                LoadDataGrid();
            }

            IzvodjenjePredstve dashboard = new IzvodjenjePredstve();
            dashboard.Show();
            this.Close();

        }

        private void BtnObrisi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();
                string query = "DELETE FROM IzvodjenjePredstave WHERE ID = " + ID.SelectedItem + "";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = CommandType.Text;
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
                LoadDataGrid();
            }

            IzvodjenjePredstve dashboard = new IzvodjenjePredstve();
            dashboard.Show();
            this.Close();
        }
        
        private void ID_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            /*
            int SelectedID = (int)ID.SelectedItem;

            sqlCon.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT IzvodjenjePredstave.*,Predstave.Naziv as NazivPredstave,Sala.Ime as NazivSale FROM " +
                "IzvodjenjePredstave,Sala, predstave WHERE IzvodjenjePredstave.ID_P = Sala.ID AND IzvodjenjePredstave.ID_P = Predstave.ID";
            cmd.Connection = sqlCon;
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable("IzvodjenjePredstave");
            dataAdapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (PredstavaModel PredstavaModel in NazivPredstave.Items)
                {
                    List<PredstavaModel> lista = new List<PredstavaModel>();
                    if (PredstavaModel.ID == (int)row["ID_P"])
                    {
                        lista.Add(PredstavaModel);
                        NazivPredstave.ItemsSource = lista;
                        NazivPredstave.SelectedIndex = 0;
                    }
                }
                foreach (SalaModel SalaModel in NazivSale.Items)
                {
                    List<SalaModel> lista = new List<SalaModel>();
                    if (SalaModel.ID == (int)row["ID_S"])
                    {
                        lista.Add(SalaModel);
                        NazivSale.ItemsSource = lista;
                        NazivSale.SelectedIndex = 0;
                    }
                }
            }

            sqlCon.Close();
            */
        }
    }
}
