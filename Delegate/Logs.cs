using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Logs
    {
        public delegate void ShowLog(string message);

        static public void Info(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Format("Info: {0}", s));
            Console.ResetColor();
        }

        static public void Warning(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Format("Waring: {0}", s));
            Console.ResetColor();
        }

        public static void TestShowLog()
        {
            ShowLog showLog;

            showLog = Info;         
            showLog("Thông báo");   

            showLog = Warning;      
            showLog("Thông báo");   
        }
        public static void TestShowLogMulti()
        {
            ShowLog showLog;

            showLog = null;
            showLog += Warning;         
            showLog += Info;            
            showLog += Warning;         

            
            showLog("TestLog");         
        }
    }
}
