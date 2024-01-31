using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Esports
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void ConfirmButton(object sender, EventArgs e)
        {
            // 必須フィールドが空でないか確認
            if (string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("すべてのフィールドを入力してください。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    // データベースへの挿入クエリを構築
                    string insertQuery = "INSERT INTO  player_in (player_id, player_name, password, game_event) " +
                                         "VALUES (@Player_id, @Player_name, @Password, @Game_event)";

                    // パラメータセット
                    SQLiteParameter[] parameters = {
                        new SQLiteParameter("@Player_id", DbType.String),
                        new SQLiteParameter("@Player_name", DbType.String),
                        new SQLiteParameter("@Password", DbType.String),
                        new SQLiteParameter("@Game_event", DbType.String)
                    };

                    // パラメータの値を設定
                    parameters[0].Value = textBox3.Text;
                    parameters[1].Value = textBox4.Text;
                    parameters[2].Value = textBox2.Text;
                    parameters[3].Value = comboBox1.Text;

                    // データベースへの挿入クエリを実行
                    ExecuteNonQuery(con, insertQuery, parameters);

                    // コミット
                    trans.Commit();
                    MessageBox.Show("登録を完了しました。");
                }
            }
        }

        private void ExecuteNonQuery(SQLiteConnection connection, string query, SQLiteParameter[] parameters)
        {
            using (SQLiteCommand cmd = connection.CreateCommand())
            {
                // SQLクエリの設定
                cmd.CommandText = query;

                // パラメータの設定
                cmd.Parameters.AddRange(parameters);

                // クエリの実行
                cmd.ExecuteNonQuery();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 選択肢が変更されたときの処理
            //string selectedValue = ListBox.SelectedItem.ToString();
            //MessageBox.Show("選択されたアイテム: " + selectedValue);
        }

        private void BackButton(object sender, EventArgs e)
        {
            LoginScreen nextForm = new LoginScreen();

            nextForm.Show();

            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // パスワードを表示する
            string password = textBox2.Text;

            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
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
    }
}

