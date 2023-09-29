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
    public partial class target : Form
    {
        bool checkbtn1;
        bool checkbtn2;
        bool checkbtn3;
        bool checkbtn4;
        bool checkbtn5;

        public target()
        {
            InitializeComponent();

            PrivateFontCollection privateFonts = new PrivateFontCollection();

            //폰트파일명 명시
            privateFonts.AddFontFile("NanumSquareB.ttf");
            privateFonts.AddFontFile("NanumSquareR.ttf");

            //24f는 출력될 폰트사이즈
            Font font = new Font(privateFonts.Families[0], 20f);
            Font menufont = new Font(privateFonts.Families[1], 15f);
            Font menufont2 = new Font(privateFonts.Families[1], 25f);
            Font menufont3 = new Font(privateFonts.Families[1], 20f);


            label1.Font = font;
            label2.Font = menufont;
            label3.Font = menufont;
            textBox1.Font = menufont3;
            textBox2.Font = menufont2;
            textBox3.Font = menufont2;
            textBox4.Font = menufont2;
            textBox9.Font = menufont2;
            textBox11.Font = menufont2;
        }

        private void circlepic1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    circlepic1.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (iconButton1.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else 
            { iconButton1.IconChar = FontAwesome.Sharp.IconChar.Square; }
            
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (iconButton2.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton2.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton2.IconChar = FontAwesome.Sharp.IconChar.Square; }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (iconButton3.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton3.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square; }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (iconButton4.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton4.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton4.IconChar = FontAwesome.Sharp.IconChar.Square; }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (iconButton5.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton5.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton5.IconChar = FontAwesome.Sharp.IconChar.Square; }
        }

        private void target_Load(object sender, EventArgs e)
        {
          
        }

 
    }
}
