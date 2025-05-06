using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace InputSimulator_SendInput
{
    public partial class VariableImageButton : UserControl
    {
        #region  属性
        /// <summary>
        /// 当前Disable = "check_gray";状态图标名
        /// </summary>
        private string _VIBtn_ImgName_Current = "check_darkgreen";
        /// <summary>
        /// 启用状态图标名
        /// </summary>
        private string _VIBtn_ImgName_Enable = "check_blue";
        /// <summary>
        /// 禁用状态图标名
        /// </summary>
        private string _VIBtn_ImgName_Disable = "check_grey";
        /// <summary>
        /// 鼠标移入状态图标名
        /// </summary>
        private string _VIBtn_ImgName_Hover = "check_grey";

        private string _hoverTips = "";
        /// <summary>
        /// 鼠标移动到 此项目上的提示
        /// </summary>
        public string HoverTips
        {
            get
            {
                return _hoverTips;
            }
            set
            {
                _hoverTips = value;
                if (string.IsNullOrWhiteSpace(_hoverTips))
                    toolTip1.RemoveAll();
                else
                    toolTip1.SetToolTip(pb_Img, value);
            }
        }

        /// <summary>
        /// 当前状态图标名
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("当前状态图标名")]
        public string VIBtn_ImgName_Current
        {
            get { return _VIBtn_ImgName_Current; }
            // set { _VIBtn_ImgName_Current = value; }
        }
        /// <summary>
        /// 启用状态图标名
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("启用状态图标名")]
        public string VIBtn_ImgName_Enable
        {
            get { return _VIBtn_ImgName_Enable; }
            set
            {
                _VIBtn_ImgName_Enable = value;
                if (_btnEnable)
                {
                    _VIBtn_ImgName_Current = VIBtn_ImgName_Enable;
                    this.pb_Img.Image = GlobalParams.GetImgFromRes(VIBtn_ImgName_Current);
                }
            }
        }
        /// <summary>
        /// 禁用状态图标名
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("禁用状态图标名")]
        public string VIBtn_ImgName_Disable
        {
            get { return _VIBtn_ImgName_Disable; }
            set
            {
                _VIBtn_ImgName_Disable = value;
                if (!_btnEnable)
                {
                    _VIBtn_ImgName_Current = VIBtn_ImgName_Disable;
                    this.pb_Img.Image = GlobalParams.GetImgFromRes(VIBtn_ImgName_Current);
                }
            }
        }
        /// <summary>
        /// 鼠标移入状态图标名
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("鼠标移入状态图标名")]
        public string VIBtn_ImgName_Hover
        {
            get { return _VIBtn_ImgName_Hover; }
            set { _VIBtn_ImgName_Hover = value; }
        }
        public bool UseHoverImg { get; set; } = false;

        /// <summary>
        /// 按钮是否启用
        /// </summary>
        private bool _btnEnable = true;
        /// <summary>
        /// 按钮是否启用
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("按钮是否启用")]
        public bool VIBtn_Enable
        {
            get { return _btnEnable; }
            set
            {
                _btnEnable = value;

                if (_btnEnable)
                {
                    _VIBtn_ImgName_Current = VIBtn_ImgName_Enable;
                }
                else
                {
                    _VIBtn_ImgName_Current = VIBtn_ImgName_Disable;
                }
                this.pb_Img.Image = GlobalParams.GetImgFromRes(VIBtn_ImgName_Current);
            }
        }

        /// <summary>
        /// 是否显示边框
        /// </summary>
        private bool _showBorder = true;
        /// <summary>
        /// 是否显示边框
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("是否显示边框")]
        public bool VIBtn_ShowBorder
        {
            get { return _showBorder; }
            set { _showBorder = value; }
        }
        #endregion

        #region 圆角背景及边框属性
        /// <summary>
        /// 圆角半径
        /// </summary>
        private int _borderRadius = 0;
        /// <summary>
        /// 圆角半径
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("圆角半径")]
        public int VIBtn_BorderRadius
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
        public int VIBtn_BorderThickness
        {
            get { return _borderThickness; }
            set { _borderThickness = value; this.Invalidate(); }
        }

        /// <summary>
        /// 边框颜色
        /// </summary>
        private Color _borderColor = Color.FromArgb(185, 186, 195);
        /// <summary>
        /// 边框颜色
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("边框颜色")]
        public Color VIBtn_BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; this.Invalidate(); }
        }
        /// <summary>
        /// 禁用状态背景色
        /// </summary>
        private Color _backColorOff = Color.Transparent;
        /// <summary>
        /// 禁用状态背景色
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("禁用状态背景色")]
        public Color VIBtn_BackColorDisabled
        {
            get { return _backColorOff; }
            set { _backColorOff = value; this.Invalidate(); }
        }

        /// <summary>
        /// 启用状态背景色
        /// </summary>
        private Color _backColorOn = Color.Transparent;
        /// <summary>
        /// 启用状态背景色
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true), Category("SwitchBar"), Description("启用状态背景色")]
        public Color VIBtn_BackColorEnable
        {
            get { return _backColorOn; }
            set { _backColorOn = value; this.Invalidate(); }
        }
        #endregion

        public delegate void ButtonClickedDelegate(object sender, EventArgs e);
        /// <summary>
        /// 按钮事件
        /// </summary>
        public event ButtonClickedDelegate ButtonClicked;

        public VariableImageButton() { InitializeComponent(); SetWMStyles(); }
        private void VariableImageButton_Load(object sender, EventArgs e)
        {
            InitPage();
        }

        private void InitPage()
        {
            pb_Img.Paint += new PaintEventHandler(pictureBox1_Paint);
            this.Cursor = Cursors.Hand;
            this.pb_Img.Image = GlobalParams.GetImgFromRes(VIBtn_ImgName_Current);

            this.pbd_top.Visible = false;
            this.pbd_right.Visible = false;
            this.pbd_bottom.Visible = false;
            this.pbd_left.Visible = false;
        }

        private void VariableImageButton_Click(object sender, EventArgs e)
        {
            if (!UseHoverImg)
                VIBtn_Enable = !VIBtn_Enable;
            if (ButtonClicked != null)
                ButtonClicked(this, e);
        }
        private void VariableImageButton_Paint(object sender, PaintEventArgs e) { PaintBody(e); }

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
                using (Pen p = new Pen(_borderColor, _borderThickness))
                {
                    Rectangle recO = new Rectangle((int)containerX, (int)containerY, (int)containerWidth, (int)containerHeight);

                    Color cl = _btnEnable ? _backColorOn : _backColorOff;
                    using (SolidBrush sb = new SolidBrush(cl))
                    {
                        g.FillPath(sb, GetRoundRectangle(recO, _borderRadius));
                    }

                    if (_showBorder)
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


        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            e.Graphics.DrawImage(pb_Img.Image, new Rectangle(0, 0, pb_Img.Width, pb_Img.Height));
        }

        private void pb_Img_Click(object sender, EventArgs e) { VariableImageButton_Click(this, e); }

        private void VariableImageButton_EnabledChanged(object sender, EventArgs e)
        {
            //VIBtn_Enable = this.Enabled;
        }

        private void pb_Img_MouseEnter(object sender, EventArgs e)
        {
            if (!UseHoverImg)
                return;
            this.pb_Img.Image = GlobalParams.GetImgFromRes(VIBtn_ImgName_Hover);
        }
        private void pb_Img_MouseLeave(object sender, EventArgs e)
        {
            if (!UseHoverImg)
                return;
            this.pb_Img.Image = GlobalParams.GetImgFromRes(VIBtn_ImgName_Current);
        }
    }
}
