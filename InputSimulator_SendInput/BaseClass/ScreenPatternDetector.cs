using InputSimulator_SendInput.BaseClass;
using OpenCvSharp;
using System.Drawing;
using System.Windows.Forms;

namespace InputSimulator_SendInput
{
    /// <summary>
    /// 截取屏幕并检测指定图案是否存在
    /// </summary>
    internal class ScreenPatternDetector
    {
        /// <summary>
        /// 屏幕上是否有指定的图案
        /// </summary>
        /// <param name="templatePath">指定图案的路径</param>
        /// <param name="threshold">阈值[识别精度,0-1],通常设置在0.8~0.95</param>
        /// <returns></returns>
        public static bool IsPatternPresent(string templatePath, double threshold = 0.8)
        {
            // 1. 截取屏幕图像
            using (var screenBitmap = CaptureScreen())
            {
                // 2. 将Bitmap转换为OpenCV的Mat格式（并转换为RGB）
                using (Mat screenMat = BitmapToMat(screenBitmap))
                using (Mat templateMat = new Mat(templatePath, ImreadModes.Color))
                {
                    // 3. 转换为灰度图（可选，但通常能提高性能）
                    Mat screenGray = new Mat();
                    Mat templateGray = new Mat();
                    Cv2.CvtColor(screenMat, screenGray, ColorConversionCodes.BGR2GRAY);
                    Cv2.CvtColor(templateMat, templateGray, ColorConversionCodes.BGR2GRAY);

                    // 4. 模板匹配
                    Mat result = new Mat();
                    Cv2.MatchTemplate(screenGray, templateGray, result, TemplateMatchModes.CCoeffNormed);

                    // 5. 获取最大匹配值
                    Cv2.MinMaxLoc(result, out _, out double maxVal, out _, out _);

                    // 6. 判断是否超过阈值
                    return maxVal >= threshold;
                }
            }
        }
        /// <summary>
        /// 屏幕上是否有指定的图案
        /// </summary>
        /// <param name="templateBitmap">指定的图</param>
        /// <param name="threshold">阈值[识别精度,0-1],通常设置在0.8~0.95</param>
        /// <returns></returns>
        public static bool IsPatternPresent(Bitmap templateBitmap, out System.Drawing.Point pt, double threshold = 0.8)
        {
            pt = new System.Drawing.Point(0, 0);

            // 1. 截取屏幕图像
            using (var screenBitmap = CaptureScreen())
            {
                // 2. 将Bitmap转换为OpenCV的Mat格式（并转换为RGB）
                using (Mat screenMat = BitmapToMat(screenBitmap))
                using (Mat templateMat = BitmapToMat(templateBitmap))
                {
                    // 3. 转换为灰度图（可选，但通常能提高性能）
                    Mat screenGray = new Mat();
                    Mat templateGray = new Mat();
                    Cv2.CvtColor(screenMat, screenGray, ColorConversionCodes.BGR2GRAY);
                    Cv2.CvtColor(templateMat, templateGray, ColorConversionCodes.BGR2GRAY);

                    // 4. 模板匹配
                    Mat result = new Mat();
                    Cv2.MatchTemplate(screenGray, templateGray, result, TemplateMatchModes.CCoeffNormed);

                    // 5. 获取最大匹配值
                    Cv2.MinMaxLoc(result, out _, out double maxVal, out _, out OpenCvSharp.Point maxLoc);

                    // 6. 判断是否超过阈值
                    if (maxVal >= threshold)
                    {
                        // 将 OpenCvSharp.Point 转换为 System.Drawing.Point
                        pt = new System.Drawing.Point(maxLoc.X, maxLoc.Y);
                        return true;
                    }
                    return false;
                }
            }
        }
        /// <summary>
        /// 屏幕上是否有指定的图案
        /// </summary>
        /// <param name="templatePath">图案路径</param>
        /// <param name="dtcf">识别配置</param>
        /// <returns></returns>
        public static bool IsPatternPresent(string templatePath, DetectConfig dtcf, out System.Drawing.Point pt)
        {
            Rectangle screenBounds = SystemInformation.VirtualScreen;
            Rectangle captureArea = new Rectangle(screenBounds.X, screenBounds.Y, screenBounds.Width, screenBounds.Height);
            if (dtcf.SearchArea != null)
                captureArea = new Rectangle(dtcf.SearchArea.X, dtcf.SearchArea.Y, dtcf.SearchArea.Width, dtcf.SearchArea.Height);

            pt = new System.Drawing.Point(0, 0);

            // 1. 截取屏幕图像
            using (var screenBitmap = CaptureScreen(captureArea))
            {
              //  screenBitmap.Save("screen.png", System.Drawing.Imaging.ImageFormat.Png); // 保存截屏图像以供调试

                // 2. 将Bitmap转换为OpenCV的Mat格式（并转换为RGB）
                using (Mat screenMat = BitmapToMat(screenBitmap))
                using (Mat templateMat = new Mat(templatePath, ImreadModes.Color))
                {
                    // 3. 转换为灰度图（可选，但通常能提高性能）
                    Mat screenGray = new Mat();
                    Mat templateGray = new Mat();
                    Cv2.CvtColor(screenMat, screenGray, ColorConversionCodes.BGR2GRAY);
                    Cv2.CvtColor(templateMat, templateGray, ColorConversionCodes.BGR2GRAY);

                    // 4. 模板匹配
                    Mat result = new Mat();
                    Cv2.MatchTemplate(screenGray, templateGray, result, TemplateMatchModes.CCoeffNormed);

                    // 5. 获取最大匹配值
                    Cv2.MinMaxLoc(result, out _, out double maxVal, out _, out OpenCvSharp.Point maxLoc);

                    // 6. 判断是否超过阈值
                    if (maxVal >= dtcf.Threshold)
                    {
                        // 将 OpenCvSharp.Point 转换为 System.Drawing.Point
                        pt = new System.Drawing.Point(maxLoc.X, maxLoc.Y);
                        return true;
                    }
                    return false;
                }
            }
        }

