using System;
using System.Runtime.InteropServices;

namespace InputSimulator_SendInput
{
    /// <summary>
    /// Win32Api
    /// </summary>
    class Win32Api
    {
        #region 常数和结构
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;
        public const int WM_SYSKEYDOWN = 0x104;
        public const int WM_SYSKEYUP = 0x105;
        public const int WH_KEYBOARD_LL = 13;

        [StructLayout(LayoutKind.Sequential)] //声明键盘钩子的封送结构类型 
        public class KeyboardHookStruct
        {
            /// <summary>
            /// 表示一个在1到254间的虚似键盘码
            /// </summary>
            public int vkCode;
            /// <summary>
            /// 表示硬件扫描码
            /// </summary>
            public int scanCode;  
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        #endregion

        #region Api
        /// <summary>
        /// 键盘钩子回调函数
        /// </summary>
        /// <param name="nCode"></param>
        /// <param name="wParam"></param>
        /// <param name="lParam"></param>
        /// <returns></returns>
        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);

        /// <summary>
        ///安装一个钩子，用于侦听特定类型的事件，比如键盘输入
        /// </summary>
        /// <param name="idHook">指定要安装的钩子的类型（例如，键盘钩子）</param>
        /// <param name="lpfn">指向钩子回调函数的指针，此函数会在钩子检测到事件时被调用。</param>
        /// <param name="hInstance">模块的句柄，通常是当前进程的句柄</param>
        /// <param name="threadId">指定钩子所应用的线程的ID（如果为0，则对所有线程有效）</param>
        /// <returns>如果成功，返回钩子的ID；如果失败，返回0</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);

        /// <summary>
        /// 如果成功，返回钩子的ID；如果失败，返回0
        /// </summary>
        /// <param name="idHook">要卸下的钩子的ID，通常是之前通过SetWindowsHookEx获得的。</param>
        /// <returns>如果成功返回true，失败则返回false。</returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);

        /// <summary>
        /// 将消息传递给下一个钩子或钩子链中的下一个处理程序。
        /// </summary>
        /// <param name="idHook">当前钩子的ID</param>
        /// <param name="nCode">钩子接收到的消息代码。</param>
        /// <param name="wParam">消息的额外信息</param>
        /// <param name="lParam">指向与消息相关的结构体的指针</param>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);

        /// <summary>
        /// 将虚拟键（uVirtKey）和扫描码（uScanCode）转换为ASCII字符。
        /// </summary>
        /// <param name="uVirtKey">虚拟键的代码</param>
        /// <param name="uScanCode">键的扫描码</param>
        /// <param name="lpbKeyState">描述当前按键状态的数组。</param>
        /// <param name="lpwTransKey">用于接收转换结果的数组</param>
        /// <param name="fuState">状态标志</param>
        /// <returns>成功时返回ASCII字符的数量，失败返回0</returns>
        [DllImport("user32")]
        public static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);

        /// <summary>
        /// 获取当前键盘的状态
        /// </summary>
        /// <param name="pbKeyState">用于接收键盘状态的数组</param>
        /// <returns>返回实际填充的字节数</returns>
        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);

        /// <summary>
        /// 获取指定模块的句柄。
        /// </summary>
        /// <param name="lpModuleName">模块的名称，可以是DLL或EXE。</param>
        /// <returns>返回模块的句柄，失败时返回IntPtr.Zero。</returns>
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion
    }
}
