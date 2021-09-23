using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Properties
{
    class Edge : GraphComponent
    {
        private int edge_no;
        private Vertex from_vertex;
        private Vertex to_vertex;
        private DrawUtil drawUtil;

        public Edge(Vertex from, Vertex to)
        {

        }

        public Vertex getFrom()
        {
            return from_vertex;
        }

        public void setFrom(Vertex from)
        {
            from = this.from_vertex;   
        }

        public Vertex getTo()
        {
            return to_vertex;
        }

        public void setTo(Vertex to)
        {
            to = this.to_vertex;            
        }

        public 

        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black);

            g.DrawLine(pen, from_vertex.getX, from_vertex.getY, to_vertex.getX, to_vertex.getY);

        }
    }
}
