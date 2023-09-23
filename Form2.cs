using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace mydiary
{
    public partial class formTarget : Form
    {

        public int CornerRadius { get; set; } = 10;
        public formTarget()
        {
            InitializeComponent();

       


            #region font
            PrivateFontCollection privateFonts = new PrivateFontCollection();


            //폰트파일명 명시
            
            privateFonts.AddFontFile("NanumSquareR.ttf");
            privateFonts.AddFontFile("NanumSquareB.ttf");
            
            //24f는 출력될 폰트사이즈

            Font menufont = new Font(privateFonts.Families[0], 22f);
            Font menufont2 = new Font(privateFonts.Families[1], 18f);
            Font menufont3 = new Font(privateFonts.Families[0], 12f);
            label_tobe.Font = menufont;
            label1.Font = menufont2;


            #endregion

        }

     

        private void formTarget_Load(object sender, EventArgs e)
        {

        }

        private void formTarget_ResizeEnd(object sender, EventArgs e)
        {

            // 현재 폼의 너비와 높이를 가져옵니다.
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // 원하는 비율을 설정합니다.
            float desiredWidth = 1100;
            float desiredHeight = 610;

            // 너비와 높이의 비율을 계산합니다.
            float widthRatio = formWidth / desiredWidth;
            float heightRatio = formHeight / desiredHeight;

            // 비율 중에서 작은 값(가로 또는 세로 중에서 크기가 더 작은 쪽)을 사용하여 폰트 크기를 계산합니다.
            float fontSize = Math.Min(widthRatio, heightRatio) * 22.0f;

            // 폰트 크기가 너무 작거나 큰 경우 최소값과 최대값을 설정할 수 있습니다.
            float minFontSize = 10.0f;
            float maxFontSize = 40.0f;
            fontSize = Math.Max(minFontSize, Math.Min(maxFontSize, fontSize));
            PrivateFontCollection privateFonts = new PrivateFontCollection();
            privateFonts.AddFontFile("NanumSquareR.ttf");
            Font menufont = new Font(privateFonts.Families[0], fontSize);
        }

        private void radiuspanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picuterboxCircle1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
          
        }

        private void picuterboxCircle1_Click(object sender, EventArgs e)
        {

        }

        private void radiuspanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_tobe_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void custombox1_Load(object sender, EventArgs e)
        {

        }
    }
}
