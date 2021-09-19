using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            song.Text = Form1.SelfRef.Recent_list.Text;
            cvolume.Value = Form1.SelfRef.cvolume.Value;
            lbl_volume.Text = cvolume.Value.ToString() + "%";
            timer1.Start();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public void button1_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.cvolume.Value = cvolume.Value;
            Form1.SelfRef.lbl_volume.Text = cvolume.Value.ToString() + "%";
            Form1.SelfRef.timer2.Start();
            timer1.Stop();
            Owner.Show();  
            Hide();
            
        }

        private void btn_previous_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.btn_prev_Click(sender, e);
            song.Text = Form1.SelfRef.Recent_list.Text;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.btn_play_Click(sender, e);
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.btn_pause_Click(sender, e);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.btn_stop_Click(sender, e);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.btn_next_Click(sender, e);
            song.Text = Form1.SelfRef.Recent_list.Text;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //Owner.Close();
            Form1.SelfRef.btn_close_Click(sender, e);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

       
        private void btn_forward_Click(object sender, EventArgs e)
        {
            Form1.SelfRef.btn_forward_Click(sender, e);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.SelfRef.btn_open_Click(sender, e);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }
        private void cvolume_Scroll(object sender, ScrollEventArgs e)
        {
            Form1.SelfRef.player.settings.volume = cvolume.Value;
            lbl_volume.Text = cvolume.Value.ToString() + "%";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1.SelfRef.player.settings.volume = cvolume.Value;
            lbl_volume.Text = cvolume.Value.ToString() + "%";
        }
    }
}
