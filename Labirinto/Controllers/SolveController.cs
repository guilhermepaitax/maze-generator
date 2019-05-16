using Labirinto.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto.Controllers
{
    public class SolveController //RESOLVER MAZE
    {
        private List<Point> visited; // LISTA DE PONTOS 
        private MazeNode[,] maze;   //MAZE

        public SolveController(MazeNode[,] maze) // CONTROLE
        {
            this.visited = new List<Point>();
            this.maze = maze;
        }

        internal MazeNode[,] Maze { set => maze = value; }

        public bool Solve(ref List<MazeNode> path) // METODO RESOLVE
        {
            int fx = maze.GetLength(0) - 1;  //MATRIZ
            int fy = maze.GetLength(1) - 1;

            MyStack<MazeNode> stack = new MyStack<MazeNode>();  // PILHA , O ALGORITMO UTILIZA A PILHA PARA SOLUÇÃO DO MAZE.

            MazeNode temp = maze[0, 0];
            path.Add(temp);
            stack.Push(temp);

            while (stack.Size != 0)
            {

                temp = stack.Peek();
                int direction = temp.Direction;

                temp.Direction = temp.Direction + 1;
                stack.Pop();
                stack.Push(temp);

                if (temp.Center == maze[fx, fy].Center) return true;

                if (direction == 0 || direction == 1 || direction == 2 || direction == 3)
                {
                    if (temp.Neighbors[direction] != null && temp.Neighbors[direction].Predecessor.Center == temp.Center && 
                        !visited.Contains(temp.Neighbors[direction].Center))
                    {
                        MazeNode newTemp = temp.Neighbors[direction];
                        visited.Add(newTemp.Center);
                        stack.Push(newTemp);
                        path.Add(newTemp);
                    }
                }
                else
                {
                    visited.Add(temp.Center);
                    path.Remove(temp);
                    stack.Pop();
                }

            }

            return false;
        }

    }
}
