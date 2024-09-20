using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ZbSkin.Controls;
using ZbSkinNetCore.Sample.MockData;
using ZbSkinNetCore.Sample.Models;
using ZbSkinNetCore.Sample.Tools;
using ZbSkin.Tools;

namespace ZbSkinNetCore.Sample.Controls
{
    public partial class LogListControl : PageControl
    {
        private readonly SynchronizationContext _context;
        private readonly List<MyLogInfo> _myLogInfoList;

        public LogListControl()
        {
            InitializeComponent();
            _context = SynchronizationContext.Current;
            _myLogInfoList = new List<MyLogInfo>();
        }

        private void LogListControl_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.SetCommonStyle(dataGridView);
            DataGridViewHelper.SetDateTimeStyle(dataGridView, "ColumnAddTime");
            ResizeControls();

            pagingControl.ShowPage += OnShowPage;
        }

        private void LogListControl_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            SetRegion();

            dataGridView.Width = ClientSize.Width - 40;
            dataGridView.Height = ClientSize.Height - dataGridView.Top - pagingControl.Height - 20;
            dataGridView.Left = 20;
            pagingControl.Left = 20;
            pagingControl.Top = dataGridView.Bottom + 10;
            pagingControl.Width = dataGridView.Width;
        }

        protected override void ShowControl()
        {
            base.ShowControl();

            _myLogInfoList.Clear();
            var logInfoList = DataManager.Instance.LogInfoList;
            var index = 0;
            foreach (var logInfo in logInfoList)
            {
                _myLogInfoList.Add(new MyLogInfo()
                {
                    Index = ++index,
                    LogInfo = logInfo
                });
            }

            pagingControl.ResetControl(_myLogInfoList.Count, Constants.CountPerPage);
            UpdateDataGridView(1);
        }

        protected override void HideControl()
        {
            base.HideControl();
            dataGridView.DataSource = null;
        }

        private void OnShowPage(int pageIndex)
        {
            UpdateDataGridView(pageIndex);
        }

        private void UpdateDataGridView(int pageIndex)
        {
            _context?.Post((state) =>
            {
                dataGridView.DataSource = null;

                if (state == null)
                {
                    return;
                }

                var curPage = (int)state;
                var count = pagingControl.GetPageCount(curPage);
                var offset = Constants.CountPerPage * (curPage - 1);
                var myLogInfoList = _myLogInfoList.Skip(offset).Take(count).ToList();

                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = myLogInfoList;
            }, pageIndex);
        }

        private class MyLogInfo
        {
            // ReSharper disable once UnusedMember.Local
            // ReSharper disable once UnusedAutoPropertyAccessor.Local
            public int Index { get; set; }
            // ReSharper disable once UnusedMember.Local
            public LogType LogType => LogInfo?.LogType ?? LogType.Unknown;
            // ReSharper disable once UnusedMember.Local
            public DateTime AddTime => LogInfo?.AddTime ?? new DateTime();
            // ReSharper disable once UnusedMember.Local
            public string Text => LogInfo?.Text;

            public LogInfo LogInfo { private get; set; }
        }
    }
}