        /// <summary>
        /// 截取整个屏幕
        /// </summary>
        /// <returns></returns>
        private static Bitmap CaptureScreen()
        {
            Rectangle screenBounds = SystemInformation.VirtualScreen;
            Bitmap bitmap = new Bitmap(screenBounds.Width, screenBounds.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(screenBounds.X, screenBounds.Y, 0, 0, screenBounds.Size);
            }
            return bitmap;
        }
        /// <summary>
        /// 截取屏幕的指定区域
        /// </summary>
        /// <param name="captureArea">需要截取的屏幕区域</param>
        /// <returns>截取的屏幕图像</returns>
        private static Bitmap CaptureScreen(Rectangle captureArea)
        {
            Bitmap bitmap = new Bitmap(captureArea.Width, captureArea.Height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.CopyFromScreen(captureArea.X, captureArea.Y, 0, 0, captureArea.Size);
            }
            return bitmap;
        }


        /// <summary>
        /// 将Bitmap转换为OpenCV的Mat（并处理通道顺序）
        /// </summary>
        /// <param name="bitmap"></param>
        /// <returns></returns>
        private static Mat BitmapToMat(Bitmap bitmap)
        {
            var bitmapData = bitmap.LockBits(
                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                System.Drawing.Imaging.ImageLockMode.ReadOnly,
                System.Drawing.Imaging.PixelFormat.Format32bppArgb
            );
            try
            {
                // 创建一个与Bitmap相同大小的Mat
                Mat mat = new Mat(bitmap.Height, bitmap.Width, MatType.CV_8UC4, bitmapData.Scan0);
                // 转换颜色通道顺序：BGRA -> BGR
                Cv2.CvtColor(mat, mat, ColorConversionCodes.BGRA2BGR);
                return mat.Clone(); // 避免内存被释放
            }
            finally
            {
                bitmap.UnlockBits(bitmapData);
            }
        }
    }
}
