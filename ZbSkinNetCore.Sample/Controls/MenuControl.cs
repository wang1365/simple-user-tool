using System;
using System.Drawing;
using System.Windows.Forms;
using ZbSkin.Controls;
using ZbSkinNetCore.Sample.Tools;

namespace ZbSkinNetCore.Sample.Controls
{
    public partial class MenuControl : UserControl
    {
        public event Action<int> MenuItemClick = (_) => { };
        public bool SwitchMenuItem { get; set; }

        private MenuItemAlignment _alignment = MenuItemAlignment.Horizontal;
        private MenuItemControl _currentMenuItem;

        public MenuControl()
        {
            InitializeComponent();

            menuItemDeviceList.Tag = Constants.MenuTag.UserList;
            menuItemRealtimeData.Tag = Constants.MenuTag.LogList;
            menuItemAbout.Tag = Constants.MenuTag.About;

            Paint += MenuControl_Paint;
        }

        private void MenuControl_Load(object sender, EventArgs e)
        {
            ResizeControls();
            OnMenuItemClick(menuItemDeviceList);
            menuItemDeviceList.Selected = true;

            menuItemDeviceList.MenuItemClicked += OnMenuItemClick;
            menuItemRealtimeData.MenuItemClicked += OnMenuItemClick;
            menuItemAbout.MenuItemClicked += OnMenuItemClick;
        }

        private void MenuControl_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void MenuControl_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var p = new Pen(Color.Gray, 1);
            g.DrawRectangle(p, Width - 1, 0, Width, Height);
        }

        private void ResizeControls()
        {
            if (_alignment == MenuItemAlignment.Horizontal)
            {
                menuItemDeviceList.Left = 20;
                menuItemDeviceList.Top = (ClientSize.Height - menuItemDeviceList.Height) / 2;
                menuItemRealtimeData.Left = menuItemDeviceList.Right + 20;
                menuItemRealtimeData.Top = menuItemDeviceList.Top;
                menuItemAbout.Left = menuItemRealtimeData.Right + 20;
                menuItemAbout.Top = menuItemDeviceList.Top;
            }
            else
            {
                menuItemDeviceList.Left = (ClientSize.Width - menuItemDeviceList.Width) / 2;
                menuItemDeviceList.Top = 20;
                menuItemRealtimeData.Left = menuItemDeviceList.Left;
                menuItemRealtimeData.Top = menuItemDeviceList.Bottom + 20;
                menuItemAbout.Left = menuItemDeviceList.Left;
                menuItemAbout.Top = menuItemRealtimeData.Bottom + 20;
            }
        }

        public void SetAlignment(MenuItemAlignment alignment)
        {
            _alignment = alignment;
        }

        private void OnMenuItemClick(MenuItemControl menuItem)
        {
            SwitchMenuItem = true;
            var menuTag = (int?)menuItem?.Tag ?? 0;
            MenuItemClick?.Invoke(menuTag);

            if (SwitchMenuItem)
            {
                if (_currentMenuItem != null)
                {
                    _currentMenuItem.Selected = false;
                }

                if (menuItem != null)
                {
                    menuItem.Selected = true;
                }

                _currentMenuItem = menuItem;
            }
        }

        public enum MenuItemAlignment
        {
            /// <summary>
            /// 水平排列
            /// </summary>
            Horizontal,

            /// <summary>
            /// 垂直排列
            /// </summary>
            Vertical
        }
    }
}
