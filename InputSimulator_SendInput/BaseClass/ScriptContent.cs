using System.Collections.Generic;

namespace InputSimulator_SendInput.BaseClass
{
    /// <summary>
    /// 脚本内容
    /// </summary>
    public class ScriptContent
    {
        /// <summary>
        /// 脚本名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 激活/停止的快捷键
        /// </summary>
        public string HotKey { get; set; }
        /// <summary>
        /// 是否启用 未启用时按快捷键无法执行
        /// </summary>
        public bool Enable { get; set; }
        /// <summary>
        /// 脚本显示顺序
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// 是否循环执行
        /// </summary>
        public bool LoopMode { get; set; }
        /// <summary>
        /// 脚本内容
        /// </summary>
        public List<ScriptAction> Actions { get; set; }

        public ScriptContent() { }

        /// <summary>
        /// 按排序字段排序
        /// </summary>
        public void SortSelf() { Actions.Sort((x, y) => x.SerialNo.CompareTo(y.SerialNo)); }
    }
    /// <summary>
    /// 脚本的某一个动作
    /// </summary>
    public class ScriptAction
    {
        /// <summary>
        /// 执行顺序
        /// </summary>
        public int SerialNo { get; set; }
        /// <summary>
        /// 动作类型
        /// </summary>
        public string ActionType { get; set; }
        /// <summary>
        /// 动作对应的值 时间间隔、按键值、鼠标坐标等
        /// </summary>
        public string ActionValue { get; set; }
        /// <summary>
        /// 是否用灰度图像进行识别
        /// </summary>
        public bool Grayscale { get; set; }
        /// <summary>
        /// 图像识别配置
        /// </summary>
        public DetectConfig Detectconfig { get; set; }
        /// <summary>
        /// 匹配时的动作
        /// </summary>
        public List<SubScriptAction> MatchActions { get; set; }
        /// <summary>
        /// 不匹配时的动作
        /// </summary>
        public List<SubScriptAction> UnmatchActions { get; set; }

        /// <summary>
        /// 按排序字段排序
        /// </summary>
        public List<SubScriptAction> SortActionsList(List<SubScriptAction> ls) { ls.Sort((x, y) => x.SerialNo.CompareTo(y.SerialNo)); return ls; }
    }
    /// <summary>
    /// 脚本的某一个动作 [子级节点用]
    /// </summary>
    public class SubScriptAction
    {
        /// <summary>
        /// 执行顺序
        /// </summary>
        public int SerialNo { get; set; }
        /// <summary>
        /// 动作类型
        /// </summary>
        public string ActionType { get; set; }
        /// <summary>
        /// 动作对应的值 时间间隔、按键值、鼠标坐标等
        /// </summary>
        public string ActionValue { get; set; }
    }
    /// <summary>
    /// 图像识别配置
    /// </summary>
    public class DetectConfig
    {
        /// <summary>
        /// 识别区域
        /// </summary>
        public Searcharea SearchArea { get; set; }
        /// <summary>
        /// 识别阈值 [匹配程度]
        /// </summary>
        public double Threshold { get; set; }
    }
    /// <summary>
    /// 查找区域
    /// </summary>
    public class Searcharea
    {
        /// <summary>
        /// 查找区域的左上角坐标X
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// 查找区域的左上角坐标Y
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// 查找区域的宽度
        /// </summary>
        public int Width { get; set; }
        /// <summary>
        /// 查找区域的高度
        /// </summary>
        public int Height { get; set; }
    }
}
