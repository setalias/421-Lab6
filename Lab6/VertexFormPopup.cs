using Lab6.Properties;
using System;
using System.Windows.Forms;

namespace Lab6
{
    public partial class VertexFormPopup : Form
    {
        private GraphManager graphmanager;
        private Form1 f1;
        private string vertexID;
        public int vertex_popup_x;
        public int vertex_popup_y;

        public VertexFormPopup(Form1 _f1)
        {
            graphmanager = GraphManager.getInstance();
            InitializeComponent();
            this.f1 = _f1;
        }

        public VertexFormPopup(Form1 _f1, string _vertexID)
        {
            graphmanager = GraphManager.getInstance();
            InitializeComponent();
            this.f1 = _f1;
            this.vertexID = _vertexID;
        }

        public void button1_Clicked(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out vertex_popup_x) && 
                int.TryParse(textBox2.Text, out vertex_popup_y))
            {
                vertex_popup_x = int.Parse(textBox1.Text);
                vertex_popup_y = int.Parse(textBox2.Text);
                if (this.vertexID != null)
                {
                    graphmanager.reviseVertex(
                        this.vertexID,
                        vertex_popup_x,
                        vertex_popup_y);
                }
                else
                {
                    f1.updateList2(
                        graphmanager.addVertexToSelectedGraph(
                            vertex_popup_x,
                            vertex_popup_y));
                }

                this.Close();
                f1.Refresh();

            }
            else
                MessageBox.Show("Please verify your integer input");
        }

        

    }
}
