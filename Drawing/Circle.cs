using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Controls;

namespace Drawing
{
    class Circle : DrawingShape, IDraw, IColor // Inherits from the DrawingShape class and implements the IDraw and IColor interface.
    {

        public Circle(int diameter) : base(diameter)
        {
        }

        /* Instantiate the shape field inherited from the 
         * DrawingShape class as a new instance of the Rectangle 
         * class if it has not already been instantiated.*/

        public override void Draw(Canvas canvas)
        {
            if (this.shape != null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Ellipse();
            }

            base.Draw(canvas);
        }

    }
}
