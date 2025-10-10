using System.Configuration;
using System.Data.SqlClient;

namespace PTS
{
    public static class VeritabaniBaglantisi
    {
        private static readonly string baglantiCumlesi = ConfigurationManager.ConnectionStrings["PtsConnectionString"].ConnectionString;
        public static SqlConnection BaglantiGetir()
        {
            return new SqlConnection(baglantiCumlesi);
        }
    }
}