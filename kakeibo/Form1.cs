using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kakeibo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 追加ボタンを押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddData();
        }

        /// <summary>
        /// 編集メニューの追加ボタンを押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 追加AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData();
        }


        /// <summary>
        /// サブルーチン。
        /// 入力されたデータを型付きデータセットに格納する。
        /// </summary>
        private void AddData()
        {
            ItemForm frmitem = new ItemForm(categoryDataSet1);
            DialogResult drRet = frmitem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                    frmitem.monCalendar.SelectionRange.Start,
                    frmitem.cmbCategory.Text,
                    frmitem.txtItem.Text,
                    int.Parse(frmitem.mtxtMoney.Text),
                    frmitem.txtRemarks.Text);
            }
        }

        /// <summary>
        /// categoryDataSet1のデータテーブルに分類データをセットする。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("給料", "入金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("食費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("雑費", "出金");
            categoryDataSet1.CategoryDataTable.AddCategoryDataTableRow("住居", "出金");
        }

        /// <summary>
        /// 終了ボタンをクリックしたときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 終了メニューを押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 終了XToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// サブルーチン。
        /// データを保存する処理。
        /// </summary>
        private void SaveData()
        {
            string path = "MoneyData.csv";  //出力するファイル名
            string strData = "";            //1行分のデータ

            System.IO.StreamWriter sw = new System.IO.StreamWriter(
                    path,
                    false,
                    System.Text.Encoding.Default);
            foreach (MoneyDataSet.moneyDataTableRow drMoney
                        in moneyDataSet.moneyDataTable)
            {
                strData = drMoney.日付.ToShortDateString() + ","
                        + drMoney.分類 + ","
                        + drMoney.品名 + ","
                        + drMoney.金額.ToString() + ","
                        + drMoney.備考;
                sw.WriteLine(strData);
            }
            sw.Close();
        }

        /// <summary>
        /// 保存メニューを選択したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// フォームを終了したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// サブルーチン。
        /// Form1クラスにデータを読み込む。
        /// </summary>
        private void LoadData()
        {
            string path = "MoneyData.csv";  //ロードするファイル名
            string delimStr = ",";          //区切り文字
            char[] delimiter = delimStr.ToCharArray();  //区切り文字をまとめる
            string[] strData;               //分解後の文字の入れ物
            string strLine;                 //1行分のデータ
            bool fileExists = System.IO.File.Exists(path);  //ファイルが存在するかの確認
            if (fileExists)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(
                                                path,
                                                System.Text.Encoding.Default);
                while (sr.Peek() >= 0)
                {
                    strLine = sr.ReadLine();
                    strData = strLine.Split(delimiter);
                    moneyDataSet.moneyDataTable.AddmoneyDataTableRow(
                                                DateTime.Parse(strData[0]),
                                                strData[1],
                                                strData[2],
                                                int.Parse(strData[3]),
                                                strData[4]);
                }
                sr.Close();
            }
        }

        /// <summary>
        /// サブルーチン。
        /// 変更する値を登録画面のインスタンスに渡す。
        /// </summary>
        private void UpdateData()
        {
            int nowRow = dgv.CurrentRow.Index;
            DateTime oldDate
                    = DateTime.Parse(dgv.Rows[nowRow].Cells[0].Value.ToString());
            string oldCategory = dgv.Rows[nowRow].Cells[1].Value.ToString();
            string oldItem = dgv.Rows[nowRow].Cells[2].Value.ToString();
            int oldMoney = int.Parse(dgv.Rows[nowRow].Cells[3].Value.ToString());
            string oldRemarks = dgv.Rows[nowRow].Cells[4].Value.ToString();
            ItemForm frmItem = new ItemForm(categoryDataSet1,
                                            oldDate,
                                            oldCategory,
                                            oldItem,
                                            oldMoney,
                                            oldRemarks);
            DialogResult drRet = frmItem.ShowDialog();
            if (drRet == DialogResult.OK)
            {
                dgv.Rows[nowRow].Cells[0].Value = frmItem.monCalendar.SelectionRange.Start;
                dgv.Rows[nowRow].Cells[1].Value = frmItem.cmbCategory.Text;
                dgv.Rows[nowRow].Cells[2].Value = frmItem.txtItem.Text;
                dgv.Rows[nowRow].Cells[3].Value = int.Parse(frmItem.mtxtMoney.Text);
                dgv.Rows[nowRow].Cells[4].Value = frmItem.txtRemarks.Text;
            }
        }

        /// <summary>
        /// 変更ボタンを押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnChange_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        /// <summary>
        /// 変更メニューを押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 変更CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        /// <summary>
        /// サブルーチン。
        /// 選択された行のデータを削除する。
        /// </summary>
        private void DeleteData()
        {
            int nowRow = dgv.CurrentRow.Index;
            dgv.Rows.RemoveAt(nowRow);  //現在行を削除
        }

        /// <summary>
        /// 削除ボタンを押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        /// <summary>
        /// 削除メニューを押したときの処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 削除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        /// <summary>
        /// サブルーチン。
        /// 日付ごとに出金合計を集計する。
        /// </summary>
        private void CalcSummary()
        {
            string expression;
            SummaryDataSet.SumDataTable.Clear();
            foreach (MoneyDataSet.moneyDataTableRow drMoney
                    in moneyDataSet.moneyDataTable)
            {
                expression = "日付= '" + drMoney.日付.ToShortDateString() + "'";
                SummaryDataSet.SumDataTableRow[] curDR
                    = (SummaryDataSet.SumDataTableRow[])
                        SummaryDataSet.SumDataTable.Select(expression);
                if (curDR.Length == 0)
                {
                    CategoryDataSet.CategoryDataTableRow[] selectedDataRow;
                    selectedDataRow = (CategoryDataSet.CategoryDataTableRow[])
                                        categoryDataSet1.CategoryDataTable.Select(
                                            "分類='" + drMoney.分類 + "'");
                    if (selectedDataRow[0].入出金分類 == "入金")
                    {
                        SummaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
                                                                        drMoney.金額,
                                                                        0);
                    }
                    else if (selectedDataRow[0].入出金分類 == "出金")
                    {
                        SummaryDataSet.SumDataTable.AddSumDataTableRow(drMoney.日付,
                                                                        0,
                                                                        drMoney.金額);
                    }
                }
                else
                {
                    CategoryDataSet.CategoryDataTableRow[] selectedDataRow;
                    selectedDataRow = (CategoryDataSet.CategoryDataTableRow[])
                                        categoryDataSet1.CategoryDataTable.Select(
                                            "分類='" + drMoney.分類 + "'");
                    if (selectedDataRow[0].入出金分類 == "入金")
                    {
                        curDR[0].入金合計 += drMoney.金額;
                    }
                    else if (selectedDataRow[0].入出金分類 == "出金")
                    {
                        curDR[0].出金合計 += drMoney.金額;
                    }
                }
            }
        }

        /// <summary>
        /// 集計表示タブに切り替えたときに呼び出される処理。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSummary();
        }

        /// <summary>
        /// 一覧表示メニューを押したときの処理。
        /// タブの画面を切り替える。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 一覧表示LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabList);
        }

        /// <summary>
        /// 集計表示メニューを押したときの処理。
        /// タブの画面を切り替える。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 集計表示SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabSummary);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ファイルFToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tabList_Click(object sender, EventArgs e)
        {
        }

    }
}
