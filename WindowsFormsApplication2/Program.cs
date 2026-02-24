using ListTrayBarInfo;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TyDll;
using WindowsFormsApplication2;

namespace WindowsFormsApplication2
{
    static class Program
	{
        /// <summary>
        /// 防止重复打开程序
        /// </summary>
        static bool CheckIfOpenAgain(string[] args, System.Threading.Mutex mu2)
        {
            Process cur = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(cur.ProcessName);
            foreach (var pro in processes)
            {
                if (pro.Id == cur.Id)
                    continue;

                if (pro.MainModule.FileName != cur.MainModule.FileName)
                    continue;

                string haveOpenedTip = Glob.ProName + "对你弱弱地说：\"我已经打开了啦~~！\"";
                MessageBox.Show(haveOpenedTip, Glob.ProName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }


            // 在完全相同的傳入參數下不允許重複執行，避免數據重複計算
            string mutexName2 = "Args_" +
                String.Join("_", args).Replace(System.IO.Path.DirectorySeparatorChar, '_');
            bool is_createdNew2;
            mu2 = new System.Threading.Mutex(true, "Global\\" + mutexName2, out is_createdNew2);
            if (!is_createdNew2)
            {
                MessageBox.Show("程序已运行！");
                return true;
            }

            return false;
        }


        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
		static void Main(string[] args)
		{
			if (!System.IO.File.Exists(Application.StartupPath + "\\TyDll.dll"))
			{
				MessageBox.Show("未找到TyDll.dll文件！");
				Application.Exit();
			}
			System.Threading.Mutex mu2 = null;
			try
			{
				if (CheckIfOpenAgain(args, mu2))
					return;

				//DoSomething();
			}
			catch (Exception ex)
			{
				throw ex;
			}

			// Enable High DPI support for clear text rendering
			Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

	}
}
