using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Esports
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonaldataScreen nextForm = new PersonaldataScreen();

            nextForm.Show();

            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // SQLの実行
            using (SQLiteConnection con = new SQLiteConnection("Data Source=Event.db"))
            {
                con.Open();

                using (SQLiteCommand cmd = con.CreateCommand())
                {
                    // SQLクエリ
                    cmd.CommandText = "SELECT Player_name, Game_event FROM player_in WHERE Game_event=@event";

                    // パラメータの型を DbType.String に設定
                    cmd.Parameters.Add(new SQLiteParameter("@event", System.Data.DbType.String));

                    // パラメータの値をセット
                    cmd.Parameters["@event"].Value = comboBox1.Text;

                    // データ取得
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        // dataTableを生成します。
                        var dataTable = new DataTable();

                        // DataTableにデータをロード
                        dataTable.Load(reader);

                        // DataGridViewにDataTableをバインド
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }
    }
}
