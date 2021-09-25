using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Properties
{
    interface IGraph<T> : ICloneable<T>
    {

        void print(Graphics g);

        String getID();

        void addEdge(Edge edge);

        Edge getEdge(String edgeId);

        void addVertex(Vertex vertex);

        Vertex getVertex(String vertexId);

        List<Vertex> getVertices();

        List<Edge> getEdges();

    }
}
