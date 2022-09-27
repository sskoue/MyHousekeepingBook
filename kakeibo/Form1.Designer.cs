
namespace kakeibo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.保存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.編集EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.変更CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.削除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.表示VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.一覧表示LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.集計表示SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.moneyDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataSet = new kakeibo.MoneyDataSet();
            this.moneyDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgv = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.分類DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.金額DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.備考DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyDataTableBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.moneyDataSet1 = new kakeibo.MoneyDataSet();
            this.moneyDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDataSet1 = new kakeibo.CategoryDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabList = new System.Windows.Forms.TabPage();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.sumDgv = new System.Windows.Forms.DataGridView();
            this.日付DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.入金合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.出金合計DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumDataTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SummaryDataSet = new kakeibo.SummaryDataSet();
            this.sumDataTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabList.SuspendLayout();
            this.tabSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sumDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.編集EToolStripMenuItem,
            this.表示VToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1407, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.保存SToolStripMenuItem,
            this.終了XToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(98, 32);
            this.toolStripMenuItem1.Text = "ファイル(&F)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(168, 6);
            // 
            // 保存SToolStripMenuItem
            // 
            this.保存SToolStripMenuItem.Name = "保存SToolStripMenuItem";
            this.保存SToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.保存SToolStripMenuItem.Text = "保存(&S)";
            this.保存SToolStripMenuItem.Click += new System.EventHandler(this.保存SToolStripMenuItem_Click);
            // 
            // 終了XToolStripMenuItem1
            // 
            this.終了XToolStripMenuItem1.Name = "終了XToolStripMenuItem1";
            this.終了XToolStripMenuItem1.Size = new System.Drawing.Size(171, 34);
            this.終了XToolStripMenuItem1.Text = "終了(&X)";
            this.終了XToolStripMenuItem1.Click += new System.EventHandler(this.終了XToolStripMenuItem1_Click);
            // 
            // 編集EToolStripMenuItem
            // 
            this.編集EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.追加AToolStripMenuItem,
            this.変更CToolStripMenuItem,
            this.削除DToolStripMenuItem});
            this.編集EToolStripMenuItem.Name = "編集EToolStripMenuItem";
            this.編集EToolStripMenuItem.Size = new System.Drawing.Size(83, 32);
            this.編集EToolStripMenuItem.Text = "編集(&E)";
            // 
            // 追加AToolStripMenuItem
            // 
            this.追加AToolStripMenuItem.Name = "追加AToolStripMenuItem";
            this.追加AToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.追加AToolStripMenuItem.Text = "追加(&A)";
            this.追加AToolStripMenuItem.Click += new System.EventHandler(this.追加AToolStripMenuItem_Click);
            // 
            // 変更CToolStripMenuItem
            // 
            this.変更CToolStripMenuItem.Name = "変更CToolStripMenuItem";
            this.変更CToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.変更CToolStripMenuItem.Text = "変更(&C)";
            this.変更CToolStripMenuItem.Click += new System.EventHandler(this.変更CToolStripMenuItem_Click);
            // 
            // 削除DToolStripMenuItem
            // 
            this.削除DToolStripMenuItem.Name = "削除DToolStripMenuItem";
            this.削除DToolStripMenuItem.Size = new System.Drawing.Size(173, 34);
            this.削除DToolStripMenuItem.Text = "削除(&D)";
            this.削除DToolStripMenuItem.Click += new System.EventHandler(this.削除DToolStripMenuItem_Click);
            // 
            // 表示VToolStripMenuItem
            // 
            this.表示VToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.一覧表示LToolStripMenuItem,
            this.集計表示SToolStripMenuItem});
            this.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem";
            this.表示VToolStripMenuItem.Size = new System.Drawing.Size(85, 32);
            this.表示VToolStripMenuItem.Text = "表示(&V)";
            // 
            // 一覧表示LToolStripMenuItem
            // 
            this.一覧表示LToolStripMenuItem.Name = "一覧表示LToolStripMenuItem";
            this.一覧表示LToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.一覧表示LToolStripMenuItem.Text = "一覧表示(&L)";
            this.一覧表示LToolStripMenuItem.Click += new System.EventHandler(this.一覧表示LToolStripMenuItem_Click);
            // 
            // 集計表示SToolStripMenuItem
            // 
            this.集計表示SToolStripMenuItem.Name = "集計表示SToolStripMenuItem";
            this.集計表示SToolStripMenuItem.Size = new System.Drawing.Size(206, 34);
            this.集計表示SToolStripMenuItem.Text = "集計表示(&S)";
            this.集計表示SToolStripMenuItem.Click += new System.EventHandler(this.集計表示SToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.バージョン情報VToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(95, 32);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(237, 34);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 735);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 36);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(105, 735);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(93, 36);
            this.btnChange.TabIndex = 3;
            this.btnChange.Text = "変更";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(204, 735);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(303, 735);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(93, 36);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = "終了";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // moneyDataSetBindingSource
            // 
            this.moneyDataSetBindingSource.DataSource = this.moneyDataSet;
            this.moneyDataSetBindingSource.Position = 0;
            // 
            // moneyDataSet
            // 
            this.moneyDataSet.DataSetName = "MoneyDataSet";
            this.moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyDataSetBindingSource1
            // 
            this.moneyDataSetBindingSource1.DataSource = this.moneyDataSet;
            this.moneyDataSetBindingSource1.Position = 0;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn,
            this.分類DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.金額DataGridViewTextBoxColumn,
            this.備考DataGridViewTextBoxColumn});
            this.dgv.DataSource = this.moneyDataTableBindingSource2;
            this.dgv.Location = new System.Drawing.Point(6, 6);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 27;
            this.dgv.Size = new System.Drawing.Size(1358, 723);
            this.dgv.TabIndex = 6;
            // 
            // 日付DataGridViewTextBoxColumn
            // 
            this.日付DataGridViewTextBoxColumn.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.日付DataGridViewTextBoxColumn.Name = "日付DataGridViewTextBoxColumn";
            this.日付DataGridViewTextBoxColumn.Width = 150;
            // 
            // 分類DataGridViewTextBoxColumn
            // 
            this.分類DataGridViewTextBoxColumn.DataPropertyName = "分類";
            this.分類DataGridViewTextBoxColumn.HeaderText = "分類";
            this.分類DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.分類DataGridViewTextBoxColumn.Name = "分類DataGridViewTextBoxColumn";
            this.分類DataGridViewTextBoxColumn.Width = 150;
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            this.品名DataGridViewTextBoxColumn.Width = 150;
            // 
            // 金額DataGridViewTextBoxColumn
            // 
            this.金額DataGridViewTextBoxColumn.DataPropertyName = "金額";
            this.金額DataGridViewTextBoxColumn.HeaderText = "金額";
            this.金額DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.金額DataGridViewTextBoxColumn.Name = "金額DataGridViewTextBoxColumn";
            this.金額DataGridViewTextBoxColumn.Width = 150;
            // 
            // 備考DataGridViewTextBoxColumn
            // 
            this.備考DataGridViewTextBoxColumn.DataPropertyName = "備考";
            this.備考DataGridViewTextBoxColumn.HeaderText = "備考";
            this.備考DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.備考DataGridViewTextBoxColumn.Name = "備考DataGridViewTextBoxColumn";
            this.備考DataGridViewTextBoxColumn.Width = 150;
            // 
            // moneyDataTableBindingSource2
            // 
            this.moneyDataTableBindingSource2.DataMember = "moneyDataTable";
            this.moneyDataTableBindingSource2.DataSource = this.moneyDataSet;
            // 
            // moneyDataTableBindingSource1
            // 
            this.moneyDataTableBindingSource1.DataMember = "moneyDataTable";
            this.moneyDataTableBindingSource1.DataSource = this.moneyDataSet1;
            // 
            // moneyDataSet1
            // 
            this.moneyDataSet1.DataSetName = "MoneyDataSet";
            this.moneyDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // moneyDataTableBindingSource
            // 
            this.moneyDataTableBindingSource.DataMember = "moneyDataTable";
            this.moneyDataTableBindingSource.DataSource = this.moneyDataSet1;
            // 
            // categoryDataSet1
            // 
            this.categoryDataSet1.DataSetName = "CategoryDataSet";
            this.categoryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabList);
            this.tabControl1.Controls.Add(this.tabSummary);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1383, 815);
            this.tabControl1.TabIndex = 7;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabList
            // 
            this.tabList.Controls.Add(this.dgv);
            this.tabList.Controls.Add(this.btnAdd);
            this.tabList.Controls.Add(this.btnEnd);
            this.tabList.Controls.Add(this.btnChange);
            this.tabList.Controls.Add(this.btnDelete);
            this.tabList.Location = new System.Drawing.Point(4, 28);
            this.tabList.Name = "tabList";
            this.tabList.Padding = new System.Windows.Forms.Padding(3);
            this.tabList.Size = new System.Drawing.Size(1375, 783);
            this.tabList.TabIndex = 0;
            this.tabList.Text = "一覧表示";
            this.tabList.UseVisualStyleBackColor = true;
            this.tabList.Click += new System.EventHandler(this.tabList_Click);
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.sumDgv);
            this.tabSummary.Location = new System.Drawing.Point(4, 28);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(1375, 783);
            this.tabSummary.TabIndex = 1;
            this.tabSummary.Text = "集計表示";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // sumDgv
            // 
            this.sumDgv.AutoGenerateColumns = false;
            this.sumDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sumDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.日付DataGridViewTextBoxColumn1,
            this.入金合計DataGridViewTextBoxColumn,
            this.出金合計DataGridViewTextBoxColumn});
            this.sumDgv.DataSource = this.sumDataTableBindingSource1;
            this.sumDgv.Location = new System.Drawing.Point(6, 6);
            this.sumDgv.Name = "sumDgv";
            this.sumDgv.RowHeadersWidth = 62;
            this.sumDgv.RowTemplate.Height = 27;
            this.sumDgv.Size = new System.Drawing.Size(1359, 723);
            this.sumDgv.TabIndex = 0;
            // 
            // 日付DataGridViewTextBoxColumn1
            // 
            this.日付DataGridViewTextBoxColumn1.DataPropertyName = "日付";
            this.日付DataGridViewTextBoxColumn1.HeaderText = "日付";
            this.日付DataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.日付DataGridViewTextBoxColumn1.Name = "日付DataGridViewTextBoxColumn1";
            this.日付DataGridViewTextBoxColumn1.Width = 150;
            // 
            // 入金合計DataGridViewTextBoxColumn
            // 
            this.入金合計DataGridViewTextBoxColumn.DataPropertyName = "入金合計";
            this.入金合計DataGridViewTextBoxColumn.HeaderText = "入金合計";
            this.入金合計DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.入金合計DataGridViewTextBoxColumn.Name = "入金合計DataGridViewTextBoxColumn";
            this.入金合計DataGridViewTextBoxColumn.Width = 150;
            // 
            // 出金合計DataGridViewTextBoxColumn
            // 
            this.出金合計DataGridViewTextBoxColumn.DataPropertyName = "出金合計";
            this.出金合計DataGridViewTextBoxColumn.HeaderText = "出金合計";
            this.出金合計DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.出金合計DataGridViewTextBoxColumn.Name = "出金合計DataGridViewTextBoxColumn";
            this.出金合計DataGridViewTextBoxColumn.Width = 150;
            // 
            // sumDataTableBindingSource1
            // 
            this.sumDataTableBindingSource1.DataMember = "SumDataTable";
            this.sumDataTableBindingSource1.DataSource = this.SummaryDataSet;
            // 
            // SummaryDataSet
            // 
            this.SummaryDataSet.DataSetName = "SummerData";
            this.SummaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sumDataTableBindingSource
            // 
            this.sumDataTableBindingSource.DataMember = "SumDataTable";
            this.sumDataTableBindingSource.DataSource = this.SummaryDataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::kakeibo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(1342, 853);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 910);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "簡易家計簿";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDataSet1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabList.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sumDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SummaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sumDataTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 保存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 編集EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 追加AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 変更CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 削除DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 表示VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 一覧表示LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 集計表示SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private MoneyDataSet moneyDataSet;
        private System.Windows.Forms.BindingSource moneyDataSetBindingSource;
        private System.Windows.Forms.BindingSource moneyDataSetBindingSource1;
        private MoneyDataSet moneyDataSet1;
        private System.Windows.Forms.BindingSource moneyDataTableBindingSource;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 金額DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 備考DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource moneyDataTableBindingSource1;
        private CategoryDataSet categoryDataSet1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabList;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.DataGridView sumDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日付DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 入金合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 出金合計DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sumDataTableBindingSource;
        private SummaryDataSet SummaryDataSet;
        private System.Windows.Forms.BindingSource sumDataTableBindingSource1;
        private System.Windows.Forms.BindingSource moneyDataTableBindingSource2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

