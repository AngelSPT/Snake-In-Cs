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
    public partial class Form3 : Form
    {
        int columnas = 50, filas = 25, puntos = 0, dx = 0, dy = 0, frente = 0, atras = 0;
        serpiente[] serpiente1 = new serpiente[1250];
        List<int> acceso = new List<int>();
        bool[,] i;

        Random aleatorio = new Random();
        Timer tiempo = new Timer();

        
        public Form3 ()
        {
            InitializeComponent();
            Inicio();
            LauncherTimer();
        }

        private void LauncherTimer()
        {
            tiempo.Interval = 50;
            tiempo.Tick += movimiento;
           tiempo.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
       
        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            dx = dy = 0;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    dx = 20;
                    break;
                case Keys.Left:
                    dx = -20;
                    break;
                case Keys.Up:
                    dy =-20;
                    break;
                case Keys.Down:
                    dy = 20;
                    break;



            }
        }

        private void movimiento(object sender, EventArgs e)
        {
            int x = serpiente1[frente].Location.X, y = serpiente1[frente].Location.Y;
            if (dx == 0 && dy == 0) return;
            if (Has_perdido (x+dx,y+dy))
            {
                tiempo.Stop();
                SoundPlayer music = new SoundPlayer();
                music.SoundLocation = "C:/Users/angel/Desktop/PROGRAMACION (PROYECTOS)/PROYECTOS (C#)/Snake_v0.5/Snake_v0.5/bua wa wa.wav";
                music.Play();
                MessageBox.Show("HAS PERDIDO:(");
                Close();
                Application.Exit();
                return;
            }
            if (colisiondecomida(x + dx, y + dy))
            {
                puntos += 1;
                puntuacion.Text = "Puntuacion:" + puntos.ToString();
                if (choque((y + dy) / 20, (x + dx) / 20)) return;
                serpiente cabeza = new serpiente(x + dx, y + dy);
                frente = (frente - 1 + 1250) % 1250;
                serpiente1[frente] = cabeza;
                i[cabeza.Location.Y / 20, cabeza.Location.X / 20] = true;
                Controls.Add(cabeza);
                aparicioncomida();

             }
                else
            {
                if (choque((y + dy) / 20, (x + dx) / 20)) return;
                i[serpiente1[atras].Location.Y / 20, serpiente1[atras].Location.X / 20] = false;
                frente = (frente - 1 + 1250) % 1250;
                serpiente1[frente] = serpiente1[atras];
                serpiente1[frente].Location = new Point(x + dx, y + dy);
                atras = (atras - 1 + 1250) % 1250;
                i[(y + dy) / 20, (x + dx) / 20] = true;

            }
            
          }

        private void aparicioncomida()
        {
            acceso.Clear();
            for (int s = 0; s < filas; s++)
                for (int a = 0; a < columnas; a++)
                    if (!i[s, a]) acceso.Add(s * columnas + a);
            int sdx = aleatorio.Next(acceso.Count) % acceso.Count;
            fruta.Left = (acceso[sdx] * 20) % Width;
            fruta.Top = (acceso[sdx] * 20) / Width * 20;

        }

        private bool choque(int x, int y)
        {
          if (i[x,y])
            {
                tiempo.Stop();
                SoundPlayer music = new SoundPlayer();
                music.SoundLocation = "C:/Users/angel/Desktop/PROGRAMACION (PROYECTOS)/PROYECTOS (C#)/Snake_v0.5/Snake_v0.5/bua wa wa.wav";
                music.Play();
                MessageBox.Show("Te has golpeado con tu propio cuerpo");
                Close();
                Application.Exit();
                return true;
                
                
            }
            return false;
        }

        private bool colisiondecomida(int x,int y)
        {
            return x == fruta.Location.X && y == fruta.Location.Y;
        }

        private bool Has_perdido(int x, int y)
        {
            return x < 0 || y < 0 || x > 980 || y > 480;
        }

        private void Inicio()
        {
            i = new bool[filas, columnas];
            serpiente cabeza = new serpiente((aleatorio.Next() % columnas) * 20, (aleatorio.Next() % filas) * 20);
            fruta.Location = new Point((aleatorio.Next() % columnas) * 20, (aleatorio.Next() % filas) * 20);
            for (int j = 0; j < filas; j++)
                for (int k = 0; k < columnas; k++)
                {
                    i[j, k] = false;
                    acceso.Add(j * columnas + k);

                }
            i[cabeza.Location.Y / 20, cabeza.Location.X / 20] = true;
            acceso.Remove(cabeza.Location.Y / 20 * columnas + cabeza.Location.X / 20);
            Controls.Add(cabeza);
            serpiente1[frente] = cabeza;
        }
    } 
        

    }