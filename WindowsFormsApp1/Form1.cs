using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;

        public Form1()
        {
            InitializeComponent();
            InitializeMySqlConnection();
        }

        private void InitializeMySqlConnection()
        {
            string connectionString = DatabaseConfig.ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Surch_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM okane";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                // カラム名を日本語に変更
                NameConverter.ConvertColumnNames(dataTable);

                // 新しい列を追加
                dataTable.Columns.Add("班名", typeof(string));

                // 班の値を変換して新しい列に格納
                foreach (DataRow row in dataTable.Rows)
                {
                    int hanValue = Convert.ToInt32(row["班"]);
                    row["班名"] = NameConverter.ConvertHanToName(hanValue);
                }

                // 新しい列をDataGridViewに表示
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["班"].Visible = false; // 元の班カラムを非表示にする
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

        private void Submit_Click(object sender, EventArgs e)
        {
            // 新しい登録フォームを表示する
            RegistrationForm registrationForm = new RegistrationForm(connection);
            registrationForm.ShowDialog();
        }
    }
}
