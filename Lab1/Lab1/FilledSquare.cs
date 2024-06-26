using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1;

public class FilledSquare : AbstractFigure, IPaintMethod
{
    public FilledSquare(int x, int y, int width, int height) : base (x, y, width, height)
    {

    }
    public void Draw(Graphics g)
    {
        Random random = new();
        Brush brush = new SolidBrush(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256)));
        g.FillRectangle(brush, new Rectangle(_x, _y, _width, _height));
    }
}
