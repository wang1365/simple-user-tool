using System;
using System.Threading;
using System.Windows.Forms;
using ZbSkin.Controls;
using ZbSkin.Frm;
using ZbSkinNetCore.Sample.Controls;
using ZbSkinNetCore.Sample.Forms;
using ZbSkinNetCore.Sample.MockData;
using ZbSkinNetCore.Sample.Tools;

namespace ZbSkinNetCore.Sample
{
    public partial class MainForm : SkinMainForm
    {
        private readonly SynchronizationContext _context;
        private readonly MenuControl _menuControl;
        private readonly Panel _customPanel;

        private readonly PageControl _userListPage;
        private readonly PageControl _logListPage;
        private PageControl _curPage;

        public MainForm()
        {
            InitializeComponent();

            Width = Constants.FormWidth;
            Height = Constants.FormHeight;
            StartPosition = FormStartPosition.CenterScreen;

            _context = SynchronizationContext.Current;
            _menuControl = new MenuControl() { BackColor = ContentPanel.BackColor, Width = 120 };
            _menuControl.SetAlignment(MenuControl.MenuItemAlignment.Vertical);
            _menuControl.MenuItemClick += OnMenuItemClick;
            _menuControl.BackColor = System.Drawing.Color.White;
            _customPanel = new Panel() { BackColor = ContentPanel.BackColor };

            _userListPage = new UserListControl() { Visible = false, Width = Constants.ContentWidth };
            _logListPage = new LogListControl() { Visible = false, Width = Constants.ContentWidth };
            _customPanel.Controls.Add(_userListPage);
            _customPanel.Controls.Add(_logListPage);
            _customPanel.BackColor = System.Drawing.Color.White;

            ContentPanel.Controls.Add(_menuControl);
            ContentPanel.Controls.Add(_customPanel);
            ContentPanel.SizeChanged += OnContentPanelSizeChanged;
            BottomPanel.Controls.Add(new BottomControl() { Dock = DockStyle.Fill });

            //初始化数据
            ThreadPool.QueueUserWorkItem((_) => { DataManager.Instance.InitData(); });
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Title = Constants.ProductName;
            ResizeContentPanelControls();
        }

        private void OnContentPanelSizeChanged(object sender, EventArgs e)
        {
            ResizeContentPanelControls();
        }

        private void ResizeContentPanelControls()
        {
            _menuControl.Left = 0;
            _menuControl.Top = 0;
            _menuControl.Height = ContentPanel.ClientSize.Height;

            _customPanel.Left = _menuControl.Right;
            _customPanel.Top = 0;
            _customPanel.Width = ContentPanel.ClientSize.Width - _menuControl.Width;
            _customPanel.Height = ContentPanel.ClientSize.Height;

            foreach (Control control in _customPanel.Controls)
            {
                if (control != null)
                {
                    control.Width = _customPanel.Width;
                    control.Height = _customPanel.ClientSize.Height;
                    control.Left = (_customPanel.ClientSize.Width - control.Width) / 2;
                    control.Top = 0;
                }
            }
        }

        private void OnMenuItemClick(int menuTag)
        {
            switch (menuTag)
            {
                case Constants.MenuTag.UserList:
                    SetCurPage(_userListPage);
                    break;
                case Constants.MenuTag.LogList:
                    SetCurPage(_logListPage);
                    break;
                case Constants.MenuTag.About:
                    _menuControl.SwitchMenuItem = false;
                    _context?.Post((_) => { new FrmAbout().ShowDialog(this); }, null);
                    break;
            }
        }

        private void SetCurPage(PageControl control)
        {
            _context?.Post((state) =>
            {
                var curPage = (PageControl)state;
                curPage?.ShowControl(true);
                _curPage?.ShowControl(false);
                _curPage = curPage;
            }, control);
        }
    }
}
