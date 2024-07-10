using Librarys;
using TechMo.GUI.Forms;
using NLog;
using NLog.Config;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace TechMo
{
    internal static class Program
    {
        private static Semaphore semaphore = null;
        public static readonly Logger Logger = LogManager.GetCurrentClassLogger();
        static public string getRunningPath()
        {
            string runningPath = AppDomain.CurrentDomain.BaseDirectory + Constants.ORIGINAL_PATH;
            return Path.GetFullPath(runningPath);
        }

        [STAThread]
        static void Main()
        {
            //Đảm bảo chỉ có 1 view xuất hiện trên màn hình
            if (!checkSemaphoreAvailability()) { return; }

            // Cấu hình NLog
            LogManager.Configuration = new XmlLoggingConfiguration("NLog.config");

            // Nếu Semaphore sẵn sàng, tiếp tục chạy ứng dụng
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmTestWeb());

            // Giải phóng Semaphore
            if (semaphore != null)
            {
                semaphore.Release();
                semaphore.Dispose();
            }
        }

        static private bool checkSemaphoreAvailability()
        {
            const string semaphoreName = "MoneyPlus";
            const int semaphoreCount = 1;

            // Tạo Semaphore với đếm ban đầu là 1
            semaphore = new Semaphore(semaphoreCount, semaphoreCount, semaphoreName);

            // Kiểm tra xem Semaphore có sẵn sàng để sử dụng hay không
            bool isSemaphoreAvailable = semaphore.WaitOne(TimeSpan.Zero);

            return isSemaphoreAvailable;
        }
    }
}
