using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Properties
{
    class Edge : GraphComponent, ICloneable<Edge>
    {
        private Vertex from_vertex;
        private Vertex to_vertex;

        public Edge(Vertex from, Vertex to)
        {
            this.from_vertex = from;
            this.to_vertex = to;
            this.setID();
        }

        public Edge Clone()
        {
            return new Edge(this.from_vertex.Clone(), this.to_vertex.Clone());
        }

        public Vertex getFrom()
        {
            return from_vertex;
        }

        public void setFrom(Vertex from)
        {
            this.from_vertex = from;   
        }

        public Vertex getTo()
        {
            return to_vertex;
        }

        public void setTo(Vertex to)
        {
            this.to_vertex = to;            
        }

        public override void draw(Graphics g)
        {
            Rectangle r1 = from_vertex.getRectangle();
            Rectangle r2 = to_vertex.getRectangle();


            int v = getV(r1, r2);
            int s = Vertex.SIZE;

            Pen pen = new Pen(Color.Black);
            SolidBrush brush = new SolidBrush(Color.Black);

            double d = DrawUtil.cosine(new Point(r2.X - r1.X, r2.Y - r1.Y), new Point(v, 0));
            double x = r1.X + s + v * s * d;
            double y = r1.Y + s + v * s * Math.Sqrt(1 - d * d);
            double x2 = r2.X + s - v * s * d;
            double y2 = r2.Y + s - v * s * Math.Sqrt(1 - d * d);
            g.DrawLine(pen, (int)x, (int)y, (int)x2, (int)y2);
            g.FillEllipse(brush, (int)(x - 5), (int)(y - 5), 10, 10);


            Point p = DrawUtil.compute(new Point(r2.X - r1.X, r2.Y - r1.Y), Math.PI / 6);
            g.DrawLine(pen,(int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);
            p = DrawUtil.compute(new Point(r2.X - r1.X, r2.Y - r1.Y), -Math.PI / 6);
            g.DrawLine(pen,(int)x2, (int)y2, (int)x2 + p.X, (int)y2 + p.Y);

        }
        public static int getV(Rectangle r1, Rectangle r2)
        {
            if (r1.Y > r2.Y)
            {
                return -1;
            }
            return 1;
        }

    }
}
