using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Properties
{
    class GraphManager
    {
        private static GraphManager graphManager = new GraphManager();
        private List<IGraph<Graph>> graphs = new List<IGraph<Graph>>();
        private IGraph<Graph> selected;

        private GraphManager() { }

        public static GraphManager getInstance ()
        {
            return graphManager;
        }

        public void create()
        {
            IGraph<Graph> newGraph = new Graph();
            graphs.Add(newGraph);
            this.selected = newGraph;
        }

        public void revise(String id)
        {
            this.selected = graphs.Where(g => g.getID().Equals(id)).First();
        }

        public void copy(String id)
        {
            Graph copied = graphs
                .Where(g => g.getID()
                .Equals(id))
                .First()
                .Clone();
            graphs.Add(copied);
            this.selected = copied;
        }

        public void addVertexToSelectedGraph(int x, int y)
        {
            this.selected.addVertex(new Vertex(x, y));
        }

        public void addEdgeToSelectedGraph(String fromVertexId, String toVertexId)
        {
            this.selected.addEdge(new Edge(
                this.selected.getVertex(fromVertexId),
                this.selected.getVertex(toVertexId)));
        }

        public void reviseVertex(String vertexId, int newX, int newY)
        {
            Vertex toRevise = this.selected.getVertex(vertexId);
            toRevise.setX(newX);
            toRevise.setY(newY);
        }

        public void reviseEdge(String edgeId, String newFromId, String newToId)
        {
            Edge toRevise = this.selected.getEdge(edgeId);
            toRevise.setFrom(this.selected.getVertex(newFromId));
            toRevise.setTo(this.selected.getVertex(newToId));
        }

        public IGraph<Graph> getselected()
        {
            return this.selected;
        }
    }
}
