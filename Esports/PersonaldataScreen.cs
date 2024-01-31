//-------------------------------------------
//#PersonaldataScreen#
//
//作成日：12月19日
//作成者：佐藤　基楽
//-------------------------------------------
using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Esports
{
    public partial class PersonaldataScreen : Form
    {
        /// <summary>
        /// ログイン会員クラス
        /// </summary>
       private string _userId = default;
        public PersonaldataScreen(string p_entry)
        {
            InitializeComponent();
            _userId = p_entry;
        }

        public PersonaldataScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 会員情報表示
        /// </summary>
        private void Personaldata_s_Load(object sender, EventArgs e)
        {
            // フォームが読み込まれたときにデータベースからデータを取得してラベルに表示
            UpdateLabelWithData();
        }
        private const string ConnectionString = "Data Source=Event.db";
        private void UpdateLabelWithData()
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand("SELECT player_name,game_event FROM player_in where p_entry = @entry", connection))
                {
                    command.Parameters.AddWithValue("@entry", _userId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // データベースから取得したデータをラベルに表示
                            PlayerNameLabel.Text = reader["player_name"].ToString();
                            CompetitionLabel.Text = reader["game_event"].ToString();
                        }
                    }
                }
            }
        }
        /// <summary>
        /// ホームに戻る
        /// </summary>
        private void MainBackButton(object sender, EventArgs e)
        {
            LoginScreen LoginForm = new LoginScreen();

            LoginForm.Show();

            this.Hide();
        }
        /// <summary>
        /// 会員情報削除フォーム移動
        /// </summary>
        private void CompetitionExitButton(object sender, EventArgs e)
        {
            MessageBox.Show("本当に脱退しますか？");
            DeleteScreen DeleteForm = new DeleteScreen();

            DeleteForm.Show();

            this.Hide();
        }
        /// <summary>
        /// 会員情報変更フォーム移動
        /// </summary>
        private void ChangeButton(object sender, EventArgs e)
        {
            Change ChangeForm = new Change();

            ChangeForm.Show();

            this.Hide();
        }
        /// <summary>
        /// 会員検索フォーム移動
        /// </summary>
        private void SearchButton(object sender, EventArgs e)
        {
            Search SearchForm = new Search();

            SearchForm.Show();

            this.Hide();
        }
    }
}
