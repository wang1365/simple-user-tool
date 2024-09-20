using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ZbSkin.Controls;
using ZbSkin.Frm;
using ZbSkinNetCore.Sample.Forms;
using ZbSkinNetCore.Sample.MockData;
using ZbSkinNetCore.Sample.Models;
using ZbSkin.Tools;

namespace ZbSkinNetCore.Sample.Controls
{
    public partial class UserListControl : PageControl
    {
        private readonly SynchronizationContext _context;

        public UserListControl()
        {
            InitializeComponent();
            _context = SynchronizationContext.Current;
        }

        private void UserListControl_Load(object sender, EventArgs e)
        {
            DataGridViewHelper.SetCommonStyle(dataGridView);
            DataGridViewHelper.SetDateTimeStyle(dataGridView, "ColumnUpdateTime");
            ResizeControls();
        }

        private void UserListControl_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }

        private void ResizeControls()
        {
            SetRegion();

            dataGridView.Width = ClientSize.Width - 40;
            dataGridView.Height = ClientSize.Height - dataGridView.Top - btnAdd.Height * 2;
            dataGridView.Left = 20;
            btnAdd.Top = ClientSize.Height - (int) (btnAdd.Height * 1.5f);
            btnDel.Top = btnAdd.Top;
            btnEdit.Top = btnAdd.Top;
        }

        protected override void ShowControl()
        {
            base.ShowControl();
            UpdateDataGridView();
        }

        protected override void HideControl()
        {
            base.HideControl();
            dataGridView.DataSource = null;
        }

        private void UpdateDataGridView()
        {
            _context?.Post((_) =>
            {
                dataGridView.DataSource = null;

                var userInfoList = DataManager.Instance.UserInfoDict
                    .Values.OrderBy(t => t.Id).ToList();

                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = userInfoList;
            }, null);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            var model = dataGridView.CurrentRow?.DataBoundItem as UserInfo;
            if (model == null)
            {
                return;
            }

            if (!MessageBoxEx.Question($"确定要删除用户[{model.Name}]吗？", ParentForm))
            {
                return;
            }

            if (DataManager.Instance.UserInfoDict.ContainsKey(model.Id))
            {
                DataManager.Instance.UserInfoDict.Remove(model.Id);
                UpdateDataGridView();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new FrmUserSetup() {Owner = ParentForm};
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateDataGridView();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditModel();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditModel();
        }

        private void EditModel()
        {
            var model = dataGridView.CurrentRow?.DataBoundItem as UserInfo;
            if (model == null)
            {
                return;
            }

            var form = new FrmUserSetup(model) {Owner = ParentForm};
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateDataGridView();
            }
        }
    }
}
