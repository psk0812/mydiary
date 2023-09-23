
namespace mydiary
{
    partial class formTarget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.radiuspanel1 = new mydiary.radiuspanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_tobe = new System.Windows.Forms.Label();
            this.picuterboxCircle1 = new mydiary.picuterboxCircle();
            this.radiuspanel2 = new mydiary.radiuspanel();
            this.radiuspanel3 = new mydiary.radiuspanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.radiuspanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuterboxCircle1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.98518F));
            this.tableLayoutPanel1.Controls.Add(this.radiuspanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.2963F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.7037F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 594);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 277);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.radiuspanel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.radiuspanel3);
            this.splitContainer2.Size = new System.Drawing.Size(871, 314);
            this.splitContainer2.SplitterDistance = 422;
            this.splitContainer2.TabIndex = 4;
            // 
            // radiuspanel1
            // 
            this.radiuspanel1.AutoSize = true;
            this.radiuspanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.radiuspanel1.BackColor = System.Drawing.Color.White;
            this.radiuspanel1.Controls.Add(this.splitContainer1);
            this.radiuspanel1.CornerRadius = 100;
            this.radiuspanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiuspanel1.Location = new System.Drawing.Point(3, 3);
            this.radiuspanel1.Name = "radiuspanel1";
            this.radiuspanel1.Size = new System.Drawing.Size(871, 268);
            this.radiuspanel1.TabIndex = 3;
            this.radiuspanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.radiuspanel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_tobe);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.picuterboxCircle1);
            this.splitContainer1.Size = new System.Drawing.Size(871, 268);
            this.splitContainer1.SplitterDistance = 604;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_tobe
            // 
            this.label_tobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tobe.Location = new System.Drawing.Point(2, 2);
            this.label_tobe.Name = "label_tobe";
            this.label_tobe.Size = new System.Drawing.Size(600, 264);
            this.label_tobe.TabIndex = 0;
            this.label_tobe.Text = "\"나는 해외 IT 대기업의 개발자가 될거다\"";
            this.label_tobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_tobe.Click += new System.EventHandler(this.label1_Click);
            // 
            // picuterboxCircle1
            // 
            this.picuterboxCircle1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Triangle;
            this.picuterboxCircle1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picuterboxCircle1.BorderColor2 = System.Drawing.Color.HotPink;
            this.picuterboxCircle1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.picuterboxCircle1.BorderSize = 8;
            this.picuterboxCircle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picuterboxCircle1.GradientAngle = 50F;
            this.picuterboxCircle1.Location = new System.Drawing.Point(0, 0);
            this.picuterboxCircle1.MaximumSize = new System.Drawing.Size(400, 400);
            this.picuterboxCircle1.MinimumSize = new System.Drawing.Size(200, 200);
            this.picuterboxCircle1.Name = "picuterboxCircle1";
            this.picuterboxCircle1.Padding = new System.Windows.Forms.Padding(2);
            this.picuterboxCircle1.Size = new System.Drawing.Size(263, 263);
            this.picuterboxCircle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picuterboxCircle1.TabIndex = 3;
            this.picuterboxCircle1.TabStop = false;
            this.picuterboxCircle1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picuterboxCircle1_LoadCompleted);
            this.picuterboxCircle1.Click += new System.EventHandler(this.picuterboxCircle1_Click);
            // 
            // radiuspanel2
            // 
            this.radiuspanel2.BackColor = System.Drawing.Color.White;
            this.radiuspanel2.CornerRadius = 100;
            this.radiuspanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiuspanel2.Location = new System.Drawing.Point(0, 0);
            this.radiuspanel2.Name = "radiuspanel2";
            this.radiuspanel2.Size = new System.Drawing.Size(422, 314);
            this.radiuspanel2.TabIndex = 0;
            // 
            // radiuspanel3
            // 
            this.radiuspanel3.BackColor = System.Drawing.Color.White;
            this.radiuspanel3.CornerRadius = 100;
            this.radiuspanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiuspanel3.Location = new System.Drawing.Point(0, 0);
            this.radiuspanel3.Name = "radiuspanel3";
            this.radiuspanel3.Size = new System.Drawing.Size(445, 314);
            this.radiuspanel3.TabIndex = 1;
            // 
            // formTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(877, 594);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "formTarget";
            this.Load += new System.EventHandler(this.formTarget_Load);
            this.ResizeEnd += new System.EventHandler(this.formTarget_ResizeEnd);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.radiuspanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picuterboxCircle1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private radiuspanel radiuspanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_tobe;
        private picuterboxCircle picuterboxCircle1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private radiuspanel radiuspanel2;
        private radiuspanel radiuspanel3;
    }
}