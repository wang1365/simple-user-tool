namespace ZbSkin.Controls
{
    partial class MenuItemControl
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
            this.label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("宋体", 12F);
            this.label.Location = new System.Drawing.Point(26, 72);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 16);
            this.label.TabIndex = 3;
            this.label.Text = "菜单1";
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::ZbSkin.Properties.Resources.defaultMenuItem;
            this.pictureBox.Location = new System.Drawing.Point(25, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(50, 50);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // MenuItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.pictureBox);
            this.Name = "MenuItemControl";
            this.Size = new System.Drawing.Size(100, 100);
            this.Load += new System.EventHandler(this.MenuItemControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuItemControl_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItemControl_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MenuItemControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MenuItemControl_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItemControl_MouseUp);
            this.Resize += new System.EventHandler(this.MenuItemControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
