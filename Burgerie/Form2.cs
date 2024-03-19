using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema_lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

       

        private void btnPreview_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Properties.Resources.bun_jos;
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Padding = new Padding(0);
            flowLayoutPanel1.Controls.Add(pictureBox1);

            foreach (RadioButton radioButton in groupBox1.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    string imageName = radioButton.Text;
                    pictureBox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);
                    pictureBox.Margin = new Padding(0);
                    pictureBox.Padding = new Padding(0);
                    flowLayoutPanel1.Controls.Add(pictureBox);

                }
            }

            foreach (CheckBox checkBox in groupBox2.Controls.OfType<CheckBox>())
            {
                if (checkBox.Checked)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
                    string imageName = checkBox.Text;
                    pictureBox.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(imageName);
                    pictureBox.Margin = new Padding(0);
                    pictureBox.Padding = new Padding(0);
                    flowLayoutPanel1.Controls.Add(pictureBox);

                }
            }
             if (checkBox9.Checked)
            {
                pbFries.Image = Properties.Resources.Fries;
                pbFries.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbFries.Image = null;
            }
            if (checkBox10.Checked)
            {
                pbSoda.Image = Properties.Resources.Soda;
                pbSoda.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pbSoda.Image = null;
            }

            PictureBox pictureBox2 = new PictureBox();
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.Image = Properties.Resources.Bun1;
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Padding = new Padding(0);
            flowLayoutPanel1.Controls.Add(pictureBox2);

           


        }
    }
}
