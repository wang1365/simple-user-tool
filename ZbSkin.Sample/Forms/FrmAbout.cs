using System;
using ZbSkin.Frm;
using ZbSkin.Sample.Tools;

namespace ZbSkin.Sample.Forms
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
