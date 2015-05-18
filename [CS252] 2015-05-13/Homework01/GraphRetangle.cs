using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Homework01
{
   

    public class GraphRetangle 
    {
        private int _length;
        private int _width;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }      
        public int Width
        {
            get { return _width; }
            set { _width = value; }
        }

        private Graphics _retangle;

        public Graphics Retangle
        {
            get { return _retangle; }
            set
            {
                
                 
                Pen drawPen = new Pen(Color.Black, 3);
                _retangle = value; //把類別Form1 的 RetanglePictureBox.CreateGraphics() Set給Graphics屬性
                
 
                this._retangle.Clear(SystemColors.Control);
                this._retangle.DrawLine(drawPen, 0, 0, this._length, 0);
                this._retangle.DrawLine(drawPen, this._length, 0, this._length, this._width);
                this._retangle.DrawLine(drawPen, this._length, this._width, 0, this._width);
                this._retangle.DrawLine(drawPen, 0, this._width, 0, 0);
   
                
            }

        }
        
    }
}
