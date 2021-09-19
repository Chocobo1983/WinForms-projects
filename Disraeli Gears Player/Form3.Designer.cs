
namespace WindowsFormsApp1
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.Color.Black;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1.ForeColor = System.Drawing.Color.LimeGreen;
            this.txt1.Location = new System.Drawing.Point(95, 0);
            this.txt1.Multiline = true;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(105, 106);
            this.txt1.TabIndex = 1;
            this.txt1.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.ForeColor = System.Drawing.Color.LimeGreen;
            this.btn_close.Location = new System.Drawing.Point(57, 204);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.LimeGreen;
            this.linkLabel1.Location = new System.Drawing.Point(12, 127);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/Chocobo1983";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pic
            // 
            this.pic.InitialImage = null;
            this.pic.Location = new System.Drawing.Point(1, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(88, 106);
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(212, 239);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Opacity = 0.9D;
            this.Text = "Form3";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        internal System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}