namespace ZbSkin.Sample.Controls
{
    partial class LogListControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLogType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pagingControl = new ZbSkin.Controls.PagingControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.ColumnLogType,
            this.ColumnAddTime,
            this.ColumnText});
            this.dataGridView.Location = new System.Drawing.Point(20, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(760, 293);
            this.dataGridView.TabIndex = 27;
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.DataPropertyName = "Index";
            this.ColumnIndex.HeaderText = "序号";
            this.ColumnIndex.Name = "ColumnIndex";
            // 
            // ColumnLogType
            // 
            this.ColumnLogType.DataPropertyName = "LogType";
            this.ColumnLogType.HeaderText = "日志类型";
            this.ColumnLogType.Name = "ColumnLogType";
            this.ColumnLogType.Width = 200;
            // 
            // ColumnAddTime
            // 
            this.ColumnAddTime.DataPropertyName = "AddTime";
            this.ColumnAddTime.HeaderText = "时间";
            this.ColumnAddTime.Name = "ColumnAddTime";
            this.ColumnAddTime.Width = 300;
            // 
            // ColumnText
            // 
            this.ColumnText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnText.DataPropertyName = "Text";
            this.ColumnText.HeaderText = "日志内容";
            this.ColumnText.Name = "ColumnText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(100)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(20, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "日志信息";
            // 
            // pagingControl
            // 
            this.pagingControl.Location = new System.Drawing.Point(24, 375);
            this.pagingControl.Name = "pagingControl";
            this.pagingControl.RegionRadius = 0;
            this.pagingControl.Size = new System.Drawing.Size(800, 40);
            this.pagingControl.TabIndex = 28;
            // 
            // LogListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pagingControl);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.label1);
            this.Name = "LogListControl";
            this.Size = new System.Drawing.Size(900, 480);
            this.Load += new System.EventHandler(this.LogListControl_Load);
            this.Resize += new System.EventHandler(this.LogListControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLogType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnText;
        private ZbSkin.Controls.PagingControl pagingControl;
    }
}
