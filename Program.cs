using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydiary
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try { Application.Run(new main()); }
           
            catch (Exception ex) { Console.WriteLine("예외 발생: " + ex.Message); }

            
        }

    }
}
