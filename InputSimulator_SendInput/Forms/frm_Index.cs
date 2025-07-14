using InputSimulator_SendInput.BaseClass;
using InputSimulator_SendInput.Forms;
using InputSimulator_SendInput.Tools;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace InputSimulator_SendInput
{
    /// <summary>
    /// 第二版
    /// </summary>
    public partial class frm_Index : Form
    {
        /// <summary>
        /// 脚本文件列表
        /// </summary>
        List<ScriptItem> lsSPTI = new List<ScriptItem>();

        public frm_Index() { InitializeComponent(); }
        private void frm_Index_Load(object sender, EventArgs e)
        {
            InitPage();

            new treeViewTest().Show();
        }

        private void InitPage()
        {
            this.Disposed += Frm_Index_Disposed;
            MessageShowList.SaveCompleted += MessageShowList_SaveCompleted;
            SetScanner();
            LoadScriptList();
        }
        private void MessageShowList_SaveCompleted(object Sender, bool SaveSucceed, object Receiver = null, string ExtraInfo = "")
        {
            if (Sender.GetType() == typeof(frmScriptEditor) || Sender.GetType() == typeof(ScriptItem) || (Sender.GetType() == typeof(string) && Sender.ToString() == "RefreshList"))
            {
                if (SaveSucceed)
                    LoadScriptList();
            }
        }

        private void Frm_Index_Disposed(object sender, EventArgs e)
        {
            UnHookSanner();

            if (lsSPTI != null)
                foreach (ScriptItem spti in lsSPTI)
                {
                    if (spti != null && spti.IsRunning)
                        spti.StopScript();
                }
        }

        /// <summary>
        /// 加载某个文件夹下的脚本列表
        /// </summary>
        /// <param name="_folderPath"></param>
        public void LoadScriptList(string _folderPath = "")
        {
            flpList.SuspendLayout();

            if (lsSPTI != null)
                lsSPTI.Clear();
            flpList.Controls.Clear();

            string FolderPath = string.IsNullOrWhiteSpace(_folderPath) ? string.Format("{0}\\Scripts", Application.StartupPath) : _folderPath;
            if (Directory.Exists(FolderPath))
            {
                // 获取文件夹下所有的 .txt 文件
                string[] txtFiles = Directory.GetFiles(FolderPath, "*.txt");
                foreach (string file in txtFiles)
                {
                    try
                    {
                        string content = File.ReadAllText(file);
                        if (string.IsNullOrEmpty(content))
                            continue;

                        ScriptContent SCT = JsonConvert.DeserializeObject<ScriptContent>(content);
                        if (SCT == null)
                            continue;

                        ScriptItem spti = new ScriptItem();
                        spti.ScriptPath = file;
                        spti.Init(SCT);
                        spti.spti_BorderRadius = 2;
                        flpList.Controls.Add(spti);
                        lsSPTI.Add(spti);
                    }
                    catch (Exception ex)
                    {
                        ToastMessageBox.Show(string.Format($"读取文件 {0} 时发生错误: {1}", file, ex.Message), 0);
                    }
                }
            }
            else
            {
                ToastMessageBox.Show("指定的文件夹不存在！", 0);
            }

            flpList.ResumeLayout();
        }


        #region 键盘钩子
        /// <summary>
        /// 键盘钩子
        /// </summary>
        private KeyboardHook KBH = null;
        /// <summary>
        /// 挂载钩子，注册键盘监听
        /// </summary>
        private void SetScanner()
        {
            try
            {
                KBH = new KeyboardHook();
                KBH.SetHook();
                KBH.OnKeyDownEvent += KBH_OnKeyDownEvent;
                KBH.OnKeyUpEvent += KBH_OnKeyUpEvent;
            }
            catch (Exception ex) { }
        }
        private void KBH_OnKeyDownEvent(object sender, KeyEventArgs e)
        {
            bool holdCtrl = (e.KeyData == (Keys.LControlKey | Keys.Control) || e.KeyData == (Keys.RControlKey | Keys.Control)) || e.Control;
            bool holdShift = (e.KeyData == (Keys.LShiftKey | Keys.Shift) || e.KeyData == (Keys.RShiftKey | Keys.Shift)) || e.Shift;
            bool holdAlt = (e.KeyData == (Keys.LMenu | Keys.Alt) || e.KeyData == (Keys.RMenu | Keys.Alt)) || e.Alt;

            if (holdAlt)
                lb_Alt.ForeColor = Color.Red;
            if (holdCtrl)
                lb_Ctrl.ForeColor = Color.Red;
            if (holdShift)
                lb_Shift.ForeColor = Color.Red;
        }
        /// <summary>
        /// 监听快捷键是否按下并释放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void KBH_OnKeyUpEvent(object sender, KeyEventArgs e)
        {
            try
            {
                bool holdCtrl = e.Control;
                bool holdShift = e.Shift;
                bool holdAlt = e.Alt;

                lb_Alt.ForeColor = holdAlt ? Color.Red : Color.Gray;
                lb_Ctrl.ForeColor = holdCtrl ? Color.Red : Color.Gray;
                lb_Shift.ForeColor = holdShift ? Color.Red : Color.Gray;

                string kc = e.KeyCode.ToString();
                if (string.IsNullOrWhiteSpace(kc))
                    return;

                bool HasPlayedNoticeSound = false;//是否已播放提示音，播放一次后就置为true，防止多个脚本共用一个快捷键时重复播放
                foreach (ScriptItem spti in lsSPTI)
                {
                    if (spti.HotKey == kc.ToUpper() && spti.spti_ActiveState)
                    {
                        if (!HasPlayedNoticeSound)
                            SystemSounds.Beep.Play();
                        HasPlayedNoticeSound = true;

                        if (spti.IsRunning)
                            spti.StopScript();
                        else
                            spti.RunScript();
                    }
                }
            }
            catch (Exception ex) { }
        }
        /// <summary>
        /// 取消钩子监听
        /// </summary>
        private void UnHookSanner()
        {
            try
            {
                if (KBH != null)
                {
                    KBH.UnHook();
                }
            }
            catch (Exception ex) { }
        }
        #endregion

        #region 顶部按钮
        private void btn_AddNew_Click()
        {
            frmScriptEditor_V2 fsce = new frmScriptEditor_V2();
            fsce.Show();
        }
        private void btn_Refresh_Click()
        {
            this.SuspendLayout();
            bool bl = false;
            if (lsSPTI != null)
                foreach (ScriptItem spti in lsSPTI)
                {
                    if (spti != null && spti.IsRunning)
                        bl = true;
                }
            if (bl)
                ToastMessageBox.Show("请先停止运行中的脚本");
            else
                LoadScriptList();
            this.ResumeLayout();
        }
        private void vbtn_AddScript_ButtonClicked(object sender, EventArgs e) { btn_AddNew_Click(); }
        private void vbtn_Refresh_ButtonClicked(object sender, EventArgs e) { btn_Refresh_Click(); }
        private void vbtn_editListJson_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string listPath = string.Format("{0}\\ScriptList.txt", Application.StartupPath);
                Process.Start("notepad.exe", listPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开文件:\r\n " + ex.Message);
            }
        }
        private void vbtn_openScriptsFolder_ButtonClicked(object sender, EventArgs e)
        {
            try
            {
                string folderPath = string.Format("{0}\\Scripts", Application.StartupPath);
                Process.Start("explorer.exe", folderPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("无法打开文件夹:\r\n" + ex.Message);
            }
        }
        private void vbtn_GenerateDicText_ButtonClicked(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Dictionary<string, object> dic in GlobalParams.lsVKeys)
            {
                if (!dic.ContainsKey("Order"))
                    dic.Add("Order", i++);
            }

            bool b1 = GlobalParams.LsDicToJsonTxt(GlobalParams.lsVKeys, GlobalParams.LocalDicKeysName);
            bool b2 = GlobalParams.LsDicToJsonTxt(GlobalParams.lsWordsStyle, GlobalParams.LocalDicWordsStyleName);

            if (b1 || b2)
                try
                {
                    string folderPath = string.Format("{0}", Application.StartupPath);
                    Process.Start("explorer.exe", folderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无法打开文件夹:\r\n" + ex.Message);
                }
        }

        private void vbtn_GenerateClassText_ButtonClicked(object sender, EventArgs e)
        {
            int i = 1;
            foreach (Dictionary<string, object> dic in GlobalParams.lsVKeys)
            {
                if (!dic.ContainsKey("Order"))
                    dic.Add("Order", i++);
            }

            bool b1 = GlobalParams.LsDicToCSharpClassTxt(GlobalParams.lsVKeys, "CSCT_dicKeys.txt");
            bool b2 = GlobalParams.LsDicToCSharpClassTxt(GlobalParams.lsWordsStyle, "CSCT_WordsStyle.txt");

            if (b1 || b2)
                try
                {
                    string folderPath = string.Format("{0}", Application.StartupPath);
                    Process.Start("explorer.exe", folderPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("无法打开文件夹:\r\n" + ex.Message);
                }
        }
        #endregion


    }
}
