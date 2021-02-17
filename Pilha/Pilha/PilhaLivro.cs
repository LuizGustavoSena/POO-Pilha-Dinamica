using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha
{
    class PilhaLivro
    {
        public Livro Topo { get; set; }

        // MÉTODOS
        public void push(Livro aux)
        {
            aux.Anterior = Topo;
            Topo = aux;
            Console.WriteLine("Elemento inserido!");
        }

        public void imprimir()
        {
            if (Topo == null)
                Console.WriteLine("Pilha vazia!");
            else
            {
                Livro aux = Topo;
                do
                {
                    Console.WriteLine("==================");
                    Console.WriteLine(aux.ToString() +"\n");
                    aux = aux.Anterior;
                } while (aux != null);
            }
        }

        public void pop()
        {
            if (Topo == null)
                Console.WriteLine("Impossivel remover!");
            else
            {
                Topo = Topo.Anterior;
            }
        }

        public int qtd()
        {
            int contador = 0;
            if (Topo != null)
            {
                Livro aux = Topo;
                do
                {
                    contador++;
                    aux = aux.Anterior;
                } while (aux != null);
            }
            return contador;
        }

        public void buscar(string titulo)
        {
            if (Topo == null)
                Console.WriteLine("Pilha vazia!");
            else
            {
                Livro aux = Topo;
                bool encontra = false;
                do
                {
                    if (aux.Titulo == titulo) { 
                        Console.WriteLine("\nLIVRO ENCONTRADO\n" + aux.ToString());
                        encontra = true;
                        break;
                    }
                    aux = aux.Anterior;
                } while (aux != null);

                if(!encontra)
                    Console.WriteLine("Livro não encontrado");
            }
        }
    }
}
