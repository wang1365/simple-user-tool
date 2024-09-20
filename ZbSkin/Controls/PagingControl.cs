using System;
using System.ComponentModel;
using System.Windows.Forms;
using ZbSkin.Frm;
using ZbSkin.Tools;

namespace ZbSkin.Controls
{
    /// <summary>
    /// 分页控件
    /// </summary>
    [ToolboxItem(true)]
    public partial class PagingControl : UserControl
    {
        public event Action<int> ShowPage = (_) => { };

        [Browsable(true), Category("Custom"), Description("Property:RegionRadius")]
        public int RegionRadius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                SetRegion();
            }
        }

        private int _totalCount; //总个数
        private int _countPerPage = 50; //每页显示个数
        private int _totalPages; //总页数
        private int _currentPage; //当前页数

        private int _radius;

        public PagingControl()
        {
            InitializeComponent();
        }

        private void PagingControl_Load(object sender, EventArgs e)
        {
            labelInfo.Text = @"总共0条记录，当前第0页，共0页，每页0条记录";
            labelInfo.Left = btnFirst.Left - labelInfo.Width - 10;
            SetRegion();
        }

        private void PagingControl_Resize(object sender, EventArgs e)
        {
            SetRegion();
        }

        private void SetRegion()
        {
            if (_radius > 0)
            {
                this.SetRegion(_radius);
            }
        }

        public void ResetControl(int totalCount, int countPerPage)
        {
            if (countPerPage <= 0)
            {
                throw new ArgumentException(@"countPerPage is 0 or less");
            }

            _totalCount = totalCount;
            _countPerPage = countPerPage;

            if (totalCount == 0)
            {
                _currentPage = 0;
                _totalPages = 0;
            }
            else
            {
                _currentPage = 1;
                _totalPages = _totalCount / _countPerPage;
                if (_totalCount % _totalPages > 0)
                {
                    _totalPages += 1;
                }
            }

            textBoxJumpPage.Text = string.Empty;
            UpdateControl();
        }

        public int GetPageCount(int pageIndex)
        {
            return pageIndex == _totalPages ? _totalCount % _countPerPage : _countPerPage;
        }

        private void UpdateControl()
        {
            labelInfo.Text = $@"总共{_totalCount}条记录，当前第{_currentPage}页，" +
                             $@"共{_totalPages}页，每页{_countPerPage}条记录";
            labelInfo.Left = btnFirst.Left - labelInfo.Width - 10;

            if (_totalPages <= 1)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
                btnGo.Enabled = false;
                textBoxJumpPage.Enabled = false;
                return;
            }

            btnFirst.Enabled = _currentPage != 1;
            btnPrev.Enabled = _currentPage > 1;
            btnNext.Enabled = _currentPage < _totalPages;
            btnLast.Enabled = _currentPage != _totalPages;
        }

        #region 按钮事件

        private void btnFirst_Click(object sender, EventArgs e)
        {
            _currentPage = 1;
            UpdateControl();
            ShowPage?.Invoke(_currentPage);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentPage -= 1;
            UpdateControl();
            ShowPage?.Invoke(_currentPage);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentPage += 1;
            UpdateControl();
            ShowPage?.Invoke(_currentPage);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            _currentPage = _totalPages;
            UpdateControl();
            ShowPage?.Invoke(_currentPage);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int pageIndex;
            if (!int.TryParse(textBoxJumpPage.Text.Trim(), out pageIndex))
            {
                MessageBoxEx.Warning("请输入正确的页码", ParentForm);
                return;
            }

            if (pageIndex < 1 || pageIndex > _totalPages)
            {
                MessageBoxEx.Warning("无效的页码", ParentForm);
                return;
            }

            if (pageIndex == _countPerPage)
            {
                return;
            }

            _currentPage = pageIndex;
            UpdateControl();
            ShowPage?.Invoke(_currentPage);
        }

        #endregion
    }
}
