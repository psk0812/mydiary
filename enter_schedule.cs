using mydiary.monthlogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydiary
{
    public partial class enter_schedule : Form
    {
        private string plantodo;
        private string day;
        private string month;
        string appDirectory;
        string Text_schedule;
        public enter_schedule()
        {
            InitializeComponent();
            this.MinimumSize = this.MaximumSize = this.Size;

            appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Text_schedule = Path.Combine(appDirectory, @"..\..\data\scheduler.txt");
        }

        public string text_plantodo
        {
            get { return plantodo; }
            set { plantodo = value; }
        }
        public string text_day
        {
            get { return day; }
            set { day = value; }
        }
        public string text_month
        {
            get { return month; }
            set { month = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                plantodo = textBox1.Text;
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                // 상대 경로를 사용하여 파일 경로 설정
                string relativeFilePath = Path.Combine(appDirectory, @"..\..\..\mydiary\data\scheduler.csv");

                using (var sw = new StreamWriter(relativeFilePath, false, Encoding.Default)) // 인코딩을 UTF-8로 설정
                {

                    string csvLine = $"{month},{day},{plantodo}";
                    sw.WriteLine(csvLine);

                }
            }
            catch (Exception ex)
            {

            }
            this.Close();
        }
    }

}
