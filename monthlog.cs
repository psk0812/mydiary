using FontAwesome.Sharp;
using mydiary.monthlogs;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using static mydiary.main;


namespace mydiary
{
    public partial class monthlog : Form
    {
        private IconButton currentbtn;
        private Form currentForm;
        private object montform;

        public monthlog()
        {
            InitializeComponent();
            PrivateFontCollection privateFonts = new PrivateFontCollection();


            //폰트파일명 명시


            privateFonts.AddFontFile("NanumSquareR.ttf");
            privateFonts.AddFontFile("NanumSquareB.ttf");

            Font menufont3 = new Font(privateFonts.Families[0], 18f, System.Drawing.FontStyle.Bold);

            #region button set
            iconButton1.Font = menufont3;
            iconButton1.ForeColor = RGBColors.color_pink;
            iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton2.Font = menufont3;
            iconButton2.ForeColor = RGBColors.color_pink;
            iconButton2.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton3.Font = menufont3;
            iconButton3.ForeColor = RGBColors.color_pink;
            iconButton3.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton4.Font = menufont3;
            iconButton4.ForeColor = RGBColors.color_pink;
            iconButton4.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton5.Font = menufont3;
            iconButton5.ForeColor = RGBColors.color_pink;
            iconButton5.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton6.Font = menufont3;
            iconButton6.ForeColor = RGBColors.color_pink;
            iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton7.Font = menufont3;
            iconButton7.ForeColor = RGBColors.color_pink;
            iconButton7.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton8.Font = menufont3;
            iconButton8.ForeColor = RGBColors.color_pink;
            iconButton8.FlatAppearance.BorderColor = System.Drawing.Color.White;
         
            iconButton9.Font = menufont3;
            iconButton9.ForeColor = RGBColors.color_pink;
            iconButton9.FlatAppearance.BorderColor = System.Drawing.Color.White;
                       
            iconButton10.Font = menufont3;
            iconButton10.ForeColor = RGBColors.color_pink;
            iconButton10.FlatAppearance.BorderColor = System.Drawing.Color.White;

            iconButton11.Font = menufont3;
            iconButton11.ForeColor = RGBColors.color_pink;
            iconButton11.FlatAppearance.BorderColor = System.Drawing.Color.White;


            iconButton12.Font = menufont3;
            iconButton12.ForeColor = RGBColors.color_pink;
            iconButton12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            #endregion
        }



       
        private void paint_round(object sender)
        {
            Button button = (Button)sender;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 50;

            // 버튼 모서리를 둥글게 만듭니다.
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(button.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(button.Width - radius * 2, button.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, button.Height - radius * 2, radius * 2, radius * 2, 90, 90);

            button.Region = new Region(path);
        }


        #region button round

        private void iconButton1_Paint(object sender, PaintEventArgs e)

        {
            paint_round(sender);
        }
        private void iconButton2_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton3_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton4_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton5_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton6_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton7_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton8_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton9_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton10_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton11_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        private void iconButton12_Paint(object sender, PaintEventArgs e)
        {
            paint_round(sender);
        }

        #endregion

        #region form open
        private void iconButton1_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }

        private void iconButton12_Click(object sender, EventArgs e)
        {
            Form1 monthform = new Form1();
            monthform.ShowDialog();
        }
        #endregion
    }
}
