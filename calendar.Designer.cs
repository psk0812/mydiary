
namespace mydiary
{
    partial class calendar
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Next = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(747, 358);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(648, 432);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 1;
            this.Next.Text = "button1";
            this.Next.UseVisualStyleBackColor = true;
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(567, 432);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(75, 23);
            this.Previous.TabIndex = 2;
            this.Previous.Text = "button2";
            this.Previous.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Previous);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "calendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Label label1;
    }
}