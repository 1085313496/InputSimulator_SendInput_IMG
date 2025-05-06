namespace InputSimulator_SendInput
{
    partial class VariableImageButton
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
            this.pbd_top = new System.Windows.Forms.Panel();
            this.pbd_right = new System.Windows.Forms.Panel();
            this.pbd_bottom = new System.Windows.Forms.Panel();
            this.pbd_left = new System.Windows.Forms.Panel();
            this.pb_Img = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img)).BeginInit();
            this.SuspendLayout();
            // 
            // pbd_top
            // 
            this.pbd_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.pbd_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbd_top.Location = new System.Drawing.Point(0, 0);
            this.pbd_top.MaximumSize = new System.Drawing.Size(0, 1);
            this.pbd_top.Name = "pbd_top";
            this.pbd_top.Size = new System.Drawing.Size(114, 1);
            this.pbd_top.TabIndex = 0;
            // 
            // pbd_right
            // 
            this.pbd_right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.pbd_right.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbd_right.Location = new System.Drawing.Point(113, 1);
            this.pbd_right.MaximumSize = new System.Drawing.Size(1, 0);
            this.pbd_right.Name = "pbd_right";
            this.pbd_right.Size = new System.Drawing.Size(1, 106);
            this.pbd_right.TabIndex = 1;
            // 
            // pbd_bottom
            // 
            this.pbd_bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.pbd_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbd_bottom.Location = new System.Drawing.Point(0, 106);
            this.pbd_bottom.MaximumSize = new System.Drawing.Size(0, 1);
            this.pbd_bottom.Name = "pbd_bottom";
            this.pbd_bottom.Size = new System.Drawing.Size(113, 1);
            this.pbd_bottom.TabIndex = 2;
            // 
            // pbd_left
            // 
            this.pbd_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(186)))), ((int)(((byte)(195)))));
            this.pbd_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbd_left.Location = new System.Drawing.Point(0, 1);
            this.pbd_left.MaximumSize = new System.Drawing.Size(1, 0);
            this.pbd_left.Name = "pbd_left";
            this.pbd_left.Size = new System.Drawing.Size(1, 105);
            this.pbd_left.TabIndex = 3;
            // 
            // pb_Img
            // 
            this.pb_Img.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb_Img.Location = new System.Drawing.Point(1, 1);
            this.pb_Img.Name = "pb_Img";
            this.pb_Img.Size = new System.Drawing.Size(112, 105);
            this.pb_Img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Img.TabIndex = 4;
            this.pb_Img.TabStop = false;
            this.pb_Img.Click += new System.EventHandler(this.pb_Img_Click);
            this.pb_Img.MouseEnter += new System.EventHandler(this.pb_Img_MouseEnter);
            this.pb_Img.MouseLeave += new System.EventHandler(this.pb_Img_MouseLeave);
            // 
            // VariableImageButton
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.pb_Img);
            this.Controls.Add(this.pbd_left);
            this.Controls.Add(this.pbd_bottom);
            this.Controls.Add(this.pbd_right);
            this.Controls.Add(this.pbd_top);
            this.DoubleBuffered = true;
            this.Name = "VariableImageButton";
            this.Size = new System.Drawing.Size(114, 107);
            this.Load += new System.EventHandler(this.VariableImageButton_Load);
            this.EnabledChanged += new System.EventHandler(this.VariableImageButton_EnabledChanged);
            this.Click += new System.EventHandler(this.VariableImageButton_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.VariableImageButton_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pbd_top;
        private System.Windows.Forms.Panel pbd_right;
        private System.Windows.Forms.Panel pbd_bottom;
        private System.Windows.Forms.Panel pbd_left;
        private System.Windows.Forms.PictureBox pb_Img;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
