using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6._1
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
             InitializeComponent();
            //bm = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);//Так ломается заливка, будь она неладна!
            this.Width = 1000;
            this.Height = 800;
            //bm = new Bitmap(1920, 1080);
            bm = new Bitmap(Width, Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
            p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            p.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            textBox1.Text = Cursor.Position.X.ToString();
            textBox2.Text = Cursor.Position.Y.ToString();
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black,1);
        Pen erase = new Pen(Color.White, 10);
        int index = 1;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color new_color;
        Form2 form2;
        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
        }

       private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = Cursor.Position.X.ToString();
            textBox2.Text = Cursor.Position.Y.ToString();
            if (paint)
            {
                if(index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;
            if(index==3)
            {
                g.DrawEllipse(p,cX,cY,sX,sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                g.DrawLine(p, cX, cY, x, y);
            }
            if(index==6)
            {

                try
                {
                    Graphics graphics = this.CreateGraphics();
                    Color color;
                    Bitmap bmp = new Bitmap(sX, sY);
                    for (int i = cX; i < e.X; i++)
                    {
                        for (int j = cY; j < e.Y; j++)
                        {
                            color = bm.GetPixel(i, j);
                            bmp.SetPixel(i - cX, j - cY, color);
                        }
                    }
                    form2 = new Form2();
                    form2.Width = bmp.Width;
                    form2.Height = bmp.Height;
                    form2.BackgroundImage = bmp;
                    form2.Show();
                    graphics.Dispose();
                    index = 1;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
                if (index == 6)
                {
                    Pen p = new Pen(Color.Black, 1);
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //g.Clear(Color.White);
            bm = new Bitmap(Width, Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }

        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value;
            erase.Width = trackBar1.Value;
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = new Bitmap(ofd.FileName);
                    bm = new Bitmap(image, image.Width, image.Height);
                    pic.Image = bm;
                    g = Graphics.FromImage(bm);
                    p.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                    p.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                }
                catch
                {

                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил Николай Гуреев", "О программе", MessageBoxButtons.OK);
        }

        private void btn_scissors_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
        }

        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx==old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_color) return;
            while (pixel.Count>0)
            {
                Point pt = (Point)pixel.Pop();
                if(pt.X > 0 && pt.Y > 0 && pt.X < bm.Width-1 && pt.Y < bm.Height-1)
                {
                    validate(bm, pixel, pt.X-1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y-1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y+1, old_color, new_clr);
                }
            }
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index==7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            index = 7;
            //p.Width = 1;
        }

    }
}
