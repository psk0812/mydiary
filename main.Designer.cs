
namespace mydiary
{
    partial class main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuPannel = new System.Windows.Forms.Panel();
            this.btnMonth = new FontAwesome.Sharp.IconButton();
            this.btnMindset = new FontAwesome.Sharp.IconButton();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.btnTarget = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblsayhello = new System.Windows.Forms.Label();
            this.lbleumgil = new System.Windows.Forms.Label();
            this.Menuicon = new FontAwesome.Sharp.IconPictureBox();
            this.titlebar = new System.Windows.Forms.Panel();
            this.iconexit = new FontAwesome.Sharp.IconPictureBox();
            this.iconmaximize = new FontAwesome.Sharp.IconPictureBox();
            this.iconmini = new FontAwesome.Sharp.IconPictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.MenuPannel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Menuicon)).BeginInit();
            this.titlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmini)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPannel
            // 
            this.MenuPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.MenuPannel.Controls.Add(this.btnMonth);
            this.MenuPannel.Controls.Add(this.btnMindset);
            this.MenuPannel.Controls.Add(this.btnCalendar);
            this.MenuPannel.Controls.Add(this.btnTarget);
            this.MenuPannel.Controls.Add(this.panel1);
            this.MenuPannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPannel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MenuPannel.Location = new System.Drawing.Point(0, 0);
            this.MenuPannel.Name = "MenuPannel";
            this.MenuPannel.Size = new System.Drawing.Size(200, 542);
            this.MenuPannel.TabIndex = 0;
            // 
            // btnMonth
            // 
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMonth.IconChar = FontAwesome.Sharp.IconChar.Instagram;
            this.btnMonth.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMonth.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonth.Location = new System.Drawing.Point(0, 408);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(200, 59);
            this.btnMonth.TabIndex = 5;
            this.btnMonth.Text = "달의 기록";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            this.btnMonth.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMonth_MouseClick);
            // 
            // btnMindset
            // 
            this.btnMindset.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMindset.FlatAppearance.BorderSize = 0;
            this.btnMindset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMindset.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMindset.IconChar = FontAwesome.Sharp.IconChar.Fire;
            this.btnMindset.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMindset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMindset.Location = new System.Drawing.Point(0, 349);
            this.btnMindset.Name = "btnMindset";
            this.btnMindset.Size = new System.Drawing.Size(200, 59);
            this.btnMindset.TabIndex = 4;
            this.btnMindset.Text = "비전보드";
            this.btnMindset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMindset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMindset.UseVisualStyleBackColor = true;
            this.btnMindset.Click += new System.EventHandler(this.btnMindset_Click);
            this.btnMindset.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMindset_MouseClick);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnCalendar.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.Location = new System.Drawing.Point(0, 290);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Size = new System.Drawing.Size(200, 59);
            this.btnCalendar.TabIndex = 3;
            this.btnCalendar.Text = "계획표";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            this.btnCalendar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalendar_MouseClick);
            // 
            // btnTarget
            // 
            this.btnTarget.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarget.FlatAppearance.BorderSize = 0;
            this.btnTarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTarget.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTarget.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.btnTarget.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnTarget.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTarget.Location = new System.Drawing.Point(0, 231);
            this.btnTarget.Name = "btnTarget";
            this.btnTarget.Size = new System.Drawing.Size(200, 59);
            this.btnTarget.TabIndex = 2;
            this.btnTarget.Text = "목표설정";
            this.btnTarget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTarget.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTarget.UseVisualStyleBackColor = true;
            this.btnTarget.Click += new System.EventHandler(this.btnTarget_Click);
            this.btnTarget.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnTarget_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblsayhello);
            this.panel1.Controls.Add(this.lbleumgil);
            this.panel1.Controls.Add(this.Menuicon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 231);
            this.panel1.TabIndex = 1;
            // 
            // lblsayhello
            // 
            this.lblsayhello.Font = new System.Drawing.Font("굴림", 12F);
            this.lblsayhello.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblsayhello.Location = new System.Drawing.Point(22, 99);
            this.lblsayhello.Name = "lblsayhello";
            this.lblsayhello.Size = new System.Drawing.Size(155, 91);
            this.lblsayhello.TabIndex = 2;
            this.lblsayhello.Text = "사람의 꿈은 죽지않아";
            // 
            // lbleumgil
            // 
            this.lbleumgil.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleumgil.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbleumgil.Location = new System.Drawing.Point(77, 38);
            this.lbleumgil.Name = "lbleumgil";
            this.lbleumgil.Size = new System.Drawing.Size(100, 54);
            this.lbleumgil.TabIndex = 1;
            this.lbleumgil.Text = "eumgil";
            this.lbleumgil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Menuicon
            // 
            this.Menuicon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.Menuicon.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Menuicon.IconChar = FontAwesome.Sharp.IconChar.FreeCodeCamp;
            this.Menuicon.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Menuicon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Menuicon.IconSize = 54;
            this.Menuicon.Location = new System.Drawing.Point(22, 38);
            this.Menuicon.Name = "Menuicon";
            this.Menuicon.Size = new System.Drawing.Size(58, 54);
            this.Menuicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Menuicon.TabIndex = 0;
            this.Menuicon.TabStop = false;
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.titlebar.Controls.Add(this.iconexit);
            this.titlebar.Controls.Add(this.iconmaximize);
            this.titlebar.Controls.Add(this.iconmini);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.Location = new System.Drawing.Point(200, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(779, 36);
            this.titlebar.TabIndex = 1;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            // 
            // iconexit
            // 
            this.iconexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.iconexit.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconexit.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            this.iconexit.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconexit.IconSize = 20;
            this.iconexit.Location = new System.Drawing.Point(721, 12);
            this.iconexit.Name = "iconexit";
            this.iconexit.Size = new System.Drawing.Size(21, 20);
            this.iconexit.TabIndex = 2;
            this.iconexit.TabStop = false;
            this.iconexit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconexit_MouseClick);
            // 
            // iconmaximize
            // 
            this.iconmaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.iconmaximize.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconmaximize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            this.iconmaximize.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconmaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmaximize.IconSize = 20;
            this.iconmaximize.Location = new System.Drawing.Point(694, 12);
            this.iconmaximize.Name = "iconmaximize";
            this.iconmaximize.Size = new System.Drawing.Size(21, 20);
            this.iconmaximize.TabIndex = 1;
            this.iconmaximize.TabStop = false;
            this.iconmaximize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconmaximize_MouseClick);
            // 
            // iconmini
            // 
            this.iconmini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconmini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(33)))), ((int)(((byte)(60)))));
            this.iconmini.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconmini.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconmini.IconColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconmini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconmini.IconSize = 20;
            this.iconmini.Location = new System.Drawing.Point(667, 12);
            this.iconmini.Name = "iconmini";
            this.iconmini.Size = new System.Drawing.Size(21, 20);
            this.iconmini.TabIndex = 0;
            this.iconmini.TabStop = false;
            this.iconmini.MouseClick += new System.Windows.Forms.MouseEventHandler(this.iconmini_MouseClick);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 36);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(779, 506);
            this.mainpanel.TabIndex = 2;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 542);
            this.ControlBox = false;
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.titlebar);
            this.Controls.Add(this.MenuPannel);
            this.Name = "main";
            this.MenuPannel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Menuicon)).EndInit();
            this.titlebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconmini)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPannel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbleumgil;
        private FontAwesome.Sharp.IconPictureBox Menuicon;
        private System.Windows.Forms.Label lblsayhello;
        private System.Windows.Forms.Panel titlebar;
        private FontAwesome.Sharp.IconButton btnTarget;
        private FontAwesome.Sharp.IconButton btnMonth;
        private FontAwesome.Sharp.IconButton btnMindset;
        private FontAwesome.Sharp.IconButton btnCalendar;
        private FontAwesome.Sharp.IconPictureBox iconexit;
        private FontAwesome.Sharp.IconPictureBox iconmaximize;
        private FontAwesome.Sharp.IconPictureBox iconmini;
        private System.Windows.Forms.Panel mainpanel;
    }
}

