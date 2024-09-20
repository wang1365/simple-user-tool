using System;
using ZbSkin.Frm;
using ZbSkinNetCore.Sample.Tools;

namespace ZbSkinNetCore.Sample.Forms
{
    public partial class FrmAbout : PopupForm
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void FrmAbout_Load(object sender, EventArgs e)
        {
            FrmTitle = $@"About {Constants.ProductName}";
        }
    }
}
