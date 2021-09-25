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
        private String uuid;
        private List<Vertex> vertices = new List<Vertex>();
        private List<Edge> edges = new List<Edge>();

        public Graph()
        {
            this.setID();
        }

        public Graph Clone()
        {
            Graph newGraph = (Graph)MemberwiseClone();
            newGraph.setID();
            newGraph.vertices = new List<Vertex>();
            newGraph.edges = new List<Edge>();
            this.vertices
                .Select(v => v.Clone())
                .ToList<Vertex>()
                .ForEach(v => newGraph.vertices.Add(v));
            this.edges
                .Select(e => e.Clone())
                .ToList<Edge>()
                .ForEach(e => newGraph.edges.Add(e));
            return newGraph;
        }

        private void setID()
        {
            this.uuid = Guid.NewGuid().ToString();
        }

        public void print(Graphics g)
        {
            this.vertices.ForEach(v => v.draw(g));
            this.edges.ForEach(e => e.draw(g));
        }

        public String getID()
        {
            return this.uuid;
        }

        public void addEdge(Edge edge)
        {
            this.edges.Add(edge);
        }

        public Edge getEdge(string edgeId)
        {
            return this.edges
                .Where(e => e.getID().Equals(edgeId))
                .First();
        }

        public void addVertex(Vertex vertex)
        {
            vertices.Add(vertex);        
        }

        public Vertex getVertex(String vertexId)
        {
            return this.vertices
                .Where(v => v.getID().Equals(vertexId))
                .First();
        }

        public List<Vertex> getVertices()
        {
            return this.vertices;
        }

        public List<Edge> getEdges()
        {
            return this.edges;
        }
    }
}
