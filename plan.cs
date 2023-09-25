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

            Font menufont = new Font(privateFonts.Families[0], 22f);
            Font menufont3 = new Font(privateFonts.Families[0], textFontSize);

            Font menufont4 = new Font(privateFonts.Families[0], textFontSize-4);


            textBox1.Font = menufont3;
            label_tobe.Font = menufont;
            custombox1.Font = menufont4;
            custombox2.Font = menufont4;
            custombox3.Font = menufont4;
            custombox4.Font = menufont4;
            custombox5.Font = menufont4;
        }





        private void formTarget_Shown(object sender, EventArgs e)
        {
            
        }

        private void picuterboxCircle1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    // 이미지 파일을 PictureBox에 표시
                    picuterboxCircle1.Image = Image.FromFile(imagePath);
                }
            }
        }
    }
}
