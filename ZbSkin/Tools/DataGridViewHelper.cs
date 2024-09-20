using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZbSkin.Tools
{
    public static class DataGridViewHelper
    {
        public static void SetCommonStyle(
            DataGridView dataGridView,
            int columnHeadersHeight = 25,
            int rowTemplateHeight = 25,
            int headerCellFont = 14,
            int cellFont = 14,
            bool showCrossColor = true
        )
        {
            if (dataGridView == null)
            {
                return;
            }

            dataGridView.BackgroundColor = Color.White;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersHeight = columnHeadersHeight;

            dataGridView.RowTemplate.Height = rowTemplateHeight;

            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", headerCellFont);
            dataGridView.DefaultCellStyle.Font = new Font("宋体", cellFont);

            if (showCrossColor)
            {
                dataGridView.DataBindingComplete += dataGridView_DataBindingComplete;
            }
        }

        public static void SetDateTimeStyle(
            DataGridView dataGridView,
            string datetimeColumn,
            string format = "yyyy-MM-dd HH:mm:ss"
        )
        {
            var dateColumn = dataGridView.Columns[datetimeColumn];
            if (dateColumn != null)
            {
                dateColumn.DefaultCellStyle.Format = format;
            }
        }

        private static void dataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            SetCrossColor(sender as DataGridView);
        }

        public static void SetCrossColor(DataGridView dataGridView)
        {
            if (dataGridView == null || dataGridView.Rows.Count == 0)
            {
                return;
            }

            try
            {
                for (var i = 0; i < dataGridView.Rows.Count; i++)
                {
                    var color = (i + 1) % 2 == 1 ? Color.LightBlue : Color.LightGray;
                    dataGridView.Rows[i].DefaultCellStyle.BackColor = color;
                    dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
            catch (Exception)
            {
                //Do nothing
            }
        }
    }
}
