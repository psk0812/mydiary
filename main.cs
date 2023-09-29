using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace mydiary
{
    public partial class main : Form
    {

        private IconButton currentbtn;
        private Form currentForm;
        private String childFormname;
        private String currentformname;
        private float aspectRatio = 955f / 558f;//비율 유지하기 위해 

        public main()
        {
            InitializeComponent();
            this.Opacity = 0.0;
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;

            // 화면의 70% 크기로 윈폼 크기를 설정합니다.
            int newWidth = (int)(screenWidth * 0.7);
            int newHeight = (int)(screenHeight * 0.7);
            this.Size = new System.Drawing.Size(newWidth, newHeight);

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            PrivateFontCollection privateFonts = new PrivateFontCollection();
            
            //폰트파일명 명시
            privateFonts.AddFontFile("SDMiSaeng.ttf");
            privateFonts.AddFontFile("NanumSquareR.ttf");

            //24f는 출력될 폰트사이즈
            Font font = new Font(privateFonts.Families[0], 18f);
            Font menufont = new Font(privateFonts.Families[1], 15f);

            lblsayhello.Font = font;
            btnTarget.Font = menufont;
            btnCalendar.Font = menufont;
            btnMindset.Font = menufont;
            btnMonth.Font = menufont;

           
            childFormname = "formTarget";
            currentformname = "formTarget";
            this.Opacity = 1.0;

          

        }
        private void OpenChildForm(Form childForm)
        {
            try
            {


                if (currentForm != null)
                {
                    string targetName=currentForm.Name;
                    Form targetForm = (Form)mainpanel.Controls.Find(targetName, true)[0];
                    currentForm.Close();
                    targetForm.Dispose();
                }
                

                    currentformname = childFormname;
                    currentForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    mainpanel.Controls.Add(childForm);
                    childForm.BringToFront();
                    childForm.Show();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"에러 발생: {ex.Message}", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 예외 처리 코드 추가
            }
        }
        
        








        #region menubtn
        public struct RGBColors
        {
            public static Color color_btn_clicked = Color.FromArgb(243, 51, 102);
            public static Color color_btn_unclicked = Color.FromArgb(16, 33, 60);
            public static Color color_mouser_hover = Color.FromArgb(53, 61, 79);
            public static Color color_pink = Color.FromArgb(254, 110, 135);

        }

        private void Disablebtn()
        {
            if (currentbtn != null)
            {
                currentbtn.BackColor = RGBColors.color_btn_unclicked;

            }
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                Disablebtn();
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = RGBColors.color_btn_clicked;
            }
        }

        private void btnTarget_MouseClick(object sender, MouseEventArgs e)
        {
            ActivateButton(sender);
            
        }

        private void btnCalendar_MouseClick(object sender, MouseEventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMindset_MouseClick(object sender, MouseEventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMonth_MouseClick(object sender, MouseEventArgs e)
        {
            ActivateButton(sender);
        }

        #endregion

        #region titlebar
        private void iconmini_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconmaximize_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }

            
        }

        private void iconexit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }



        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void titlebar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        #endregion

        private void btnMindset_Click(object sender, EventArgs e)
        {
            childFormname = "visionboardform";
            OpenChildForm(new visionboardform());

        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            childFormname= "monthlog";
            OpenChildForm(new monthlog());
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            childFormname = "calendar";
            OpenChildForm(new calendar());
        }

        private void btnTarget_Click(object sender, EventArgs e)
        {
            childFormname = "formTarget";
            OpenChildForm(new target());
        }
    }
}

