using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ZbSkin.Tools;

namespace ZbSkin.Controls
{
    [ToolboxItem(true)]
    public partial class MenuItemControl : UserControl
    {
        public event Action<MenuItemControl> MenuItemClicked = (_) => { };

        [Browsable(true), Category("Custom"), Description("Property:ItemImage")]
        public Bitmap ItemImage { get; set; }

        [Browsable(true), Category("Custom"), Description("Property:ItemText")]
        public string ItemText
        {
            get { return label.Text; }
            set { label.Text = value; }
        }

        public bool Selected
        {
            get { return _menuItemState == MenuItemState.Selected; }
            set
            {
                if (value && _menuItemState != MenuItemState.Selected)
                {
                    _menuItemState = MenuItemState.Selected;
                    Refresh();
                }
                else if (!value && _menuItemState == MenuItemState.Selected)
                {
                    _menuItemState = MenuItemState.Normal;
                    Refresh();
                }
            }
        }

        private static readonly Image HoverImage = Properties.Resources.menuItemHover;
        private static readonly Image PressedImage = Properties.Resources.menuItemDown;
        private static readonly Image SelectedImage = Properties.Resources.menuItemSelected;

        private MenuItemState _menuItemState = MenuItemState.Normal;

        public MenuItemControl()
        {
            InitializeComponent();
        }

        private void MenuItemControl_Load(object sender, EventArgs e)
        {
            if (ItemImage != null)
            {
                pictureBox.Image = ItemImage;
            }

            ControlTool.SetControlEnabled(pictureBox, false);
            ControlTool.SetControlEnabled(label, false);

            ResizeControls();
        }

        private void MenuItemControl_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            label.Left = (ClientSize.Width - label.Width) / 2;
        }

        private void MenuItemControl_Paint(object sender, PaintEventArgs e)
        {
            Image image = null;
            switch (_menuItemState)
            {
                case MenuItemState.Normal:
                    break;
                case MenuItemState.Hover:
                    image = HoverImage;
                    break;
                case MenuItemState.Selected:
                    image = SelectedImage;
                    break;
                case MenuItemState.Pressed:
                    image = PressedImage;
                    break;
            }

            ImageHelper.Draw9Scale(e.Graphics, image, ClientSize.Width, ClientSize.Height,
                5, 3, 128);
        }

        private void MenuItemControl_MouseEnter(object sender, EventArgs e)
        {
            if (_menuItemState != MenuItemState.Selected)
            {
                _menuItemState = MenuItemState.Hover;
                Refresh();
            }
        }

        private void MenuItemControl_MouseLeave(object sender, EventArgs e)
        {
            if (_menuItemState != MenuItemState.Selected)
            {
                _menuItemState = MenuItemState.Normal;
                Refresh();
            }
        }

        private void MenuItemControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (_menuItemState != MenuItemState.Selected)
            {
                _menuItemState = MenuItemState.Pressed;
                Refresh();
            }
        }

        private void MenuItemControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (_menuItemState != MenuItemState.Selected)
            {
                _menuItemState = MenuItemState.Hover;
                Refresh();
                MenuItemClicked?.Invoke(this);
            }
        }

        private enum MenuItemState
        {
            Normal = 0,
            Hover,
            Pressed,
            Selected
        }
    }
}
