//-------------------------------------------
//#ChangeScreen#
//
//作成日：12月10日
//作成者：佐藤　基楽
//-------------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Esports
{
    public partial class Change : Form
    {
        public Change()
        {
            InitializeComponent();
        }
        private const string ConnectionString = "Data Source=Event.db";
       /// <summary>
       /// 会員情報変更
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void ChangeButton(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteTransaction trans = connection.BeginTransaction())
                {
                    using (SQLiteCommand cmd = connection.CreateCommand())
                    {
                        // SQLコマンド
                        cmd.CommandText = "UPDATE player_in SET player_name = @Player_name, game_event = @Game_event WHERE player_id = @Player_id";

                        // パラメーター
                        cmd.Parameters.Add(new SQLiteParameter("@Player_name", System.Data.DbType.String));
                        cmd.Parameters.Add(new SQLiteParameter("@Game_event", System.Data.DbType.String));
                        cmd.Parameters.Add(new SQLiteParameter("@Player_id", System.Data.DbType.String));

                        // データの代入
                        cmd.Parameters["@Player_name"].Value = BoxId.Text;
                        cmd.Parameters["@Game_event"].Value = ListBox.Text;
                        cmd.Parameters["@Player_id"].Value = PasswordBox.Text;

                        // クエリの実行
                        cmd.ExecuteNonQuery();

                        // トランザクションのコミット
                        trans.Commit();
                    }
                }
            }
        }
        /// <summary>
        /// 戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton(object sender, EventArgs e)
        {
            PersonaldataScreen nextForm = new PersonaldataScreen();

            nextForm.Show();

            this.Hide();
        }
    }
}