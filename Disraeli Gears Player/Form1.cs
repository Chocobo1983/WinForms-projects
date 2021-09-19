using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Form2 frm2;
        Form3 frm3;
        public static Form1 SelfRef { get; set; }
        public Form1()
        {
            SelfRef = this;
            InitializeComponent();
            sfd.Filter = "Playlist files(*.fpl)|*.fpl";
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            cvolume.Value = 50;
            timer2.Start();
            MemoryReader();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        SaveFileDialog sfd = new SaveFileDialog();
        internal List<string> paths = new List<string>();
        Image image = null;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private bool random = false;
        
        public void btn_open_Click(object sender, EventArgs e)
        {
            ofd.Multiselect = true;
            ofd.Filter = "mp3 files(*.mp3)|*.mp3|cda files(*.cda)|*cda";//|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            else
            {
                foreach (string item in ofd.FileNames)
                {
                    paths.Add(item);
                }
                foreach (var item in ofd.SafeFileNames)
                {
                    Recent_list.Items.Add(item);
                }
            }
            
        }
        private void MemoryReader()
        {
            DriveInfo drive = DriveInfo.GetDrives()[0];
            string path = drive.Name + @"\DGP\tmp.dat";
            try
            {
                using (FileStream fstream = File.OpenRead(path))
                {
                    string line;
                    System.IO.StreamReader file = new System.IO.StreamReader(path);
                    while ((line = file.ReadLine()) != null)
                    {
                        paths.Add(line);
                    }

                    file.Close();
                }
                foreach (var item in paths)
                {
                    Recent_list.Items.Add(Path.GetFileName(item));
                }
            }
            catch (Exception) {}
            
        }
        private void Recent_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            image = pic.InitialImage;
            Song.Text = Recent_list.Text;
            info.Text = "";
            Album.Text = "";
            year.Text = "";
            if (Recent_list.SelectedIndex==-1)
            {
                player.Ctlcontrols.stop();
            }
            else
            {
                try
                {
                    player.URL = paths[Recent_list.SelectedIndex];
                    TagLib.File file_TAG = TagLib.File.Create(paths[Recent_list.SelectedIndex]);
                    if (file_TAG.Tag.Pictures.Length >= 1)
                    {
                        var bin = (byte[])(file_TAG.Tag.Pictures[0].Data.Data);

                        try
                        {
                            image = Image.FromStream(new MemoryStream(bin));
                        }
                        catch (Exception )
                        {
                            
                        }
                    }
                    if (file_TAG.Tag.Title != "" && file_TAG.Tag.Title != null)
                    {
                        try
                        {
                            Song.Text = file_TAG.Tag.Title;
                        }
                        catch (Exception)
                        {

                            
                        }
                    }
                    if (file_TAG.Tag.FirstPerformer != "" && file_TAG.Tag.FirstPerformer != null)
                    {
                        try
                        {
                            info.Text += file_TAG.Tag.FirstPerformer;
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                    }
                    if (file_TAG.Tag.Album != "" && file_TAG.Tag.Album != null)
                    {
                        try
                        {
                            Album.Text += file_TAG.Tag.Album;
                        }
                        catch (Exception)
                        {

                            
                        }
                    }
                    if (file_TAG.Tag.Year.ToString() != "" && file_TAG.Tag.Year.ToString() != "0")
                    {
                        try
                        {
                            year.Text += file_TAG.Tag.Year.ToString();
                        }
                        catch (Exception)
                        {

                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    player.Ctlcontrols.play();
                }
                catch (Exception) {}
                pic.Image = image;
                
            }
            
            
            timer1.Start();
                       
        }
        
        
        public void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void Recent_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            player.URL = paths[Recent_list.SelectedIndex];
            player.Ctlcontrols.play();
            
        }

        public void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            progressBar1.Value = 0;
            lbl_track_start.Text = "00:00";
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

           if (sfd.ShowDialog() == DialogResult.Cancel) return;
           string filename = sfd.FileName;
           StreamWriter Save = new StreamWriter(filename);
           foreach (string item in paths)
           {
              Save.WriteLine(item);
              this.Refresh();
           }
           MessageBox.Show("Saved to Favorite_List");
           Save.Close();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Playlist files(*.fpl)|*.fpl|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;
            Recent_list.Items.Clear();
            paths = new List<string>();
            string filename = ofd.FileName;
            using (StreamReader read = new StreamReader(filename))
            {
                string line;
                while((line = read.ReadLine())!=null)
                {
                    paths.Add(line);
                    Recent_list.Items.Add(Path.GetFileName(line));
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(Recent_list.SelectedItems.Count>0)
            {
                paths.RemoveAt(Recent_list.SelectedIndex);
                  Recent_list.Items.RemoveAt(Recent_list.SelectedIndex);
            }

        }

        public void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        public void btn_next_Click(object sender, EventArgs e)
        {
            if (Recent_list.SelectedIndex < Recent_list.Items.Count - 1)
            {
                Recent_list.SelectedIndex = Recent_list.SelectedIndex + 1;
            }
        }

        public void btn_prev_Click(object sender, EventArgs e)
        {
            if (Recent_list.SelectedIndex >0)
            {
                Recent_list.SelectedIndex = Recent_list.SelectedIndex -1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
                lbl_track_start.Text = player.Ctlcontrols.currentPositionString;
                lbl_track_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                if (frm2 != null)
                { 
                    frm2.lbl_start.Text = player.Ctlcontrols.currentPositionString;
                    frm2.lbl_end.Text = player.Ctlcontrols.currentItem.durationString.ToString();
                }
                if((int)player.Ctlcontrols.currentPosition == (int)player.Ctlcontrols.currentItem.duration-1 && Recent_list.SelectedIndex<Recent_list.Items.Count-1 && !random)
                {
                    btn_next_Click(sender, e);
                }
                if((int)player.Ctlcontrols.currentPosition == (int)player.Ctlcontrols.currentItem.duration - 1 && random)
                {
                    Random rand = new Random();
                    Recent_list.SelectedIndex = rand.Next(0, paths.Count);                    
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frm2 == null)
            {
                frm2 = new Form2();   
                frm2.FormClosed += frm2_FormClosed;  
                
            }
            timer2.Stop();
            frm2.timer1.Start();
            frm2.song.Text = Recent_list.Text;
            frm2.cvolume.Value = cvolume.Value;
            frm2.lbl_volume.Text = cvolume.Value.ToString() + "%";
            frm2.Show(this);  
            
            Hide();
        }
        void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm2 = null;  
            Show();
        }

        public void btn_reverse_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastReverse();
        }

        public void btn_forward_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.fastForward();
        }

        private void progressBar1_MouseClick(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = (e.X*progressBar1.Maximum)/progressBar1.Width;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        internal void btn_close_Click(object sender, EventArgs e)
        {

            DriveInfo drive = DriveInfo.GetDrives()[0];
            string path = drive.Name + @"\DGP";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if(!dirInfo.Exists) dirInfo.Create();
            string filename = drive.Name+@"\DGP\tmp.dat";
            //MessageBox.Show(filename);
            File.WriteAllLines(filename, paths);
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Recent_list.Items.Clear();
            paths = new List<string>();
        }

        private void cvolume_Scroll(object sender, ScrollEventArgs e)
        {
            player.settings.volume = cvolume.Value;
            lbl_volume.Text = cvolume.Value.ToString() + "%";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            player.settings.volume = cvolume.Value;
            lbl_volume.Text = cvolume.Value.ToString() + "%";
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            if (random)
            {
                random = false;
                btn_random.Image = Properties.Resources.shuffle_off;
            }
            else
            {
                random = true;
                btn_random.Image = Properties.Resources.shuffle_on;
            }
            
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void frm3_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm3 = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (frm3 == null)
            {
                frm3 = new Form3();
                frm3.FormClosed += frm3_FormClosed;
                frm3.StartPosition = FormStartPosition.CenterParent;
                frm3.txt1.Text = "For non-commercial use only";
                frm3.ShowDialog();
            }
            
            
        }
    }
}
