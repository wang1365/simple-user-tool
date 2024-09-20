using System;
using System.Linq;
using System.Windows.Forms;
using ZbSkin.Frm;
using ZbSkin.Sample.MockData;
using ZbSkin.Sample.Models;

namespace ZbSkin.Sample.Forms
{
    public partial class FrmUserSetup : PopupForm
    {
        private readonly bool _addFlag;
        private readonly UserInfo _model;

        public FrmUserSetup()
            : this(true, new UserInfo())
        {
        }

        public FrmUserSetup(UserInfo model)
            : this(false, model)
        {
        }

        private FrmUserSetup(bool addFlag, UserInfo model)
        {
            InitializeComponent();

            _addFlag = addFlag;
            _model = model;
        }

        private void FrmUserSetup_Load(object sender, EventArgs e)
        {
            textBoxId.Text = _model.Id.ToString();

            var genderList = new[] {@"男", @"女"};
            comboBoxGender.DataSource = genderList;

            if (!_addFlag)
            {
                textBoxName.Text = _model.Name;
                comboBoxGender.SelectedIndex = _model.Gender ? 0 : 1;
                textBoxAge.Text = _model.Age.ToString();
            }

            textBoxName.Focus();
            textBoxName.SelectionStart = textBoxName.TextLength;

            FrmTitle = _addFlag ? @"添加用户" : @"编辑用户";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!CheckParas())
            {
                return;
            }

            if (_addFlag)
            {
                _model.Id = DataManager.Instance.UserInfoDict.Values.Max(t => t.Id) + 1;
                _model.UpdateTime = DateTime.Now;
                DataManager.Instance.UserInfoDict.Add(_model.Id, _model);
            }
            else
            {
                if (!DataManager.Instance.UserInfoDict.ContainsKey(_model.Id))
                {
                    MessageBoxEx.Warning($@"错误的用户ID：{_model.Id}", this);
                    return;
                }

                _model.UpdateTime = DateTime.Now;
                DataManager.Instance.UserInfoDict[_model.Id] = _model;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool CheckParas()
        {
            var name = textBoxName.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBoxEx.Warning(@"请输入用户姓名");
                return false;
            }

            var ageStr = textBoxAge.Text.Trim();
            if (string.IsNullOrWhiteSpace(ageStr))
            {
                MessageBoxEx.Warning(@"请输入用户年龄");
                return false;
            }

            int age;
            if (!int.TryParse(ageStr, out age) || age <= 0)
            {
                MessageBoxEx.Warning(@"用户年龄不合法");
                return false;
            }

            _model.Name = name;
            _model.Age = age;
            _model.Gender = comboBoxGender.SelectedIndex == 0;
            return true;
        }
    }
}
