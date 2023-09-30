using mydiary.monthlogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydiary
{
    public partial class calendar : Form
    {
        int month, year,day;
        int nowmonth;
        Font fontdays;
        String Text_path;
        string appDirectory;
        public calendar()
        {
            this.Opacity = 0.0;
            InitializeComponent();


            appDirectory = AppDomain.CurrentDomain.BaseDirectory;

            Text_path = Path.Combine(appDirectory, @"..\..\..\mydiary\data\scheduler.txt");
            this.Opacity = 1.0;
        }

        private void calender_click_event(Panel target,String month, String day)
        {
            target.Click += (s, args) =>
            {
                enter_schedule enter = new enter_schedule();
                enter.text_month = month;
                enter.text_day = day;
                enter.Show();
            };
        }
        private void calendar_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            for (int i = 1; i <= 42; i++)
            {
                string PanelName = "panel" + i;
                Panel targetPanel = (Panel)tableLayoutPanel1.Controls.Find(PanelName, true)[0];
                targetPanel.BackColor = Color.White;
                targetPanel.Dock = DockStyle.Fill;
                
            }
            display();
            this.Opacity = 1.0;

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            panel_refresh();
            month++;

            if (month == 13) { month = 1;year++; }

            label8.Text = "Month" + month.ToString();
            label9.Text = year.ToString();
            //이달의 첫째 요일은
            DateTime startofthmonth = new DateTime(year, month, 1);

            //이달을 몇일로 이루어져 있나.
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthmonth.DayOfWeek.ToString("d")) + 1;
            
            int count = 0;
            



            for (int i = dayoftheweek; i <= days + dayoftheweek; i++)
            {

            
                string PanelName = "panel" + i;
            
                Panel targetPanel = (Panel)tableLayoutPanel1.Controls.Find(PanelName, true)[0];
                targetPanel.BackColor = Color.White;
                targetPanel.Dock = DockStyle.Fill;

                count += 1;


               
                Label daylabel = new Label();

                daylabel.Dock = DockStyle.Top;
                daylabel.Text = "  " + count.ToString();
                daylabel.Margin = new Padding(20, 10, 0, 0);
                daylabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                if (day == count && month == nowmonth)
                { daylabel.ForeColor = Color.RoyalBlue; }
                targetPanel.Controls.Add(daylabel);
                calender_click_event(targetPanel, month.ToString(), i.ToString());


            }
        }

        private void display()
        {
            

            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            day = now.Day;
            nowmonth= now.Month;

            day = day * 1;
            


            label8.Text ="Month"+ month.ToString() ;
            label9.Text = year.ToString();
            //이달의 첫째 요일은
            DateTime startofthmonth = new DateTime(now.Year, month, 1);

            //이달을 몇일로 이루어져 있나.
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            int dayoftheweek = Convert.ToInt32(startofthmonth.DayOfWeek.ToString("d")) + 1;


            int count = 0;
            for (int i = dayoftheweek ; i <= days + dayoftheweek; i++)
            {


                string PanelName = "panel" + i;
                Console.WriteLine(PanelName);
                Panel targetPanel = (Panel)tableLayoutPanel1.Controls.Find(PanelName, true)[0];
                targetPanel.BackColor = Color.White;
                targetPanel.Dock = DockStyle.Fill;

                count += 1;
                
                Label daylabel = new Label();
                
                daylabel.Dock = DockStyle.Top;
                daylabel.Text = "  "+count.ToString();
                daylabel.Margin = new Padding(20, 10, 0, 0);
                daylabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);

                if (day == count)
                { daylabel.ForeColor = Color.RoyalBlue; }

                targetPanel.Controls.Add(daylabel);
                calender_click_event(targetPanel, month.ToString(), i.ToString()); ;
            }
       
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           
            Form1 monthform = new Form1();
            string[] whatshould = File.ReadAllLines(Text_path);
            monthform.Text = "전체 계획";
            monthform.FilePath = Text_path;
            monthform.TextBox1 = whatshould;
            monthform.ShowDialog();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            panel_refresh();
            month--;

            if (month == 0) { month = 12; year--; }

            label8.Text = "Month" + month.ToString();
            label9.Text = year.ToString();
            //이달의 첫째 요일은
            DateTime startofthmonth = new DateTime(year, month, 1);

            //이달을 몇일로 이루어져 있나.
            int days = DateTime.DaysInMonth(year, month);
            int dayoftheweek = Convert.ToInt32(startofthmonth.DayOfWeek.ToString("d")) + 1;

            int count = 0;




            for (int i = dayoftheweek; i <= days + dayoftheweek; i++)
            {


                string PanelName = "panel" + i;

                Panel targetPanel = (Panel)tableLayoutPanel1.Controls.Find(PanelName, true)[0];
                targetPanel.BackColor = Color.White;
                targetPanel.Dock = DockStyle.Fill;

                count += 1;



                Label daylabel = new Label();

                daylabel.Dock = DockStyle.Top;
                daylabel.Text = "  " + count.ToString();
                daylabel.Margin = new Padding(20, 10, 0, 0);
                daylabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                if (day == count && month == nowmonth)
                { daylabel.ForeColor = Color.RoyalBlue; }
                targetPanel.Controls.Add(daylabel);
                calender_click_event(targetPanel, month.ToString(), i.ToString()); ;
            }
        }

        private void panel_refresh()
        {

            for (int i = 1; i <= 42; i++)
            {
                string PanelName = "panel" + i;
                Panel targetPanel = (Panel)tableLayoutPanel1.Controls.Find(PanelName, true)[0];
              
                foreach (Control control in targetPanel.Controls)
                {
                    if (control is Label)
                    {
                        
                        targetPanel.Controls.Remove(control);
                        control.Dispose(); // 라벨을 메모리에서 해제
                        break; // 라벨 하나만 삭제 break를 사용하여 루프를 종료
                    }
                }

            }
        }


    }
}
