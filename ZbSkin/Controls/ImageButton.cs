using System;
using System.ComponentModel;
using System.Drawing;

namespace ZbSkin.Controls
{
    [ToolboxItem(true)]
    public class ImageButton : ImageButtonBase
    {
        protected override Bitmap NormalBackBitmap =>
            Properties.Resources.skinButton01_NormlBack;

        protected override Bitmap DownBackBitmap =>
            Properties.Resources.skinButton01_DownBack;

        protected override Bitmap MouseBackBitmap =>
            Properties.Resources.skinButton01_MouseBack;

        protected override void OnHandleCreated(object sender, EventArgs e)
        {
            ForeColor = Color.White;
        }
    }
}
