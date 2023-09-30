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

namespace mydiary
{
    public partial class target : Form
    {
        private String[] checking;

        string Text_targetpicbox;
        string Text_target1;
        string Text_target2 ;
        string Text_target3;
        string Text_target4;

        private TextBox[] textBoxArray;

        public target()
        {
            this.Opacity = 0.0;
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


            textBox5.Font = font;
            label2.Font = menufont;
            label3.Font = menufont;
            textBox1.Font = menufont3;
            todo1.Font = menufont2;
            todo2.Font = menufont2;
            todo3.Font = menufont2;
            todo4.Font = menufont2;
            todo5.Font = menufont2;

            textBoxArray = new TextBox[5];
            checking = new string[5];

            load_data();
            this.Opacity = 1.0;
        }

        private void load_data()
        {
            textBoxArray[0] = todo1;
            textBoxArray[1] = todo2;
            textBoxArray[2] = todo3;
            textBoxArray[3] = todo4;
            textBoxArray[4] = todo5;

            // 파일 경로 지정
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Text_targetpicbox = Path.Combine(appDirectory, @"..\..\..\mydiary\data\targetpicbox.txt");
            Text_target1 = Path.Combine(appDirectory, @"..\..\..\mydiary\data\target_1.txt");
            Text_target2 = Path.Combine(appDirectory, @"..\..\..\mydiary\data\target_2.txt");
            Text_target3 = Path.Combine(appDirectory, @"..\..\..\mydiary\data\target_3.txt");
            Text_target4 = Path.Combine(appDirectory, @"..\..\..\mydiary\data\target_4.txt");
            // 파일 경로 지정


            // 텍스트 파일에서 파일 이미지 경로 읽어오기
            using (StreamReader reader = new StreamReader(Text_targetpicbox))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    try
                    {
                        circlepic1.Image = Image.FromFile(line);
                    }
                    catch
                    { Console.Write("이미지 없음"); }
                }
            }
     

            string[] lines = File.ReadAllLines(Text_target1);
            textBox5.Lines = lines;

            string[] whatshould = File.ReadAllLines(Text_target2);
            textBox1.Lines = whatshould;

            #region checkbox
            checking = File.ReadAllLines(Text_target3);


            if (checking[0] == "false")
            {
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
            else { iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }

            if (checking[1] == "false")
            {
                iconButton2.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
            else { iconButton2.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }

            if (checking[2] == "false")
            {
                iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
            else { iconButton3.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }

            if (checking[3] == "false")
            {
                iconButton4.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
            else { iconButton4.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }

            if (checking[4] == "false")
            {
                iconButton5.IconChar = FontAwesome.Sharp.IconChar.Square;
            }
            else { iconButton5.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }

            #endregion

            string[] todo = File.ReadAllLines(Text_target4);
            int count = 0;
            foreach (string lists in todo)
            {
                textBoxArray[count].Text = lists;
                count += 1;
            }

        }


        private void circlepic1_Click(object sender, EventArgs e)
        {
            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(appDirectory, @"..\..\..\mydiary\data\targetpicbox.txt");
            Console.WriteLine(filePath);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    circlepic1.Image = Image.FromFile(imagePath);
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(imagePath);
                    }
                }
                
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (iconButton1.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton1.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else 
            { iconButton1.IconChar = FontAwesome.Sharp.IconChar.Square; }

            if (checking[0] == "false")
            {
                checking[0] = "true";
            }
            else
            {
                checking[0] = "false";
            }

            string filePath = Text_target3;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (String check in checking)
                {
                    string edit = check;
                    writer.WriteLine(edit);
                }

            }

        }

            private void iconButton2_Click(object sender, EventArgs e)
        {
            if (iconButton2.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton2.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton2.IconChar = FontAwesome.Sharp.IconChar.Square; }
            if (checking[1] == "false")
            {
                checking[1] = "true";
            }
            else
            {
                checking[1] = "false";
            }

            string filePath = Text_target3;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (String check in checking)
                {
                    string edit = check;
                    writer.WriteLine(edit);
                }

            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (iconButton3.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton3.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton3.IconChar = FontAwesome.Sharp.IconChar.Square; }
            if (checking[2] == "false")
            {
                checking[2] = "true";
            }
            else
            {
                checking[2] = "false";
            }

            string filePath = Text_target3;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (String check in checking)
                {
                    string edit = check;
                    writer.WriteLine(edit);
                }

            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (iconButton4.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton4.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton4.IconChar = FontAwesome.Sharp.IconChar.Square; }

            if (checking[3] == "false")
            {
                checking[3] = "true";
            }
            else
            {
                checking[3] = "false";
            }

            string filePath = Text_target3;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (String check in checking)
                {
                    string edit = check;
                    writer.WriteLine(edit);
                }

            }
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            if (iconButton5.IconChar == FontAwesome.Sharp.IconChar.Square)
            { iconButton5.IconChar = FontAwesome.Sharp.IconChar.SquareCheck; }
            else
            { iconButton5.IconChar = FontAwesome.Sharp.IconChar.Square; }

            if (checking[4] == "false")
            {
                checking[4] = "true";
            }
            else
            {
                checking[4] = "false";
            }

            string filePath = Text_target3;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (String check in checking)
                {
                    string edit = check;
                    writer.WriteLine(edit);
                }

            }
        }

        private void target_Load(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filePath = Text_target2;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(textBox1.Text);
            }
        }

        #region todo리스트박스 
        private void todo1_TextChanged(object sender, EventArgs e)
        {
            string filePath = Text_target4;
            
            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (TextBox lists in textBoxArray)
                {
                    string edit = lists.Text;
                    writer.WriteLine(edit);
                }
                
            }
        }

        private void todo2_TextChanged(object sender, EventArgs e)
        {
            string filePath = Text_target4;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (TextBox lists in textBoxArray)
                {
                    string edit = lists.Text;
                    writer.WriteLine(edit);
                }

            }
        }

        private void todo3_TextChanged(object sender, EventArgs e)
        {
            string filePath = Text_target4;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (TextBox lists in textBoxArray)
                {
                    string edit = lists.Text;
                    writer.WriteLine(edit);
                }

            }
        }

        private void todo4_TextChanged(object sender, EventArgs e)
        {
            string filePath = Text_target4;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (TextBox lists in textBoxArray)
                {
                    string edit = lists.Text;
                    writer.WriteLine(edit);
                }

            }
        }

        private void todo5_TextChanged(object sender, EventArgs e)
        {
            string filePath = Text_target4;

            // 텍스트 파일에 데이터 쓰기
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (TextBox lists in textBoxArray)
                {
                    string edit = lists.Text;
                    writer.WriteLine(edit);
                }

            }
        }
    }
    #endregion
}
