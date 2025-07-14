using InputSimulator_SendInput.BaseClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InputSimulator_SendInput.Forms
{
    public partial class treeViewTest : Form
    {
        public treeViewTest()
        {
            InitializeComponent();
        }

        private void treeViewTest_Load(object sender, EventArgs e)
        {
            ReloadScriptContent();
        }

        public void ReloadScriptContent()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts//指令合集.txt");
                string content = File.ReadAllText(filePath);
                if (string.IsNullOrEmpty(content))
                    return;

                ScriptContent SCT = JsonConvert.DeserializeObject<ScriptContent>(content);
                if (SCT == null)
                    return;

                List<ScriptAction> ls = SCT.Actions;
                //TreeNode tnRt = new TreeNode("actions_脚本内容");
                TreeNode tnRt = new TreeNode("actions");
                tv.Nodes.Add(tnRt);

                foreach (ScriptAction a in ls)
                {

                    TreeNode tn = new TreeNode();
                    tn.Text = string.Format("{0}({1})", a.ActionType, a.ActionValue);
                    tn.Tag = a;
                    tnRt.Nodes.Add(tn);

                    if (a.MatchActions != null && a.MatchActions.Count > 0)
                    {
                        TreeNode tnMatch = new TreeNode("MatchActions_匹配时的动作");
                        tn.Nodes.Add(tnMatch);
                        foreach (SubScriptAction sa in a.MatchActions)
                        {
                            TreeNode tnSub = new TreeNode();
                            tnSub.Text = string.Format("{0}({1})", sa.ActionType, sa.ActionValue);
                            tnSub.Tag = sa;
                            tnMatch.Nodes.Add(tnSub);
                        }
                    }
                    if (a.UnmatchActions != null && a.UnmatchActions.Count > 0)
                    {
                        TreeNode tnUnmatch = new TreeNode("UnmatchActions_不匹配时的动作");
                        tn.Nodes.Add(tnUnmatch);
                        foreach (SubScriptAction sa in a.UnmatchActions)
                        {
                            TreeNode tnSub = new TreeNode();
                            tnSub.Text = string.Format("{0}({1})", sa.ActionType, sa.ActionValue);
                            tnSub.Tag = sa;
                            tnUnmatch.Nodes.Add(tnSub);
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                ToastMessageBox.Show("重载脚本内容出错！", 0);
            }
        }

        private void tv_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void tv_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TreeNode)))
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }
        private Point Position = new Point(0, 0);
        private void tv_DragDrop(object sender, DragEventArgs e)
        {
            TreeNode myNode = null;
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                myNode = (TreeNode)(e.Data.GetData(typeof(TreeNode)));
            }
            else
            {
                MessageBox.Show("error");
            }
            Position.X = e.X;
            Position.Y = e.Y;
            Position = tv.PointToClient(Position);
            TreeNode DropNode = this.tv.GetNodeAt(Position);
            // 1.目标节点不是空。2.目标节点不是被拖拽接点的字节点。3.目标节点不是被拖拽节点本身
            if (DropNode != null && DropNode.Parent != myNode && DropNode != myNode)
            {
                TreeNode DragNode = myNode;
                // 将被拖拽节点从原来位置删除。
                myNode.Remove();

                int insertIndex = DropNode.Index;
                DropNode.Parent.Nodes.Insert(insertIndex, DragNode);

                // 在目标节点下增加被拖拽节点
               // DropNode.Nodes.Add(DragNode);
            }
            // 如果目标节点不存在，即拖拽的位置不存在节点，那么就将被拖拽节点放在根节点之下
            if (DropNode == null)
            {
                TreeNode DragNode = myNode;
                myNode.Remove();
                tv.Nodes[0].Nodes.Add(DragNode);
            }
        }

        private void tv_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }

        private void tv_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode tn = e.Node;
            if (tn == null || tn.Tag == null)
                return;

            int _order = tn.Index;
            rtb.Text = string.Format("序号：{0}\r\n", _order+1);
            if (tn.Tag is ScriptAction action)
            {
                lb_ActionType.Text = action.ActionType;
                string str = JsonConvert.SerializeObject(action, Formatting.Indented);
                rtb.Text += str;
            }
            else if (tn.Tag is SubScriptAction subAction)
            {
                lb_ActionType.Text = subAction.ActionType;
                string str = JsonConvert.SerializeObject(subAction, Formatting.Indented);
                rtb.Text += str;
            }
            else
            {
                rtb.Text += "";
            }
        }
    }
}
