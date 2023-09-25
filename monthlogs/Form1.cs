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

namespace mydiary.monthlogs
{
    public partial class Form1 : Form
    {
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
    }
   
}
