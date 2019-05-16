using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirinto.Models
{
    public class MyStack<T> // PILHA GENERICA
    {
        T[] items = new T[0]; //ARRAY
        private int size; // VARIAVELTAMANHO 

        public int Size { get => size; set => size = value; }

        public void Push(T value) //Insere na PILHA
        {
            if (Size == items.Count()) // COMPARA O TAMANHO COM ITENS 
            {
                int newlength = Size == 0 ? 4 : Size * 2;
                T[] newarray = new T[newlength]; //NOVO TAMANHO ARRAY
                items.CopyTo(newarray, 0); // COPIA ITENS PARA NOVO ARRAY
                items = newarray;
            }
            items[Size] = value;
            Size++;
        }
        

        public T Pop() // remove o ultimo inserido NA PILHA
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            Size--;
            return items[Size];
        }


        public T Peek() // mostra o primeiro
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Empty");
            }
            return items[Size - 1];
        }
    }
}
