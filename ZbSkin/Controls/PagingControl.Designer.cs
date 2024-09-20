namespace ZbSkin.Controls
{
    partial class PagingControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            labelInfo = new System.Windows.Forms.Label();
            textBoxJumpPage = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnGo = new ImageButton();
            btnLast = new ImageButton();
            btnNext = new ImageButton();
            btnPrev = new ImageButton();
            btnFirst = new ImageButton();
            SuspendLayout();
            // 
            // labelInfo
            // 
            labelInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            labelInfo.AutoSize = true;
            labelInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelInfo.Location = new System.Drawing.Point(119, 17);
            labelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new System.Drawing.Size(367, 16);
            labelInfo.TabIndex = 15;
            labelInfo.Text = "总共108条记录，当前第2页，共6页，每页20条记录";
            // 
            // textBoxJumpPage
            // 
            textBoxJumpPage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxJumpPage.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxJumpPage.Location = new System.Drawing.Point(779, 10);
            textBoxJumpPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            textBoxJumpPage.MaxLength = 5;
            textBoxJumpPage.Name = "textBoxJumpPage";
            textBoxJumpPage.Size = new System.Drawing.Size(60, 26);
            textBoxJumpPage.TabIndex = 14;
            textBoxJumpPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(747, 17);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 16);
            label1.TabIndex = 13;
            label1.Text = "第          页";
            // 
            // btnGo
            // 
            btnGo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnGo.BackColor = System.Drawing.Color.Transparent;
            btnGo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGo.ForeColor = System.Drawing.Color.White;
            btnGo.Location = new System.Drawing.Point(898, 7);
            btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnGo.Name = "btnGo";
            btnGo.Size = new System.Drawing.Size(35, 42);
            btnGo.TabIndex = 12;
            btnGo.Text = "GO";
            btnGo.UseVisualStyleBackColor = false;
            btnGo.Click += btnGo_Click;
            // 
            // btnLast
            // 
            btnLast.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnLast.BackColor = System.Drawing.Color.Transparent;
            btnLast.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnLast.ForeColor = System.Drawing.Color.White;
            btnLast.Location = new System.Drawing.Point(700, 7);
            btnLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnLast.Name = "btnLast";
            btnLast.Size = new System.Drawing.Size(35, 42);
            btnLast.TabIndex = 11;
            btnLast.Text = ">|";
            btnLast.UseVisualStyleBackColor = false;
            btnLast.Click += btnLast_Click;
            // 
            // btnNext
            // 
            btnNext.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnNext.BackColor = System.Drawing.Color.Transparent;
            btnNext.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnNext.ForeColor = System.Drawing.Color.White;
            btnNext.Location = new System.Drawing.Point(653, 7);
            btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(35, 42);
            btnNext.TabIndex = 10;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrev
            // 
            btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnPrev.BackColor = System.Drawing.Color.Transparent;
            btnPrev.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnPrev.ForeColor = System.Drawing.Color.White;
            btnPrev.Location = new System.Drawing.Point(607, 7);
            btnPrev.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new System.Drawing.Size(35, 42);
            btnPrev.TabIndex = 9;
            btnPrev.Text = "<";
            btnPrev.UseVisualStyleBackColor = false;
            btnPrev.Click += btnPrev_Click;
            // 
            // btnFirst
            // 
            btnFirst.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnFirst.BackColor = System.Drawing.Color.Transparent;
            btnFirst.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFirst.ForeColor = System.Drawing.Color.White;
            btnFirst.Location = new System.Drawing.Point(560, 7);
            btnFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new System.Drawing.Size(35, 42);
            btnFirst.TabIndex = 8;
            btnFirst.Text = "|<";
            btnFirst.UseVisualStyleBackColor = false;
            btnFirst.Click += btnFirst_Click;
            // 
            // PagingControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(labelInfo);
            Controls.Add(textBoxJumpPage);
            Controls.Add(label1);
            Controls.Add(btnGo);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrev);
            Controls.Add(btnFirst);
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "PagingControl";
            Size = new System.Drawing.Size(933, 57);
            Load += PagingControl_Load;
            Resize += PagingControl_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxJumpPage;
        private System.Windows.Forms.Label label1;
        private ImageButton btnGo;
        private ImageButton btnLast;
        private ImageButton btnNext;
        private ImageButton btnPrev;
        private ImageButton btnFirst;
    }
}
