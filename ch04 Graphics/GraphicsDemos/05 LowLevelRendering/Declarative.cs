using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace LowLevelRendering
{
    public class Declarative : Grid
    {
        public Declarative()
        {
            Rectangle r = new Rectangle();
            r.Fill = Brushes.Red;
            Children.Add(r);
            Ellipse e = new Ellipse()
            {
                Fill = Brushes.Yellow,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Children.Add(e);
        }
    }
}
