using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Snake_v0._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SoundPlayer music1 = new SoundPlayer();
            music1.SoundLocation = "C:/Users/angel/Desktop/PROGRAMACION (PROYECTOS)/PROYECTOS (C#)/Snake_v0.5/Snake_v0.5/SMusicMenuLL.wav";
            music1.PlayLooping();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SoundPlayer music1 = new SoundPlayer();
            music1.SoundLocation = "C:/Users/angel/Desktop/PROGRAMACION (PROYECTOS)/PROYECTOS (C#)/Snake_v0.5/Snake_v0.5/SMusicL.wav";
            music1.PlayLooping();
            Form3 pasar_a = new Form3();
            pasar_a.Show();
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form2 ir_a = new Form2();
            ir_a.Show();
            

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
