namespace InputSimulator_SendInput.Forms
{
    partial class treeViewTest
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
            this.tv = new System.Windows.Forms.TreeView();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ActionType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tv
            // 
            this.tv.AllowDrop = true;
            this.tv.Location = new System.Drawing.Point(14, 14);
            this.tv.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(408, 529);
            this.tv.TabIndex = 0;
            this.tv.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tv_ItemDrag);
            this.tv.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseClick);
            this.tv.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tv_NodeMouseDoubleClick);
            this.tv.DragDrop += new System.Windows.Forms.DragEventHandler(this.tv_DragDrop);
            this.tv.DragEnter += new System.Windows.Forms.DragEventHandler(this.tv_DragEnter);
            // 
            // rtb
            // 
            this.rtb.Location = new System.Drawing.Point(431, 280);
            this.rtb.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.rtb.Name = "rtb";
            this.rtb.Size = new System.Drawing.Size(510, 263);
            this.rtb.TabIndex = 1;
            this.rtb.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(448, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "操作类型";
            // 
            // lb_ActionType
            // 
            this.lb_ActionType.AutoSize = true;
            this.lb_ActionType.Location = new System.Drawing.Point(528, 25);
            this.lb_ActionType.Name = "lb_ActionType";
            this.lb_ActionType.Size = new System.Drawing.Size(0, 21);
            this.lb_ActionType.TabIndex = 2;
            // 
            // treeViewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 552);
            this.Controls.Add(this.lb_ActionType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb);
            this.Controls.Add(this.tv);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "treeViewTest";
            this.Text = "treeViewTest";
            this.Load += new System.EventHandler(this.treeViewTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.RichTextBox rtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ActionType;
    }
}