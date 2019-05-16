using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto.Models
{
    public class MazeNode
    {
        public const int North = 0;
        public const int South = North + 1;
        public const int East = South + 1;
        public const int West = East + 1;

        private int direction = 0;


        // Os vizinhos do nó na ordem norte, sul, leste, oeste.
        public MazeNode[] Neighbors = new MazeNode[4];


        // O predecessor do Spanning Tree
        public MazeNode Predecessor = null;


        // Os limites do nó
        public Rectangle Bounds;


        // Retorna o centro deste nó.
        public Point Center
        {
            get
            {
                int x = Bounds.Left + Bounds.Width / 2;
                int y = Bounds.Top + Bounds.Height / 2;
                return new Point(x, y);
            }
        }

        public int Direction { get => direction; set => direction = value; }

        // Construtor.
        public MazeNode(int x, int y, int wid, int hgt)
        {
            Bounds = new Rectangle(x, y, wid, hgt);
        }


        // Desenhe as paredes que não cruzam um link predecessor.
        public void DrawWalls(Graphics gr, Pen pen)
        {
            for (int side = 0; side < 4; side++)
            {
                if ((Neighbors[side] == null) ||
                    ((Neighbors[side].Predecessor != this) &&
                     (Neighbors[side] != this.Predecessor)))
                {
                    DrawWall(gr, pen, side, 0);
                }
            }
        }

        // Desenhe um círculo no centro do nó.
        public void DrawCenter(Graphics gr, Brush brush, int cellSize)
        {
            float size = cellSize / 3;
            int cx = Bounds.Left + Bounds.Width / 2;
            int cy = Bounds.Top + Bounds.Height / 2;
       
            gr.FillEllipse(brush, cx - size / 2, cy - size / 2, size, size);
        }

        //Paredes do labirinto
        private void DrawWall(Graphics gr, Pen pen, int side, int offset)
        {
           
      

            switch (side)
            {
                case North:
                    
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Top + offset,
                        Bounds.Right - offset, Bounds.Top + offset);
                    break;
                case South:
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Bottom - offset,
                        Bounds.Right - offset, Bounds.Bottom - offset);
                    break;
                case East:
                    gr.DrawLine(pen,
                        Bounds.Right - offset, Bounds.Top + offset,
                        Bounds.Right - offset, Bounds.Bottom - offset);
                    break;
                case West:
                    gr.DrawLine(pen,
                        Bounds.Left + offset, Bounds.Top + offset,
                        Bounds.Left + offset, Bounds.Bottom - offset);
                    break;
            }
        }

    }
}
