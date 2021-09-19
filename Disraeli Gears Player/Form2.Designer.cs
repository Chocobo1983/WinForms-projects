
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.song = new System.Windows.Forms.TextBox();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cvolume = new Siticone.Desktop.UI.WinForms.SiticoneTrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // song
            // 
            this.song.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.song.ForeColor = System.Drawing.Color.Lime;
            this.song.Location = new System.Drawing.Point(47, 1);
            this.song.Name = "song";
            this.song.Size = new System.Drawing.Size(281, 20);
            this.song.TabIndex = 1;
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_volume.Location = new System.Drawing.Point(636, 4);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(27, 13);
            this.lbl_volume.TabIndex = 9;
            this.lbl_volume.Text = "50%";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.ForeColor = System.Drawing.Color.Lime;
            this.lbl_start.Location = new System.Drawing.Point(12, 4);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(34, 13);
            this.lbl_start.TabIndex = 10;
            this.lbl_start.Text = "00:00";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.ForeColor = System.Drawing.Color.Lime;
            this.lbl_end.Location = new System.Drawing.Point(329, 4);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(34, 13);
            this.lbl_end.TabIndex = 11;
            this.lbl_end.Text = "00:00";
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.Image = global::WindowsFormsApp1.Properties.Resources.cd;
            this.btn_open.Location = new System.Drawing.Point(598, -2);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(32, 32);
            this.btn_open.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btn_open, "Add files");
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.BackColor = System.Drawing.Color.Black;
            this.btn_forward.Image = global::WindowsFormsApp1.Properties.Resources.fast_forward;
            this.btn_forward.Location = new System.Drawing.Point(522, -2);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(32, 32);
            this.btn_forward.TabIndex = 12;
            this.btn_forward.UseVisualStyleBackColor = false;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = global::WindowsFormsApp1.Properties.Resources.close__1_;
            this.btn_close.Location = new System.Drawing.Point(848, -2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btn_close, "close");
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Black;
            this.btn_next.Image = global::WindowsFormsApp1.Properties.Resources.next_track;
            this.btn_next.Location = new System.Drawing.Point(560, -2);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(32, 32);
            this.btn_next.TabIndex = 6;
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Black;
            this.btn_stop.Image = global::WindowsFormsApp1.Properties.Resources.stop;
            this.btn_stop.Location = new System.Drawing.Point(484, -2);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(32, 32);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.BackColor = System.Drawing.Color.Black;
            this.btn_pause.Image = global::WindowsFormsApp1.Properties.Resources.pause;
            this.btn_pause.Location = new System.Drawing.Point(446, -2);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(32, 32);
            this.btn_pause.TabIndex = 4;
            this.btn_pause.UseVisualStyleBackColor = false;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Black;
            this.btn_play.Image = global::WindowsFormsApp1.Properties.Resources.play;
            this.btn_play.Location = new System.Drawing.Point(408, -2);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(32, 32);
            this.btn_play.TabIndex = 3;
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.Black;
            this.btn_previous.Image = global::WindowsFormsApp1.Properties.Resources.previous_track;
            this.btn_previous.Location = new System.Drawing.Point(370, -2);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(32, 32);
            this.btn_previous.TabIndex = 2;
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // button1
            // 
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.scroll_up;
            this.button1.Location = new System.Drawing.Point(810, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "restore");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cvolume
            // 
            this.cvolume.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cvolume.HoverState.Parent = this.cvolume;
            this.cvolume.Location = new System.Drawing.Point(669, -2);
            this.cvolume.MouseWheelBarPartitions = 20;
            this.cvolume.Name = "cvolume";
            this.cvolume.Size = new System.Drawing.Size(131, 32);
            this.cvolume.TabIndex = 15;
            this.cvolume.ThumbColor = System.Drawing.Color.LimeGreen;
            this.cvolume.Scroll += new System.Windows.Forms.ScrollEventHandler(this.cvolume_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(881, 36);
            this.Controls.Add(this.cvolume);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.lbl_end);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_volume);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.song);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox song;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_close;
        internal System.Windows.Forms.Label lbl_start;
        internal System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_open;
        internal System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.ToolTip toolTip1;
        internal Siticone.Desktop.UI.WinForms.SiticoneTrackBar cvolume;
        internal System.Windows.Forms.Timer timer1;
    }
}