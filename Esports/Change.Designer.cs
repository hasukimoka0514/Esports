
namespace Esports
{
    partial class Change
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Changebutton = new System.Windows.Forms.Button();
            this.BoxId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ComboBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Loginbutton
            // 
            this.Changebutton.Location = new System.Drawing.Point(413, 150);
            this.Changebutton.Name = "Loginbutton";
            this.Changebutton.Size = new System.Drawing.Size(276, 171);
            this.Changebutton.TabIndex = 0;
            this.Changebutton.Text = "変更";
            this.Changebutton.UseVisualStyleBackColor = true;
            this.Changebutton.Click += new System.EventHandler(this.ChangeButton);
            // 
            // TextBoxID
            // 
            this.BoxId.Location = new System.Drawing.Point(137, 242);
            this.BoxId.Name = "TextBoxID";
            this.BoxId.Size = new System.Drawing.Size(189, 22);
            this.BoxId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "プレイヤー名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "競技名";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Items.AddRange(new object[] {
            "音ゲー",
            "FPS",
            "格ゲー",
            "ぷよぷよ"});
            this.ListBox.Location = new System.Drawing.Point(137, 298);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(121, 23);
            this.ListBox.TabIndex = 5;
            // 
            // TextBoxpwd
            // 
            this.PasswordBox.Location = new System.Drawing.Point(137, 113);
            this.PasswordBox.Name = "TextBoxpwd";
            this.PasswordBox.Size = new System.Drawing.Size(189, 22);
            this.PasswordBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(132, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "プレイヤーID確認";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(132, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "変更項目";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label5.Location = new System.Drawing.Point(289, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "情報変更";
            // 
            // Backbutton
            // 
            this.button2.Location = new System.Drawing.Point(26, 369);
            this.button2.Name = "Entrybutton";
            this.button2.Size = new System.Drawing.Size(128, 69);
            this.button2.TabIndex = 10;
            this.button2.Text = "戻る";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BackButton);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxId);
            this.Controls.Add(this.Changebutton);
            this.Name = "Change";
            this.Text = "change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.TextBox BoxId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ListBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}