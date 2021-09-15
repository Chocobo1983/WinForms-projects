
namespace lab6._1
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
            this.btn_fill = new System.Windows.Forms.Panel();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btn_scissors = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_fill.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_fill.Controls.Add(this.button2);
            this.btn_fill.Controls.Add(this.btn_load);
            this.btn_fill.Controls.Add(this.btn_save);
            this.btn_fill.Controls.Add(this.btn_clear);
            this.btn_fill.Controls.Add(this.color_picker);
            this.btn_fill.Controls.Add(this.pic_color);
            this.btn_fill.Controls.Add(this.panel1);
            this.btn_fill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_fill.Location = new System.Drawing.Point(0, 0);
            this.btn_fill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(1307, 123);
            this.btn_fill.TabIndex = 0;
            // 
            // btn_load
            // 
            this.btn_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_load.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_load.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_load.ForeColor = System.Drawing.Color.White;
            this.btn_load.Location = new System.Drawing.Point(1044, 84);
            this.btn_load.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(112, 30);
            this.btn_load.TabIndex = 10;
            this.btn_load.Text = "Load";
            this.btn_load.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1044, 47);
            this.btn_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(112, 30);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(1044, 15);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(112, 30);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Clear";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(308, 47);
            this.pic_color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(36, 37);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btn_color);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Location = new System.Drawing.Point(353, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 110);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btn_scissors);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 600);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 68);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1176, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1036, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cursor X:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1111, 18);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(56, 22);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1207, 18);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(239, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thickness";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 9);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(227, 56);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // btn_scissors
            // 
            this.btn_scissors.BackgroundImage = global::lab6._1.Properties.Resources.Scissors;
            this.btn_scissors.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_scissors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_scissors.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_scissors.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_scissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_scissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_scissors.ForeColor = System.Drawing.Color.White;
            this.btn_scissors.Image = global::lab6._1.Properties.Resources.Scissors;
            this.btn_scissors.Location = new System.Drawing.Point(958, 0);
            this.btn_scissors.Margin = new System.Windows.Forms.Padding(4);
            this.btn_scissors.Name = "btn_scissors";
            this.btn_scissors.Size = new System.Drawing.Size(70, 70);
            this.btn_scissors.TabIndex = 6;
            this.btn_scissors.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_scissors.UseVisualStyleBackColor = true;
            this.btn_scissors.Click += new System.EventHandler(this.btn_scissors_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::lab6._1.Properties.Resources.git;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1176, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 108);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::lab6._1.Properties.Resources._1_8QcxCpYS_xjvr9sVFxUeQA;
            this.color_picker.Location = new System.Drawing.Point(0, 15);
            this.color_picker.Margin = new System.Windows.Forms.Padding(4);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(300, 98);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // btn_color
            // 
            this.btn_color.BackgroundImage = global::lab6._1.Properties.Resources.paint_114370;
            this.btn_color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_color.ForeColor = System.Drawing.Color.White;
            this.btn_color.Location = new System.Drawing.Point(13, 11);
            this.btn_color.Margin = new System.Windows.Forms.Padding(4);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(85, 84);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::lab6._1.Properties.Resources.colors_1014;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(107, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 84);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fill";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackgroundImage = global::lab6._1.Properties.Resources.brush_256_icon_icons_com_75989;
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Location = new System.Drawing.Point(200, 11);
            this.btn_pencil.Margin = new System.Windows.Forms.Padding(4);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(85, 84);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackgroundImage = global::lab6._1.Properties.Resources.gui_eraser_icon_157160;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Location = new System.Drawing.Point(293, 11);
            this.btn_eraser.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(85, 84);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.BackgroundImage = global::lab6._1.Properties.Resources.circle_91059;
            this.btn_ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Location = new System.Drawing.Point(387, 11);
            this.btn_ellipse.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(85, 84);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Circle";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_line
            // 
            this.btn_line.BackgroundImage = global::lab6._1.Properties.Resources.Line_34554;
            this.btn_line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Location = new System.Drawing.Point(573, 11);
            this.btn_line.Margin = new System.Windows.Forms.Padding(4);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(85, 84);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.BackgroundImage = global::lab6._1.Properties.Resources.unnamed;
            this.btn_rect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Location = new System.Drawing.Point(480, 11);
            this.btn_rect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(85, 84);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rect";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Margin = new System.Windows.Forms.Padding(4);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1307, 668);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 668);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_fill);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.btn_fill.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel btn_fill;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_scissors;
    }
}

