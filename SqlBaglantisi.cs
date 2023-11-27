using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Yonetim_Otomasyonu
{
    internal class SqlBaglantisi // Sınıf Adı.
    {
        public SqlConnection baglanti() // Metod adı.
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-OLQS08S\\MSSQLSERVER02;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            // Geriye dönün değeri tutan kısım.
            return baglan;

        }
    }
}
