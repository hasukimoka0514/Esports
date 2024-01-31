
namespace Esports
{
    partial class LoginScreen
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Entrybutton = new System.Windows.Forms.Button();
            this.TextBoxID = new System.Windows.Forms.TextBox();
            this.TextBoxpwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OpenIndication = new System.Windows.Forms.CheckBox();
            this.Logoutbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(207, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "eスポーツエントリー";
            // 
            // Loginbutton
            // 
            this.Loginbutton.Location = new System.Drawing.Point(216, 340);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(193, 72);
            this.Loginbutton.TabIndex = 2;
            this.Loginbutton.Text = "ログイン";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.LoginButton);
            // 
            // Entrybutton
            // 
            this.Entrybutton.Location = new System.Drawing.Point(444, 340);
            this.Entrybutton.Name = "Entrybutton";
            this.Entrybutton.Size = new System.Drawing.Size(176, 72);
            this.Entrybutton.TabIndex = 3;
            this.Entrybutton.Text = "新規エントリー";
            this.Entrybutton.UseVisualStyleBackColor = true;
            this.Entrybutton.Click += new System.EventHandler(this.EntryButton);
            // 
            // TextBoxID
            // 
            this.TextBoxID.Location = new System.Drawing.Point(244, 152);
            this.TextBoxID.Name = "TextBoxID";
            this.TextBoxID.Size = new System.Drawing.Size(311, 22);
            this.TextBoxID.TabIndex = 4;
            // 
            // TextBoxpwd
            // 
            this.TextBoxpwd.Location = new System.Drawing.Point(244, 240);
            this.TextBoxpwd.Name = "TextBoxpwd";
            this.TextBoxpwd.Size = new System.Drawing.Size(311, 22);
            this.TextBoxpwd.TabIndex = 5;
            this.TextBoxpwd.UseSystemPasswordChar = true;
            this.TextBoxpwd.TextChanged += new System.EventHandler(this.TextBoxPwd);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(239, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(239, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "パスワード";
            // 
            // OpenIndication
            // 
            this.OpenIndication.AutoSize = true;
            this.OpenIndication.Location = new System.Drawing.Point(561, 240);
            this.OpenIndication.Name = "OpenIndication";
            this.OpenIndication.Size = new System.Drawing.Size(59, 19);
            this.OpenIndication.TabIndex = 8;
            this.OpenIndication.Text = "表示";
            this.OpenIndication.UseVisualStyleBackColor = true;
            this.OpenIndication.CheckedChanged += new System.EventHandler(this.OpenIndication_CheckedChanged);
            // 
            // Logoutbutton
            // 
            this.Logoutbutton.Font = new System.Drawing.Font("MS UI Gothic", 10F);
            this.Logoutbutton.Location = new System.Drawing.Point(12, 391);
            this.Logoutbutton.Name = "Logoutbutton";
            this.Logoutbutton.Size = new System.Drawing.Size(110, 47);
            this.Logoutbutton.TabIndex = 9;
            this.Logoutbutton.Text = "ログアウト";
            this.Logoutbutton.UseVisualStyleBackColor = true;
            this.Logoutbutton.Click += new System.EventHandler(this.LogoutButton);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logoutbutton);
            this.Controls.Add(this.OpenIndication);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxpwd);
            this.Controls.Add(this.TextBoxID);
            this.Controls.Add(this.Entrybutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.label1);
            this.Name = "LoginScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Entrybutton;
        private System.Windows.Forms.TextBox TextBoxID;
        private System.Windows.Forms.TextBox TextBoxpwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox OpenIndication;
        private System.Windows.Forms.Button Logoutbutton;
    }
}

