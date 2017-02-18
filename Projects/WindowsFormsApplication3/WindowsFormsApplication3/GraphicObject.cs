using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class GraphicObject
    {
        private int currentX;
        private int currentY;
        private int height;
        private int width;
        private int drawType;
        private bool canDraw;
        private Color color;

        public GraphicObject(int currentX, int currentY, int height, int width, int drawType, Color color, bool canDraw)
        {
            this.currentX = currentX;
            this.currentY = currentY;
            this.drawType = drawType;
            this.height = height;
            this.width = width;
            this.color = color;
            this.canDraw = canDraw;
        }
        public void Redraw()
        {
            SolidBrush newBrush;
            newBrush = new SolidBrush(GetColor());
            switch (GetDrawType())
            {
                case Statics.GRAPHIC_TYPE_CIRCLE:
                    Statics.graphics.FillEllipse(newBrush, GetCurrentX(), GetCurrentY(), GetWidth(), GetHeight());
                    break;
                case Statics.GRAPHIC_TYPE_RECTANGLE:
                    Statics.graphics.FillRectangle(newBrush, GetCurrentX(), GetCurrentY(), GetWidth(), GetHeight());                    
                    break;
            }
            newBrush.Dispose();

        }
        //armo getters y setters
        public void SetCurrentX(int value)
        {
            this.currentX = value;
        }
        public int GetCurrentX()
        {
            return this.currentX;
        }
        //armo getters y setters
        public void SetCurrentY(int value)
        {
            currentY = value;
        }
        public int GetCurrentY()
        {
            return currentY;
        }
        //armo getters y setters
        public void SetHeight(int value)
        {
            height = value;
        }
        public int GetHeight()
        {
            return height;
        }
        //armo getters y setters
        public void SetWidth(int value)
        {
            width = value;
        }
        public int GetWidth()
        {
            return width;
        }
        //armo getters y setters
        public void SetDrawType(int value)
        {
            drawType = value;
        }
        public int GetDrawType()
        {
            return drawType;
        }
        //armo getters y setters
        public void SetColor(Color value)
        {
            color = value;
        }
        public Color GetColor()
        {
            return color;
        }
        //armo getters y setters
        public void SetCanDraw(bool value)
        {
            canDraw = value;
        }
        public bool GetCanDraw()
        {
            return canDraw;
        }
    }
}
