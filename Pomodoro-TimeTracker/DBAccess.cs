using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Pomodoro_TimeTracker
{
    class DBAccess
    {
      static readonly string projectDir = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName; //běhový adresář (např. bin\Debug\net8.0), projektová složka = 3 úrovně výš z bin\Debug\netX
      static readonly string dbFilePath = Path.Combine(projectDir, @"mssql_dbFile.mdf");

      static readonly string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True";

      #region settings
      public static void UpdateSettings(int? pomodoroLengthSeconds = null, int? pauseLengthSeconds = null)
      {
         int pomodoro = pomodoroLengthSeconds ?? Settings.pomodoroLenghtSeconds;
         int pause = pauseLengthSeconds ?? Settings.pomodoroLenghtSeconds;

         string sql = @"IF EXISTS (SELECT 1 FROM Settings)
                  BEGIN
                      UPDATE Settings SET PomodoroLength = @PomodoroLength, PauseLength = @PauseLength;
                  END
                  ELSE
                  BEGIN
                      INSERT INTO Settings (PomodoroLength, PauseLength)
                      VALUES (@PomodoroLength, @PauseLength);
                  END";

         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
               cmd.Parameters.Add("@PomodoroLength", SqlDbType.Int).Value = pomodoro;
               cmd.Parameters.Add("@PauseLength", SqlDbType.Int).Value = pause;

               conn.Open();
               cmd.ExecuteNonQuery();
            }
         }

         //současně aktualizuj statické nastavení v paměti
         Settings.pomodoroLenghtSeconds = pomodoro;
         Settings.pauseLengthSeconds = pause;
      }

      public static void LoadSetting()
      {
         string sql = "SELECT 1 FROM Settings";

         using (SqlConnection conn = new SqlConnection(connectionString))
         {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
               conn.Open();

               using (SqlDataReader reader = cmd.ExecuteReader())
               {
                  if (reader.Read())
                  {
                     //Settings.pomodoroLenghtSeconds = reader.GetInt32(0); // sloupec 0 = PomodoroLength
                     //Settings.pauseLengthSeconds = reader.GetInt32(1);    // sloupec 1 = PauseLength1
                     Settings.pomodoroLenghtSeconds = Convert.ToInt32(reader["PomodoroLength"]);
                     Settings.pauseLengthSeconds = Convert.ToInt32(reader["PauseLength"]);
                  }
               }
            }
         }
      }

      #endregion



   }
}
