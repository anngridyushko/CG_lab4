namespace CG_lab4
{
    partial class lab4
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
            this.pointsPictureBox = new System.Windows.Forms.PictureBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tby1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tby2 = new System.Windows.Forms.TextBox();
            this.tbr = new System.Windows.Forms.TextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.ddaB = new System.Windows.Forms.Button();
            this.bresenhamB = new System.Windows.Forms.Button();
            this.bresenhamCircleB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.stepByStepB = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pointsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pointsPictureBox
            // 
            this.pointsPictureBox.Location = new System.Drawing.Point(230, 53);
            this.pointsPictureBox.Name = "pointsPictureBox";
            this.pointsPictureBox.Size = new System.Drawing.Size(873, 596);
            this.pointsPictureBox.TabIndex = 0;
            this.pointsPictureBox.TabStop = false;
            this.pointsPictureBox.Click += new System.EventHandler(this.pointsPictureBox_Click);
            this.pointsPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pointsPictureBox_Paint);
            this.pointsPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pointsPictureBox_MouseClick);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(13, 13);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(100, 22);
            this.tbx1.TabIndex = 1;
            // 
            // tby1
            // 
            this.tby1.Location = new System.Drawing.Point(13, 41);
            this.tby1.Name = "tby1";
            this.tby1.Size = new System.Drawing.Size(100, 22);
            this.tby1.TabIndex = 2;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(13, 69);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(100, 22);
            this.tbx2.TabIndex = 3;
            // 
            // tby2
            // 
            this.tby2.Location = new System.Drawing.Point(13, 97);
            this.tby2.Name = "tby2";
            this.tby2.Size = new System.Drawing.Size(100, 22);
            this.tby2.TabIndex = 4;
            // 
            // tbr
            // 
            this.tbr.Location = new System.Drawing.Point(13, 125);
            this.tbr.Name = "tbr";
            this.tbr.Size = new System.Drawing.Size(100, 22);
            this.tbr.TabIndex = 5;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(13, 334);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 17);
            this.timeLabel.TabIndex = 6;
            // 
            // ddaB
            // 
            this.ddaB.Location = new System.Drawing.Point(16, 207);
            this.ddaB.Name = "ddaB";
            this.ddaB.Size = new System.Drawing.Size(139, 23);
            this.ddaB.TabIndex = 7;
            this.ddaB.Text = "DDA";
            this.ddaB.UseVisualStyleBackColor = true;
            this.ddaB.Click += new System.EventHandler(this.ddaB_Click);
            // 
            // bresenhamB
            // 
            this.bresenhamB.Location = new System.Drawing.Point(16, 236);
            this.bresenhamB.Name = "bresenhamB";
            this.bresenhamB.Size = new System.Drawing.Size(139, 23);
            this.bresenhamB.TabIndex = 8;
            this.bresenhamB.Text = "Bresenham";
            this.bresenhamB.UseVisualStyleBackColor = true;
            this.bresenhamB.Click += new System.EventHandler(this.bresenhamB_Click);
            // 
            // bresenhamCircleB
            // 
            this.bresenhamCircleB.Location = new System.Drawing.Point(16, 265);
            this.bresenhamCircleB.Name = "bresenhamCircleB";
            this.bresenhamCircleB.Size = new System.Drawing.Size(139, 23);
            this.bresenhamCircleB.TabIndex = 9;
            this.bresenhamCircleB.Text = "Bresenham circle";
            this.bresenhamCircleB.UseVisualStyleBackColor = true;
            this.bresenhamCircleB.Click += new System.EventHandler(this.bresenhamCircleB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(16, 294);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(139, 23);
            this.clearB.TabIndex = 11;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // stepByStepB
            // 
            this.stepByStepB.Location = new System.Drawing.Point(16, 178);
            this.stepByStepB.Name = "stepByStepB";
            this.stepByStepB.Size = new System.Drawing.Size(139, 23);
            this.stepByStepB.TabIndex = 12;
            this.stepByStepB.Text = "step by step";
            this.stepByStepB.UseVisualStyleBackColor = true;
            this.stepByStepB.Click += new System.EventHandler(this.stepByStepB_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(230, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(873, 34);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(183, 53);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 596);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "x2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "y2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "radius";
            // 
            // lab4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 661);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.stepByStepB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.bresenhamCircleB);
            this.Controls.Add(this.bresenhamB);
            this.Controls.Add(this.ddaB);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.tbr);
            this.Controls.Add(this.tby2);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tby1);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.pointsPictureBox);
            this.Name = "lab4";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pointsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pointsPictureBox;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tby1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tby2;
        private System.Windows.Forms.TextBox tbr;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button ddaB;
        private System.Windows.Forms.Button bresenhamB;
        private System.Windows.Forms.Button bresenhamCircleB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button stepByStepB;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

