using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace mydiary
{
    public class colortextbox : TextBox
    {
        public Color BorderColor { get; set; } // 테두리 색상 프로퍼티

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // 테두리 그리기
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, BorderColor, ButtonBorderStyle.Solid);
        }
    }
}
