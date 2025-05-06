namespace InputSimulator_SendInput
{
    partial class frmScriptEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScriptEditor));
            this.rtb_Codes = new System.Windows.Forms.RichTextBox();
            this.flp_CodeType = new System.Windows.Forms.FlowLayoutPanel();
            this.button200 = new System.Windows.Forms.Button();
            this.flp_Keys = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_New = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lb_Selectedtype = new System.Windows.Forms.Label();
            this.lb_SelectedKey = new System.Windows.Forms.Label();
            this.lb_codeTips = new System.Windows.Forms.Label();
            this.vbtn_AddCode = new InputSimulator_SendInput.VariableImageButton();
            this.tb_newCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_SavePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ScriptName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_HotKey = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_ShowOrder = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_SaveScript = new System.Windows.Forms.Button();
            this.swb_ActiveState = new InputSimulator_SendInput.SwitchBar();
            this.label10 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flp_CodeType.SuspendLayout();
            this.flp_Keys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_Codes
            // 
            this.rtb_Codes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Codes.BackColor = System.Drawing.Color.White;
            this.rtb_Codes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtb_Codes.Location = new System.Drawing.Point(0, 86);
            this.rtb_Codes.Name = "rtb_Codes";
            this.rtb_Codes.Size = new System.Drawing.Size(248, 433);
            this.rtb_Codes.TabIndex = 2;
            this.rtb_Codes.Text = "Delay(100);\nKeyPress(V);";
            this.rtb_Codes.Leave += new System.EventHandler(this.rtb_Leave);
            // 
            // flp_CodeType
            // 
            this.flp_CodeType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flp_CodeType.AutoScroll = true;
            this.flp_CodeType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_CodeType.Controls.Add(this.button200);
            this.flp_CodeType.Location = new System.Drawing.Point(12, 127);
            this.flp_CodeType.Name = "flp_CodeType";
            this.flp_CodeType.Size = new System.Drawing.Size(155, 493);
            this.flp_CodeType.TabIndex = 3;
            // 
            // button200
            // 
            this.button200.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button200.FlatAppearance.BorderSize = 0;
            this.button200.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button200.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button200.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button200.ForeColor = System.Drawing.Color.White;
            this.button200.Location = new System.Drawing.Point(3, 3);
            this.button200.Name = "button200";
            this.button200.Size = new System.Drawing.Size(120, 35);
            this.button200.TabIndex = 172;
            this.button200.Text = "添加";
            this.button200.UseVisualStyleBackColor = false;
            // 
            // flp_Keys
            // 
            this.flp_Keys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Keys.AutoScroll = true;
            this.flp_Keys.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Keys.Controls.Add(this.btn_New);
            this.flp_Keys.Controls.Add(this.button3);
            this.flp_Keys.Controls.Add(this.button6);
            this.flp_Keys.Controls.Add(this.button7);
            this.flp_Keys.Controls.Add(this.button8);
            this.flp_Keys.Location = new System.Drawing.Point(1, 27);
            this.flp_Keys.Name = "flp_Keys";
            this.flp_Keys.Size = new System.Drawing.Size(514, 491);
            this.flp_Keys.TabIndex = 3;
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_New.FlatAppearance.BorderSize = 0;
            this.btn_New.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_New.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_New.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btn_New.ForeColor = System.Drawing.Color.White;
            this.btn_New.Location = new System.Drawing.Point(3, 3);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(186, 28);
            this.btn_New.TabIndex = 12;
            this.btn_New.Text = "LAUNCH_MEDIA_SELECT";
            this.btn_New.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(195, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "VOLUME_MUTE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(387, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(90, 28);
            this.button6.TabIndex = 18;
            this.button6.Text = "LCONTROL";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(3, 37);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(90, 28);
            this.button7.TabIndex = 19;
            this.button7.Text = "LCONTROL";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(99, 37);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 28);
            this.button8.TabIndex = 20;
            this.button8.Text = "NUMPAD0";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "操作类型";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "按键";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "指令列表";
            // 
            // lb_Selectedtype
            // 
            this.lb_Selectedtype.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_Selectedtype.Location = new System.Drawing.Point(12, 107);
            this.lb_Selectedtype.Name = "lb_Selectedtype";
            this.lb_Selectedtype.Size = new System.Drawing.Size(157, 20);
            this.lb_Selectedtype.TabIndex = 8;
            this.lb_Selectedtype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lb_Selectedtype, "当前已选择的操作类型");
            // 
            // lb_SelectedKey
            // 
            this.lb_SelectedKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_SelectedKey.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_SelectedKey.Location = new System.Drawing.Point(134, 6);
            this.lb_SelectedKey.Name = "lb_SelectedKey";
            this.lb_SelectedKey.Size = new System.Drawing.Size(379, 20);
            this.lb_SelectedKey.TabIndex = 9;
            this.lb_SelectedKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lb_SelectedKey, "当前已选择的按键");
            // 
            // lb_codeTips
            // 
            this.lb_codeTips.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_codeTips.AutoEllipsis = true;
            this.lb_codeTips.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.lb_codeTips.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lb_codeTips.Location = new System.Drawing.Point(58, 7);
            this.lb_codeTips.Name = "lb_codeTips";
            this.lb_codeTips.Size = new System.Drawing.Size(189, 20);
            this.lb_codeTips.TabIndex = 10;
            this.lb_codeTips.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.lb_codeTips, "当前已选择的按键");
            // 
            // vbtn_AddCode
            // 
            this.vbtn_AddCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vbtn_AddCode.BackColor = System.Drawing.Color.Transparent;
            this.vbtn_AddCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.vbtn_AddCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vbtn_AddCode.HoverTips = "";
            this.vbtn_AddCode.Location = new System.Drawing.Point(221, 28);
            this.vbtn_AddCode.Name = "vbtn_AddCode";
            this.vbtn_AddCode.Size = new System.Drawing.Size(25, 23);
            this.vbtn_AddCode.TabIndex = 6;
            this.toolTip1.SetToolTip(this.vbtn_AddCode, "将指令添加到列表");
            this.vbtn_AddCode.UseHoverImg = true;
            this.vbtn_AddCode.VIBtn_BackColorDisabled = System.Drawing.Color.Transparent;
            this.vbtn_AddCode.VIBtn_BackColorEnable = System.Drawing.Color.Transparent;
            this.vbtn_AddCode.VIBtn_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.vbtn_AddCode.VIBtn_BorderRadius = 0;
            this.vbtn_AddCode.VIBtn_BorderThickness = 1;
            this.vbtn_AddCode.VIBtn_Enable = true;
            this.vbtn_AddCode.VIBtn_ImgName_Disable = "check_grey";
            this.vbtn_AddCode.VIBtn_ImgName_Enable = "check_blue";
            this.vbtn_AddCode.VIBtn_ImgName_Hover = "check_grey";
            this.vbtn_AddCode.VIBtn_ShowBorder = false;
            this.vbtn_AddCode.ButtonClicked += new InputSimulator_SendInput.VariableImageButton.ButtonClickedDelegate(this.vbtn_AddCode_ButtonClicked);
            // 
            // tb_newCode
            // 
            this.tb_newCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_newCode.BackColor = System.Drawing.Color.White;
            this.tb_newCode.Location = new System.Drawing.Point(1, 27);
            this.tb_newCode.Name = "tb_newCode";
            this.tb_newCode.Size = new System.Drawing.Size(219, 26);
            this.tb_newCode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "示例指令";
            // 
            // tb_SavePath
            // 
            this.tb_SavePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SavePath.Location = new System.Drawing.Point(77, 63);
            this.tb_SavePath.Name = "tb_SavePath";
            this.tb_SavePath.Size = new System.Drawing.Size(866, 26);
            this.tb_SavePath.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "存放路径";
            // 
            // tb_ScriptName
            // 
            this.tb_ScriptName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ScriptName.Location = new System.Drawing.Point(77, 28);
            this.tb_ScriptName.Name = "tb_ScriptName";
            this.tb_ScriptName.Size = new System.Drawing.Size(291, 26);
            this.tb_ScriptName.TabIndex = 13;
            this.tb_ScriptName.Leave += new System.EventHandler(this.tb_ScriptName_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "脚本名";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(382, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "运行/停止快捷键";
            // 
            // cb_HotKey
            // 
            this.cb_HotKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_HotKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_HotKey.ForeColor = System.Drawing.Color.Red;
            this.cb_HotKey.FormattingEnabled = true;
            this.cb_HotKey.Location = new System.Drawing.Point(501, 29);
            this.cb_HotKey.Name = "cb_HotKey";
            this.cb_HotKey.Size = new System.Drawing.Size(137, 25);
            this.cb_HotKey.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "显示顺序";
            // 
            // tb_ShowOrder
            // 
            this.tb_ShowOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ShowOrder.Location = new System.Drawing.Point(869, 28);
            this.tb_ShowOrder.Name = "tb_ShowOrder";
            this.tb_ShowOrder.Size = new System.Drawing.Size(74, 26);
            this.tb_ShowOrder.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(656, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "激活使用";
            // 
            // btn_SaveScript
            // 
            this.btn_SaveScript.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_SaveScript.BackColor = System.Drawing.Color.Teal;
            this.btn_SaveScript.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveScript.FlatAppearance.BorderSize = 0;
            this.btn_SaveScript.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btn_SaveScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_SaveScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveScript.ForeColor = System.Drawing.Color.White;
            this.btn_SaveScript.Location = new System.Drawing.Point(428, 629);
            this.btn_SaveScript.Name = "btn_SaveScript";
            this.btn_SaveScript.Size = new System.Drawing.Size(99, 35);
            this.btn_SaveScript.TabIndex = 20;
            this.btn_SaveScript.Text = "保存";
            this.btn_SaveScript.UseVisualStyleBackColor = false;
            this.btn_SaveScript.Click += new System.EventHandler(this.btn_SaveScript_Click);
            // 
            // swb_ActiveState
            // 
            this.swb_ActiveState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.swb_ActiveState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.swb_ActiveState.Location = new System.Drawing.Point(724, 30);
            this.swb_ActiveState.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.swb_ActiveState.Name = "swb_ActiveState";
            this.swb_ActiveState.Size = new System.Drawing.Size(60, 23);
            this.swb_ActiveState.swb_BackColorOff = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(245)))));
            this.swb_ActiveState.swb_BackColorOn = System.Drawing.Color.SeaGreen;
            this.swb_ActiveState.swb_BarColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(222)))), ((int)(((byte)(227)))));
            this.swb_ActiveState.swb_BarColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.swb_ActiveState.swb_BarSpacing = 2F;
            this.swb_ActiveState.swb_BorderCorlor = System.Drawing.Color.SeaGreen;
            this.swb_ActiveState.swb_BorderRadius = 9;
            this.swb_ActiveState.swb_BorderThickness = 1;
            this.swb_ActiveState.swb_OffText = "off";
            this.swb_ActiveState.swb_OnText = "on";
            this.swb_ActiveState.swb_TextDistance = 5F;
            this.swb_ActiveState.swb_TextPosition = InputSimulator_SendInput.SwitchBar.StateTextPositon.None;
            this.swb_ActiveState.SwitchState = false;
            this.swb_ActiveState.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoEllipsis = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "以下为要保存的脚本内容";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(175, 101);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.flp_Keys);
            this.splitContainer1.Panel1.Controls.Add(this.lb_SelectedKey);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.vbtn_AddCode);
            this.splitContainer1.Panel2.Controls.Add(this.rtb_Codes);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.tb_newCode);
            this.splitContainer1.Panel2.Controls.Add(this.lb_codeTips);
            this.splitContainer1.Size = new System.Drawing.Size(768, 519);
            this.splitContainer1.SplitterDistance = 516;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 22;
            // 
            // frmScriptEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(955, 676);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btn_SaveScript);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.swb_ActiveState);
            this.Controls.Add(this.tb_ShowOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_HotKey);
            this.Controls.Add(this.tb_ScriptName);
            this.Controls.Add(this.tb_SavePath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flp_CodeType);
            this.Controls.Add(this.lb_Selectedtype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmScriptEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "编辑脚本";
            this.Load += new System.EventHandler(this.frmScriptEditor_Load);
            this.flp_CodeType.ResumeLayout(false);
            this.flp_Keys.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Codes;
        private System.Windows.Forms.FlowLayoutPanel flp_CodeType;
        private System.Windows.Forms.FlowLayoutPanel flp_Keys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_New;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button200;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tb_newCode;
        private VariableImageButton vbtn_AddCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Selectedtype;
        private System.Windows.Forms.Label lb_SelectedKey;
        private System.Windows.Forms.Label lb_codeTips;
        private System.Windows.Forms.TextBox tb_SavePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ScriptName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_HotKey;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_ShowOrder;
        private SwitchBar swb_ActiveState;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_SaveScript;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}