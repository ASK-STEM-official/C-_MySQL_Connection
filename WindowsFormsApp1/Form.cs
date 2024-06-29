using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        // 登録ボタンのクリックイベント
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // ここにデータベース登録のロジックを追加する
            // string query = "INSERT INTO ...";
            MessageBox.Show("登録が完了しました！");
            this.Close();
        }
    }
}
