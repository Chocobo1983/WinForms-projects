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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Picture(*.jpg)|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage.Save(sfd.FileName, ImageFormat.Jpeg);
                this.Close();
            }
        }
    }
}
