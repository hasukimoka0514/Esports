using System.Data.SQLite;


namespace Esports
{
    public class Login
    {
        private const string ConnectionString = "Data Source=Event.db"; // データベースへの接続文字列を設定
        public string AuthenticateUser(string player_id, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string query = "SELECT P_ENTRY FROM player_in WHERE player_id = @Username AND password = @Password";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", player_id);
                    command.Parameters.AddWithValue("@Password", password);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // ログイン成功時に p_entry の値を取得
                            string pEntryValue = reader["P_ENTRY"].ToString();
                            return pEntryValue;
                        }
                    }

                    // ログイン失敗時は null を返すか、適切な処理を行う
                    return null;
                }
            }
        }
    }
}
