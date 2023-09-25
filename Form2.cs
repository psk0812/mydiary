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

        int textFontSize= (int)18f;
      
        public formTarget()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();


            //폰트파일명 명시
         

            privateFonts.AddFontFile("NanumSquareR.ttf");
            privateFonts.AddFontFile("NanumSquareB.ttf");
            
            Font menufont3 = new Font(privateFonts.Families[0], textFontSize);

            Font menufont4 = new Font(privateFonts.Families[0], textFontSize-4);
            textBox1.Font = menufont3;
            custombox1.Font = menufont4;
            custombox2.Font = menufont4;
            custombox3.Font = menufont4;
            custombox4.Font = menufont4;
            custombox5.Font = menufont4;
        }





        private void formTarget_Shown(object sender, EventArgs e)
        {
            PrivateFontCollection privateFonts = new PrivateFontCollection();


            //폰트파일명 명시

            privateFonts.AddFontFile("NanumSquareR.ttf");
            privateFonts.AddFontFile("NanumSquareB.ttf");

            //24f는 출력될 폰트사이즈

            int textFontSize = (int)(9.0 * panel1.Width / 200.0);


            Font menufont = new Font(privateFonts.Families[0], 22f);
            Font menufont2 = new Font(privateFonts.Families[1], 18f);
            
            label_tobe.Font = menufont;
            label1.Font = menufont2;
            



            Console.WriteLine("로그가 파일에 기록되었습니다.");
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           

            // 이미지 비교 함수 호출
          
        }


        //이미지 비교 함수
       
    }
}
