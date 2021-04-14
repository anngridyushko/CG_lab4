using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CG_lab4
{
    public partial class lab4 : Form
    {
        HashSet<KeyValuePair<int, int>> line_points = new HashSet<KeyValuePair<int, int>>();
       
        private int centerX = 0, centerY = 0;
        private int scale = 1, minScale = 1, maxScale = 16;
        private int fontSize = 7;
        private int width = 700;
        private int height = 500;

        public lab4() {
            InitializeComponent();
            pointsPictureBox.Width = width;
            pointsPictureBox.Height = height;
            pictureBox1.Width = width;
            pictureBox1.Height = 10;
            pictureBox2.Height = height;
            pictureBox2.Width = 40;
        }

        private void pointsPictureBox_Paint(object sender, PaintEventArgs e)
        {
            int beginX = centerX - width / 2 / scale, beginY = centerY - height / 2 / scale;
            int endX = width / scale + beginX, endY = height / scale + beginY;

            drawLines(e.Graphics, beginX, endX, beginY, endY);

            int x = 0;
            if (beginX <= 0 && endX >= 0) {
                x = -beginX * scale;
                e.Graphics.DrawLine(new Pen(Brushes.Blue, 2),
                    new Point(x, 0),
                    new Point(x, height));
            }
            int y = 0;
            if (beginY <= 0 && endY >= 0) {
                y = -beginY * scale;
                e.Graphics.DrawLine(new Pen(Brushes.Blue, 2),
                    new Point(0, y),
                    new Point(width, y));
            }

            drawPoints(e.Graphics);
        }

        private void drawLines(Graphics g, int beginX, int endX, int beginY, int endY)
        {
            int cellX = (endX - beginX) / (width / 25);
            int cellY = (endY - beginY) / (height / 25);
            int diff = (-beginX) % (cellX * 2);

            int lines = 0, x = 0, y = 0;
            int start = beginX + diff;
            if (diff < cellX / 2)
            {
                start += cellX;
            }

            while (start <= width)
            {
                x = (start - beginX) * scale;
                g.DrawLine(new Pen(Brushes.Gray),
                    new Point(x, 0),
                    new Point(x, height));

                if (scale < 10 || lines % 2 == 0)
                {
                    g.DrawLine(new Pen(Brushes.Black, 1),
                        new Point(x, 0),
                        new Point(x, height));
                }
                start += cellX;
                lines++;
            }

            diff = (-beginY) % (cellY * 2);
            start = beginY + diff;
            if (diff < cellY / 2)
            {
                start += cellY;
            }

            while (start <= height)
            {
                y = (start - beginY) * scale;
                g.DrawLine(new Pen(Brushes.Gray),
                    new Point(0, y),
                    new Point(width, y));

                if (scale < 10 || lines % 2 != 0)
                {
                    g.DrawLine(new Pen(Brushes.Black),
                        new Point(0, y),
                        new Point(width, y));
                }
                start += cellY;
                lines++;
            }
        }

        private void drawPoints(Graphics g)
        {
            KeyValuePair<int, int> rect1 = new KeyValuePair<int, int>(centerX - width / scale / 2,
                centerY - height / scale / 2);
            KeyValuePair<int, int> rect2 = new KeyValuePair<int, int>(rect1.Key + width / scale,
                rect1.Value + height / scale);
            
            foreach (KeyValuePair<int, int> point in line_points)
            {
                if(point.Key >= rect1.Key &&
                    point.Key < rect2.Key &&
                    point.Value >= rect1.Value &&
                    point.Value < rect2.Value)
                {
                    g.FillRectangle(Brushes.Black,
                        scale * (point.Key - rect1.Key),
                        scale * (point.Value - rect1.Value),
                        scale,
                        scale);
                }
            }
        }

        private void pointsPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            int x = (e.X) / scale - width / scale / 2, y = (e.Y) / scale - height / scale / 2;

            if(e.Button == MouseButtons.Left && scale < maxScale) {
                centerX += x;
                centerY += y;
                scale *= 2;               
            }
            else if(e.Button == MouseButtons.Right && scale > minScale)
            {
                centerX += x;
                centerY += y;
                scale /= 2;
            }          
            
           if (scale == 1) {
                centerX = 0;
                centerY = 0;
            }

            pointsPictureBox.Refresh();
            pictureBox1.Refresh();
            pictureBox2.Refresh();
        }

        private void clearB_Click(object sender, EventArgs e)
        {
            line_points.Clear();
            pointsPictureBox.Refresh();
        }

        private void stepByStepB_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            int x1, y1, x2, y2;
            line_points.Clear();
            if(validate_line(out x1, out y1, out x2, out y2))
            {
                time.Start();
                line_points = Rasterization.StepByStep(x1, -y1, x2, -y2);
                time.Stop();
            }
            else
            {
                MessageBox.Show("Please, enter numbers");
            }
            
            timeLabel.Text = $"Elapsed time: \n {time.Elapsed.TotalMilliseconds * 1000} \n microseconds";
            pointsPictureBox.Refresh();
        }

        private void ddaB_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            int x1, y1, x2, y2;
            line_points.Clear();
            if (validate_line(out x1, out y1, out x2, out y2))
            {
                time.Start();
                line_points = Rasterization.DDA(x1, -y1, x2, -y2);
                time.Stop();
                
            }
            else
            {
                MessageBox.Show("Please, enter numbers");
            }

            timeLabel.Text = $"Elapsed time: \n {time.Elapsed.TotalMilliseconds * 1000} \n microseconds";
            pointsPictureBox.Refresh();
        }

        private void bresenhamB_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            int x1, y1, x2, y2;
            line_points.Clear();
            if (validate_line(out x1, out y1, out x2, out y2))
            {
                time.Start();
                line_points = Rasterization.Bresenham(x1, -y1, x2, -y2);
                time.Stop();
            }
            else
            {
                MessageBox.Show("Please, enter numbers");
            }

            timeLabel.Text = $"Elapsed time: \n {time.Elapsed.TotalMilliseconds * 1000} \n microseconds";
            pointsPictureBox.Refresh();
        }

        private void bresenhamCircleB_Click(object sender, EventArgs e)
        {
            Stopwatch time = new Stopwatch();
            int x1, y1, r;
            line_points.Clear();
            if (validate_circle(out x1, out y1, out r))
            {
                time.Start();
                line_points = Rasterization.BresenhamCircle(x1, -y1, r);
                time.Stop();
            }
            else
            {
                MessageBox.Show("Please, enter numbers");
            }

            timeLabel.Text = $"Elapsed time: \n {time.Elapsed.TotalMilliseconds * 1000} \n microseconds";
            pointsPictureBox.Refresh();
        }

        
        private void pointsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int beginX = centerX - width / 2 / scale, beginY = centerY - height / 2 / scale;
            int endX = width / scale + beginX, endY = height / scale + beginY;

            int cellX = (endX - beginX) / (width / 25);
            int cellY = (endY - beginY) / (height / 25);
            int diff = (-beginX) % (cellX * 2);

            int lines = 0, x = 0, y = 0;
            int start = beginX + diff;
            if (diff < cellX / 2)
            {
                start += cellX;
            }

            while (start <= width)
            {
                x = (start - beginX) * scale;
                
                if (scale < 10 || lines % 2 == 0)
                {
                   
                    e.Graphics.DrawString(start.ToString(),
                        new Font("Verdana", fontSize),
                        new SolidBrush(Color.Red),
                        x - start.ToString().Length * fontSize / 2f,
                        0);
                }
                start += cellX;
                lines++;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            int beginX = centerX - width / 2 / scale, beginY = centerY - height / 2 / scale;
            int endX = width / scale + beginX, endY = height / scale + beginY;

            int cellX = (endX - beginX) / (width / 25);
            int cellY = (endY - beginY) / (height / 25);
            int diff = (-beginX) % (cellX * 2);

            int lines = 0, x = 0, y = 0;
            int start = beginX + diff;
            if (diff < cellX / 2)
            {
                start += cellX;
            }

            diff = (-beginY) % (cellY * 2);
            start = beginY + diff;
            if (diff < cellY / 2)
            {
                start += cellY;
            }

            while (start <= height)
            {
                y = (start - beginY) * scale;
                
                if (scale < 10 || lines % 2 == 0)
                {
                  
                    e.Graphics.DrawString((-start).ToString(),
                        new Font("Verdana", fontSize),
                        new SolidBrush(Color.Red),
                        0,
                        y - fontSize);
                }
                start += cellY;
                lines++;
            }
        }

        private bool validate_line(out int x1, out int y1, out int x2, out int y2)
        { 
            bool isIntx1 = int.TryParse(tbx1.Text, out x1);
            bool isInty1 = int.TryParse(tby1.Text, out y1);
            bool isIntx2 = int.TryParse(tbx2.Text, out x2);
            bool isInty2 = int.TryParse(tby2.Text, out y2);
            return isIntx1 && isIntx2 && isInty1 && isInty2;
        }

        private bool validate_circle(out int x1, out int y1, out int r)
        {
            bool isIntx1 = int.TryParse(tbx1.Text, out x1);
            bool isInty1 = int.TryParse(tby1.Text, out y1);
            bool isIntR = int.TryParse(tbr.Text, out r);          
            return isIntx1 && isInty1 && isIntR;
        }

        private void pointsPictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }




    }
}