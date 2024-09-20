namespace ZbSkin.Sample.Controls
{
    partial class BottomControl
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
            this.label_info = new System.Windows.Forms.Label();
            this.label_version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.BackColor = System.Drawing.Color.Transparent;
            this.label_info.Font = new System.Drawing.Font("宋体", 18F);
            this.label_info.ForeColor = System.Drawing.Color.White;
            this.label_info.Location = new System.Drawing.Point(145, 63);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(130, 24);
            this.label_info.TabIndex = 1;
            this.label_info.Text = "支持S7系列";
            // 
            // label_version
            // 
            this.label_version.AutoSize = true;
            this.label_version.BackColor = System.Drawing.Color.Transparent;
            this.label_version.Font = new System.Drawing.Font("宋体", 18F);
            this.label_version.ForeColor = System.Drawing.Color.White;
            this.label_version.Location = new System.Drawing.Point(25, 63);
            this.label_version.Name = "label_version";
            this.label_version.Size = new System.Drawing.Size(58, 24);
            this.label_version.TabIndex = 2;
            this.label_version.Text = "V1.0";
            // 
            // BottomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_info);
            this.Controls.Add(this.label_version);
            this.Name = "BottomControl";
            this.Size = new System.Drawing.Size(300, 150);
            this.Load += new System.EventHandler(this.BottomControl_Load);
            this.Resize += new System.EventHandler(this.BottomControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_version;
    }
}
