using System;
using System.Drawing;

namespace Lab6
{
    interface IGraphComponent
    {
        void draw(Graphics g);

        String getID();
    }
}
