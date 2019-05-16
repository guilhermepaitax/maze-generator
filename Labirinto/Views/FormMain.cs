using Labirinto.Controllers;
using Labirinto.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //Trabalho elaborado por Guilherme Paitax e Lucas Corsi, elaborando um labirinto utilizando kruskal algorithm (Sapnning Tree)
        // e a solução utilizando Pilha

        private int Xmin, Ymin, CellSize; // tamanho especificado pelo usuario
        private MazeNode[,] nodes;
        private Color backgroundColor = Color.White;
        private Brush resultColor = Brushes.MediumSlateBlue;
        private LineCap lineCap = LineCap.Flat;
        private int lineWid = 1;

        //Altera Cor das paredes do labirinto
        private void corDaLinhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog(this) == DialogResult.OK)
            {
                backgroundColor = cd.Color;
            }
        }

        //Altera a largura das paredes do labirinto
        private void toolStripMenuItemLineWid_Click(object sender, EventArgs e)
        {

            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;

            lineWid = Convert.ToInt32(tsmi.Text);
            CheckedFalse(tsmiLineWid);
            tsmi.Checked = true;
            tsmiLineWid.Checked = true;
        }

        //Desmarca os itens do menu
        private void CheckedFalse(ToolStripMenuItem toolStripMenu)
        {
            foreach (ToolStripMenuItem tsmi in toolStripMenu.DropDownItems)
            {
                tsmi.Checked = false;
            }
        }

        //Altera o tipo da linha das paredes do labirinto
        private void ToolStripMenuItemLineType_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = sender as ToolStripMenuItem;

            switch (tsmi.Text)
            {
                case "ArrowAnchor":
                    lineCap = LineCap.ArrowAnchor;
                    break;
                case "DiamondAnchor":
                    lineCap = LineCap.DiamondAnchor;
                    break;
                case "Flat":
                    lineCap = LineCap.Flat;
                    break;
                case "Round":
                    lineCap = LineCap.Round;
                    break;
                case "RoundAnchor":
                    lineCap = LineCap.RoundAnchor;
                    break;
                case "Square":
                    lineCap = LineCap.Square;
                    break;
                case "SquareAnchor":
                    lineCap = LineCap.SquareAnchor;
                    break;
                case "Triangle":
                    lineCap = LineCap.Triangle;
                    break;
            }

            CheckedFalse(tsmiLineType);
            tsmi.Checked = true;
            tsmiLineType.Checked = true;
        }

        //Altera a cor dos pontos do caminho do labirinto
        private void tsmiResolutColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog(this) == DialogResult.OK)
            {
                
                resultColor = new SolidBrush(cd.Color);
            }
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {// metodo utilizando pilha para resolver
            List<MazeNode> path = new List<MazeNode>();
            SolveController solver = new SolveController(nodes);
            btnSolve.Enabled = false;

            if (solver.Solve(ref path))
            {
                Bitmap bitmap = new Bitmap(picMaze.Image);
                picMaze.Image = MazeController.DisplayPath(path, CellSize, bitmap, resultColor);
            }
            else MessageBox.Show("Impossivel resolver o Labirinto!");
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            //DESENHO DO LABIRINTO
            int wid = int.Parse(numLargura.Text);
            int hgt = int.Parse(numAltura.Text);

            CellSize = int.Parse(numTamanhoBlc.Text);

            Xmin = (picMaze.ClientSize.Width - wid * CellSize) / 2;
            Ymin = (picMaze.ClientSize.Height - hgt * CellSize) / 2;


            // Construtor dos   nós do labirinto.
            nodes = MazeController.MazeNodes(wid, hgt, Ymin, Xmin, CellSize);

            // Inicializa o kruskal Algorithm (Spanning TREE)
            MazeController.FindSpanningTree(ref nodes[0, 0]);

            // Mostra o Maze 
            picMaze.Image = MazeController.DisplayMaze(nodes, picMaze.ClientSize.Width, picMaze.ClientSize.Height, CellSize, backgroundColor, lineCap, lineWid);

            btnSolve.Visible = true;
            btnSolve.Enabled = true;
        }


    }
}
