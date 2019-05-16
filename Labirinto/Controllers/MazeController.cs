using Labirinto.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto.Controllers
{
    class MazeController  // controle do Maze
    {

        public static MazeNode[,] MazeNodes(int wid, int hgt, int Ymin, int Xmin, int CellSize)
        {
            // Cria os nós.
            MazeNode[,] nodes = new MazeNode[hgt, wid];

            for (int i = 0; i < hgt; ++i)
            {
                int y = Ymin + CellSize * i;
                for (int j = 0; j < wid; ++j)
                {
                    int x = Xmin + CellSize * j;
                    nodes[i, j] = new MazeNode(x, y, CellSize, CellSize);
                }
            }

            // Inicialize os neighbors dos nós.
            for (int i = 0; i < hgt; ++i)
            {
                for (int j = 0; j < wid; ++j)
                {
                    if (i > 0) nodes[i, j].Neighbors[MazeNode.North] = nodes[i - 1, j];
                    if (i < hgt - 1) nodes[i, j].Neighbors[MazeNode.South] = nodes[i + 1, j];
                    if (j > 0) nodes[i, j].Neighbors[MazeNode.West] = nodes[i, j - 1];
                    if (j < wid - 1) nodes[i, j].Neighbors[MazeNode.East] = nodes[i, j + 1];
                }
            }

            // Retorna os nodes.
            return nodes;
        }


        /* Construa uma SPANNING TREE com o nó raiz indicado    KRUSKAL ALGORIGHT/*
         * O algoritmo de Kruskal é um algoritmo de amplitude mínima que encontra uma borda com o menor peso possível que conecta quaisquer duas árvores na floresta. 
         * É um algoritmo guloso na teoria dos grafos , pois encontra uma árvore geradora mínima para um grafo ponderado conectado, adicionando arcos de custo crescente em cada etapa.
         *  Isso significa que ele encontra um subconjunto das arestas que formam uma árvore que inclui todos os vértices , onde o peso total de todas as arestas da árvore é minimizado.
         *  Se o gráfico não estiver conectado, ele encontrará uma floresta de extensão mínima(uma árvore de abrangência mínima para cada componente conectado.
          Esse algoritmo apareceu pela primeira vez em Proceedings ofthe American Mathematical Society, pp. 48-50 em 1956, e foi escrito por Joseph Kruskal.*/


        public static void FindSpanningTree(ref MazeNode root)
        {
            Random rand = new Random();


            // Defina o predecessor do nó raiz para que saibamos que ele está na árvore.
            root.Predecessor = root;

         
            List<MazeLink> links = new List<MazeLink>();

            
            foreach (MazeNode neighbor in root.Neighbors)
            {
                if (neighbor != null)
                    links.Add(new MazeLink(root, neighbor));
            }


            // Adiciona os outros nós à árvore.
            while (links.Count > 0)
            {

                // Escolha um link aleatório.
                int link_num = rand.Next(0, links.Count);
                MazeLink link = links[link_num];
                links.RemoveAt(link_num);


                // Adicione este link à árvore.
                MazeNode to_node = link.ToNode;
                link.ToNode.Predecessor = link.FromNode;


                // Remove quaisquer links da lista desse ponto
                for (int i = links.Count - 1; i >= 0; i--)
                {
                    if (links[i].ToNode.Predecessor != null)
                        links.RemoveAt(i);
                }


                // Adiciona os links do to_node à lista 
                foreach (MazeNode neighbor in to_node.Neighbors)
                {
                    if ((neighbor != null) && (neighbor.Predecessor == null))
                        links.Add(new MazeLink(to_node, neighbor));
                }
            }

        }
        // controle de desenho wall
        public static Bitmap DisplayMaze(MazeNode[,] nodes, int picWid, int picHgt, int cellSize, Color color, LineCap lineCap, int lineWid)
        {
            Pen pen = new Pen(color, lineWid)
            {
                StartCap = lineCap,
                EndCap = lineCap,
            };
            int hgt = nodes.GetUpperBound(0) + 1;
            int wid = nodes.GetUpperBound(1) + 1;
            Bitmap bm = new Bitmap(picWid, picHgt);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                for (int r = 0; r < hgt; r++)
                {
                    for (int c = 0; c < wid; c++)
                    {
                        if ((r == 0 && c == 0) || (r == hgt - 1 && c == wid - 1))
                        {
                            if (pen.Color != Color.Red) pen.Color = Color.OrangeRed;
                            else pen.Color = Color.BlueViolet;
                        }
                        else pen.Color = color;
                        nodes[r, c].DrawWalls(gr, pen);
                     
                    }
                }
            }

            return bm;
        }
        //controle dos  pontos
        public static Bitmap DisplayPath(List<MazeNode> path, int cellSize, Bitmap image, Brush color)
        {
            Bitmap bm = image;

            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                foreach (MazeNode node in path)
                {
                    node.DrawCenter(gr, color, cellSize);
                }
            }
            return bm;
        }

    }
}
