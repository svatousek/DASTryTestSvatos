using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DASTryTestSvatos
{
    public partial class MainWindow : Window
    {

        private static string connectionString = "Server=alaska;Database=23IB25_SVATOS;Trusted_Connection=True;TrustServerCertificate=True";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadMovies_Click(object sender, RoutedEventArgs e)
        {
            using SqlConnection conn = new SqlConnection(connectionString);

            string sql = "SELECT * FROM Movie";
            
            var data = conn.Query<Movie>(sql).ToList();

            MoviesDataGrid.ItemsSource = data;
        }
    }
}