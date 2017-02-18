using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class frmMain : Form
    {
               
        // en esta lista voy a tener todos los objetos graficos que meta en el formulario
        private List<GraphicObject> Entities = new List<GraphicObject>();   
     
        //este struct va a ser el tipo del que sean los graficos, para crear una estructura y agregar complejidad
        // a los elementos graficos que cree, como altura, ancho, posicion, luego masa, friccion, rebote etc.
        

        public frmMain()
        {
            
            InitializeComponent();
            Statics.graphics = this.CreateGraphics();
            //creo un circulo nuevo
            CreateCircle(10,10,20,20,Color.Blue);
            CreateCircle(0, 50, 20, 20, Color.Blue);
            CreateRectangle(0, 50, 4, 20, Color.Red);
            Update.Enabled = true;            
            Update.Interval = 10;
        }
        private void CreateCircle(int posX, int posY, int height, int width, Color color)
        {
            Entities.Add(new GraphicObject(posX, posY, height, width, Statics.GRAPHIC_TYPE_CIRCLE, color, true));
        }
        private void CreateRectangle(int posX, int posY, int height, int width, Color color)
        {
            Entities.Add(new GraphicObject(posX, posY, height, width, Statics.GRAPHIC_TYPE_RECTANGLE, color, true));
        }
        private void onUpdate(object sender, EventArgs e)
        {
           //redibuja el objeto en pantalla
            Entities[0].SetCurrentX(Entities[0].GetCurrentX() + 1);
            Entities[1].SetCurrentX(Entities[1].GetCurrentX() + 2);
            Redraw();           
            
        }
        private void Redraw()
        {
            this.Refresh();
            // Redibujo todas las formas que haya en el escenario!
            foreach (GraphicObject item in Entities)
            {
                item.Redraw();
            }           
        }
    }
}