using InputSimulator_SendInput.BaseClass;
using InputSimulator_SendInput.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace InputSimulator_SendInput
{
    public partial class ScriptItem : UserControl
    {
        #region UI属性
        /// <summary>
        /// 圆角半径
        /// </summary>
        private int _borderRadius = 0;
        /// <summary>
        /// 圆角半径
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("圆角半径")]
        public int spti_BorderRadius
        {
            get { return _borderRadius; }
            set { _borderRadius = value; this.Invalidate(); }
        }

        /// <summary>
        /// 边框粗细
        /// </summary>
        private int _borderThickness = 1;
        /// <summary>
        /// 边框粗细
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("边框粗细")]
        public int spti_BorderThickness
        {
            get { return _borderThickness; }
            set { _borderThickness = value; this.Invalidate(); }
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        private Color _borderCorlor = Color.FromArgb(185, 186, 195);
        /// <summary>
        /// 边框颜色
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("边框颜色")]
        public Color spti_BorderCorlor
        {
            get { return _borderCorlor; }
            set { _borderCorlor = value; this.Invalidate(); }
        }


        /// <summary>
        /// 激活状态
        /// </summary>
        private bool _state = false;
        /// <summary>
        /// 激活状态
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("激活状态")]
        public bool spti_ActiveState
        {
            get { return _state; }
            set
            {
                _state = value;

                vibtn_Enable.VIBtn_Enable = value;

                vibtn_Loop.Enabled = value;
                vibtn_Play.Enabled = value;
                //vibtn_Edit.Enabled = value;
                //vibtn_Delete.Enabled = value;
                lb_HotKey.Enabled = value;

                _scriptContent.Enable = value;

                this.Invalidate();
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("激活状态")]
        public bool spti_LoopMode
        {
            get { return vibtn_Loop.VIBtn_Enable; }
            set
            {
                vibtn_Loop.VIBtn_Enable = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// 禁用状态背景色
        /// </summary>
        private Color _backColorOff = Color.FromArgb(243, 244, 245);
        /// <summary>
        /// 禁用状态背景色
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("禁用状态背景色")]
        public Color spti_BackColorDisabled
        {
            get { return _backColorOff; }
            set { _backColorOff = value; this.Invalidate(); }
        }

        /// <summary>
        /// 启用状态背景色
        /// </summary>
        private Color _backColorOn = Color.White;
        /// <summary>
        /// 启用状态背景色
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("启用状态背景色")]
        public Color spti_BackColorEnable
        {
            get { return _backColorOn; }
            set { _backColorOn = value; this.Invalidate(); }
        }
        #endregion

        #region 脚本信息相关属性
        /// <summary>
        /// 脚本内容
        /// </summary>
        public ScriptContent _scriptContent { get; set; } = new ScriptContent();

        /// <summary>
        /// 脚本名称
        /// </summary>
        public string ScriptName
        {
            get { return lb_ScriptName.Text; }
            set { lb_ScriptName.Text = value; }
        }
        /// <summary>
        /// 运行/暂停快捷键
        /// </summary>
        public string HotKey
        {
            get { return lb_HotKey.Text; }
            set { lb_HotKey.Text = value; }
        }
        /// <summary>
        /// 脚本路径
        /// </summary>
        public string ScriptPath { get; set; }
        /// <summary>
        /// 脚本显示顺序
        /// </summary>
        public int OrderNum { get; set; }
        #endregion

        #region 事件
        public delegate void VIBTNClickEventHandler(object sender, EventArgs e);
        /// <summary>
        /// 启用按钮点击事件
        /// </summary>
        public event VIBTNClickEventHandler VIBTN_Enable_Clicked;
        /// <summary>
        /// 循环按钮点击事件
        /// </summary>
        public event VIBTNClickEventHandler VIBTN_Loop_Clicked;
        /// <summary>
        /// 播放按钮点击事件
        /// </summary>
        public event VIBTNClickEventHandler VIBTN_Play_Clicked;
        /// <summary>
        /// 暂停按钮点击事件
        /// </summary>
        public event VIBTNClickEventHandler VIBTN_ShortKey_Pressed;
        /// <summary>
        /// 编辑按钮点击事件
        /// </summary>
        public event VIBTNClickEventHandler VIBTN_Edit_Clicked;
        /// <summary>
        /// 删除按钮点击事件
        /// </summary>
        public event VIBTNClickEventHandler VIBTN_Delete_Clicked;
        #endregion

        private bool _running = false;
        /// <summary>
        /// 是否已在运行脚本
        /// </summary>
        public bool IsRunning
        {
            get { return _running; }
            set
            {
                _running = value;

                if (RunningStateChanged != null)
                    RunningStateChanged(value);
            }
        }
        /// <summary>
        /// 是否正在循环运行
        /// </summary>
        private bool EnableLoopRunning = false;

        public delegate void RunningStateChangedDelegate(bool isRunning, string ExtraInfo = "");
        public event RunningStateChangedDelegate RunningStateChanged;

        public ScriptItem()
        {
            InitializeComponent();
            SetWMStyles();
            initSPI();
        }

        private void ScriptItem_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                lb_ScriptName.BorderStyle = BorderStyle.None;
                lb_HotKey.BorderStyle = BorderStyle.None;
            }
        }
        private void initSPI()
        {
            vibtn_Enable.VIBtn_Enable = false;
            vibtn_Loop.VIBtn_Enable = false;
            vibtn_Play.VIBtn_Enable = false;
            vibtn_Edit.VIBtn_Enable = true;
            vibtn_Delete.VIBtn_Enable = true;
            lb_HotKey.ForeColor = Color.Gray;
        }
        private void ScriptItem_Paint(object sender, PaintEventArgs e) { PaintBody(e); }

        #region 绘制圆角背景及边框
        private void SetWMStyles()
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
        private void PaintBody(PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                #region 计算坐标与大小
                float containerWidth = this.Width - this.Padding.Left - this.Padding.Right - 1;
                float containerHeight = this.Height - this.Padding.Top - this.Padding.Bottom - 1;

                float containerX = this.Padding.Left;
                float containerY = this.Padding.Top;

                float barOffX = containerX + _borderThickness + 1;
                float barOffY = containerY + _borderThickness + 1;

                float spw = 1;
                float barOnX = containerWidth / 2f + spw;
                float barOnY = containerY + _borderThickness + 1;
                #endregion

                #region 绘制圆角背景及边框
                using (Pen p = new Pen(_borderCorlor, _borderThickness))
                {
                    Rectangle recO = new Rectangle((int)containerX, (int)containerY, (int)containerWidth, (int)containerHeight);

                    Color cl = _state ? _backColorOn : _backColorOff;
                    using (SolidBrush sb = new SolidBrush(cl))
                    {
                        g.FillPath(sb, GetRoundRectangle(recO, _borderRadius));
                    }

                    g.DrawPath(p, GetRoundRectangle(recO, _borderRadius));
                }
                #endregion
            }
            catch (Exception ex) { }
            finally
            {
                //  GC.Collect();
            }
        }
        /// <summary>  
        /// 根据普通矩形得到圆角矩形的路径  
        /// </summary>  
        /// <param name="rectangle">原始矩形</param>  
        /// <param name="r">半径</param>  
        /// <returns>图形路径</returns>  
        private GraphicsPath GetRoundRectangle(Rectangle rectangle, int r)
        {
            int l = r == 0 ? 1 : 2 * r;
            // 把圆角矩形分成八段直线、弧的组合，依次加到路径中  
            GraphicsPath gp = new GraphicsPath();
            gp.AddLine(new Point(rectangle.X + r, rectangle.Y), new Point(rectangle.Right - r, rectangle.Y));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Y, l, l), 270F, 90F);

            gp.AddLine(new Point(rectangle.Right, rectangle.Y + r), new Point(rectangle.Right, rectangle.Bottom - r));
            gp.AddArc(new Rectangle(rectangle.Right - l, rectangle.Bottom - l, l, l), 0F, 90F);

            gp.AddLine(new Point(rectangle.Right - r, rectangle.Bottom), new Point(rectangle.X + r, rectangle.Bottom));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Bottom - l, l, l), 90F, 90F);

            gp.AddLine(new Point(rectangle.X, rectangle.Bottom - r), new Point(rectangle.X, rectangle.Y + r));
            gp.AddArc(new Rectangle(rectangle.X, rectangle.Y, l, l), 180F, 90F);
            return gp;
        }
        #endregion

        #region 脚本读取及编辑
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="_scriptName"></param>
        /// <param name="_hotKey"></param>
        /// <param name="_scriptPath"></param>
        /// <param name="_orderNum"></param>
        /// <param name="_enable"></param>
        public void Init(string _scriptName, string _hotKey, string _scriptPath, int _orderNum, bool _enable)
        {
            ScriptName = _scriptName;
            HotKey = _hotKey;
            ScriptPath = _scriptPath;
            OrderNum = _orderNum;
            spti_ActiveState = _enable;
        }
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="_SCT"></param>
        public void Init(ScriptContent _SCT)
        {
            _scriptContent = _SCT;

            ScriptName = _SCT.Name;
            HotKey = _SCT.HotKey;
            OrderNum = _SCT.Order;
            spti_ActiveState = _SCT.Enable;
            spti_LoopMode = _SCT.LoopMode;
        }
        /// <summary>
        /// 重新加载脚本内容
        /// </summary>
        public void ReloadScriptContent()
        {
            try
            {
                string content = File.ReadAllText(ScriptPath);
                if (string.IsNullOrEmpty(content))
                    return;

                ScriptContent SCT = JsonConvert.DeserializeObject<ScriptContent>(content);
                if (SCT == null)
                    return;

                _scriptContent = SCT;
            }
            catch (Exception ex)
            {
                ToastMessageBox.Show("重载脚本内容出错！", 0);
            }
        }
        /// <summary>
        /// 删除脚本文件
        /// </summary>
        private void DeleteScript()
        {
            try
            {
                string _FilePath = string.Format("{0}\\{1}", Application.StartupPath, ScriptPath);
                if (File.Exists(_FilePath))
                {
                    File.Delete(_FilePath);
                }
                MessageShowList.SendSaveCompletedMsg(this, true, null, "");
            }
            catch (Exception ex)
            {
                MessageBox.Show("删除文件时出现异常！\r\n" + ex.Message, "提示");
            }
        }

        /// <summary>
        /// 保存脚本内容
        /// </summary>
        private void SaveScriptContent()
        {
            try
            {
                if (File.Exists(ScriptPath))
                {
                    File.Delete(ScriptPath);
                }
                File.WriteAllText(ScriptPath, JsonConvert.SerializeObject(_scriptContent));
            }
            catch (Exception ex)
            {
                ToastMessageBox.Show("保存文件时出现异常！\r\n" + ex.Message, 0);
            }
        }
        #endregion

        #region 运行脚本相关
        private SendKeyboardMouse SendKBM = new SendKeyboardMouse();
        private Thread th = null;

        /// <summary>
        /// 开始运行脚本
        /// </summary>
        public void RunScript()
        {
            ReloadScriptContent();
            if (_scriptContent.Actions == null || _scriptContent.Actions.Count < 1)
                return;

            if (IsRunning)
                return;

            bool loopMode = vibtn_Loop.VIBtn_Enable;
            if (th != null && th.IsAlive)
            {
                th.Abort();
                th = null;
            }

            th = new Thread(new ThreadStart(() =>
            {
                EnableLoopRunning = true;
                IsRunning = true;

                lb_HotKey.ForeColor = Color.Red;
                vibtn_Play.VIBtn_Enable = true;

                if (loopMode)
                {
                    //循环执行
                    while (EnableLoopRunning)
                    {
                        ReadCommandAndRun();
                    }
                }
                else
                {
                    //只执行一次
                    ReadCommandAndRun();
                }

                StopScript();
            }));
            th.IsBackground = true;
            th.Start();
        }
        /// <summary>
        /// 逐行分析指令并执行
        /// </summary>
        private void ReadCommandAndRun()
        {
            _scriptContent.SortSelf();
            foreach (ScriptAction scta in _scriptContent.Actions)
            {
                if (!IsRunning)
                    return;

                ExcuteCommand(scta);
            }
        }
        /// <summary>
        /// 执行脚本指令
        /// </summary>
        /// <param name="scta"></param>
        private void ExcuteCommand(ScriptAction scta, object ExtraData = null)
        {
            string cdType = scta.ActionType.ToUpper();
            string codeValue = scta.ActionValue.ToUpper();

            //Common.WriteFile("执行指令", string.Format("B_cdType={0},codeValue={1}", cdType, codeValue), "TEST");

            try
            {
                switch (cdType)
                {
                    #region 延时
                    case "Delay":
                    case "DELAY":
                        int itv = 0;
                        int delayMs = int.TryParse(codeValue, out itv) ? itv : 0;
                        Thread.Sleep(delayMs);
                        break;
                    #endregion

                    #region 按键操作
                    #region 按下并释放按键
                    case "KeyPress":
                    case "KEYPRESS":
                        byte key = GlobalParams.GetKeyCode(codeValue);
                        if (key > 0)
                            SendKBM.SendKeyPress(key);
                        break;
                    #endregion

                    #region 按住按键
                    case "KeyDown":
                    case "KEYDOWN":
                        byte key1 = GlobalParams.GetKeyCode(codeValue);
                        if (key1 > 0)
                            SendKBM.SendKeyDown(key1);
                        break;
                    #endregion

                    #region 释放按键
                    case "KeyUp":
                    case "KEYUP":
                        byte key2 = GlobalParams.GetKeyCode(codeValue);
                        if (key2 > 0)
                            SendKBM.SendKeyUp(key2);
                        break;
                    #endregion
                    #endregion

                    #region 鼠标操作
                    #region 点击鼠标按键
                    case "MouseClick":
                    case "MOUSECLICK":
                        switch (codeValue)
                        {
                            case "LBUTTON":
                            case "L": SendKBM.MouseLeftClick(); break;
                            case "MBUTTON":
                            case "M": SendKBM.MouseMiddleClick(); break;
                            case "RBUTTON":
                            case "R": SendKBM.MouseRightClick(); break;
                        }
                        break;
                    #endregion

                    #region 按住鼠标按键
                    case "MouseDown":
                    case "MOUSEDOWN":
                        switch (codeValue)
                        {
                            case "LBUTTON":
                            case "L": SendKBM.MouseLeftDown(); break;
                            case "MBUTTON":
                            case "M": SendKBM.MouseMiddleDown(); break;
                            case "RBUTTON":
                            case "R": SendKBM.MouseRightDown(); break;
                        }
                        break;
                    #endregion

                    #region 释放鼠标按键
                    case "MouseUp":
                    case "MOUSEUP":
                        switch (codeValue)
                        {
                            case "LBUTTON":
                            case "L": SendKBM.MouseLeftUp(); break;
                            case "MBUTTON":
                            case "M": SendKBM.MouseMiddleUp(); break;
                            case "RBUTTON":
                            case "R": SendKBM.MouseRightUp(); break;
                        }
                        break;
                    #endregion

                    #region 滑动鼠标滚轮
                    case "MouseWhell":
                    case "MOUSEWHELL":
                        int scroll = 0;
                        int.TryParse(codeValue, out scroll);
                        SendKBM.MouseWhell(scroll);
                        break;
                    #endregion


                    #region 鼠标出现在指定坐标
                    case "MouseMove":
                    case "MOUSEMOVE":
                        Point _pt = GetPointFromCodeValue(codeValue, ExtraData);
                        SendKBM.MouseMove(_pt);
                        break;
                    #endregion

                    #region 鼠标移动到指定坐标
                    case "MouseMove_A":
                    case "MOUSEMOVE_A":
                        Point _ptA = GetPointFromCodeValue(codeValue, ExtraData);
                        SendKBM.MouseMove_A(_ptA, Control.MousePosition);
                        break;
                    #endregion


                    #region 鼠标出现在屏幕中心
                    case "MouseMoveToCenter":
                    case "MOUSEMOVETOCENTER":
                        int cx = Screen.PrimaryScreen.WorkingArea.Width / 2;
                        int cy = Screen.PrimaryScreen.WorkingArea.Height / 2;
                        SendKBM.MouseMove(new Point(cx, cy));
                        break;
                    #endregion

                    #region 鼠标移动到屏幕中心
                    case "MouseMoveToCenter_A":
                    case "MOUSEMOVETOCENTER_A":
                        int cxA = Screen.PrimaryScreen.WorkingArea.Width / 2;
                        int cyA = Screen.PrimaryScreen.WorkingArea.Height / 2;
                        SendKBM.MouseMove_A(new Point(cxA, cyA), Control.MousePosition);
                        break;
                    #endregion


                    #region 鼠标相对坐标移动 无轨迹
                    case "MouseMove_R":
                    case "MOUSEMOVE_R":
                    case "MouseMove_Relative":
                    case "MOUSEMOVE_RELATIVE":
                        Point _ptR = GetPointFromCodeValue(codeValue, ExtraData);
                        SendKBM.MouseMove_Relative(_ptR.X, _ptR.Y);
                        break;
                    #endregion

                    #region 鼠标相对坐标移动（带轨迹）
                    case "MouseMove_RA":
                    case "MOUSEMOVE_RA":
                    case "MouseMove_Relative_A":
                    case "MOUSEMOVE_RELATIVE_A":
                        Point _ptRA = GetPointFromCodeValue(codeValue, ExtraData);
                        SendKBM.MouseMove_Relative_A(_ptRA.X, _ptRA.Y);
                        break;
                    #endregion
                    #endregion

                    #region 屏幕图案检测
                    case "DetectImg":
                    case "识图":
                    case "检测图案":
                    case "DETECTIMG":
                        Point pt = new Point(0, 0);
                        bool bl = ScreenPatternDetector.IsPatternPresent(codeValue, scta.Detectconfig, out pt);
                        if (bl)
                        {
                            #region 有图案
                           // Common.WriteFile("执行指令", string.Format("matchPt={0},{1}", pt.X, pt.Y), "TEST");

                            #region 此处返回的坐标为图案在检测区域的坐标，需要加上检测区域起始坐标修正
                            int _xG = pt.X + getXYFromDetectconfig(scta, "X");
                            int _yG = pt.Y + getXYFromDetectconfig(scta, "Y");
                            Point _ptG = new Point(_xG, _yG);
                            #endregion

                            List<SubScriptAction> ls = scta.SortActionsList(scta.MatchActions);
                            foreach (SubScriptAction _sta in ls)
                            {
                                ScriptAction _sa = new ScriptAction();
                                _sa.SerialNo = _sta.SerialNo;
                                _sa.ActionType = _sta.ActionType;
                                _sa.ActionValue = _sta.ActionValue;
                                ExcuteCommand(_sa, _ptG);
                            }
                            #endregion
                        }
                        else
                        {
                            #region 无图案
                           // Common.WriteFile("执行指令", string.Format("unMatchPt={0},{1}", pt.X, pt.Y), "TEST");
                            List<SubScriptAction> ls = scta.SortActionsList(scta.UnmatchActions);
                            foreach (SubScriptAction _sta in ls)
                            {
                                ScriptAction _sa = new ScriptAction();
                                _sa.SerialNo = _sta.SerialNo;
                                _sa.ActionType = _sta.ActionType;
                                _sa.ActionValue = _sta.ActionValue;
                                ExcuteCommand(_sa, pt);
                            }
                            #endregion
                        }
                        break;
                        #endregion
                }
               // Common.WriteFile("执行指令", string.Format("E_cdType={0},codeValue={1}", cdType, codeValue), "TEST");
            }
            catch (Exception ex)
            {
                //Common.WriteFile("执行指令", string.Format("Ex_cdType={0},codeValue={1},ExcetionMsg={2}", cdType, codeValue, ex.Message), "TEST");
            }
        }
        /// <summary>
        /// 获取图案检测区域的起始坐标
        /// </summary>
        /// <param name="scta"></param>
        /// <param name="XorY"></param>
        /// <returns></returns>
        private int getXYFromDetectconfig(ScriptAction scta, string XorY = "X")
        {
            try
            {
                int i = 0;
                switch (XorY)
                {
                    case "X": i = scta.Detectconfig.SearchArea.X; break;
                    case "Y": i = scta.Detectconfig.SearchArea.Y; break;
                }
                return i;
            }
            catch { return 0; }
        }
        /// <summary>
        /// 从脚本指令中获取坐标
        /// </summary>
        /// <param name="_codeValue"></param>
        /// <param name="ExtraData"></param>
        /// <returns></returns>
        private Point GetPointFromCodeValue(string _codeValue, object ExtraData)
        {
            try
            {
                Point _mpt;
                if (GlobalParams.lsMatchedPointName.Contains(_codeValue))
                {
                    if (ExtraData != null)
                        _mpt = (Point)ExtraData;
                    else
                        _mpt = new Point(0, 0);
                }
                else
                {
                    int x = 0, y = 0;
                    int.TryParse(_codeValue.Split(',')[0], out x);
                    int.TryParse(_codeValue.Split(',')[1], out y);
                    _mpt = new Point(x, y);
                }
                return _mpt;
            }
            catch (Exception ex)
            {
                return new Point(0, 0);
            }
        }
        /// <summary>
        /// 停止运行脚本
        /// </summary>
        public void StopScript()
        {
            IsRunning = false;
            EnableLoopRunning = false;

            lb_HotKey.ForeColor = Color.Gray;
            vibtn_Play.VIBtn_Enable = false;

            if (th != null && th.IsAlive)
            {
                th.Abort();
                th = null;
            }
        }
        #endregion

        #region 按钮事件
        private void vibtn_Enable_ButtonClicked(object sender, EventArgs e)
        {
            this.spti_ActiveState = !this.spti_ActiveState;
            SaveScriptContent();

            if (VIBTN_Enable_Clicked != null)
                VIBTN_Enable_Clicked(this, e);
        }
        private void vibtn_Loop_ButtonClicked(object sender, EventArgs e)
        {
            if (!this.spti_ActiveState)
                return;

            if (IsRunning)
            {
                StopScript();
                RunScript();
            }

            bool loopMode = vibtn_Loop.VIBtn_Enable;
            _scriptContent.LoopMode = loopMode;
            SaveScriptContent();

            if (VIBTN_Loop_Clicked != null)
                VIBTN_Loop_Clicked(this, e);
        }
        private void vibtn_Play_ButtonClicked(object sender, EventArgs e)
        {
            if (!this.spti_ActiveState)
                return;

            if (IsRunning)
                StopScript();
            else
                RunScript();

            if (VIBTN_Play_Clicked != null)
                VIBTN_Play_Clicked(this, e);
        }
        private void vibtn_Edit_ButtonClicked(object sender, EventArgs e)
        {
            //if (!this.spti_ActiveState)
            //    return;

            if (IsRunning)
            {
                ToastMessageBox.Show("脚本正在运行，请先停止运行再编辑！");
            }
            else
            {
                ReloadScriptContent();
                frmScriptEditor_V2 fsce = new frmScriptEditor_V2(_scriptContent, ScriptPath);
                fsce.Show();
            }

            if (VIBTN_Edit_Clicked != null)
                VIBTN_Edit_Clicked(this, e);
        }
        private void vibtn_Delete_ButtonClicked(object sender, EventArgs e)
        {
            //if (!this.spti_ActiveState)
            //    return;

            if (IsRunning)
            {
                ToastMessageBox.Show("脚本正在运行，请先停止运行再删除！");
            }
            else
            {
                if (MessageBox.Show("确认删除？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DeleteScript();
                }
            }

            if (VIBTN_Delete_Clicked != null)
                VIBTN_Delete_Clicked(this, e);
        }
        private void lb_HotKey_Click(object sender, EventArgs e)
        {
            if (!this.spti_ActiveState)
                return;

            if (VIBTN_ShortKey_Pressed != null)
                VIBTN_ShortKey_Pressed(this, e);
        }
        #endregion
    }
}
