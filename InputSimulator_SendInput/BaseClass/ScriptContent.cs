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
    }
}
