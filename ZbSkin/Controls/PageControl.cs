using System;
using System.Threading;
using System.Windows.Forms;
using ZbSkin.Tools;

namespace ZbSkin.Controls
{
    public partial class PageControl : UserControl
    {
        public Action<Tuple<string, object>> SwitchPage = (_) => { };

        protected SynchronizationContext Context { get; }

        public PageControl()
        {
            InitializeComponent();
            Context = SynchronizationContext.Current;
        }

        private void PageControl_Load(object sender, EventArgs e)
        {

        }

        public void ShowControl(bool show)
        {
            if (show)
            {
                ShowControl();
            }
            else
            {
                HideControl();
            }
        }

        protected virtual void ShowControl()
        {
            Visible = true;
            BringToFront();
        }

        protected virtual void HideControl()
        {
            Visible = false;
        }

        protected void InvokeSwitchPage(Tuple<string, object> data)
        {
            SwitchPage?.Invoke(data);
        }

        protected void SetRegion()
        {
            this.SetRegion(30);
        }
    }
}
