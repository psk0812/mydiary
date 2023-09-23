
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
            this.radiuspanel1 = new mydiary.radiuspanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.picuterboxCircle1 = new mydiary.picuterboxCircle();
            this.label_tobe = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radiuspanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picuterboxCircle1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radiuspanel1
            // 
            this.radiuspanel1.AutoSize = true;
            this.radiuspanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.radiuspanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.radiuspanel1, 2);
            this.radiuspanel1.Controls.Add(this.splitContainer1);
            this.radiuspanel1.CornerRadius = 100;
            this.radiuspanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radiuspanel1.Location = new System.Drawing.Point(3, 3);
            this.radiuspanel1.Name = "radiuspanel1";
            this.radiuspanel1.Size = new System.Drawing.Size(871, 257);
            this.radiuspanel1.TabIndex = 3;
            this.radiuspanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.radiuspanel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
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
            this.splitContainer1.Size = new System.Drawing.Size(871, 257);
            this.splitContainer1.SplitterDistance = 604;
            this.splitContainer1.TabIndex = 0;
            // 
            // picuterboxCircle1
            // 
            this.picuterboxCircle1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.picuterboxCircle1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.picuterboxCircle1.BorderColor2 = System.Drawing.Color.HotPink;
            this.picuterboxCircle1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.picuterboxCircle1.BorderSize = 2;
            this.picuterboxCircle1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picuterboxCircle1.GradientAngle = 50F;
            this.picuterboxCircle1.Location = new System.Drawing.Point(0, 0);
            this.picuterboxCircle1.MaximumSize = new System.Drawing.Size(400, 400);
            this.picuterboxCircle1.MinimumSize = new System.Drawing.Size(200, 200);
            this.picuterboxCircle1.Name = "picuterboxCircle1";
            this.picuterboxCircle1.Size = new System.Drawing.Size(263, 263);
            this.picuterboxCircle1.TabIndex = 3;
            this.picuterboxCircle1.TabStop = false;
            this.picuterboxCircle1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.picuterboxCircle1_LoadCompleted);
            this.picuterboxCircle1.Click += new System.EventHandler(this.picuterboxCircle1_Click);
            // 
            // label_tobe
            // 
            this.label_tobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_tobe.Location = new System.Drawing.Point(2, 2);
            this.label_tobe.Name = "label_tobe";
            this.label_tobe.Size = new System.Drawing.Size(600, 253);
            this.label_tobe.TabIndex = 0;
            this.label_tobe.Text = "\"나는 해외 IT 대기업의 개발자가 될거다\"";
            this.label_tobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_tobe.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0057F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.9943F));
            this.tableLayoutPanel1.Controls.Add(this.radiuspanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(877, 594);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.radiuspanel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picuterboxCircle1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private radiuspanel radiuspanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label_tobe;
        private picuterboxCircle picuterboxCircle1;
    }
}