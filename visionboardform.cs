using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydiary
{
    public partial class visionboardform : Form
    {
        string visionboard_1;
        string visionboard_2;
        string visionboard_3;
        string visionboard_4;
        string visionboard_5;
        string visionboard_6;
        string visionboard_7;

        public object LoadBitmap { get; private set; }

        public visionboardform()
        {
            InitializeComponent();

            string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("appDirectory");
            Console.WriteLine(appDirectory);
            visionboard_1 = Path.Combine(appDirectory, @"..\..\..\data\visionboard_1.txt");
            visionboard_2 = Path.Combine(appDirectory, @"..\..\..\data\visionboard_2.txt");
            visionboard_3 = Path.Combine(appDirectory, @"..\..\..\data\visionboard_3.txt");
            visionboard_4 = Path.Combine(appDirectory, @"..\..\..\data\visionboard_4.txt");
            visionboard_5 = Path.Combine(appDirectory, @"..\..\..\data\visionboard_5.txt");
            visionboard_6 = Path.Combine(appDirectory, @"..\..\..\data\visionboard_6.txt");
            visionboard_7 = Path.Combine(appDirectory, @"..\..\..\data\visionboard_7.txt");

           

        }
        #region updatebox wih double click
        private void visionpictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                
                string filePath = Path.Combine(appDirectory, @"..\..\..\data\visionboard_1.txt");
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;

                        visionpictureBox1.Image = Image.FromFile(imagePath);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(imagePath);
                        }
                    }

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
    
        }

        private void visionpictureBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                string filePath = Path.Combine(appDirectory, @"..\..\..\data\visionboard_2.txt");
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;

                        visionpictureBox2.Image = Image.FromFile(imagePath);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(imagePath);
                        }
                    }

                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void visionpictureBox3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(appDirectory, @"..\..\..\data\visionboard_3.txt");
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;

                        visionpictureBox3.Image = Image.FromFile(imagePath);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(imagePath);
                        }
                    }

                }
            }
            catch { }
        }

        private void visionpictureBox4_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(appDirectory, @"..\..\..\data\visionboard_4.txt");
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;

                        visionpictureBox4.Image = Image.FromFile(imagePath);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(imagePath);
                        }
                    }

                }
            }
            catch { }
        }

        private void visionpictureBox5_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(appDirectory, @"..\..\..\data\visionboard_5.txt");
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;

                        visionpictureBox5.Image = Image.FromFile(imagePath);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(imagePath);
                        }
                    }

                }
            }
            catch { }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(appDirectory, @"..\..\..\data\visionboard_6.txt");
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;

                        pictureBox1.Image = Image.FromFile(imagePath);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(imagePath);
                        }
                    }

                }
            }
            catch { }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(appDirectory, @"..\..\..\data\visionboard_7.txt");
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string imagePath = openFileDialog.FileName;

                        pictureBox2.Image = Image.FromFile(imagePath);
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                            writer.WriteLine(imagePath);
                        }
                    }

                }
            }
            catch { }
        }
        #endregion

        private void visionboardform_Load(object sender, EventArgs e)
        {
            try
            {

                using (StreamReader reader = new StreamReader(visionboard_1))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            visionpictureBox1.Image = Image.FromFile(line);
                        }
                        catch
                        { Console.Write("이미지 없음"); }
                    }
                }

                using (StreamReader reader = new StreamReader(visionboard_2))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            visionpictureBox2.Image = Image.FromFile(line);
                        }
                        catch
                        { Console.Write("이미지 없음"); }
                    }
                }

                using (StreamReader reader = new StreamReader(visionboard_3))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            visionpictureBox3.Image = Image.FromFile(line);
                        }
                        catch
                        { Console.Write("이미지 없음"); }
                    }
                }

                using (StreamReader reader = new StreamReader(visionboard_4))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            visionpictureBox4.Image = Image.FromFile(line);
                        }
                        catch
                        { Console.Write("이미지 없음"); }
                    }
                }

                using (StreamReader reader = new StreamReader(visionboard_5))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            visionpictureBox5.Image = Image.FromFile(line);
                        }
                        catch
                        { Console.Write("이미지 없음"); }
                    }
                }

                using (StreamReader reader = new StreamReader(visionboard_6))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            pictureBox1.Image = Image.FromFile(line);
                        }
                        catch
                        { Console.Write("이미지 없음"); }
                    }
                }

                using (StreamReader reader = new StreamReader(visionboard_7))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        try
                        {
                            pictureBox2.Image = Image.FromFile(line);
                        }
                        catch
                        { Console.Write("이미지 없음"); }
                    }
                }


            }
            catch 
            {
                
            }



        }
        public static Bitmap loadBitmap(string filePath)
        {
            try
            {
                return new Bitmap(filePath);
            }
            catch (Exception ex)
            {
                // 이미지 로드 중에 예외가 발생한 경우 예외 처리
                Console.WriteLine("이미지 로드 중에 예외 발생: " + ex.Message);
                return null; // 예외 발생 시 null 반환
            }
        }
    }

}
