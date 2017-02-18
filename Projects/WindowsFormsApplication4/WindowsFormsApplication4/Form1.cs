using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        int indice = 0;
        int velocidad = 50;
        List<Button> proyectiles = new List<Button>();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            cmdBarra.Left = e.X;
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CrearCuadradito();
           
        }
        private void CrearCuadradito()
        {
            
            proyectiles.Add(new Button());
            proyectiles[indice].Name = "proyectil" + indice;            
            proyectiles[indice].Left = rnd.Next(0, this.Width);
            proyectiles[indice].Top = 0;            
            proyectiles[indice].BackColor = Color.FromArgb(255, 0, 0);
            this.Controls.Add(proyectiles[indice]);            
            indice++;

        }
        private void MoverCuadraditos()
        {
            foreach (Button btn in proyectiles)
            {
                btn.Top += velocidad;
            }
        }
        private void EliminarFueraPantalla()
        {
            for (int i = 0; i < proyectiles.Count();i++ )
            {
                if (proyectiles[i].Top + 1000 >= this.Height)
                {
                    proyectiles[i].Dispose();
                    proyectiles.RemoveAt(i);
                    indice--;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            MoverCuadraditos();
            EliminarFueraPantalla();
            LogicaPlayer();
        }
        private void LogicaPlayer()
        {
            foreach (Button btn in proyectiles)
            {
                if (cmdBarra.Top + cmdBarra.Height <= btn.Top && cmdBarra.Top + cmdBarra.Height > btn.Top + btn.Height && velocidad < 0 && cmdBarra.Left + cmdBarra.Width < btn.Left + btn.Width && cmdBarra.Left > btn.Left)
                {
                    velocidad = 100;
                }
            }
            velocidad--;
        }
    }
}
