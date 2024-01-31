using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Esports
{
    public partial class DeleteScreen : Form
    {
        public DeleteScreen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonaldataScreen nextForm = new PersonaldataScreen();

            nextForm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                con.Open();
                using (SQLiteTransaction trans = con.BeginTransaction())
                {
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        // DELETE文
                        cmd.CommandText = "DELETE FROM player_in WHERE Player_id = @Player_id;";

                        // パラメータの型を DbType.String に設定
                        cmd.Parameters.Add(new SQLiteParameter("@Player_id", System.Data.DbType.String));

                        // パラメータの値をセット
                        cmd.Parameters["@Player_id"].Value = textBox1.Text;

                        // DELETE文の実行
                        int rowsAffected = cmd.ExecuteNonQuery();

                        trans.Commit();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("削除に成功しました。");

                            LoginScreen nextForm = new LoginScreen();
                            nextForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("削除に失敗しました。対象のデータが見つかりませんでした。", "エラー",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
        }
    }
}
