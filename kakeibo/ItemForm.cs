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
    public partial class ItemForm : Form
    {
        /// <summary>
        /// 変更ボタンで呼び出される登録画面の処理。
        /// </summary>
        /// <param name="dsCategory"></param>
        public ItemForm(CategoryDataSet dsCategory,
                        DateTime nowDate,
                        string category,
                        string item,
                        int money,
                        string remarks)
        {
            InitializeComponent();  //初期化処理
            categoryDataSet.Merge(dsCategory);
            monCalendar.SetDate(nowDate);
            cmbCategory.Text = category;
            txtItem.Text = item;
            mtxtMoney.Text = money.ToString();
            txtRemarks.Text = remarks;
        }

        /// <summary>
        /// 追加ボタンで呼び出される登録画面の処理。
        /// </summary>
        /// <param name="dsCategory"></param>
        public ItemForm(CategoryDataSet dsCategory)
        {
            InitializeComponent();  //初期化処理
            categoryDataSet.Merge(dsCategory);
        }

        /// <summary>
        /// 引数なしでのコンストラクタの呼び出しを禁止する。
        /// </summary>
        private void ItemForm_Load(object sender, EventArgs e)
        {
            // 引数なしのコンストラクタは使用しない
        }
    }
}
