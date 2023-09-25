using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mydiary
{
    public partial class visionboardform : Form
    {
        public visionboardform()
        {
            InitializeComponent();
        }
        #region updatebox wih double click
        private void visionpictureBox1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    visionpictureBox1.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void visionpictureBox2_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    visionpictureBox2.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void visionpictureBox3_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    visionpictureBox3.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void visionpictureBox4_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    visionpictureBox4.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void visionpictureBox5_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    visionpictureBox5.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    pictureBox1.Image = Image.FromFile(imagePath);
                }
            }
        }

        private void pictureBox2_DoubleClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "이미지 파일 (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string imagePath = openFileDialog.FileName;

                    pictureBox2.Image = Image.FromFile(imagePath);
                }
            }
        }
        #endregion
    }
}
