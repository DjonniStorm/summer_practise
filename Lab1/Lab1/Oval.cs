using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;

public class Oval : AbstractFigure, IPaintMethod
{
    public Oval(int x, int y, int width, int height) : base(x, y, width, height)
    {
        
    }
    public void Draw(Graphics g)
    {
        Random random = new ();
        Pen pen = new (Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)), 4f);
        g.DrawEllipse(pen, new Rectangle(_x, _y, _width, _height));
    }
}
