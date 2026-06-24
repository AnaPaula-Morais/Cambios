namespace Cambios.Servicos
{
    using Modelos;
    using Microsoft.Data.Sqlite;
    public class DataService
    {
        private SqliteConnection connection;
        private SqliteCommand command;
        private DialogService dialogService;

        public DataService()
        {
            dialogService = new DialogService();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");

            }

            var path = @"Data\Rates.sqlite";

            try
            {
                connection = new SqliteConnection("Data Source = " + path);
                connection.Open();

                string sqlcommand =
                    "CREATE TABLE IF NOT EXISTS rates(RateId int, Code varchar(5), TaxRate real," +
                    "Name varchar(250))";
                command = new SqliteCommand(sqlcommand, connection);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
            }
        }

        public void SaveData(List<Rate> Rates)
        {
            try
            {
                foreach (var rate in Rates)
                {
                    string sql = string.Format("INSERT INTO Rates(RateId, Code, TaxRate, Name) values ({0},'{1}',{2},'{3}')",
                        rate.RateId, rate.Code, rate.TaxRate, rate.Name);
                    command = new SqliteCommand(sql, connection);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
            }
        }

        public List<Rate> GetData()
        {
            List<Rate> rates = new List<Rate>();
            try
            {
                string sql = "SELECT RateId, Code, TaxRate, Name FROM Rates";
                command = new SqliteCommand(sql, connection);

                //Ler cada registo/linha da tabela
                SqliteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    rates.Add(new Rate
                    {
                        RateId = Convert.ToInt32(reader["RateId"]),
                        Code = Convert.ToString(reader["Code"]),
                        TaxRate = Convert.ToDouble(reader["TaxRate"]),
                        Name = Convert.ToString(reader["Name"]),
                    });
                }
                connection.Close();
                return rates;

            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
                return null;
            }
        }

        public void DeleteData()
        {
            try
            {
                string sql = "DELETE FROM Rates";
                command = new SqliteCommand(sql, connection);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Erro", e.Message);
            }
        }
    }
}
