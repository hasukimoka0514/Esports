using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Esports
{
    public partial class TableScreen : Form
    {
        public TableScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //コネクションを開いてテーブル制作を閉じる
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                con.Open();
                using (SQLiteCommand command = con.CreateCommand())
                {
                    command.CommandText = "create table if not exists player_in(P_ENTRY INTEGER PRIMARY KEY AUTOINCREMENT, player_id TEXT, player_name TEXT, password TEXT, game_event TEXT)";
                    command.ExecuteNonQuery();
                    Console.WriteLine("テーブル");
                }

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "INSERT INTO  player_in (player_id,password) VALUES (@Player_id, @Password)";
                    //パラメータセット
                    cmd.Parameters.Add("Player_id", System.Data.DbType.String);
                    cmd.Parameters.Add("Password", System.Data.DbType.String);
                    //データ追加
                    cmd.Parameters["Player_id"].Value = textBox1.Text;
                    cmd.Parameters["Password"].Value = textBox2.Text;
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                //dataTableを生成します。
                var dataTable = new DataTable();
                //SQLの実行
                var adapter = new SQLiteDataAdapter("SELECT * FROM player_in", con);
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = default;
            if(!int.TryParse(textBox3.Text,out num))
            {
                return;
            }
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "UPDATE player_in set player_id = @Player_up, password = @Price WHERE P_ENTRY = @Cd";
                    //パラメータセット
                    cmd.Parameters.Add("Player_up", System.Data.DbType.String);
                    cmd.Parameters.Add("Price", System.Data.DbType.String);
                    cmd.Parameters.Add("Cd", System.Data.DbType.Int64);
                    //データ追加
                    cmd.Parameters["Player_up"].Value = textBox4.Text;
                    cmd.Parameters["Price"].Value = textBox5.Text;
                    cmd.Parameters["P_ENTRY"].Value = num;
                    Console.WriteLine(num + "P_ENTRY");
                    int er = cmd.ExecuteNonQuery();
                    Console.WriteLine(er);
                    //コミット
                    trans.Commit();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    SQLiteCommand cmd = con.CreateCommand();
                    //インサート
                    cmd.CommandText = "DELETE FROM player_in WHERE P_ENTRY = @P_ENTRY;";
                    //パラメータセット
                    cmd.Parameters.Add("P_ENTRY", System.Data.DbType.Int64);
                    //データ削除
                    cmd.Parameters["P_ENTRY"].Value = int.Parse(textBox6.Text);
                    cmd.ExecuteNonQuery();
                    //コミット
                    trans.Commit();
                }
            }
        }
    }
}
