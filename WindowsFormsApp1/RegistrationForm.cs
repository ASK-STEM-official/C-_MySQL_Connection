using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    public partial class RegistrationForm : Form
    {
        private MySqlConnection connection;

        public RegistrationForm(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            InitializeHanComboBox();
        }

        private void InitializeHanComboBox()// 下にでろろろろって出る奴のラベル設定
        {
            hanComboBox.Items.AddRange(new string[]
            {
                "Web", "ロボ", "Unity", "ET", "e-sports", "動画制作", "ガーデニング", "業務用IT", "その他"
            });
        }

        private void registerButton_Click(object sender, EventArgs e)// クエリをぶちたたくボタンの制御
        {
            string youto = youtoTextBox.Text;
            string hanName = hanComboBox.SelectedItem?.ToString();
            int han = ConvertHanToInt(hanName);
            int okane;

            if (!int.TryParse(okaneTextBox.Text, out okane))
            {
                MessageBox.Show("お金の金額が無効です。");
                return;
            }

            try
            {
                connection.Open();

                // 最新の残高を取得
                string getZandakaQuery = "SELECT IFNULL(zandaka, 0) FROM okane ORDER BY id DESC LIMIT 1";
                MySqlCommand getZandakaCmd = new MySqlCommand(getZandakaQuery, connection);
                int lastZandaka = Convert.ToInt32(getZandakaCmd.ExecuteScalar());

                int newZandaka = lastZandaka - okane;

                // 新しいレコードを挿入
                string insertQuery = "INSERT INTO okane (youto, han, okane, zandaka) VALUES (@youto, @han, @okane, @zandaka)";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@youto", youto);
                insertCmd.Parameters.AddWithValue("@han", han);
                insertCmd.Parameters.AddWithValue("@okane", okane);
                insertCmd.Parameters.AddWithValue("@zandaka", newZandaka);

                insertCmd.ExecuteNonQuery();
                MessageBox.Show("データが正常に登録されました。");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"エラーが発生しました: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private int ConvertHanToInt(string hanName) //ここでしか使わないと思うのでローカル宣言
        {
            switch (hanName)
            {
                case "Web": return 1;
                case "ロボ": return 2;
                case "Unity": return 3;
                case "ET": return 4;
                case "e-sports": return 5;
                case "動画制作": return 6;
                case "ガーデニング": return 7;
                case "業務用IT": return 8;
                case "その他": return 9;
                default: throw new Exception("無効な班名です");
            }
        }

        // 自動生成されて消せなくなっちゃった方々

        private void youtoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void okaneTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
