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
            Font menufont2 = new Font(privateFonts.Families[1], 16f);
            lblsay.Font = menufont;
            lblwhatshoud.Font = menufont2;
            lblwhatshoud.ForeColor = Color.FromArgb(245, 77, 43);
            lblTodo.Font = menufont2;
            lblTodo.ForeColor = Color.FromArgb(245, 77, 43);
            #endregion

        }

        private void picuterboxCircle1_Click(object sender, EventArgs e)
        {

        }
 

        private void label1_Click(object sender, EventArgs e)
        {

        }
 
    }
}
