using InputSimulator_SendInput.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace InputSimulator_SendInput
{
    public partial class frmScriptEditor : Form
    {
        /// <summary>
        /// 当前已选择的操作类型
        /// </summary>
        private string cType { get { return lb_Selectedtype.Text; } set { lb_Selectedtype.Text = value; } }
        /// <summary>
        /// 当前已选择的按键
        /// </summary>
        private string cKey { get { return lb_SelectedKey.Text; } set { lb_SelectedKey.Text = value; } }
        /// <summary>
        /// 指令格式提示
        /// </summary>
        private string codeTips { get { return lb_codeTips.Text; } set { lb_codeTips.Text = value; } }

        public frmScriptEditor() { InitializeComponent(); ClearScriptInfo(); InitPage(); }
        private void frmScriptEditor_Load(object sender, EventArgs e)
        {

        }
        private void InitPage()
        {
            loadHotkeyDs();
            LoadCodeType();
            LoadKeysList();
        }


        #region 通过UI生成指令相关
        /// <summary>
        /// 加载操作类型
        /// </summary>
        private void LoadCodeType()
        {
            try
            {
                //从文件读取操作类型字典，若读取失败则使用预定字典
                List<Dictionary<string, object>> ls = GlobalParams.ReadlsDicFromTxt(2);
                if (ls == null || ls.Count < 1)
                    ls = GlobalParams.lsWordsStyle;
               
                flp_CodeType.SuspendLayout();
                flp_CodeType.Controls.Clear();
                foreach (Dictionary<string, object> dic in ls)
                {
                    string _word = Common.GetObjStr(dic["Word"]);
                    string _color = Common.GetObjStr(dic["Color"]);
                    bool _bold = Convert.ToBoolean(Common.GetObj(dic["Bold"], true));
                    int _type = Convert.ToInt32(Common.GetObj(dic["Type"], true));
                    string _Description = Common.GetObjStr(dic["Description"]);

                    if (_type != 1)
                        continue;

                    Button btn = new Button();
                    btn.Cursor = Cursors.Hand;
                    btn.Text = _word;
                    toolTip1.SetToolTip(btn, _Description);
                    btn.Size = new Size(122, 31);
                    float fsz = _word.Length > 10 ? 9F : 10.5F;
                    btn.Font = new Font("微软雅黑", fsz, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                    btn.ForeColor = Color.SeaGreen;
                    btn.BackColor = Color.White;

                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.SeaGreen;
                    btn.FlatAppearance.MouseOverBackColor = Color.Green;
                    btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;

                    btn.Click += BtnCodeType_Click;
                    btn.MouseEnter += btn_MouseEnter;
                    btn.MouseLeave += btn_MouseLeave;
                    flp_CodeType.Controls.Add(btn);
                }
                flp_CodeType.ResumeLayout();
            }
            catch { }
        }
        /// <summary>
        /// 加载按键
        /// </summary>
        private void LoadKeysList()
        {
            try
            {
                //从文件读取操作类型字典，若读取失败则使用预定字典
                List<Dictionary<string, object>> ls = GlobalParams.ReadlsDicFromTxt(1);
                if (ls == null || ls.Count < 1)
                    ls = GlobalParams.lsVKeys;

                flp_Keys.SuspendLayout();
                flp_Keys.Controls.Clear();
                int i = 1;
                foreach (Dictionary<string, object> dic in ls)
                {
                    string _VKey = Common.GetObjStr(dic["VKey"]);
                    string _Description = Common.GetObjStr(dic["Description"]);
                    bool Enable = dic.ContainsKey("Enable") ? Convert.ToBoolean(Common.GetObj(dic["Enable"], true)) : true;

                    if (!Enable)
                        continue;

                    Button btn = new Button();
                    btn.Cursor = Cursors.Hand;
                    btn.Text = _VKey;
                    toolTip1.SetToolTip(btn, _Description);
                    btn.Size = _VKey.Length > 8 ? new Size(186, 28) : new Size(90, 28);
                    float fsz = _VKey.Length > 5 ? 9F : 10.5F;
                    btn.Font = new Font("微软雅黑", fsz, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134)));

                    btn.ForeColor = Color.SeaGreen;
                    btn.BackColor = Color.White;

                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 1;
                    btn.FlatAppearance.BorderColor = Color.SeaGreen;
                    btn.FlatAppearance.MouseOverBackColor = Color.Green;
                    btn.FlatAppearance.MouseDownBackColor = Color.SeaGreen;

                    btn.Click += BtnKey_Click;
                    btn.MouseEnter += btn_MouseEnter;
                    btn.MouseLeave += btn_MouseLeave;
                    flp_Keys.Controls.Add(btn);
                }
                flp_Keys.ResumeLayout();
            }
            catch (Exception ex) { }
        }
       
       

        private void BtnCodeType_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            cType = btn.Text;
            GenerateCode();
        }
        private void BtnKey_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            cKey = btn.Text;
            GenerateCode();
        }
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.White;
        }
        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.ForeColor = Color.Teal;
        }

        /// <summary>
        /// 生成新指令
        /// </summary>
        private void GenerateCode()
        {
            string newCode = "";
            switch (cType)
            {
                case "Delay":
                    codeTips = string.Format("括号内为延迟时间,单位毫秒");
                    int delayInterval = 1000;
                    newCode = string.Format("{0}({1});", cType, delayInterval);
                    break;

                #region 按键操作
                case "KeyPress":
                case "KeyDown":
                case "KeyUp":
                    codeTips = string.Format("括号内为按键字符");
                    switch (cKey)
                    {
                        case "LBUTTON":
                        case "MBUTTON":
                        case "RBUTTON": break;
                        default:
                            newCode = string.Format("{0}({1});", cType, cKey);
                            break;
                    }
                    break;
                #endregion

                #region 鼠标操作
                case "MouseClick":
                case "MouseDown":
                case "MouseUp":
                    codeTips = string.Format("括号内为鼠标按钮[L/M/R]");
                    switch (cKey)
                    {
                        case "LBUTTON":
                        case "L":
                        case "MBUTTON":
                        case "M":
                        case "RBUTTON":
                        case "R":
                            newCode = string.Format("{0}({1});", cType, cKey);
                            break;
                    }
                    break;

                case "MouseWhell":
                    codeTips = string.Format("括号内为滚轮滑动量");
                    int delta = 20;
                    newCode = string.Format("{0}({1});", cType, delta);
                    break;
                case "MouseMove_A":
                case "MouseMove":
                    codeTips = string.Format("括号内为鼠标坐标");

                    int X = 0;
                    int Y = 0;
                    newCode = string.Format("{0}({1},{2});", cType, X, Y);
                    break;
                case "MouseMoveToCenter":
                    codeTips = string.Format("无需参数");
                    newCode = string.Format("{0}();", cType);
                    break;
                case "MouseMove_RA":
                case "MouseMove_R":
                    codeTips = string.Format("括号内为鼠标坐标");

                    int dX = 0;
                    int dY = 0;
                    newCode = string.Format("{0}({1},{2});", cType, dX, dY);
                    break;
                    #endregion
            }

            tb_newCode.Text = newCode;
        }
        private void AddNewCodeToRtb()
        {
            string newCode = tb_newCode.Text;
            if (string.IsNullOrEmpty(newCode))
                return;
            rtb_Codes.AppendText(newCode);
            rtb_Codes.AppendText("\n");
            GlobalParams.SetTextStyle(rtb_Codes);
            rtb_Codes.Select(rtb_Codes.Text.Length, 0);
            rtb_Codes.ScrollToCaret();
        }
        private void vbtn_AddCode_ButtonClicked(object sender, EventArgs e) { AddNewCodeToRtb(); }
        private void tb_ScriptName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tb_ScriptName.Text))
                return;

            //if (string.IsNullOrWhiteSpace(tb_SavePath.Text))
            tb_SavePath.Text = string.Format("Scripts\\{0}.txt", tb_ScriptName.Text);
        }
        private void rtb_Leave(object sender, EventArgs e) { GlobalParams.SetTextStyle(rtb_Codes); }
        #endregion

        #region 加载及保存脚本
        public void ClearScriptInfo()
        {
            tb_ScriptName.Text = string.Format("Script_{0}", DateTime.Now.ToString("yyyyMMddHHmmss"));
            tb_SavePath.Text = string.Format("Scripts\\{0}.txt", tb_ScriptName.Text);
            cb_HotKey.Text = "";
            tb_ShowOrder.Text = "1";
            swb_ActiveState.SwitchState = true;
            rtb_Codes.Text = null;
        }

        /// <summary>
        /// 加载脚本信息
        /// </summary>
        /// <param name="_scriptName"></param>
        /// <param name="_hotKey"></param>
        /// <param name="_scriptPath"></param>
        /// <param name="_orderNum"></param>
        /// <param name="_enable"></param>
        public void LoadScriptInfo(string _scriptName, string _hotKey, string _scriptPath, int _orderNum, bool _enable)
        {
            tb_ScriptName.Text = _scriptName;
            cb_HotKey.Text = _hotKey;
            tb_ShowOrder.Text = _orderNum.ToString();
            tb_SavePath.Text = _scriptPath;
            swb_ActiveState.SwitchState = _enable;

            string ScriptContent = GlobalParams.LoadScriptStr(_scriptPath);
            rtb_Codes.Text = ScriptContent;
            GlobalParams.SetTextStyle(rtb_Codes);
        }
        /// <summary>
        /// 加载可选快捷键
        /// </summary>
        private void loadHotkeyDs()
        {
            cb_HotKey.Items.Clear();
            foreach (string s in GlobalParams.lsShortKey)
            {
                cb_HotKey.Items.Add(s);
            }
            cb_HotKey.SelectedIndex = 0;
            cb_HotKey.Text = "F6";
        }
        /// <summary>
        /// 保存脚本
        /// </summary>
        private void SaveScript()
        {
            bool bl = false;
            try
            {
                string scriptName = tb_ScriptName.Text;
                string scriptPath = tb_SavePath.Text;
                string hotKey = cb_HotKey.Text;
                string showOrder = Common.GetObjStr(tb_ShowOrder.Text, true);
                bool activeState = swb_ActiveState.SwitchState;
                string scriptStr = rtb_Codes.Text;

                if (string.IsNullOrWhiteSpace(scriptName))
                {
                    ToastMessageBox.Show("脚本名称呢？");
                    tb_ScriptName.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(scriptPath))
                {
                    ToastMessageBox.Show("脚本路径呢？");
                    tb_SavePath.Focus();
                    return;
                }
                if (string.IsNullOrWhiteSpace(scriptStr))
                {
                    ToastMessageBox.Show("脚本内容呢？");
                    rtb_Codes.Focus();
                    return;
                }


                string _FilePath = string.Format("{0}\\{1}", Application.StartupPath, scriptPath);
                using (System.IO.StreamWriter sw = new StreamWriter(_FilePath, false))
                {
                    sw.Write(scriptStr);
                    UpdateScriptListFile();
                    bl = true;
                    sw.Close();
                    sw.Dispose();
                }

                if (bl)
                {
                    ToastMessageBox.Show("保存成功！");
                    MessageShowList.SendSaveCompletedMsg(this, bl, null, "");
                    this.Dispose();
                }
                else
                    ToastMessageBox.Show("保存失败！");
            }
            catch (Exception ex) { bl = false; ToastMessageBox.Show("保存失败！"); }
        }
        /// <summary>
        /// 更新脚本列表文件
        /// </summary>
        /// <param name="_listpath"></param>
        private void UpdateScriptListFile(string _listpath = "")
        {
            string ListPath = string.IsNullOrWhiteSpace(_listpath) ? string.Format("{0}\\ScriptList.txt", Application.StartupPath) : _listpath;
            string str = "";
            using (StreamReader sr = new StreamReader(ListPath, true))
            {
                str = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
            }
            if (string.IsNullOrEmpty(str))
                return;

            try
            {
                #region 生成新的json
                string scriptName = tb_ScriptName.Text;
                string scriptPath = tb_SavePath.Text;
                string hotKey = cb_HotKey.Text;
                string showOrder = Common.GetObjStr(tb_ShowOrder.Text, true);
                bool activeState = swb_ActiveState.SwitchState;

                int r = 0;
                int _showOrder = int.TryParse(showOrder, out r) ? r : 0;

                bool isNewScript = true;
                List<Dictionary<string, object>> lsScript = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(str);
                foreach (Dictionary<string, object> dic in lsScript)
                {
                    string name = Common.GetObjStr(dic["name"]);
                    string path = Common.GetObjStr(dic["path"]);
                    string hotkey = Common.GetObjStr(dic["HotKey"]).ToUpper();
                    bool _enable = Convert.ToInt32(Common.GetObj(dic["enable"], true)) == 1;
                    int order = Convert.ToInt32(Common.GetObj(dic["order"], true));

                    #region 已有此脚本，更新
                    if (scriptName == name)
                    {
                        isNewScript = false;
                        dic["name"] = scriptName;
                        dic["path"] = scriptPath;
                        dic["HotKey"] = hotKey;
                        dic["enable"] = activeState;
                        dic["order"] = _showOrder;

                        break;
                    }
                    #endregion
                }

                #region 无此脚本，添加
                if (isNewScript)
                {
                    Dictionary<string, object> dic = new Dictionary<string, object>() { };
                    dic["name"] = scriptName;
                    dic["path"] = scriptPath;
                    dic["HotKey"] = hotKey;
                    dic["enable"] = activeState;
                    dic["order"] = _showOrder;
                    lsScript.Add(dic);
                }
                #endregion

                #endregion

                #region 更新脚本列表文件
                var settings = new JsonSerializerSettings { Formatting = Formatting.Indented };
                string sJson = JsonConvert.SerializeObject(lsScript, settings);
                using (System.IO.StreamWriter sw = new StreamWriter(ListPath, false))
                {
                    sw.Write(sJson);
                    sw.Close();
                    sw.Dispose();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btn_SaveScript_Click(object sender, EventArgs e) { SaveScript(); }
        #endregion
    }
}
