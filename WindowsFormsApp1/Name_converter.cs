// データ名日本語にする
using System.Data;

namespace WindowsFormsApp1
{
    public static class NameConverter
    {
        public static string ConvertHanToName(int han)
        {
            switch (han)
            {
                case 1: return "Web";
                case 2: return "ロボ";
                case 3: return "Unity";
                case 4: return "ET";
                case 5: return "e-sports";
                case 6: return "動画制作";
                case 7: return "ガーデニング";
                case 8: return "業務用IT";
                case 9: return "その他";
                default: return "未知";
            }
        }
        public static void ConvertColumnNames(DataTable dataTable) // カラム名を日本語にすり替える
        {
            dataTable.Columns["ID"].ColumnName = "ID";
            dataTable.Columns["youto"].ColumnName = "用途";
            dataTable.Columns["han"].ColumnName = "班";
            dataTable.Columns["okane"].ColumnName = "利用金額";
            dataTable.Columns["zandaka"].ColumnName = "残高";
        }
    }
}

