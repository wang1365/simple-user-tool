namespace ZbSkinNetCore.Sample.Controls
{
    partial class MenuControl
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
            this.menuItemDeviceList = new ZbSkin.Controls.MenuItemControl();
            this.menuItemAbout = new ZbSkin.Controls.MenuItemControl();
            this.menuItemRealtimeData = new ZbSkin.Controls.MenuItemControl();
            this.SuspendLayout();
            // 
            // menuItemDeviceList
            // 
            this.menuItemDeviceList.ItemImage = null;
            this.menuItemDeviceList.ItemText = "用户列表";
            this.menuItemDeviceList.Location = new System.Drawing.Point(24, 40);
            this.menuItemDeviceList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.menuItemDeviceList.Name = "menuItemDeviceList";
            this.menuItemDeviceList.Selected = false;
            this.menuItemDeviceList.Size = new System.Drawing.Size(100, 100);
            this.menuItemDeviceList.TabIndex = 0;
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.ItemImage = global::ZbSkinNetCore.Sample.Properties.Resources.About;
            this.menuItemAbout.ItemText = "关于";
            this.menuItemAbout.Location = new System.Drawing.Point(24, 277);
            this.menuItemAbout.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Selected = false;
            this.menuItemAbout.Size = new System.Drawing.Size(100, 100);
            this.menuItemAbout.TabIndex = 1;
            // 
            // menuItemRealtimeData
            // 
            this.menuItemRealtimeData.ItemImage = global::ZbSkinNetCore.Sample.Properties.Resources.Data;
            this.menuItemRealtimeData.ItemText = "日志信息";
            this.menuItemRealtimeData.Location = new System.Drawing.Point(24, 155);
            this.menuItemRealtimeData.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.menuItemRealtimeData.Name = "menuItemRealtimeData";
            this.menuItemRealtimeData.Selected = false;
            this.menuItemRealtimeData.Size = new System.Drawing.Size(100, 100);
            this.menuItemRealtimeData.TabIndex = 0;
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuItemAbout);
            this.Controls.Add(this.menuItemRealtimeData);
            this.Controls.Add(this.menuItemDeviceList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(150, 450);
            this.Load += new System.EventHandler(this.MenuControl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuControl_Paint);
            this.Resize += new System.EventHandler(this.MenuControl_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private ZbSkin.Controls.MenuItemControl menuItemDeviceList;
        private ZbSkin.Controls.MenuItemControl menuItemRealtimeData;
        private ZbSkin.Controls.MenuItemControl menuItemAbout;
    }
}
