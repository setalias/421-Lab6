using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab6.Properties
{
    class Graph : IGraph<Graph>
    {
        private int id;
        private List<IGraphComponent> graphComponents = new List<IGraphComponent>();


        public Graph clone()
        {
            throw new NotImplementedException();
        }


        public void print(Graphics g)
        {
            graphComponents.ForEach(c => c.draw(g));
        }

        public void create()
        {

        }

        public void revise()
        {

        }

        public void copy()
        {


        }

        public int getID()
        {


            return id;
        }

        public void addEdge(Vertex from, Vertex to)
        {
            graphComponents.Add(new Edge(from, to));
        }

        public void addVertex(int x, int y)
        {
            graphComponents.Add(new Vertex(x, y));        
        }

    }
}
