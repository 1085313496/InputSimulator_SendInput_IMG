namespace InputSimulator_SendInput
{
    partial class frm_Index
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Index));
            this.flpList = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Alt = new System.Windows.Forms.Label();
            this.lb_Shift = new System.Windows.Forms.Label();
            this.lb_Ctrl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.vbtn_openScriptsFolder = new InputSimulator_SendInput.VariableImageButton();
            this.vbtn_editListJson = new InputSimulator_SendInput.VariableImageButton();
            this.vbtn_Refresh = new InputSimulator_SendInput.VariableImageButton();
            this.vbtn_AddScript = new InputSimulator_SendInput.VariableImageButton();
            this.vbtn_GenerateDicText = new InputSimulator_SendInput.VariableImageButton();
            this.vbtn_GenerateClassText = new InputSimulator_SendInput.VariableImageButton();
            this.SuspendLayout();
            // 
            // flpList
            // 
            this.flpList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpList.AutoScroll = true;
            this.flpList.Location = new System.Drawing.Point(12, 58);
            this.flpList.Name = "flpList";
            this.flpList.Size = new System.Drawing.Size(817, 374);
            this.flpList.TabIndex = 5;
            // 
            // lb_Alt
            // 
            this.lb_Alt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Alt.AutoSize = true;
            this.lb_Alt.BackColor = System.Drawing.Color.Transparent;
            this.lb_Alt.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lb_Alt.ForeColor = System.Drawing.Color.Gray;
            this.lb_Alt.Location = new System.Drawing.Point(813, 430);
            this.lb_Alt.Name = "lb_Alt";
            this.lb_Alt.Size = new System.Drawing.Size(23, 17);
            this.lb_Alt.TabIndex = 13;
            this.lb_Alt.Text = "Alt";
            // 
            // lb_Shift
            // 
            this.lb_Shift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Shift.AutoSize = true;
            this.lb_Shift.BackColor = System.Drawing.Color.Transparent;
            this.lb_Shift.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lb_Shift.ForeColor = System.Drawing.Color.Gray;
            this.lb_Shift.Location = new System.Drawing.Point(742, 430);
            this.lb_Shift.Name = "lb_Shift";
            this.lb_Shift.Size = new System.Drawing.Size(33, 17);
            this.lb_Shift.TabIndex = 12;
            this.lb_Shift.Text = "Shift";
            // 
            // lb_Ctrl
            // 
            this.lb_Ctrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Ctrl.AutoSize = true;
            this.lb_Ctrl.BackColor = System.Drawing.Color.Transparent;
            this.lb_Ctrl.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lb_Ctrl.ForeColor = System.Drawing.Color.Gray;
            this.lb_Ctrl.Location = new System.Drawing.Point(781, 430);
            this.lb_Ctrl.Name = "lb_Ctrl";
            this.lb_Ctrl.Size = new System.Drawing.Size(28, 17);
            this.lb_Ctrl.TabIndex = 11;
            this.lb_Ctrl.Text = "Ctrl";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(11, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "激活/锁定";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(74, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "脚本名";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(493, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "循环执行";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(548, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "执行";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(590, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "执行/暂停快捷键";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(708, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "编辑";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 7F);
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(753, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "删除";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Visible = false;
            // 
            // vbtn_openScriptsFolder
            // 
            this.vbtn_openScriptsFolder.BackColor = System.Drawing.Color.Transparent;
            this.vbtn_openScriptsFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbtn_openScriptsFolder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtn_openScriptsFolder.HoverTips = "打开脚本文件夹";
            this.vbtn_openScriptsFolder.Location = new System.Drawing.Point(166, 7);
            this.vbtn_openScriptsFolder.Name = "vbtn_openScriptsFolder";
            this.vbtn_openScriptsFolder.Size = new System.Drawing.Size(45, 45);
            this.vbtn_openScriptsFolder.TabIndex = 24;
            this.vbtn_openScriptsFolder.UseHoverImg = true;
            this.vbtn_openScriptsFolder.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vbtn_openScriptsFolder.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vbtn_openScriptsFolder.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vbtn_openScriptsFolder.VIBtn_BorderRadius = 0;
            this.vbtn_openScriptsFolder.VIBtn_BorderThickness = 1;
            this.vbtn_openScriptsFolder.VIBtn_Enable = true;
            this.vbtn_openScriptsFolder.VIBtn_ImgName_Disable = "open_folder_grey";
            this.vbtn_openScriptsFolder.VIBtn_ImgName_Enable = "open_folder_gold";
            this.vbtn_openScriptsFolder.VIBtn_ImgName_Hover = "open_folder_lightyellow";
            this.vbtn_openScriptsFolder.VIBtn_ShowBorder = false;
            this.vbtn_openScriptsFolder.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vbtn_openScriptsFolder_ButtonClicked);
            // 
            // vbtn_editListJson
            // 
            this.vbtn_editListJson.BackColor = System.Drawing.Color.Transparent;
            this.vbtn_editListJson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbtn_editListJson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtn_editListJson.HoverTips = "编辑列表文件";
            this.vbtn_editListJson.Location = new System.Drawing.Point(115, 7);
            this.vbtn_editListJson.Name = "vbtn_editListJson";
            this.vbtn_editListJson.Size = new System.Drawing.Size(45, 45);
            this.vbtn_editListJson.TabIndex = 25;
            this.vbtn_editListJson.UseHoverImg = true;
            this.vbtn_editListJson.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vbtn_editListJson.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vbtn_editListJson.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vbtn_editListJson.VIBtn_BorderRadius = 0;
            this.vbtn_editListJson.VIBtn_BorderThickness = 1;
            this.vbtn_editListJson.VIBtn_Enable = true;
            this.vbtn_editListJson.VIBtn_ImgName_Disable = "edit_file_grey";
            this.vbtn_editListJson.VIBtn_ImgName_Enable = "edit_file_gold";
            this.vbtn_editListJson.VIBtn_ImgName_Hover = "edit_file_lightyellow";
            this.vbtn_editListJson.VIBtn_ShowBorder = false;
            this.vbtn_editListJson.Visible = false;
            this.vbtn_editListJson.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vbtn_editListJson_ButtonClicked);
            // 
            // vbtn_Refresh
            // 
            this.vbtn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.vbtn_Refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbtn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtn_Refresh.HoverTips = "刷新脚本列表";
            this.vbtn_Refresh.Location = new System.Drawing.Point(64, 7);
            this.vbtn_Refresh.Name = "vbtn_Refresh";
            this.vbtn_Refresh.Size = new System.Drawing.Size(45, 45);
            this.vbtn_Refresh.TabIndex = 23;
            this.vbtn_Refresh.UseHoverImg = true;
            this.vbtn_Refresh.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vbtn_Refresh.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vbtn_Refresh.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vbtn_Refresh.VIBtn_BorderRadius = 0;
            this.vbtn_Refresh.VIBtn_BorderThickness = 1;
            this.vbtn_Refresh.VIBtn_Enable = true;
            this.vbtn_Refresh.VIBtn_ImgName_Disable = "refresh_grey";
            this.vbtn_Refresh.VIBtn_ImgName_Enable = "refresh_bluepurple";
            this.vbtn_Refresh.VIBtn_ImgName_Hover = "refresh_bluegrey";
            this.vbtn_Refresh.VIBtn_ShowBorder = false;
            this.vbtn_Refresh.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vbtn_Refresh_ButtonClicked);
            // 
            // vbtn_AddScript
            // 
            this.vbtn_AddScript.BackColor = System.Drawing.Color.Transparent;
            this.vbtn_AddScript.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbtn_AddScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtn_AddScript.HoverTips = "添加脚本";
            this.vbtn_AddScript.Location = new System.Drawing.Point(13, 7);
            this.vbtn_AddScript.Name = "vbtn_AddScript";
            this.vbtn_AddScript.Size = new System.Drawing.Size(45, 45);
            this.vbtn_AddScript.TabIndex = 23;
            this.vbtn_AddScript.UseHoverImg = true;
            this.vbtn_AddScript.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vbtn_AddScript.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vbtn_AddScript.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vbtn_AddScript.VIBtn_BorderRadius = 0;
            this.vbtn_AddScript.VIBtn_BorderThickness = 1;
            this.vbtn_AddScript.VIBtn_Enable = true;
            this.vbtn_AddScript.VIBtn_ImgName_Disable = "add_grey";
            this.vbtn_AddScript.VIBtn_ImgName_Enable = "add_green";
            this.vbtn_AddScript.VIBtn_ImgName_Hover = "add_lightgreen";
            this.vbtn_AddScript.VIBtn_ShowBorder = false;
            this.vbtn_AddScript.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vbtn_AddScript_ButtonClicked);
            // 
            // vbtn_GenerateDicText
            // 
            this.vbtn_GenerateDicText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vbtn_GenerateDicText.BackColor = System.Drawing.Color.Transparent;
            this.vbtn_GenerateDicText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbtn_GenerateDicText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtn_GenerateDicText.HoverTips = "生成本地字典";
            this.vbtn_GenerateDicText.Location = new System.Drawing.Point(770, 7);
            this.vbtn_GenerateDicText.Name = "vbtn_GenerateDicText";
            this.vbtn_GenerateDicText.Size = new System.Drawing.Size(45, 45);
            this.vbtn_GenerateDicText.TabIndex = 26;
            this.vbtn_GenerateDicText.UseHoverImg = true;
            this.vbtn_GenerateDicText.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vbtn_GenerateDicText.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vbtn_GenerateDicText.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vbtn_GenerateDicText.VIBtn_BorderRadius = 0;
            this.vbtn_GenerateDicText.VIBtn_BorderThickness = 1;
            this.vbtn_GenerateDicText.VIBtn_Enable = true;
            this.vbtn_GenerateDicText.VIBtn_ImgName_Disable = "edit_file_grey";
            this.vbtn_GenerateDicText.VIBtn_ImgName_Enable = "edit_file_gold";
            this.vbtn_GenerateDicText.VIBtn_ImgName_Hover = "edit_file_lightyellow";
            this.vbtn_GenerateDicText.VIBtn_ShowBorder = false;
            this.vbtn_GenerateDicText.Visible = false;
            this.vbtn_GenerateDicText.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vbtn_GenerateDicText_ButtonClicked);
            // 
            // vbtn_GenerateClassText
            // 
            this.vbtn_GenerateClassText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vbtn_GenerateClassText.BackColor = System.Drawing.Color.Transparent;
            this.vbtn_GenerateClassText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbtn_GenerateClassText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtn_GenerateClassText.HoverTips = "生成c#类文本文件";
            this.vbtn_GenerateClassText.Location = new System.Drawing.Point(722, 7);
            this.vbtn_GenerateClassText.Name = "vbtn_GenerateClassText";
            this.vbtn_GenerateClassText.Size = new System.Drawing.Size(45, 45);
            this.vbtn_GenerateClassText.TabIndex = 26;
            this.vbtn_GenerateClassText.UseHoverImg = true;
            this.vbtn_GenerateClassText.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vbtn_GenerateClassText.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vbtn_GenerateClassText.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vbtn_GenerateClassText.VIBtn_BorderRadius = 0;
            this.vbtn_GenerateClassText.VIBtn_BorderThickness = 1;
            this.vbtn_GenerateClassText.VIBtn_Enable = true;
            this.vbtn_GenerateClassText.VIBtn_ImgName_Disable = "edit_file_grey";
            this.vbtn_GenerateClassText.VIBtn_ImgName_Enable = "edit_file_gold";
            this.vbtn_GenerateClassText.VIBtn_ImgName_Hover = "edit_file_lightyellow";
            this.vbtn_GenerateClassText.VIBtn_ShowBorder = false;
            this.vbtn_GenerateClassText.Visible = false;
            this.vbtn_GenerateClassText.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vbtn_GenerateClassText_ButtonClicked);
            // 
            // frm_Index
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 445);
            this.Controls.Add(this.vbtn_GenerateClassText);
            this.Controls.Add(this.vbtn_GenerateDicText);
            this.Controls.Add(this.vbtn_openScriptsFolder);
            this.Controls.Add(this.vbtn_editListJson);
            this.Controls.Add(this.flpList);
            this.Controls.Add(this.vbtn_Refresh);
            this.Controls.Add(this.vbtn_AddScript);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Shift);
            this.Controls.Add(this.lb_Ctrl);
            this.Controls.Add(this.lb_Alt);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "键鼠模拟";
            this.Load += new System.EventHandler(this.frm_Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpList;
        private System.Windows.Forms.Label lb_Alt;
        private System.Windows.Forms.Label lb_Shift;
        private System.Windows.Forms.Label lb_Ctrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private VariableImageButton vbtn_AddScript;
        private VariableImageButton vbtn_Refresh;
        private VariableImageButton vbtn_openScriptsFolder;
        private VariableImageButton vbtn_editListJson;
        private VariableImageButton vbtn_GenerateDicText;
        private VariableImageButton vbtn_GenerateClassText;
    }
}