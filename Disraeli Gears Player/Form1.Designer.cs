
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Song = new System.Windows.Forms.TextBox();
            this.info = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.year = new System.Windows.Forms.TextBox();
            this.Album = new System.Windows.Forms.TextBox();
            this.Recent_list = new System.Windows.Forms.ListBox();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_forward = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.cvolume = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_random = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(6, 98);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(301, 46);
            this.player.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Song
            // 
            this.Song.BackColor = System.Drawing.Color.Black;
            this.Song.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Song.Dock = System.Windows.Forms.DockStyle.Top;
            this.Song.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Song.ForeColor = System.Drawing.Color.Lime;
            this.Song.Location = new System.Drawing.Point(0, 0);
            this.Song.Multiline = true;
            this.Song.Name = "Song";
            this.Song.Size = new System.Drawing.Size(280, 29);
            this.Song.TabIndex = 23;
            // 
            // info
            // 
            this.info.BackColor = System.Drawing.Color.Black;
            this.info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.info.Dock = System.Windows.Forms.DockStyle.Top;
            this.info.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.ForeColor = System.Drawing.Color.Green;
            this.info.Location = new System.Drawing.Point(0, 29);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(280, 15);
            this.info.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.Album);
            this.panel1.Controls.Add(this.info);
            this.panel1.Controls.Add(this.Song);
            this.panel1.Controls.Add(this.player);
            this.panel1.Location = new System.Drawing.Point(174, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 147);
            this.panel1.TabIndex = 25;
            // 
            // year
            // 
            this.year.BackColor = System.Drawing.Color.Black;
            this.year.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.year.Dock = System.Windows.Forms.DockStyle.Top;
            this.year.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year.ForeColor = System.Drawing.Color.Green;
            this.year.Location = new System.Drawing.Point(0, 59);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(280, 15);
            this.year.TabIndex = 26;
            // 
            // Album
            // 
            this.Album.BackColor = System.Drawing.Color.Black;
            this.Album.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Album.Dock = System.Windows.Forms.DockStyle.Top;
            this.Album.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Album.ForeColor = System.Drawing.Color.Green;
            this.Album.Location = new System.Drawing.Point(0, 44);
            this.Album.Name = "Album";
            this.Album.Size = new System.Drawing.Size(280, 15);
            this.Album.TabIndex = 25;
            // 
            // Recent_list
            // 
            this.Recent_list.BackColor = System.Drawing.Color.Black;
            this.Recent_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Recent_list.ForeColor = System.Drawing.Color.LimeGreen;
            this.Recent_list.FormattingEnabled = true;
            this.Recent_list.ItemHeight = 15;
            this.Recent_list.Location = new System.Drawing.Point(12, 269);
            this.Recent_list.Name = "Recent_list";
            this.Recent_list.Size = new System.Drawing.Size(443, 259);
            this.Recent_list.TabIndex = 2;
            this.Recent_list.SelectedIndexChanged += new System.EventHandler(this.Recent_list_SelectedIndexChanged);
            this.Recent_list.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Recent_list_MouseDoubleClick);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_volume.Location = new System.Drawing.Point(427, 237);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(27, 13);
            this.lbl_volume.TabIndex = 14;
            this.lbl_volume.Text = "50%";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(48, 207);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(363, 10);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.progressBar1_MouseClick);
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_track_start.Location = new System.Drawing.Point(8, 203);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(34, 13);
            this.lbl_track_start.TabIndex = 16;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_track_end.Location = new System.Drawing.Point(417, 204);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(34, 13);
            this.lbl_track_end.TabIndex = 17;
            this.lbl_track_end.Text = "00:00";
            // 
            // btn_clear
            // 
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Image = global::WindowsFormsApp1.Properties.Resources.clear;
            this.btn_clear.Location = new System.Drawing.Point(196, 544);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(40, 40);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_clear, "Clear playlist");
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Image = global::WindowsFormsApp1.Properties.Resources.gtk_close_20x20_;
            this.btn_close.Location = new System.Drawing.Point(446, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(20, 20);
            this.btn_close.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btn_close, "close");
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // pic
            // 
            this.pic.InitialImage = ((System.Drawing.Image)(resources.GetObject("pic.InitialImage")));
            this.pic.Location = new System.Drawing.Point(11, 42);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(157, 148);
            this.pic.TabIndex = 22;
            this.pic.TabStop = false;
            // 
            // btn_forward
            // 
            this.btn_forward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_forward.Image = global::WindowsFormsApp1.Properties.Resources.gtk_media_forward_ltr_40x40_;
            this.btn_forward.Location = new System.Drawing.Point(196, 223);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(40, 40);
            this.btn_forward.TabIndex = 21;
            this.btn_forward.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.emblem_downloads__1_;
            this.button1.Location = new System.Drawing.Point(420, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 20);
            this.button1.TabIndex = 19;
            this.toolTip1.SetToolTip(this.button1, "minimize");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pause.Image = global::WindowsFormsApp1.Properties.Resources.gtk_media_pause__40x40_;
            this.btn_pause.Location = new System.Drawing.Point(104, 223);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(40, 40);
            this.btn_pause.TabIndex = 18;
            this.btn_pause.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prev.Image = global::WindowsFormsApp1.Properties.Resources.gtk_media_next_rtl__40x40_;
            this.btn_prev.Location = new System.Drawing.Point(12, 223);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(40, 40);
            this.btn_prev.TabIndex = 12;
            this.btn_prev.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_next.Image = global::WindowsFormsApp1.Properties.Resources.gtk_media_next_ltr;
            this.btn_next.Location = new System.Drawing.Point(242, 223);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(40, 40);
            this.btn_next.TabIndex = 11;
            this.btn_next.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_load
            // 
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Image = global::WindowsFormsApp1.Properties.Resources.dvd_unmount;
            this.btn_load.Location = new System.Drawing.Point(150, 544);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(40, 40);
            this.btn_load.TabIndex = 10;
            this.btn_load.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_load, "Load playlist");
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Image = global::WindowsFormsApp1.Properties.Resources.gtk_remove;
            this.btn_delete.Location = new System.Drawing.Point(58, 544);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(40, 40);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_delete, "Delete selected file");
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::WindowsFormsApp1.Properties.Resources.stock_new_window;
            this.btn_save.Location = new System.Drawing.Point(104, 544);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(40, 40);
            this.btn_save.TabIndex = 8;
            this.btn_save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_save, "Save playlist");
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.Image = global::WindowsFormsApp1.Properties.Resources.gtk_media_stop__40x40_;
            this.btn_stop.Location = new System.Drawing.Point(150, 223);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(40, 40);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_play
            // 
            this.btn_play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_play.Image = global::WindowsFormsApp1.Properties.Resources.gtk_media_play_ltr__40x40_;
            this.btn_play.Location = new System.Drawing.Point(58, 223);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(40, 40);
            this.btn_play.TabIndex = 4;
            this.btn_play.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.player_eject__1_;
            this.btn_open.CausesValidation = false;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Image = global::WindowsFormsApp1.Properties.Resources.add;
            this.btn_open.Location = new System.Drawing.Point(12, 544);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(40, 40);
            this.btn_open.TabIndex = 3;
            this.btn_open.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_open, "Add files");
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // cvolume
            // 
            this.cvolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cvolume.HoverState.Parent = this.cvolume;
            this.cvolume.Location = new System.Drawing.Point(288, 223);
            this.cvolume.MouseWheelBarPartitions = 20;
            this.cvolume.Name = "cvolume";
            this.cvolume.Size = new System.Drawing.Size(123, 40);
            this.cvolume.TabIndex = 30;
            this.cvolume.ThumbColor = System.Drawing.Color.LimeGreen;
            this.cvolume.Value = 0;
            this.cvolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cvolume_Scroll);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btn_random
            // 
            this.btn_random.BackColor = System.Drawing.Color.Black;
            this.btn_random.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_random.Image = global::WindowsFormsApp1.Properties.Resources.shuffle_off;
            this.btn_random.Location = new System.Drawing.Point(242, 544);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(40, 40);
            this.btn_random.TabIndex = 31;
            this.btn_random.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btn_random, "Random track");
            this.btn_random.UseVisualStyleBackColor = false;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
            // 
            // btn_hide
            // 
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Image = global::WindowsFormsApp1.Properties.Resources.bottom__2_;
            this.btn_hide.Location = new System.Drawing.Point(394, 5);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(20, 20);
            this.btn_hide.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btn_hide, "hide");
            this.btn_hide.UseVisualStyleBackColor = true;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::WindowsFormsApp1.Properties.Resources.info;
            this.button2.Location = new System.Drawing.Point(446, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 20);
            this.button2.TabIndex = 34;
            this.toolTip1.SetToolTip(this.button2, "info");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.disraeli_gears_player_phone_copy;
            this.ClientSize = new System.Drawing.Size(467, 596);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_hide);
            this.Controls.Add(this.btn_random);
            this.Controls.Add(this.cvolume);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.lbl_track_end);
            this.Controls.Add(this.lbl_track_start);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.Recent_list);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disraeli Gears Player";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public AxWMPLib.AxWindowsMediaPlayer player;
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox Song;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Album;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        public System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button btn_clear;
        internal System.Windows.Forms.ListBox Recent_list;
        internal Siticone.Desktop.UI.WinForms.SiticoneTrackBar cvolume;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button button2;
    }
}

