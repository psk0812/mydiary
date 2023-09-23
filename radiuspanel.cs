using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace mydiary
{

    class radiuspanel : Panel
    {

        private int cornerRadius = 10;
        public int CornerRadius
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                this.Invalidate();
            }
        }

        //Fields
       
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            GraphicsPath path = new GraphicsPath();
            int width = this.Width;
            int height = this.Height;
            int radius = CornerRadius;

            path.AddArc(0, 0, radius, radius, 180, 90); // 왼쪽 위 모서리
            path.AddArc(width - radius, 0, radius, radius, 270, 90); // 오른쪽 위 모서리
            path.AddArc(width - radius, height - radius, radius, radius, 0, 90); // 오른쪽 아래 모서리
            path.AddArc(0, height - radius, radius, radius, 90, 90); // 왼쪽 아래 모서리
            path.CloseAllFigures();

            this.Region = new Region(path);


        }
       
    }
}
