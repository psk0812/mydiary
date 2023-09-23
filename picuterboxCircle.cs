using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace mydiary
{
    class picuterboxCircle : PictureBox
    {
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        private Color borderColor2 = Color.HotPink;
        private DashStyle borderLineStyle = DashStyle.Solid;
        private DashCap borderCapStyle = DashCap.Flat;
        private float gradientAngle = 50F;

        public int BorderSize
        {
            get
            {
                return borderSize;
            }

            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get
            {
                return borderColor;
            }

            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public Color BorderColor2
        {
            get
            {
                return borderColor2;
            }

            set
            {
                borderColor2 = value;
                this.Invalidate();
            }
        }

        public DashStyle BorderLineStyle
        {
            get
            {
                return borderLineStyle;
            }

            set
            {
                borderLineStyle = value;
                this.Invalidate();
            }
        }

        public DashCap BorderCapStyle
        {
            get
            {
                return borderCapStyle;
            }

            set
            {
                borderCapStyle = value;
                this.Invalidate();
            }
        }

        public float GradientAngle
        {
            get
            {
                return gradientAngle;
            }

            set
            {
                gradientAngle = value;
                this.Invalidate();
            }
        }

        public void circlePictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        protected override void OnResize(EventArgs pe)
        {
            base.OnResize(pe);
            this.Size = new Size(this.Width, this.Width);

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            //Fields (필드 정의)

            var graph = pe.Graphics; // 그래픽 개체 생성
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1); // 부드러운 외곽 사각형 생성
            var rectBorder = Rectangle.Inflate(rectContourSmooth, -borderSize, -borderSize); // 테두리 사각형 생성
            var smoothSize = borderSize > 0 ? borderSize * 3 : 1; // 부드러운 테두리 두께 정의 (테두리가 0 이상인 경우)

            // 그래디언트 브러시를 사용하여 테두리 색상 설정
            using (var borderGColor = new LinearGradientBrush(rectBorder, borderColor, borderColor2, gradientAngle))
            using (var pathRegion = new GraphicsPath()) // 그래픽 경로 생성
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize)) // 부드러운 테두리 펜 생성 (부모 컨트롤의 배경색 사용)
            using (var penBorder = new Pen(borderGColor, borderSize)) // 테두리 펜 생성 (그래디언트 색상 사용)
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias; // 부드럽게 그리기 모드 설정
                penBorder.DashStyle = borderLineStyle; // 테두리 선 스타일 설정
                penBorder.DashCap = borderCapStyle; // 테두리 선 끝 스타일 설정
                pathRegion.AddEllipse(rectContourSmooth); // 부드러운 외곽을 가진 경로 생성

                // 둥근 모양의 영역 설정
                this.Region = new Region(pathRegion);

                // 그리기
                graph.DrawEllipse(penSmooth, rectContourSmooth); // 외곽을 부드럽게 그림
                if (borderSize > 0) // 테두리를 그림 (테두리 크기가 0보다 큰 경우)
                    graph.DrawEllipse(penBorder, rectBorder); // 테두리 그리기
            }
        }

    }

    }
