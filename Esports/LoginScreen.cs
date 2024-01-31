//-------------------------------------------
//#LoginScreen#
//
//作成日：12月2日
//作成者：佐藤　基楽
//-------------------------------------------
using System;
using System.Windows.Forms;

namespace Esports
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 会員登録フォームに移動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EntryButton(object sender, EventArgs e)
        {
            // 移動先のフォームのインスタンスを作成
            //新規登録画面に移動
            SignUp nextForm = new SignUp();

            nextForm.Show();

            this.Hide();
        }

      /// <summary>
      /// ログイン
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void LoginButton(object sender, EventArgs e)
        {
            Login login = new Login();
            string username = TextBoxID.Text;
            string password = TextBoxpwd.Text;
            string p_entry = login.AuthenticateUser(username, password);
            if (p_entry != null)
            {
                PersonaldataScreen nextForm = new PersonaldataScreen(p_entry);

                nextForm.Show();

                this.Hide();
                // ここでメインアプリケーション画面に遷移するなどの処理を追加

            }
            else
            {
                MessageBox.Show("ログイン失敗。ユーザー名またはパスワードが正しくありません。");
            }
        }
        
        private void TextBoxPwd(object sender, EventArgs e)
        {
            string logText = TextBoxpwd.Text;
            // 別のコントロールやコンソールにログを表示する
            Console.Write("入力されたログ:\n" + logText, "ログの確認");
        }
        /// <summary>
        /// チェックボックスによるパスワード表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenIndication_CheckedChanged(object sender, EventArgs e)
        {
            // パスワードを表示する
            string password = TextBoxpwd.Text;

            TextBoxpwd.UseSystemPasswordChar = !TextBoxpwd.UseSystemPasswordChar;
        }
        /// <summary>
        /// ログアウト
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton(object sender, EventArgs e)
        {
            // プログラムを終了する
            Application.Exit();
        }
    }
}
