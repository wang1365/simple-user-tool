using System;
using System.Reflection;
using System.Windows.Forms;

namespace ZbSkin.Sample.Controls
{
    public partial class BottomControl : UserControl
    {
        public BottomControl()
        {
            InitializeComponent();
        }

        private void BottomControl_Load(object sender, EventArgs e)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            var index = version.LastIndexOf('.');
            if (index >= 0)
            {
                version = version.Substring(0, index);
            }

            label_version.Text = $@"version: {version}";
            label_info.Text = @"Designed by Simon";
            ResizeControls();
        }

        private void BottomControl_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            label_version.Left = 10;
            label_version.Top = (ClientSize.Height - label_version.Height) / 2;
            label_info.Left = ClientSize.Width - label_info.Width - 10;
            label_info.Top = label_version.Top;
        }
    }
}
