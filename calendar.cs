using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydiary
{
    public partial class calendar : Form
    {
        int month, year;
        Font fontdays;

        public calendar()
        {
            InitializeComponent();
        }

        private void calendar_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 42; i++)
            {
                string PanelName = "panel" + i;
                Panel targetPanel = (Panel)tableLayoutPanel1.Controls.Find(PanelName, true)[0];
                targetPanel.BackColor = Color.White;
                targetPanel.Dock = DockStyle.Fill;

            }
            display();
            
            
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
                targetPanel.Controls.Add(daylabel);
            }
        }

        private void display()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;


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
                targetPanel.Controls.Add(daylabel);
            }
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
                
                targetPanel.Dock = DockStyle.Fill;

                count += 1;



                Label daylabel = new Label();

                daylabel.Dock = DockStyle.Top;
                daylabel.Text = "  " + count.ToString();
                daylabel.Margin = new Padding(20, 10, 0, 0);
                daylabel.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
                targetPanel.Controls.Add(daylabel);
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
