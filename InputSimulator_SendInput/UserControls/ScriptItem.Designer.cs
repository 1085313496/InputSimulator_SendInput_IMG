namespace InputSimulator_SendInput
{
    partial class ScriptItem
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptItem));
            this.lb_ScriptName = new System.Windows.Forms.Label();
            this.lb_HotKey = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.vibtn_Delete = new InputSimulator_SendInput.VariableImageButton();
            this.vibtn_Edit = new InputSimulator_SendInput.VariableImageButton();
            this.vibtn_Play = new InputSimulator_SendInput.VariableImageButton();
            this.vibtn_Loop = new InputSimulator_SendInput.VariableImageButton();
            this.vibtn_Enable = new InputSimulator_SendInput.VariableImageButton();
            this.SuspendLayout();
            // 
            // lb_ScriptName
            // 
            this.lb_ScriptName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_ScriptName.AutoEllipsis = true;
            this.lb_ScriptName.BackColor = System.Drawing.Color.Transparent;
            this.lb_ScriptName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_ScriptName.Location = new System.Drawing.Point(5, 25);
            this.lb_ScriptName.Name = "lb_ScriptName";
            this.lb_ScriptName.Size = new System.Drawing.Size(121, 48);
            this.lb_ScriptName.TabIndex = 1;
            this.lb_ScriptName.Text = "示例脚本.txt";
            this.lb_ScriptName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_HotKey
            // 
            this.lb_HotKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_HotKey.BackColor = System.Drawing.Color.Transparent;
            this.lb_HotKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_HotKey.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold);
            this.lb_HotKey.ForeColor = System.Drawing.Color.Red;
            this.lb_HotKey.Location = new System.Drawing.Point(37, 73);
            this.lb_HotKey.Name = "lb_HotKey";
            this.lb_HotKey.Size = new System.Drawing.Size(59, 29);
            this.lb_HotKey.TabIndex = 6;
            this.lb_HotKey.Text = "F6";
            this.lb_HotKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lb_HotKey, "运行/暂停快捷键");
            this.lb_HotKey.Click += new System.EventHandler(this.lb_HotKey_Click);
            // 
            // vibtn_Delete
            // 
            this.vibtn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vibtn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.vibtn_Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vibtn_Delete.BackgroundImage")));
            this.vibtn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vibtn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vibtn_Delete.HoverTips = "删除此脚本";
            this.vibtn_Delete.Location = new System.Drawing.Point(106, 3);
            this.vibtn_Delete.Name = "vibtn_Delete";
            this.vibtn_Delete.Size = new System.Drawing.Size(20, 20);
            this.vibtn_Delete.TabIndex = 8;
            this.vibtn_Delete.UseHoverImg = true;
            this.vibtn_Delete.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vibtn_Delete.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vibtn_Delete.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vibtn_Delete.VIBtn_BorderRadius = 0;
            this.vibtn_Delete.VIBtn_BorderThickness = 1;
            this.vibtn_Delete.VIBtn_Enable = true;
            this.vibtn_Delete.VIBtn_ImgName_Disable = "delete_grey";
            this.vibtn_Delete.VIBtn_ImgName_Enable = "delete_ori";
            this.vibtn_Delete.VIBtn_ImgName_Hover = "delete_grey";
            this.vibtn_Delete.VIBtn_ShowBorder = false;
            this.vibtn_Delete.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vibtn_Delete_ButtonClicked);
            // 
            // vibtn_Edit
            // 
            this.vibtn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vibtn_Edit.BackColor = System.Drawing.Color.Transparent;
            this.vibtn_Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vibtn_Edit.BackgroundImage")));
            this.vibtn_Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vibtn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vibtn_Edit.HoverTips = "修改脚本信息";
            this.vibtn_Edit.Location = new System.Drawing.Point(82, 3);
            this.vibtn_Edit.Name = "vibtn_Edit";
            this.vibtn_Edit.Size = new System.Drawing.Size(20, 20);
            this.vibtn_Edit.TabIndex = 7;
            this.vibtn_Edit.UseHoverImg = true;
            this.vibtn_Edit.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vibtn_Edit.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vibtn_Edit.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vibtn_Edit.VIBtn_BorderRadius = 0;
            this.vibtn_Edit.VIBtn_BorderThickness = 1;
            this.vibtn_Edit.VIBtn_Enable = true;
            this.vibtn_Edit.VIBtn_ImgName_Disable = "edit_grey";
            this.vibtn_Edit.VIBtn_ImgName_Enable = "edit_bluepurple";
            this.vibtn_Edit.VIBtn_ImgName_Hover = "edit_grey";
            this.vibtn_Edit.VIBtn_ShowBorder = false;
            this.vibtn_Edit.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vibtn_Edit_ButtonClicked);
            // 
            // vibtn_Play
            // 
            this.vibtn_Play.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.vibtn_Play.BackColor = System.Drawing.Color.Transparent;
            this.vibtn_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vibtn_Play.BackgroundImage")));
            this.vibtn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vibtn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vibtn_Play.HoverTips = "运行/暂停此脚本";
            this.vibtn_Play.Location = new System.Drawing.Point(102, 75);
            this.vibtn_Play.Name = "vibtn_Play";
            this.vibtn_Play.Size = new System.Drawing.Size(25, 25);
            this.vibtn_Play.TabIndex = 5;
            this.vibtn_Play.UseHoverImg = false;
            this.vibtn_Play.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vibtn_Play.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vibtn_Play.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vibtn_Play.VIBtn_BorderRadius = 0;
            this.vibtn_Play.VIBtn_BorderThickness = 1;
            this.vibtn_Play.VIBtn_Enable = true;
            this.vibtn_Play.VIBtn_ImgName_Disable = "play_grey";
            this.vibtn_Play.VIBtn_ImgName_Enable = "play_green";
            this.vibtn_Play.VIBtn_ImgName_Hover = "check_grey";
            this.vibtn_Play.VIBtn_ShowBorder = false;
            this.vibtn_Play.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vibtn_Play_ButtonClicked);
            // 
            // vibtn_Loop
            // 
            this.vibtn_Loop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vibtn_Loop.BackColor = System.Drawing.Color.Transparent;
            this.vibtn_Loop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("vibtn_Loop.BackgroundImage")));
            this.vibtn_Loop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vibtn_Loop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vibtn_Loop.HoverTips = "循环执行此脚本";
            this.vibtn_Loop.Location = new System.Drawing.Point(6, 75);
            this.vibtn_Loop.Name = "vibtn_Loop";
            this.vibtn_Loop.Size = new System.Drawing.Size(25, 25);
            this.vibtn_Loop.TabIndex = 4;
            this.vibtn_Loop.UseHoverImg = false;
            this.vibtn_Loop.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vibtn_Loop.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vibtn_Loop.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vibtn_Loop.VIBtn_BorderRadius = 0;
            this.vibtn_Loop.VIBtn_BorderThickness = 1;
            this.vibtn_Loop.VIBtn_Enable = true;
            this.vibtn_Loop.VIBtn_ImgName_Disable = "loop_grey";
            this.vibtn_Loop.VIBtn_ImgName_Enable = "loop_bluepurple";
            this.vibtn_Loop.VIBtn_ImgName_Hover = "check_grey";
            this.vibtn_Loop.VIBtn_ShowBorder = false;
            this.vibtn_Loop.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vibtn_Loop_ButtonClicked);
            // 
            // vibtn_Enable
            // 
            this.vibtn_Enable.BackColor = System.Drawing.Color.Transparent;
            this.vibtn_Enable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vibtn_Enable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vibtn_Enable.HoverTips = "切换此脚本的激活/锁定状态";
            this.vibtn_Enable.Location = new System.Drawing.Point(6, 2);
            this.vibtn_Enable.Name = "vibtn_Enable";
            this.vibtn_Enable.Size = new System.Drawing.Size(25, 23);
            this.vibtn_Enable.TabIndex = 3;
            this.vibtn_Enable.UseHoverImg = false;
            this.vibtn_Enable.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vibtn_Enable.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vibtn_Enable.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vibtn_Enable.VIBtn_BorderRadius = 0;
            this.vibtn_Enable.VIBtn_BorderThickness = 1;
            this.vibtn_Enable.VIBtn_Enable = true;
            this.vibtn_Enable.VIBtn_ImgName_Disable = "switch_l_grey";
            this.vibtn_Enable.VIBtn_ImgName_Enable = "switch_r_blue";
            this.vibtn_Enable.VIBtn_ImgName_Hover = "switch_l_grey";
            this.vibtn_Enable.VIBtn_ShowBorder = false;
            this.vibtn_Enable.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vibtn_Enable_ButtonClicked);
            // 
            // ScriptItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.vibtn_Delete);
            this.Controls.Add(this.vibtn_Edit);
            this.Controls.Add(this.vibtn_Play);
            this.Controls.Add(this.vibtn_Loop);
            this.Controls.Add(this.vibtn_Enable);
            this.Controls.Add(this.lb_HotKey);
            this.Controls.Add(this.lb_ScriptName);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.Name = "ScriptItem";
            this.Size = new System.Drawing.Size(130, 105);
            this.Load += new System.EventHandler(this.ScriptItem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ScriptItem_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_ScriptName;
        private VariableImageButton vibtn_Enable;
        private VariableImageButton vibtn_Loop;
        private VariableImageButton vibtn_Play;
        private System.Windows.Forms.Label lb_HotKey;
        private VariableImageButton vibtn_Delete;
        private VariableImageButton vibtn_Edit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
