using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydiary.monthlogs
{
    public partial class Form1 : Form
    {
        private TextBox textbox1; // textbox1을 private으로 유지
        private String Path;
        public Form1()
        {
            InitializeComponent(); 
            PrivateFontCollection privateFonts = new PrivateFontCollection();


            //폰트파일명 명시


            privateFonts.AddFontFile("NanumSquareR.ttf");
            privateFonts.AddFontFile("NanumSquareB.ttf");

            Font memofont = new Font(privateFonts.Families[0], 18f, System.Drawing.FontStyle.Bold);
            textBox1.Font = memofont;
        }

        public string[] TextBox1
        {
            get { return textBox1.Lines; }

            set { textBox1.Lines = value; }
        }

        public string FilePath
        {
            get { return Path; }
            set { Path = value; }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(Path))
            {
                writer.WriteLine(textBox1.Text);
            }
        }
    }
   
}
